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
    public partial class SearchForm : UserControl
    {
        //-- Enums
        /// <summary>
        /// Denna enum definierar bit-flaggor som modifierar sök-komponentens utseende.
        /// EndLagerfProdChecked: Anger om checkboxen "Endast lagerförda produkter" ska vara kryssad eller ej då kontrollen initieras ( Init() ).
        /// SaldoKolumn: Anger om en kolumn med produkternas lagersaldon ska visas i datagridviewn.
        /// PrisKolumn: Anger om en kolumn med produkternas priser ska visas i datagridviewn.
        /// </summary>
        [Flags]
        public enum SearchFlags { EndLagerfProdChecked=1, SaldoKolumn=2, PrisKolumn=4 }

        //-- Fields
        private BindingList<Produkt> dataSource = null;

        public SearchFlags Flags;   

        //-- Properties
        /// <summary>
        /// Till denna property ska listan med produkter som sökningen ska operera på knytas.
        /// </summary>
        public BindingList<Produkt> DataSource { set { dataSource = value; prodDgw.DataSource = dataSource; } }

        /// <summary>
        /// Propertyn innehåller den produkt som för tillfället är vald i sökkomponenten.
        /// </summary>
        public Produkt ValdProdukt
        {
            get
            {
                if (prodDgw.SelectedRows.Count == 1)
                    return (Produkt)dataSource.First(p => p.Varunr == (long)prodDgw.SelectedRows[0].Cells[0].Value);
                else
                    return null;
            }
        }

        //-- Events
        /// <summary>
        /// Detta event kastas när en ny produkt väljs i datagridviewn.
        /// </summary>
        public event EventHandler<SearchEventArgs> ProductSelected;

        //-- Constructors
        public SearchForm()
        {
            InitializeComponent();

            kategoriCbx.Items.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(ProdKategoriEnum)).Length; i++)
                kategoriCbx.Items.Add(Enum.GetName(typeof(ProdKategoriEnum), i));
            kategoriCbx.SelectedIndex = 0;
        }

        //-- Methods
        /// <summary>
        /// Initierar sök-komponenten. 
        /// </summary>
        public void Init()
        {
            prodDgw.Columns["Varunr"].Width = 44;
            prodDgw.Columns["Namn"].Width = 260;

            prodDgw.Columns["Kategori"].Visible = false;

            // SearchFlags.PrisKolumn
            if(Flags.HasFlag(SearchFlags.PrisKolumn))
            {
                prodDgw.Columns["Pris"].Visible = true;
                prodDgw.Columns["Namn"].Width -= 60;
                prodDgw.Columns["Pris"].Width = 60;
            }
            else
                prodDgw.Columns["Pris"].Visible = false;
            // SearchFlags.SaldoKolumn
            if (Flags.HasFlag(SearchFlags.SaldoKolumn))
            {
                prodDgw.Columns["Saldo"].Visible = true;
                prodDgw.Columns["Namn"].Width -= 40;
                prodDgw.Columns["Saldo"].Width = 40;
            }
            else
                prodDgw.Columns["Saldo"].Visible = false;

            rensaBtn_Click(this, new EventArgs());
            lagerVarunrTbx.Focus();
        }

        /// <summary>
        /// Updaterar produktlistan i DataGridView:n.
        /// Denna metod är lämplig att anropa efter att man lagt till eller makulerat en produkt.
        /// </summary>
        /// <param name="_selVarunr">Anger varunumret på den produkt som ska vara markerad efter uppdateringen.</param>
        public void UpdateList(long _selVarunr=0)
        {
            FilterDataGrid();
            if (_selVarunr != 0)
            {
                bool isSet = false;
                while (!isSet)
                {
                    for (int i = prodDgw.RowCount - 1; i >= 0; i--)
                    {
                        if (Int64.Parse(prodDgw.Rows[i].Cells[0].Value.ToString()) == _selVarunr)
                        {
                            prodDgw.Rows[i].Selected = true;
                            prodDgw.CurrentCell = prodDgw.Rows[i].Cells[0];
                            isSet = true;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Filtrerar produktlistan i DataGridView:n i enlighet med angivna sökkriterier.
        /// </summary>
        private void FilterDataGrid()
        {
            if (dataSource != null)
            {
                BindingList<Produkt> filteredLst = new BindingList<Produkt>(((BindingList<Produkt>)dataSource).Where(delegate(Produkt p)
                    {
                        int tmpInt;

                        // Varunr
                        if (Int32.TryParse(lagerVarunrTbx.Text, out tmpInt))
                        {
                            if (p.Varunr != tmpInt)
                                return false;
                        }
                        else if (lagerVarunrTbx.Text.Length > 0) // Varunummret är felaktigt (inte ett heltal)
                            return false;
                        // Kategori
                        if (kategoriCbx.SelectedIndex != 0)
                        {
                            if (kategoriCbx.SelectedIndex - 1 != (int)p.Kategori)
                                return false;
                        }
                        // Namn
                        if (namnTbx.Text.Length > 0)
                        {
                            if (namnExaktCbx.Checked && String.Compare(p.Namn, namnTbx.Text) != 0)
                                return false;
                            else if (!namnExaktCbx.Checked && !p.Namn.ToUpper().Contains(namnTbx.Text.ToUpper()))
                                return false;
                        }
                        // Lagerförda produkter
                        if (lagerfordaProdCbx.Checked)
                            if (p.Saldo == 0)
                                return false;
                        // Lagersaldo
                        if (Int32.TryParse(saldoMinTbx.Text, out tmpInt))
                        {
                            if (p.Saldo < tmpInt)
                                return false;
                        }
                        else if (saldoMinTbx.Text.Length > 0) // Minvärdet är felaktigt (inte ett heltal)
                            return false;
                        if (Int32.TryParse(saldoMaxTbx.Text, out tmpInt))
                        {
                            if (p.Saldo > tmpInt)
                                return false;
                        }
                        else if (saldoMaxTbx.Text.Length > 0)// Maxvärdet är felaktigt (inte ett heltal)
                            return false;

                        return true;
                    }
                ).ToList());

                prodDgw.DataSource = filteredLst;
            }
        }

        /// <summary>
        /// Callback-metod som anropas då användaren interagerar med sök-komponenterna på ett sådant sätt att en filtrering ska äga rum. 
        /// </summary>
        private void search_Click(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        /// <summary>
        /// Callback-metod som anropas då användaren klickar på sök-knappen. 
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            FilterDataGrid();
            prodDgw.Focus();
        }

        /// <summary>
        /// Callback-metod som anropas då användaren trycker Enter i en TextBox i sök-komponenten.
        /// </summary>
        private void searchTbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterDataGrid();
            }
        }

        /// <summary>
        /// Callback-metod som anropas då användaren anger att sökkriterierna ska rensas. 
        /// </summary>
        private void rensaBtn_Click(object sender, EventArgs e)
        {
            lagerVarunrTbx.Text = "";
            kategoriCbx.SelectedIndex = 0;
            namnTbx.Text = "";
            namnExaktCbx.Checked = false;
            if(Flags.HasFlag(SearchFlags.EndLagerfProdChecked))
                lagerfordaProdCbx.Checked = true;
            else
                lagerfordaProdCbx.Checked = false;
            saldoMinTbx.Text = "";
            saldoMaxTbx.Text = "";
            lagerVarunrTbx.Focus();
            FilterDataGrid();
        }

        /// <summary>
        /// Callback-metod som anropas då en ny produkt har valts i DataGridView:n. Detta triggar ett event, ProductSelected.
        /// </summary>
        private void lagerProdDgw_SelectionChanged(object sender, EventArgs e)
        {
            if (prodDgw.SelectedRows.Count > 0)
            {
                if(ProductSelected != null)
                    ProductSelected(this, new SearchEventArgs(Int64.Parse(prodDgw.Rows[prodDgw.SelectedRows[0].Index].Cells[0].Value.ToString())));
            }
        }
    }
}
