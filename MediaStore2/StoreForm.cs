using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            this.Width = 1087;
            this.Height = 650;

            butik = new Butik();

            lagerSearchForm.ProductSelected += ProductSelected;
            lagerSearchForm.DataSource = new BindingList<Produkt>(butik.ProduktLst);
            lagerSearchForm.Flags = SearchForm.SearchFlags.SaldoKolumn;

            butikSearchForm.ProductSelected += ProductSelected;
            butikSearchForm.DataSource = new BindingList<Produkt>(butik.ProduktLst);
            butikSearchForm.Flags = SearchForm.SearchFlags.EndLagerfProdChecked | SearchForm.SearchFlags.SaldoKolumn | SearchForm.SearchFlags.PrisKolumn;

            statCompactSearchForm.DataSource = new BindingList<Produkt>(butik.ProduktLst);
            statCompactSearchForm.ProductSelected += CompactProductSelected;
            statCompactSearchForm.InputIsEmpty += InputIsEmpty;

            foreach (DataGridViewColumn col in statToppDgw.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            foreach (DataGridViewColumn col in statTotDgw.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        //-- Methods
        /// <summary>
        /// Callback-metod som anropas då huvudformen laddas. 
        /// </summary>
        private void StoreForm_Load(object sender, EventArgs e)
        {
            InitialInit();
            tabControl_SelectedIndexChanged(this, new EventArgs());
        }

        /// <summary>
        /// Metod som anropas från konstruktorn. Utför initial initiering diverse kontroller.
        /// </summary>
        private void InitialInit()
        {
            statToppMonthCbx.Items.Clear();
            statToppMonthCbx.Items.Add("Hela året");
            for (int i = 1; i < Enum.GetNames(typeof(MonthEnum)).Length; i++)
                statToppMonthCbx.Items.Add(Enum.GetName(typeof(MonthEnum), i));
            statToppMonthCbx.SelectedIndex = 0;

            statToppKategoriCbx.Items.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(ProdKategoriEnum)).Length; i++)
                statToppKategoriCbx.Items.Add(Enum.GetName(typeof(ProdKategoriEnum), i));
            statToppKategoriCbx.SelectedIndex = 0;

            statToppYearCbx.SelectedIndexChanged += statToppCbx_SelectedIndexChanged;
            statToppMonthCbx.SelectedIndexChanged += statToppCbx_SelectedIndexChanged;
            statToppKategoriCbx.SelectedIndexChanged += statToppCbx_SelectedIndexChanged;
        }

        /// <summary>
        /// Callback-metod som knyts till SearchForm-objektets event med samma namn.
        /// </summary>
        /// <param name="Sender">Definierar eventets avsändare.</param>
        /// <param name="args">Med hjälp av detta objekt kan man identifiera vilken produkt (varunr) som har valts i SearchForm-objektet.</param>
        private void ProductSelected(object Sender, SearchEventArgs args)
        {
            Produkt prod = butik.GetProdukt(args.Varunr);
            if(prod != null)
            {
                if ((SearchForm)Sender == lagerSearchForm)
                    UpdateLagerProduktInfo(prod);
            }
        }

        /// <summary>
        /// Callback-metod som anropas då en ny flik (Butik/Lager/Statistik) har valts i programmets huvudfönser.
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            butikToolStrip.Stretch = true;
            lagerToolStrip.Stretch = true;
            searchToolStrip.Stretch = true;

            if(tabControl.SelectedIndex == (int)ProgramView.Butik)
            {
                butikToolStrip.Visible = true;
                lagerToolStrip.Visible = false;
                searchToolStrip.Visible = false;
                butikSearchForm.Init();
            }
            else if(tabControl.SelectedIndex == (int)ProgramView.Lager)
            {
                lagerToolStrip.Visible = true;
                butikToolStrip.Visible = false;
                searchToolStrip.Visible = false;
                lagerSearchForm.Init();
            }
            else if(tabControl.SelectedIndex == (int)ProgramView.Statistik)
            {
                searchToolStrip.Visible = true;
                lagerToolStrip.Visible = false;
                butikToolStrip.Visible = false;
                statCompactSearchForm.Init();
                
                statToppYearCbx.Items.Clear();
                int[] years = butik.Statistics.GetYearsWithStatistics();
                for (int i = 0; i < years.Length; i++)
                    statToppYearCbx.Items.Add(years[i].ToString());
                statToppYearCbx.SelectedIndex = 0;

                statToppMonthCbx.SelectedIndex = 0;
                statToppKategoriCbx.SelectedIndex = 0;

                statToppCbx_SelectedIndexChanged(this, new EventArgs());
                totYearBtn.Checked = true;
                periodBtn_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Callback-metod som kopierar produktregister-filen till exportmappen.
        /// </summary>
        private void exporteraBtn_Click(object sender, EventArgs e)
        {
            if(butik.ExportProdukter())
                MessageBox.Show("Produktregistret har exporterats.", "Exportera produktregister", MessageBoxButtons.OK);
            else
                MessageBox.Show("Ett fel uppstod när filen skulle exporteras. Kontrollera att exportmappen existerar.", "Exportera produktregister", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Callback-metod som importerar produkterna från en import-fil.
        /// </summary>
        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = butik.GetImportPath();
            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                butik.ImportProdukter(openDialog.FileName);
                if (tabControl.SelectedIndex == (int)ProgramView.Butik)
                    butikSearchForm.UpdateList();
                else if (tabControl.SelectedIndex == (int)ProgramView.Lager)
                    lagerSearchForm.UpdateList();
            }  
        }


        ///////////////////////////////////////////////////
        ///// Metoder som relaterar till Butik-fliken /////
        ///////////////////////////////////////////////////
        /// <summary>
        /// Beräknar upp uppdaterar varukorgens totalpris.
        /// </summary>
        private void CalcTotalPrice()
        {
            int totsumma = 0;
            foreach (DataGridViewRow row in varukorgDgw.Rows)
                totsumma += Int32.Parse(row.Cells["PrisCol"].Value.ToString());
            totsummaLbl.Text = totsumma.ToString() + " kr";
        }

        /// <summary>
        /// Callback-metod som anropas då användaren lägger en produkt i varukorgen.
        /// </summary>
        private void addBuyBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            Produkt p = butikSearchForm.ValdProdukt;
            if (p != null)
            {
                for (int i = 0; i < varukorgDgw.RowCount; i++)
                {
                    if (((Produkt)varukorgDgw.Rows[i].Tag).Varunr == p.Varunr) // Om produkten redan finns i varukorgen, öka på saldot
                    {
                        varukorgDgw.Rows[i].Cells["SaldoCol"].Value = Int32.Parse(varukorgDgw.Rows[i].Cells["SaldoCol"].Value.ToString()) + 1;

                        row = varukorgDgw.Rows[i];
                        break;
                    }
                }
                if (row == null) // Om produkten inte finns i varukorgen sedan tidigare, lägg i den.
                {
                    int index = varukorgDgw.Rows.Add(p.Varunr.ToString(), p.Namn, String.Format("{0}", 1));
                    row = varukorgDgw.Rows[index];
                    row.Tag = p;
                }

                // Beräknar priset
                row.Cells["PrisCol"].Value = Int32.Parse(row.Cells["SaldoCol"].Value.ToString()) * p.Pris;
                CalcTotalPrice();
            }
        }

        /// <summary>
        /// Callback-metod som anropas då användaren tar ur en produkt ur varukorgen.
        /// </summary>
        private void removeBuyBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;

            if (varukorgDgw.SelectedRows.Count > 0)
            {
                row = varukorgDgw.SelectedRows[0];

                if (Int32.Parse(row.Cells["SaldoCol"].Value.ToString()) > 1)  // Om det finns fler än en av prudukten
                {
                    row.Cells["SaldoCol"].Value = Int32.Parse(row.Cells["SaldoCol"].Value.ToString()) - 1;

                    // Beräknar nya priset
                    row.Cells["PrisCol"].Value = Int32.Parse(row.Cells["SaldoCol"].Value.ToString()) * ((Produkt)row.Tag).Pris;
                }
                else
                    varukorgDgw.Rows.Remove(row);
            }
            CalcTotalPrice();
        }

        /// <summary>
        /// Callback-metod som hanterar cell-formatteringen i varukorg-DataGridView:n. Denna används för att markera när en produkt är slut på lagret.
        /// </summary>
        private void varukorgDgw_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (Int32.Parse(varukorgDgw.Rows[e.RowIndex].Cells["SaldoCol"].Value.ToString()) > ((Produkt)varukorgDgw.Rows[e.RowIndex].Tag).Saldo)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Callback-metod som anropas då användaren avbryter ett köp.
        /// </summary>
        private void abortBuyBtn_Click(object sender, EventArgs e)
        {
            if (varukorgDgw.RowCount > 0)
                if (MessageBox.Show("Är du säker på att du vill avbryta köpet?", "Avbryt", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    varukorgDgw.Rows.Clear();
                    totsummaLbl.Text = "0 kr";
                }
        }

        /// <summary>
        /// Callback-metod som anropas då användaren slutför köpet.
        /// </summary>
        private void execBuyBtn_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            bool skrivUtKvitto = false;
            Order order;

            if (varukorgDgw.RowCount == 0)
                return;

            foreach (DataGridViewRow row in varukorgDgw.Rows)
            {
                if (Int32.Parse(row.Cells["SaldoCol"].Value.ToString()) > ((Produkt)row.Tag).Saldo)
                {
                    isOk = false;
                    break;
                }
            }
            if (!isOk)
                MessageBox.Show("Alla produkter finns inte på lager i önskat antal. Anpassa köpet.", "Lagersaldon", MessageBoxButtons.OK);
            else // Köpet går igenom
            {
                DialogResult res;
                res = MessageBox.Show("Köpet slutförs nu. Vill du skriva ut ett kvitto?", "Slutför köp", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Cancel) // Köpet avbryts
                    return;
                else if (res == DialogResult.Yes)
                    skrivUtKvitto = true;

                order = new Order();
                foreach (DataGridViewRow row in varukorgDgw.Rows)
                {
                    Produkt prod = (Produkt)row.Tag;
                    int antal = Int32.Parse(row.Cells["SaldoCol"].Value.ToString());
                    order.AdderaOrderrad(prod.Varunr, prod.Namn, prod.Pris, antal);
                }
                butik.AdderaOrder(order);

                // Kvitto-utskrift
                if (skrivUtKvitto)
                    order.PrintKvitto();

                varukorgDgw.Rows.Clear();
                butikSearchForm.Init();
            }
        }

        /// <summary>
        /// Callback-metod som anropas man klickar på återköp.
        /// </summary>
        private void aterkopBtn_Click(object sender, EventArgs e)
        {
            using (AterkopForm akForm = new AterkopForm(butik.ProduktLst))
            {
                akForm.ShowDialog();
                butik.SparaProdukter();
                butikSearchForm.UpdateList();
            }
        }


        ///////////////////////////////////////////////////
        ///// Metoder som relaterar till Lager-fliken /////
        ///////////////////////////////////////////////////
        /// <summary>
        /// Metod som fyller i vald produkts egenskaper i formen.
        /// </summary>
        /// <param name="_prod">Den produkt som ska visas.</param>
        private void UpdateLagerProduktInfo(Produkt _prod)
        {
            lagerVarunrTbx.Text = _prod.Varunr.ToString();
            lagerKategoriTbx.Text = _prod.Kategori.ToString();
            lagerNamnTbx.Text = _prod.Namn;
            lagerPrisTbx.Text = _prod.Pris.ToString();
            lagerSaldoTbx.Text = _prod.Saldo.ToString();
        }

        /// <summary>
        /// Callback-metod som anropas då användaren valt att makulera aktuell produkt.
        /// </summary>
        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            long varunr;
            DialogResult resultat;

            if (Int64.TryParse(lagerVarunrTbx.Text, out varunr))
            {
                if (Int32.Parse(lagerSaldoTbx.Text) > 0)
                    resultat = MessageBox.Show("Lagersaldot är inte noll. Vill du ändå makulera produkten?", "Makulera produkt", MessageBoxButtons.YesNo);
                else
                    resultat = MessageBox.Show("Är du säker på att du vill makulera produkten?", "Makulera produkt", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    butik.RaderaProdukt(varunr);
                    lagerSearchForm.UpdateList();
                }
            }
        }

        /// <summary>
        /// Callback-metod som anropas då användaren väljer att lägga till en ny produkt.
        /// </summary>
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            Produkt prod = new Produkt();
            using (ProduktForm ap = new ProduktForm(butik.ProduktLst, ProduktFormStatus.Addera, prod))
            {
                if (ap.ShowDialog() == DialogResult.OK)
                {
                    long varunr = butik.AdderaProdukt(prod.Namn, prod.Kategori, prod.Pris);
                    lagerSearchForm.UpdateList(varunr);
                }
            }
        }

        /// <summary>
        /// Callback-metod som anropas då användaren väljer att redigera uppgifterna för en befintlig produkt.
        /// </summary>
        private void lagerRedigeraProdBtn_Click(object sender, EventArgs e)
        {
            if (lagerVarunrTbx.Text.Length == 0)
                return;
            Produkt aktProd = butik.GetProdukt(Int64.Parse(lagerVarunrTbx.Text));
            Produkt tmpProd = new Produkt(aktProd);

            using (ProduktForm ap = new ProduktForm(butik.ProduktLst, ProduktFormStatus.Uppdatera, tmpProd))
            {
                if (ap.ShowDialog() == DialogResult.OK)
                {
                    aktProd.Copy(tmpProd);
                    lagerSearchForm.UpdateList(aktProd.Varunr);
                    butik.RedigeraProdukt(aktProd);
                }
            }
        }

        /// <summary>
        /// Callback-metod som anropas då man klickar på inleverans.
        /// </summary>
        private void inleveransBtn_Click(object sender, EventArgs e)
        {
            using (InleveransForm ilForm = new InleveransForm(butik.ProduktLst))
            {
                ilForm.ShowDialog();
                butik.SparaProdukter();
                butikSearchForm.UpdateList();

                if (butik.ProduktLst.Count == 0)
                    return;

                long varunr = lagerSearchForm.ValdProdukt.Varunr;
                if(varunr != 0)
                    UpdateLagerProduktInfo(butik.ProduktLst.First(p => p.Varunr == varunr));
                butikSearchForm.UpdateList();
            }
        }

        ///////////////////////////////////////////////////////
        ///// Metoder som relaterar till Statistik-fliken /////
        ///////////////////////////////////////////////////////
        /// <summary>
        /// Callback-metod som anropas när en produkt har valts i sökkomponenten. 
        /// Försälningsstatistiken läses då upp.
        /// </summary>
        private void CompactProductSelected(object Sender, SearchEventArgs args)
        {
            LoadTotalForsaljningStatistik();
        }

        /// <summary>
        /// Callback-metod som anropas när fälten i sökkomponenten är tomma. 
        /// Försäljningsstatistiken slutar visas då. 
        /// </summary>
        private void InputIsEmpty(object Sender, EventArgs args)
        {
            statTotDgw.Rows.Clear();
        }

        /// <summary>
        /// Callback-metod som anropas då värdet i någon av comboboxarna på statistik-fliken ändras.
        /// 10-topp-listan uppdaters.
        /// </summary>
        private void statToppCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load10ToppStatistik();
        }

        /// <summary>
        /// Uppdaterar 10-i-topp-informationen.
        /// </summary>
        private void Load10ToppStatistik()
        {
            int year;
            if (Int32.TryParse(statToppYearCbx.Text, out year))
            {
                List<ProdSales> salesLst = butik.Statistics.GetSoldProductsOrdered(year, statToppMonthCbx.SelectedIndex, (ProdKategoriEnum)statToppKategoriCbx.SelectedIndex);
                statToppDgw.Rows.Clear();
                for (int i = 0; i < salesLst.Count && i < 10; i++)
                {
                    statToppDgw.Rows.Add(salesLst[i].Prod.Varunr.ToString(), salesLst[i].Prod.Namn, salesLst[i].Antal.ToString());
                }
            }
        }

        /// <summary>
        /// Callback-metod som anropas då någon av periodiseringsknapparna klickas. 
        /// Försäljningsstatistiken visas då.
        /// </summary>
        private void periodBtn_Click(object sender, EventArgs e)
        {
            statCompactSearchForm.RefreshSelected();
            LoadTotalForsaljningStatistik();
        }

        /// <summary>
        /// Metod som visar aktuell försäljningsstatistik.
        /// </summary>
        private void LoadTotalForsaljningStatistik()
        {
            PeriodiseringEnum period;
            if (totYearBtn.Checked)
            {
                period = PeriodiseringEnum.Year;
                statTotDgw.Columns["totYearCol"].Width = 80;
                statTotDgw.Columns["totAntalCol"].Width = 206;
                statTotDgw.Columns["totMonthCol"].Visible = false;
            }
            else
            {
                period = PeriodiseringEnum.Month;
                statTotDgw.Columns["totMonthCol"].Visible = true;
                statTotDgw.Columns["totYearCol"].Width = 80;
                statTotDgw.Columns["totMonthCol"].Width = 110;
                statTotDgw.Columns["totAntalCol"].Width = 80;
            }

            if (statCompactSearchForm.ValdProdukt == null)
                return; 

            List<ProdTotalSales> salesLst = butik.Statistics.GetTotalSales(statCompactSearchForm.ValdProdukt.Varunr, period);
            statTotDgw.Rows.Clear();
            for(int i=0;i< salesLst.Count; i++)
            {
                if (period == PeriodiseringEnum.Year)
                    statTotDgw.Rows.Add(salesLst[i].Year.ToString(), "", salesLst[i].Antal.ToString());
                else // period == PeriodiseringEnum.Month
                    statTotDgw.Rows.Add(salesLst[i].Year.ToString(), Enum.GetName(typeof(MonthEnum), salesLst[i].Month), salesLst[i].Antal.ToString());
            }
        }
    }
}

