using Kurs.Repository;
using Kurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Kurs
{
    class BinRepository : Abst
    {
        private string filename = "bin.dat";
        protected override List<ProductModel> products { get; set; }
        private static BinRepository instance;
        public static BinRepository Instance
        {
            get
            {
                if (instance == null)
                    return instance = new BinRepository();
                return instance;
            }
        }
        private BinRepository()
        {
            products = new List<ProductModel>();
            ReadBinFile();
        }
        

        private  void ReadBinFile()
        {
            try
            {
                using (Stream fileIn = File.Open(filename, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    products = (List<ProductModel>)bf.Deserialize(fileIn);
                }
            }
            catch (Exception)
            {
                products = new List<ProductModel>();
            }
            
        }



        public override void Update()
        {
            using (Stream fileOut = File.Open(filename, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileOut, products);
            }
        }

        public override void Refresh(string file)
        {
            filename = file;
            ReadBinFile();
        }
    }
}
