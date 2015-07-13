using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    /// <summary>
    /// Denna enum definierar de kategorier som en produkt kan tillhöra.
    /// </summary>
    public enum ProdKategoriEnum { Alla=0, Musik=1, Film=2, Bok=3, Spel=4 }

    public class Produkt
    {
        //-- Fields
        private long varunr;

        //-- Properties
        public long Varunr 
        { 
            get { return varunr; }
        }
        public ProdKategoriEnum Kategori { get; set; }
        public string Namn { get; set; }
        public int Saldo { get; set; }
        public int Pris { get; set; }

        // Constructors
        public Produkt()
        {
            varunr = 0;
            Kategori = 0;
            Namn = "";
            Pris = 0;
            Saldo = 0;
        }
        public Produkt(long _varunr, ProdKategoriEnum _kategori, string _namn, int _pris=0, int _saldo=0)
        {
            varunr = _varunr;
            Kategori = _kategori;
            Namn = _namn;
            Pris = _pris;
            Saldo = _saldo;
        }
        public Produkt(Produkt _p) // Copy-konstruktor
        {
            this.Copy(_p);
        }

        // Methods
        /// <summary>
        /// Kopierar en produkt.
        /// </summary>
        /// <param name="_p">Den produkt som ska kopieras.</param>
        public void Copy(Produkt _p)
        {
            varunr = _p.Varunr;
            Kategori = _p.Kategori;
            Namn = _p.Namn;
            Pris = _p.Pris;
            Saldo = _p.Saldo;
        }

        /// <summary>
        /// Överlagrar Object.ToString() och skapar en sträng som lämpar sig för lagring till datafil.
        /// </summary>
        /// <returns>Returnerar en sträng innehållande all information om produkten.</returns>
        public override string ToString()
        {
            return String.Format("{0};{1};{2};{3};{4}", Varunr, (int)Kategori, Namn, Pris, Saldo);
        }
    }
}
