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
    public partial class InleveransForm : Form
    {
        /// <summary>
        /// Lista som innehåller samtliga produkter.
        /// </summary>
        private List<Produkt> produktLst;

        /// <summary>
        /// Konstruktor. 
        /// </summary>
        /// <param name="_produktLst">Listan med samtliga produkter.</param>
        public InleveransForm(List<Produkt> _produktLst)
        {
            InitializeComponent();
            statusLbl.Text = "";

            produktLst = _produktLst;
            inlevCompactSearchForm.DataSource = new BindingList<Produkt>(produktLst);
            inlevCompactSearchForm.InputEntered = (object sender, EventArgs e) => { statusLbl.Text = ""; };
            inlevCompactSearchForm.Init();
        }

        /// <summary>
        /// Callback-metod som anropas då formen laddas. Sätter fokus på önskad kontroll.
        /// </summary>
        private void InleveransForm_Load(object sender, EventArgs e)
        {
            inlevCompactSearchForm.Focus();
        }

        /// <summary>
        /// Utför en inleverans i enlighet med användarens inmatade uppgifter.
        /// </summary>
        /// <returns>Returnerar false om det är något fel med användarens inmatade uppgifter. Annars returneras true efter att inleveransen är klar.</returns>
        private bool Execute()
        {
            int antal;
            Produkt prod = inlevCompactSearchForm.ValdProdukt;
            if (prod != null && Int32.TryParse(antalTbx.Text, out antal))
            {
                prod.Saldo += antal;
                statusLbl.Text = "Inleveransen är utförd.";
                inlevCompactSearchForm.Init();
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
        /// Callback-metod som anropas då användaren klickar på knappen Verkställ.
        /// Inleverans utförs, och sedan konfigureras formen för en ny inmatning.
        /// </summary>
        private void verkstallBtn_Click(object sender, EventArgs e)
        {
            Execute();
        }

        /// <summary>
        /// Callback-metod som anropas då användaren klickar på knappen Ok.
        /// Inleverans utförs, och sedan stängs fönstret.
        /// </summary>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (Execute())
                this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Callback-metod som anropas när antal-fältet får fokus.
        /// </summary>
        private void antalTbx_Enter(object sender, EventArgs e)
        {
            antalTbx.SelectAll();
        }

        /// <summary>
        /// Callback-metod som anropas när en tangent trycks i antal-fältet.
        /// </summary>
        private void antalTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusLbl.Text = "";
        }
    }
}
