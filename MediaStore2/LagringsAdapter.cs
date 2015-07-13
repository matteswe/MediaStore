using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore
{
    public abstract class LagringsAdapter
    {
        protected static string productFileName = "produktDB.txt";  // Denna datafil innehåller produkterna
        protected static string orderFileName = "orderDB.txt";      // Denna datafil innehåller ordrarna
        protected static string dataPath = @"..\..";                    // Detta är sökvägen till datafilerna innehållande produkter och ordrar
        protected static string importPath = @"C:\BizTalk\Lab4v3\MediaStoreOut";    // Detta är sökvägen till den mapp i vilken produktfilen ska importeras.
        protected static string exportPath = @"C:\BizTalk\Lab4v3\MediaStoreIn";    // Detta är sökvägen till den mapp i vilken produktfilen ska exporteras.

        public static string GetImportPath() { return importPath; }

        public abstract bool LaddaProdukter(ref List<Produkt> prodLst, string file = "");
        public abstract void SparaProdukter(List<Produkt> prodLst);
        public abstract List<Produkt> ImportProdukter(string file);
        public abstract bool ExportProdukter();

        public abstract bool LaddaOrdrar(ref List<Order> orderLst);
        public abstract void SparaOrdrar(List<Order> orderLst);
    }
}
