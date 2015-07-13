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
    /// <summary>
    /// EventArgs-ärvande klass som används av sökkomponenterna SearchForm och CompactSearchForm i anslutning till eventet ProductSelected. Anger vilken produkt som är vald.
    /// </summary>
    public class SearchEventArgs : EventArgs
    {
        private readonly long varunr;
        public long Varunr { get { return varunr; } }
        public SearchEventArgs(long _varunr) { varunr = _varunr; }
    }
}