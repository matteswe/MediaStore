using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace MediaStore
{
    public class Order : IEnumerable
    {
        //-- Fields
        private List<Orderrad> radLst;

        //-- Properties
        public long Ordernr { get; set; }
        public DateTime OrderDatum { get; set; }
        public List<Orderrad> RadLst { get { return radLst; } }

        //-- Constructors
        public Order()
            : this(0, DateTime.Today)
        { }
        public Order(long _ordernr, DateTime _orderDatum)
        {
            radLst = new List<Orderrad>();
            Ordernr = _ordernr;
            OrderDatum = _orderDatum;
        }

        //-- Methods
        /// <summary>
        /// Här implementerar vi interfacet IEnumerable. Detta för att man ska kunna använda foreach på en order och därigenom stega igenom orderraderna. 
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            return RadLst.GetEnumerator();
        }

        /// <summary>
        /// Denna metod jämför två instanser av klassen. Detta möjliggör sortering i en List<Order>.
        /// </summary>
        public int CompareTo(Order _o)
        {
            if (this.OrderDatum.Year > _o.OrderDatum.Year)
                return 1;
            else if (this.OrderDatum.Year < _o.OrderDatum.Year)
                return -1;
            else
                return 0;
        }

        /// <summary>
        /// Överlagrar Object.ToString() -metoden. Returnerar en sträng som lämpar sig för lagring i datafilen.
        /// </summary>
        /// <returns>Returnerar en sträng innehållande all information om ordern.</returns>
        public override string ToString()
        {
            string oStr;
            oStr = String.Format("{0};{1};{2}", Ordernr, OrderDatum.ToString("yyyyMMdd"), radLst.Count);
            foreach (Orderrad r in radLst)
                oStr += String.Format("\r\n{0};{1};{2};{3}", r.Varunr, r.Namn, r.StyckPris, r.BestSaldo);
            return oStr;
        }

        /// <summary>
        /// Undersöker om en produkt med ett visst varunr finns på ordern.
        /// </summary>
        /// <param name="_varunr">Efterfrågad produkts varunr.</param>
        /// <returns>True om produkten finns på ordern, false annars.</returns>
        public bool VarunrExists(long _varunr)
        {
            foreach (Orderrad o in radLst)
                if (o.Varunr == _varunr)
                    return true;
            return false;
        }

        /// <summary>
        /// Lägger till en orderrad till ordern.
        /// </summary>
        /// <param name="_varunr">Produktens varunr.</param>
        /// <param name="_namn">Produktens namn.</param>
        /// <param name="_styckPris">Produktens pris.</param>
        /// <param name="_saldo">Produktens saldo.</param>
        public void AdderaOrderrad(long _varunr, string _namn, int _styckPris, int _saldo)
        {
            Orderrad rad = new Orderrad(_varunr, _namn, _styckPris, _saldo);
            radLst.Add(rad);
        }

        /// <summary>
        /// Skriver ut ett kvitto.
        /// </summary>
        public void PrintKvitto()
        {
            PrintDocument kvittoDoc = new PrintDocument();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = kvittoDoc;
            kvittoDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            if (printDialog.ShowDialog() == DialogResult.OK)
                kvittoDoc.Print();
        }

        /// <summary>
        /// Callback-metod som knyts till PrintDocument-objektet. Hanterar själva utskriften och dess layout.
        /// </summary>
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int x = 60, y = 100;
            int offset = 40;
            int namnX = 60, antalX = 350, prisX = 410;
            long totalSumma = 0;

            SolidBrush brush = new SolidBrush(Color.Black);
            
            graphics.DrawString("MediaStore", new Font("Courier New", 18), brush, x, y);
            graphics.DrawString(String.Format("Kvitto för ordernr: {0}", Ordernr), new Font("Courier New", 12), brush, x, y + offset);
            offset += 20;
            graphics.DrawString(String.Format("Köpdatum: {0}", OrderDatum.ToShortDateString()), new Font("Courier New", 12), brush, x, y + offset);
            offset += 20;
            graphics.DrawString("---------------------------------------------------------", new Font("Courier New", 10), brush, x, y + offset);
            offset += 20;
            graphics.DrawString("Varunr", new Font("Courier New", 10, FontStyle.Bold), brush, x, y + offset); // Varunr
            graphics.DrawString("Namn", new Font("Courier New", 10, FontStyle.Bold), brush, x + namnX, y + offset); // Namn
            graphics.DrawString("Antal", new Font("Courier New", 10, FontStyle.Bold), brush, x + antalX, y + offset); // Antal
            graphics.DrawString("Pris", new Font("Courier New", 10, FontStyle.Bold), brush, x + prisX, y + offset); // Pris
            
            foreach(Orderrad r in radLst)
            {
                offset += 20;
                graphics.DrawString(r.Varunr.ToString(), new Font("Courier New", 10), brush, x, y + offset); // Varunr
                graphics.DrawString(r.Namn, new Font("Courier New", 10), brush, x + namnX, y + offset); // Namn
                graphics.DrawString(r.BestSaldo.ToString(), new Font("Courier New", 10), brush, x + antalX, y + offset); // Antal
                graphics.DrawString((r.StyckPris * r.BestSaldo).ToString() + " kr", new Font("Courier New", 10), brush, x + prisX, y + offset); // Pris
                totalSumma += r.StyckPris * r.BestSaldo;
            }
            offset += 20;
            graphics.DrawString("-------", new Font("Courier New", 10), brush, x + prisX, y + offset);
            offset += 20;
            graphics.DrawString("Totalt:", new Font("Courier New", 10, FontStyle.Bold), brush, x, y + offset); // Totalt
            graphics.DrawString(totalSumma.ToString() + " kr", new Font("Courier New", 10, FontStyle.Bold), brush, x + prisX, y + offset);
        }
    }
}
