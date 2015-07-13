using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaStore
{
    /// <summary>
    /// Denna kontroll erbjuder sökning av produkt mha. varunr resp. namn.
    /// </summary>
    public partial class CompactSearchForm : UserControl
    {
        //-- Fields
        private BindingList<Produkt> dataSource = null;

        //-- Properties
        /// <summary>
        ///  Det är till DataSource som man ska knyta listan med produkter.
        /// </summary>
        public BindingList<Produkt> DataSource 
        { 
            set 
            { 
                dataSource = value; 
                namnCbx.DataSource = dataSource;
                namnCbx.DisplayMember = "Namn";
                namnCbx.ValueMember = "Namn";
            } 
        }
        /// <summary>
        /// ValdProdukt innehåller den produkt som för tillfället är vald.
        /// </summary>
        public Produkt ValdProdukt 
        { 
            get { return (Produkt)namnCbx.SelectedItem; }
        }

        //-- Events
        /// <summary>
        /// Eventet triggar varje gång en tangentinmatning utförs.
        /// </summary>
        public EventHandler<EventArgs> InputEntered;
        /// <summary>
        /// Event som triggar när kontrollens inmatningsfält är tomma.
        /// </summary>
        public EventHandler<EventArgs> InputIsEmpty;
        /// <summary>
        /// Eventet triggar varje gång en produkt blir vald. 
        /// </summary>
        public EventHandler<SearchEventArgs> ProductSelected;

        //-- Constructors
        public CompactSearchForm()
        {
            InitializeComponent();

            namnCbx.DisplayMember = Name;
        }

        //-- Methods
        /// <summary>
        /// Callback-metod som anropas då formen laddas.
        /// </summary>
        private void CompactSearchForm_Load(object sender, EventArgs e)
        {
            Init();
        }
        /// <summary>
        /// Initierar formens kontroller.
        /// </summary>
        public void Init()
        {
            UpdateFromVarunr("0");
            this.ActiveControl = namnCbx;
        }

        /// <summary>
        /// Metod som upptaderar input-fälten med den valda produkten.
        /// </summary>
        public void RefreshSelected()
        {
            long varunr;
            if (Int64.TryParse(varunrTbx.Text, out varunr))
                UpdateFromVarunr(varunrTbx.Text);
            else if (namnCbx.Text.Length > 0)
                UpdateFromNamn(namnCbx.Text);
            else
                UpdateFromVarunr("0");
        }

        /// <summary>
        /// Metoden letar fram produktnamnet för angivet varunr och fyller i namnfältet.
        /// </summary>
        /// <param name="_varunr">Aktuell produkts varunr, som ska ligga till grund för uppdateringen.</param>
        private void UpdateFromVarunr(string _varunr)
        {
            long varunr;
            if (Int64.TryParse(_varunr, out varunr) && dataSource!=null)
            {
                if (dataSource.ToList().Exists(p => p.Varunr == varunr))
                {
                    Produkt prod = dataSource.ToList().First(p => p.Varunr == varunr);
                    namnCbx.SelectedItem = prod;
                    namnCbx.Text = prod.Namn;
                    if (ProductSelected != null)
                        ProductSelected(this, new SearchEventArgs(varunr)); // Ny produkt vald
                }
                else
                {
                    namnCbx.SelectedItem = null;
                    namnCbx.Text = "";
                }
            }
            else
            {
                namnCbx.SelectedItem = null;
                namnCbx.Text = "";
            }
        }

        /// <summary>
        /// Metoden letar fram varunumret för angivet produktnamn och fyller i varunrfältet.
        /// </summary>
        /// <param name="_varunr">Aktuell produkts namn, som ska ligga till grund för uppdateringen.</param>
        private void UpdateFromNamn(string _namn)
        {
            if (dataSource != null)
            {
                if (dataSource.ToList().Exists(p => String.Compare(p.Namn, _namn) == 0))
                {
                    varunrTbx.Text = dataSource.ToList().First(p => p.Namn == _namn).Varunr.ToString();
                    if (ProductSelected != null)
                        ProductSelected(this, new SearchEventArgs(((Produkt)namnCbx.SelectedItem).Varunr)); // Ny produkt vald
                }
                else
                {
                    varunrTbx.Text = "";
                }
            }
        }

        /// <summary>
        /// Callback-metod som anropas då Texten i namn-comboboxen ändras. Triggar då eventet InputEntered,
        /// samt eventuellt eventet InputIsEmpty.
        /// </summary>
        private void namnCbx_TextChanged(object sender, EventArgs e)
        {
            UpdateFromNamn(namnCbx.Text);

            if (InputEntered != null && namnCbx.Text.Length > 0)
                InputEntered(this, new EventArgs());
            if (namnCbx.Text.Length == 0)
                if (InputIsEmpty != null)
                    InputIsEmpty(this, new EventArgs());
        }

        /// <summary>
        /// Callback-metod som anropas då en tangent trycks ner för inmatning i produktnamn-comboboxen.
        /// Hanterar knappen Delete.
        /// </summary>
        private void namnCbx_KeyDown(object sender, KeyEventArgs e)
        {
            // Hanterar Delete-knappen
            if (e.KeyCode == Keys.Delete)
            {
                namnCbx.Text = "";
                UpdateFromNamn("");
            }
        }

        /// <summary>
        /// Callback-metod som anropas då en tangent trycks ner för inmatning i produktnamn-comboboxen.
        /// Anropar autokompletteringen. Om namnet är identifierbart sätts varunumret.
        /// </summary>
        private void namnCbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AutoComplete(e.KeyChar))
            {
                e.Handled = true;
                UpdateFromNamn(namnCbx.Text);
            }
        }

        /// <summary>
        /// Auto-kompletterar det man skrivit i produktnamn-comboboxen, till ett värde från combobox-listan (alltså ett existerande produktnamn). 
        /// </summary>
        /// <param name="tgtChar">Tangenten som precis tryckts ner.</param>
        /// <returns>Returnerar true om det inskrivna (tillsammans med autocomplete) bildar ett gilltigt produktnamn. False annars.</returns>
        private bool AutoComplete(char tgtChar)
        {
            string strFindStr = "";

            if (tgtChar == (char)8) // Backspace
            {
                if (namnCbx.SelectionStart <= 1) // Om markeringen börjar med första eller andra bokstaven, så raderas hela fältet.
                {
                    namnCbx.Text = "";
                    return false;
                }

                // strFindStr tilldelas den del av textsträngen som inte är markerad.
                if (namnCbx.SelectionLength == 0)
                    strFindStr = namnCbx.Text.Substring(0, namnCbx.Text.Length - 1);
                else
                    strFindStr = namnCbx.Text.Substring(0, namnCbx.SelectionStart - 1);
            }
            else // Ej Backspace, någon annan tgt
            {
                // strFindStr tilldelas den del av textsträngen som inte är markerad + det nu nedtryckta tecknet.
                if (namnCbx.SelectionLength == 0)
                    strFindStr = namnCbx.Text + tgtChar;
                else
                    strFindStr = namnCbx.Text.Substring(0, namnCbx.SelectionStart) + tgtChar;
            }

            int intIdx = -1;

            // Sök efter strängen i ComboBox-listan
            intIdx = namnCbx.FindString(strFindStr);

            if (intIdx != -1) // Strängen hittades
            {
                namnCbx.SelectedText = "";
                namnCbx.SelectedIndex = intIdx;
                namnCbx.SelectionStart = strFindStr.Length;
                namnCbx.SelectionLength = namnCbx.Text.Length;
                return true;
            }
            else // Strängen hittades inte
            {
                return false;
            }
        }

        /// <summary>
        /// Callback-metod som anropas när varunr-textboxen får focus. 
        /// Här stängs namn-comboboxens event av.
        /// </summary>
        private void varunrTbx_Enter(object sender, EventArgs e)
        {
            namnCbx.KeyDown -= namnCbx_KeyDown;
            namnCbx.KeyPress -= namnCbx_KeyPress;
            namnCbx.TextChanged -= namnCbx_TextChanged;
            varunrTbx.SelectAll();
        }

        /// <summary>
        /// Callback-metod som anropas när varunr-textboxen förlorar focus. 
        /// Här sätts namn-comboboxens event på.
        /// </summary>
        private void varunrTbx_Leave(object sender, EventArgs e)
        {
            namnCbx.KeyDown += namnCbx_KeyDown;
            namnCbx.KeyPress += namnCbx_KeyPress;
            namnCbx.TextChanged += namnCbx_TextChanged;
        }

        /// <summary>
        /// Callback-metod som anropas då Texten i varunr-comboboxen ändras. Triggar då eventet InputEntered,
        /// samt eventuellt eventet InputIsEmpty.
        /// </summary>
        private void varunrTbx_TextChanged(object sender, EventArgs e)
        {
            UpdateFromVarunr(varunrTbx.Text);

            if (InputEntered != null && varunrTbx.Text.Length > 0)
                InputEntered(this, new EventArgs());
            if (varunrTbx.Text.Length == 0)
                if (InputIsEmpty != null)
                    InputIsEmpty(this, new EventArgs());
        }

        /// <summary>
        /// Callback-metod som anropas när en tangent trycks ner i varunr-textboxen. 
        /// Hanterar Delete-knappen.
        /// </summary>
        private void varunrTbx_KeyDown(object sender, KeyEventArgs e)
        {
            // Hanterar Delete-knappen
            if (e.KeyCode == Keys.Delete)
            {
                varunrTbx.Text = "";
                UpdateFromVarunr("0");
            }
        }
    }
}
