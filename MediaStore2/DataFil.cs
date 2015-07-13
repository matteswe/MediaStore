using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaStore
{


    class DataFil : LagringsAdapter
    {
        //-- Methods
        public override bool LaddaProdukter(ref List<Produkt> prodLst, string file = "")
        {
            prodLst.Clear();

            if (!File.Exists(Path.Combine(dataPath, productFileName)))
                return false;

            if (file.Length == 0)
                file = Path.Combine(dataPath, productFileName);

            using (StreamReader reader = File.OpenText(file))
            {
                string line;

                try
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(';');
                        prodLst.Add(new Produkt(Int64.Parse(fields[0]), (ProdKategoriEnum)Int32.Parse(fields[1]), fields[2], Int32.Parse(fields[3]), Int32.Parse(fields[4])));
                    }
                }
                catch(Exception)
                {
                    return false;
                }
                return true;
            }
        }
        public override void SparaProdukter(List<Produkt> prodLst)
        {
            using (StreamWriter writer = File.CreateText(Path.Combine(dataPath, productFileName)))
            {
                foreach (Produkt p in prodLst)
                    writer.WriteLine(p.ToString());
            }
        }
        public override List<Produkt> ImportProdukter(string file)
        {
            List<Produkt> prodLst = new List<Produkt>();
            if (LaddaProdukter(ref prodLst, file))
                return prodLst;
            else
                return null;

        }
        public override bool ExportProdukter()
        {
            try
            {
                File.Copy(Path.Combine(dataPath, productFileName),
                          Path.Combine(exportPath, productFileName),
                          true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
                
        }

        public override bool LaddaOrdrar(ref List<Order> orderLst)
        {
            orderLst.Clear();

            if (!File.Exists(Path.Combine(dataPath, orderFileName)))
                return false;

            using (StreamReader reader = File.OpenText(Path.Combine(dataPath, orderFileName)))
            {
                string line;

                try
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(';');
                        DateTime dt = new DateTime();
                        dt = DateTime.ParseExact(fields[1], "yyyyMMdd", null);
                        Order order = new Order(Int64.Parse(fields[0]), dt);
                        for(int i=0;i<Int32.Parse(fields[2]);i++)
                        {
                            line = reader.ReadLine();
                            string[] rowFields = line.Split(';');
                            order.AdderaOrderrad(Int64.Parse(rowFields[0]), rowFields[1], Int32.Parse(rowFields[2]), Int32.Parse(rowFields[3]));
                        }
                        orderLst.Add(order);
                    }
                }
                catch(Exception)
                {
                    return false;
                }
                return true;
            }
        }
        public override void SparaOrdrar(List<Order> orderLst)
        {
            using (StreamWriter writer = File.CreateText(Path.Combine(dataPath, orderFileName)))
            {
                foreach (Order o in orderLst)
                    writer.WriteLine(o.ToString());
            } 
        }
    }
}
