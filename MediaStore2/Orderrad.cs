using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    public class Orderrad
    {
        //-- Fields
        private long varunr;
        private string namn;
        private int styckPris;

        //-- Properties
        public long Varunr { get { return varunr; } }
        public string Namn { get { return namn; } }
        public int StyckPris { get { return styckPris; } }
        public int BestSaldo { get; set; }

        //-- Constructor
        public Orderrad(long _varunr, string _namn, int _styckPris, int _bestSaldo=1)
        {
            varunr = _varunr;
            namn = _namn;
            styckPris = _styckPris;
            BestSaldo = _bestSaldo;
        }
    }
}
