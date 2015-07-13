using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaStore
{
    public partial class AterkopForm : Form
    {
        //-- Fields
        private List<Produkt> produktLst;


        //-- Constructor
        public AterkopForm(List<Produkt> _produktLst)
        {
            InitializeComponent();
            statusLbl.Text = "";

            produktLst = _produktLst;
            aterkopCompactSearchForm.DataSource = new BindingList<Produkt>(produktLst);
            aterkopCompactSearchForm.InputEntered = (object sender, EventArgs e) => { statusLbl.Text = ""; };
            aterkopCompactSearchForm.ProductSelected = (object sender, SearchEventArgs e) => { Summera(antalTbx.Text); };
            aterkopCompactSearchForm.InputIsEmpty = (object sender, EventArgs e) => { Summera(antalTbx.Text); };
        }

        //-- Methods
        /// <summary>
        /// Callback-metod som anropas när formen laddas.
        /// </summary>
        private void AterkopForm_Load(object sender, EventArgs e)
        {
            aterkopCompactSearchForm.Focus();
        }

        /// <summary>
        /// Beräknar och uppdaterar totalsumman som ska återbetalas. 
        /// </summary>
        private void Summera(string _antal)
        {
            int antal;
            Produkt prod = aterkopCompactSearchForm.ValdProdukt;
            if (Int32.TryParse(_antal, out antal) && prod != null)
                betalaTbx.Text = ((long)antal * ((Produkt)produktLst.First(p => p.Varunr == prod.Varunr)).Pris).ToString() + " kr";
            else
                betalaTbx.Text = "";
        }

        /// <summary>
        /// Metoden utför ett återköp enligt de uppgifter som användaren angivit. 
        /// </summary>
        /// <returns>Returnerar false om inmatningen är felaktig, annars true vilket betyder att återköpet registrerats.</returns>
        private bool Execute()
        {
            int antal;
            Produkt prod = aterkopCompactSearchForm.ValdProdukt;
            if (Int32.TryParse(antalTbx.Text, out antal))
            {
                prod.Saldo += antal;
                statusLbl.Text = "Återköpet har genomförts.";
                aterkopCompactSearchForm.Init();
                antalTbx.Text = "";
                return true;
            }
            else
            {
                statusLbl.Text = "Produktuppgifterna är inte korrekt ifyllda.";
                return false;
            }
        }

        /// <summary>
        /// Callback-metod som anropas när man klickar på Verkställ-knappen.
        /// </summary>
        private void verkstallBtn_Click(object sender, EventArgs e)
        {
            Execute();
        }

        /// <summary>
        /// Callback-metod som anropas när man klickar på Ok-knappen.
        /// </summary>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if(Execute()) 
                this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Callback-metod som anropas när Antal-textboxen får fokus.
        /// </summary>
        private void tbx_Enter(object sender, EventArgs e)
        {
            antalTbx.SelectAll();
        }

        /// <summary>
        /// Callback-metod som anropas när användaren trycker en tangent i antal-textboxen.
        /// </summary>
        private void antalTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            int antal;
            if (Int32.TryParse(antalTbx.Text+e.KeyChar, out antal))
                Summera(antalTbx.Text + e.KeyChar);
            statusLbl.Text = "";
        }

        /// <summary>
        /// Callback-metod som anropas när texten i antalsfältet ändras.
        /// </summary>
        private void antalTbx_TextChanged(object sender, EventArgs e)
        {
            int antal;
            if (Int32.TryParse(antalTbx.Text, out antal))
                Summera(antalTbx.Text);
            else
                betalaTbx.Text = "";
        }
    }
}
