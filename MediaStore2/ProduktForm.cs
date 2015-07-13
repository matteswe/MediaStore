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
    /// <summary>
    /// Med hjälp av denna enum avgörs om formen (ProduktForm) används för att skapa en ny produkt eller för att uppdatera en befintlig.
    /// </summary>
    public enum ProduktFormStatus { Addera, Uppdatera }

    public partial class ProduktForm : Form
    {
        //-- Fields
        /// <summary>
        /// Lista som innehåller samtliga produkter.
        /// </summary>
        private List<Produkt> produktLst;
        private ProduktFormStatus formStatus;

        //-- Properties
        private Produkt ProduktAkt;

        //-- Constructors
        public ProduktForm(List<Produkt> _produktLst)
        {
            InitializeComponent();
            produktLst = _produktLst;
            statusLbl.Text = "";

            kategoriCbx.Items.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(ProdKategoriEnum)).Length; i++)
                kategoriCbx.Items.Add(Enum.GetName(typeof(ProdKategoriEnum), i));
            kategoriCbx.SelectedIndex = 0;
            this.ActiveControl = namnTbx;
        }
        public ProduktForm(List<Produkt> _produktLst, ProduktFormStatus _status, Produkt _produkt)
            : this(_produktLst)
        {
            formStatus = _status;
            ProduktAkt = _produkt;

            if (formStatus == ProduktFormStatus.Addera)
            {
                this.Text = "Addera produkt";
                prisTbx.Text = "0";
                saldoTbx.Text = "0";
            }
            else if (formStatus == ProduktFormStatus.Uppdatera)
            {
                this.Text = "Redigera produkt";
                varunrTbx.Text = ProduktAkt.Varunr.ToString();
                kategoriCbx.SelectedIndex = (int)ProduktAkt.Kategori;
                namnTbx.Text = ProduktAkt.Namn;
                prisTbx.Text = ProduktAkt.Pris.ToString();
                saldoTbx.Text = ProduktAkt.Saldo.ToString();

            }
        }

        //-- Methods
        /// <summary>
        /// Callback-metod som anropas då man trycker på Ok-knappen.
        /// </summary>
        private void adderaBtn_Click(object sender, EventArgs e)
        {
            bool dRes = true;
            int pris;
            if (namnTbx.Text.Length == 0)
            {
                statusLbl.Text = "Produkten måste tilldelas ett namn.";
                //MessageBox.Show("Produkten måste tilldelas ett namn.", "Addera produkt", MessageBoxButtons.OK);
                dRes = false;
            }
            else if (formStatus == ProduktFormStatus.Addera && produktLst.Exists(p => String.Compare(p.Namn, namnTbx.Text) == 0))
            {
                statusLbl.Text = "Produktnamnet finns redan. Ange ett nytt namn."; 
                //MessageBox.Show("Produktnamnet finns redan. Ange ett nytt namn.", "Addera produkt", MessageBoxButtons.OK);
                dRes = false;
            }
            else if (!Int32.TryParse(prisTbx.Text, out pris))
            {
                statusLbl.Text = "Ett pris måste anges i hela kronor.";
                //MessageBox.Show("Ett pris måste anges i hela kronor.", "Addera produkt", MessageBoxButtons.OK);
                dRes = false;
            }
            else if (dRes)
            {
                ProduktAkt.Kategori = (ProdKategoriEnum)kategoriCbx.SelectedIndex;
                ProduktAkt.Namn = namnTbx.Text;
                ProduktAkt.Pris = Int32.Parse(prisTbx.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Callback-metod som anropas när användaren trycker ner en tangent i pris-fältet eller i namn-fältet.
        /// </summary>
        private void tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusLbl.Text = "";
        }
    }
}
