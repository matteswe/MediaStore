using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MediaStore
{
    public class Butik
    {
        //-- Fields
        private List<Produkt> produktLst;   // Master-listan som innehåller samtliga produkter.
        private List<Order> orderLst;       // Master-listan som innehåller samtliga order (köp).

        private LagringsAdapter lagring;    // Referensen till det objekt som kommunicerar med datafilen.
        private Statistik statistics;       // Referensen till det objekt som beräknar all statistik.

        //-- Properties
        public List<Produkt> ProduktLst
        {
            get { return produktLst; }
        }
        public Statistik Statistics
        {
            get { return statistics; }
        }

        //-- Constructor
        public Butik()
        {
            produktLst = new List<Produkt>();
            orderLst = new List<Order>();
            lagring = new DataFil();
            statistics = new Statistik(produktLst, orderLst);

            lagring.LaddaProdukter(ref produktLst);
            lagring.LaddaOrdrar(ref orderLst);
        }

        //-- Methods
        /// <summary>
        /// Returnerar en produkt.
        /// </summary>
        /// <param name="_varunr">Varunumret på den produkt som ska returneras.</param>
        /// <returns>Returnerar produkten med angivet varunummer. Om ingen sådan produkt finns, returneras null.</returns>
        public Produkt GetProdukt(long _varunr)
        {
            if(!produktLst.Exists(p => p.Varunr == _varunr))
                return null;
            List<Produkt> lst = produktLst.Where(p => p.Varunr == _varunr).Select(p => p).ToList();
            if (lst.Count == 1)
                return lst[0];
            else
                return null;
        }

        /// <summary>
        /// Metod som sparar listan med produkter till fil.
        /// </summary>
        public void SparaProdukter()
        {
            lagring.SparaProdukter(produktLst);
        }

        /// <summary>
        /// Lägger till en ny produkt till sortementet. Sparas även till fil.
        /// </summary>
        /// <param name="_namn">Produktens namn.</param>
        /// <param name="_kategori">Produktens kategori.</param>
        /// <param name="_pris">Produktens pris.</param>
        /// <param name="_saldo">Produktens lagersaldo.</param>
        /// <returns>Returnerar adderad produkts varunr.</returns>
        public long AdderaProdukt(string _namn, ProdKategoriEnum _kategori, int _pris=0, int _saldo=0, long _varunr=0)
        {
            Produkt prod;
            if(produktLst.Count == 0 && _varunr != 0) // Tomt produktregister, produkten som ska adderas är inte importerad
                prod = new Produkt(1 , _kategori, _namn, _pris, _saldo);
            else if(_varunr != 0) // Produkten är importerad (har ett varunr)
                prod = new Produkt(_varunr, _kategori, _namn, _pris, _saldo);
            else // Produkten är nyupplaggd här i programmet
                prod = new Produkt(produktLst.Max(p => p.Varunr+1), _kategori, _namn, _pris, _saldo);
            produktLst.Add(prod);
            lagring.SparaProdukter(produktLst);
            return prod.Varunr;
        }

        /// <summary>
        /// Redigerar uppgifterna på en befintlig produkt. Redigerar även i filen. 
        /// </summary>
        /// <param name="_prod">Aktuell produkt med redigerade uppgifter.</param>
        public void RedigeraProdukt(Produkt _prod)
        {
            if(produktLst.Exists(p => p.Varunr == _prod.Varunr))
            {
                Produkt prod = produktLst.First(p => p.Varunr == _prod.Varunr);
                prod.Copy(_prod);
                lagring.SparaProdukter(produktLst);
            }
        }

        /// <summary>
        /// Raderar en produkt ur sortementet. Raderar den även från filen.
        /// </summary>
        /// <param name="_varunr"></param>
        /// <returns></returns>
        public bool RaderaProdukt(long _varunr)
        {
            if(produktLst.Exists(p => p.Varunr == _varunr))
            {
                produktLst.RemoveAll(p => p.Varunr == _varunr);
                lagring.SparaProdukter(produktLst);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Kopierar datafilen innehållande produkterna till exportmappen.
        /// </summary>
        /// <returns>Anger om filkopieringen gick bra eller ej.</returns>
        public bool ExportProdukter()
        {
            return lagring.ExportProdukter();
        }
        /// <summary>
        /// Hämtar sökvägen för import.
        /// </summary>
        /// <returns></returns>
        public string GetImportPath()
        {
            return LagringsAdapter.GetImportPath();
        }
        /// <summary>
        /// Importerar produkterna från en importfil.
        /// </summary>
        public void ImportProdukter(string file)
        {
            List<Produkt> newProdLst = lagring.ImportProdukter(file);
            if(newProdLst != null)
            {
                foreach(Produkt p in newProdLst)
                {
                    if (produktLst.Exists(pr => pr.Varunr == p.Varunr))
                        RedigeraProdukt(p);
                    else
                        AdderaProdukt(p.Namn, p.Kategori, p.Pris, p.Saldo, p.Varunr); ;
                }
            }
        }

        /// <summary>
        /// Lägger till angivet saldo till produktens lagersaldo. (Endast i minnet)
        /// Metoden SparaProdukter() bör härefter anropas för att spara ändringen till fil.
        /// </summary>
        /// <param name="_varunr">Produktens varunr.</param>
        /// <param name="_saldo">Antalet som ska läggas till.</param>
        /// <returns>Returnerar true om det finns en produkt med angivet varunr, annars false.</returns>
        public bool Inleverans(long _varunr, int _saldo)
        {
            Produkt prod = produktLst.FirstOrDefault(p => p.Varunr == _saldo);
            if (prod != null)
            {
                prod.Saldo += _saldo;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Lägger till en order till listan. Sparas även till fil.
        /// </summary>
        /// <param name="_order">Den order som ska sparas.</param>
        public void AdderaOrder(Order _order)
        {
            if (orderLst.Count > 0)
                _order.Ordernr = orderLst.Max(o => o.Ordernr + 1);
            else
                _order.Ordernr = 1;
            orderLst.Add(_order);
            lagring.SparaOrdrar(orderLst);

            // Räkna ner lagersaldot
            foreach (Orderrad r in _order.RadLst)
                SubtraheraProduktSaldo(r.Varunr, r.BestSaldo);
            lagring.SparaProdukter(produktLst);
        }

        /// <summary>
        /// Subtraherar angivet antal från en produkts lagersaldo.
        /// </summary>
        /// <param name="_varunr">Varunumret för produkten vars saldo ska minskas.</param>
        /// <param name="_antal">Antalet med vilket saldot ska minskas.</param>
        private void SubtraheraProduktSaldo(long _varunr, int _antal)
        {
            Produkt prod = produktLst.First(p => p.Varunr == _varunr);
            prod.Saldo -= _antal;
            if (prod.Saldo < 0)
                prod.Saldo = 0;
        }
    }
}
