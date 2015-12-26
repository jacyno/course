using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Kurs.Repository;
using Kurs.Model;

namespace Kurs
{
    public class TextRepository : Abst
    {
        private string filename = "file.csv";
        //List<ProductModel> products = new List<ProductModel>();
        private static TextRepository instance;
        protected override List<ProductModel> products { get; set; }
        public static TextRepository Instance
        {
            get
            {
                if (instance == null)
                    return instance = new TextRepository();

                return instance;
            }
        }
        private TextRepository()
        {
            products = new List<ProductModel>();
            ReadTextFile();
        }

        
        
        public override void Update()
        {
            Stream file = File.Open(filename, FileMode.OpenOrCreate);
            file.Close();
            StreamWriter fileOut = new StreamWriter(filename);
            using (fileOut)
            {
                foreach (var item in products)
                {
                    fileOut.WriteLine(item.Id + ";" + item.Name + ";" + item.Code + ";" + item.Count + ";" + item.Producer + ";");
                }
            }
        }
        public override void Refresh(string file)
        {
            filename = file;
            ReadTextFile();
        }

        private void ReadTextFile()
        {
            products.Clear();
            Stream file = File.Open(filename, FileMode.OpenOrCreate);
            file.Close();
            StreamReader fileIn = new StreamReader(filename);
            using (fileIn)
            {
                while (!fileIn.EndOfStream)
                {
                    string atr = fileIn.ReadLine();
                    string[] on = atr.Split(';');
                    products.Add(new ProductModel(Convert.ToInt32(on[0]), on[1], Convert.ToInt32(on[2]), Convert.ToInt32(on[3]), on[4]));
                }
            }
        }
        
    }
}
