using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    /// <summary>
    /// Används för att returnera statistik (Topp-10), antal sålda enheter av en viss produkt.
    /// </summary>
    public class ProdSales
    {
        public Produkt Prod { get; set; }
        public int Antal { get; set; }

        public ProdSales(Produkt _prod, int _antal)
        {
            Prod = _prod;
            Antal = _antal;
        }

        /// <summary>
        /// Denna metod jämför två instanser av klassen. Detta möjliggör sortering i en List<ProdSales>.
        /// </summary>
        public int CompareTo(ProdSales _ps)
        {
            if (this.Antal > _ps.Antal)
                return -1;
            else if (this.Antal < _ps.Antal)
                return 1;
            else
                return 0;
        }
}

    /// <summary>
    /// Används för att returnera statistik (Total försäljning under en specifik period).
    /// </summary>
    public class ProdTotalSales
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Antal { get; set; }

        public ProdTotalSales(int _year, int _month, int _antal)// : this()
        {
            Year = _year;
            Month = _month;
            Antal = _antal;
        }
    }

    //-- Enums
    public enum PeriodiseringEnum { Month, Year };
    public enum MonthEnum { Alla = 0, Januari = 1, Februari = 2, Mars = 3, April = 4, Maj = 5, Juni = 6, Juli = 7, Augusti = 8, September = 9, Oktober = 10, November = 11, December = 12 }

    public class Statistik
    {
        //-- Fields
        List<Produkt> produktLst;
        List<Order> orderLst;

        //-- Constructors
        public Statistik(List<Produkt> _prodLst, List<Order> _orderLst)
        {
            produktLst = _prodLst;
            orderLst = _orderLst;
        }

        //-- Methods
        /// <summary>
        /// Returnerar alla årtal som en viss produkt har sålts, sorterat från det senaste årtalet till det äldsta.
        /// Om inget varunr anges, så returneras alla årtal som det finns ordrar på. 
        /// </summary>
        /// <param name="_varunr">Produktens varunr.</param>
        /// <returns>Returnerar en array av årtal.</returns>
        public int[] GetYearsWithStatistics(long _varunr=0)
        {
            List<int> yearsLst;
            if (_varunr != 0)
                yearsLst = orderLst.Where(o => o.VarunrExists(_varunr)).Select(o => o.OrderDatum.Year).Distinct().ToList();
            else
                yearsLst = orderLst.Select(o => o.OrderDatum.Year).Distinct().ToList();
            yearsLst.Sort();
            yearsLst.Reverse();

            return yearsLst.ToArray();
        }

        /// <summary>
        /// Beräknar och returnerar en sorterad lista på produkterna under angiven tidsperiod.
        /// </summary>
        /// <param name="_year">Önskat år för urvalet.</param>
        /// <param name="_month">Önskad månad för urvalet. Om värdet är 0 ska alla månader inkluderas.</param>
        /// <param name="_kategori">Önskad kategori för urvalet.</param>
        /// <returns>Returnerar en lista med ProdSales innehållande samtliga produkter som sålts under angiven tidsperiod, samt antalet sålda.
        /// Listan är sorterad från flest sålda till minst sålda.</returns>
        public List<ProdSales> GetSoldProductsOrdered(int _year, int _month, ProdKategoriEnum _kategori)
        {
            // Sorterar fram endast de ordrar som ligger inom önskat tidsintervall.
            List<Order> oList = orderLst.Where(delegate(Order o)
            {
                // Årtal
                if (o.OrderDatum.Year != _year)
                    return false;

                // Månad
                if (_month != 0 && o.OrderDatum.Month != _month)
                    return false;

                return true;
            }
            ).ToList();

            List<ProdSales> salesLst = new List<ProdSales>();
            foreach (Order o in oList)
            {
                foreach (Orderrad r in o)
                {
                    // Verifierar att produkten är av rätt kategori
                    try 
                    { 
                        Produkt prod = produktLst.First(p => p.Varunr == r.Varunr);
                        if (_kategori == 0 || prod.Kategori == _kategori)
                        {
                            if (salesLst.Exists(p => p.Prod.Varunr == r.Varunr))
                            {
                                ProdSales ps = salesLst.First(p => p.Prod.Varunr == r.Varunr);
                                ps.Antal += r.BestSaldo;
                            }
                            else
                                salesLst.Add(new ProdSales(prod, r.BestSaldo));
                        }
                    }
                    catch (InvalidOperationException) // Produkten finns inte i produktlistan fastän den finns i en order. Det betyder att den är raderad. Vi ignorerar den.
                    {}
                }
            }
            salesLst.Sort((o1, o2) => o1.CompareTo(o2));

            return salesLst;
        }

        /// <summary>
        /// Metoden returnerar en lista över hur många enheter som har sålts av en viss produkt, uppdelat på månad eller år.
        /// Om uppdelningen är månad, så innehåller listan de 12 senaste månaderna, om uppdelningen är år så innehåller listan
        /// samtliga år sedan den första enheten såldes, fram till idag. Om ingen har sålts (och periodiseringen är år) så innehåller 
        /// listan endast innevarande år med ett saldo på 0.
        /// </summary>
        /// <param name="_varunr">Varunumret på den produkt man söker statisik för.</param>
        /// <param name="_period">Anger om periodiseringen ska vara månad eller år.</param>
        /// <returns>En lista objekt av typen ProdTotalSales. Denna lista innehåller information om hur många enheter som har sålts under resp. period.</returns>
        public List<ProdTotalSales> GetTotalSales(long _varunr, PeriodiseringEnum _period)
        {
            List<Order> oList = orderLst;
            List<ProdTotalSales> salesLst = new List<ProdTotalSales>();

            // Om periodiseringen är månad
            if (_period == PeriodiseringEnum.Month)
            {
                // Ordrar med datum sedan 12 månader tillbaka sorteras fram.
                oList = orderLst.Where(delegate(Order o)
                {
                    if (o.OrderDatum.Year != DateTime.Today.Year && !(o.OrderDatum.Year == DateTime.Today.Year-1 && o.OrderDatum.Month > DateTime.Today.Month))
                        return false;
                    else
                        return true;
                }
                ).ToList();

                // Alla månaderna läggs in i rätt ordning, med saldo 0
                int presentMonth = DateTime.Today.Month;
                int presentYear = DateTime.Today.Year;
                salesLst.Clear();
                for (int i = presentMonth; i > 0; i--)
                    salesLst.Add(new ProdTotalSales(presentYear, i, 0));
                for (int i = 12; i > presentMonth; i--)
                    salesLst.Add(new ProdTotalSales(presentYear - 1, i, 0));
            }
            else // Om periodiseringen är år (samtliga ordrar ska hanteras, alltså görs inget urval)
            {
                // Aktuella år läggs in i rätt ordning, med saldo 0.
                salesLst.Add(new ProdTotalSales(DateTime.Today.Year, 0, 0));
                int[] years = GetYearsWithStatistics(_varunr);
                if(years.Length > 0)
                {
                    for(int i=DateTime.Today.Year-1; i>years[years.Length-1];i--)
                        salesLst.Add(new ProdTotalSales(i, 0, 0));
                }
            }

            // Genomgång av alla orderrader i order-urvalet. Sålda produkter adderas till rätt period.
            foreach (Order o in oList)
            {
                foreach (Orderrad r in o)
                {
                    if (r.Varunr == _varunr)
                    {
                        // Om periodiseringen är månader
                        if (_period == PeriodiseringEnum.Month)
                        {
                            ProdTotalSales ps = salesLst.First(p => p.Month == o.OrderDatum.Month);
                            ps.Antal += r.BestSaldo;
                        }
                        else // Periodiseringen är år
                        {
                            if (salesLst.Exists(p => p.Year == o.OrderDatum.Year))
                            {
                                ProdTotalSales ps = salesLst.First(p => p.Year == o.OrderDatum.Year);
                                ps.Antal += r.BestSaldo;
                            }
                            else
                                salesLst.Add(new ProdTotalSales(o.OrderDatum.Year, o.OrderDatum.Month, r.BestSaldo));
                        }
                    }
                }
            }

            return salesLst;
        }
    }
}
