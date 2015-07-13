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
    public partial class StoreForm : Form
    {
        //-- Enums
        /// <summary>
        /// Denna enum kan användas för att beskriva vilken vy (vilken flik) som är aktiv i programmet.
        /// </summary>
        enum ProgramView { Butik=0, Lager=1, Statistik=2 }

        //-- Fields
        /// <summary>
        /// Denna medlem innehåller programmets "Business Intelligence"
        /// </summary>
        private Butik butik;

        //-- Constructors
        public StoreForm()
        {
            InitializeComponent();

            butik = new Butik();

            lagerSearchForm.ProductSelected += ProductSelected;
            butikSearchForm.ProductSelected += ProductSelected;
            lagerSearchForm.DataSource = new BindingList<Produkt>(butik.ProduktLst);
            butikSearchForm.DataSource = new BindingList<Produkt>(butik.ProduktLst);
            butikSearchForm.flags = SearchForm.SearchFlags.EndLagerfProdChecked | SearchForm.SearchFlags.SaldoKolumn;
        }

        //-- Methods
        /// <summary>
        /// Callback-metod som anropas då huvudformen laddas. 
        /// </summary>
        private void StoreForm_Load(object sender, EventArgs e)
        {
            tabControl_SelectedIndexChanged(this, new EventArgs());
        }

        /// <summary>
        /// Callback-metod som knyts till SearchForm-objektets event med samma namn.
        /// </summary>
        /// <param name="Sender">Definierar eventets avsändare.</param>
        /// <param name="args">Med hjälp av detta objekt kan man identifiera vilken produkt (varunr) som har valts i SearchForm-objektet.</param>
        private void ProductSelected(object Sender, SearchForm.SearchEventArgs args)
        {
            Produkt prod = butik.GetProdukt(args.Varunr);
            if(prod != null)
            {
                if((SearchForm)Sender == butikSearchForm)
                {

                }
                else if ((SearchForm)Sender == lagerSearchForm)
                {
                    lagerVarunrTbx.Text = prod.Varunr.ToString();
                    lagerKategoriTbx.Text = prod.Kategori.ToString();
                    lagerNamnTbx.Text = prod.Namn;
                    lagerPrisTbx.Text = prod.Pris.ToString();
                    lagerSaldoTbx.Text = prod.Saldo.ToString();
                }
            }
        }

        /// <summary>
        /// Callback-metod som anropas då en ny flik (Butik/Lager/Statistik) har valts i programmets huvudfönser.
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            butikToolStrip.Stretch = true;
            lagerToolStrip.Stretch = true;

            if(tabControl.SelectedIndex == (int)ProgramView.Butik)
            {
                butikToolStrip.Visible = true;
                lagerToolStrip.Visible = false;
                butikSearchForm.Init();
            }
            else if(tabControl.SelectedIndex == (int)ProgramView.Lager)
            {
                lagerToolStrip.Visible = true;
                butikToolStrip.Visible = false;
                lagerSearchForm.Init();
            }
        }
    }
}
