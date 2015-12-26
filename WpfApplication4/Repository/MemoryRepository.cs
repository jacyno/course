using Kurs.Model;
using Kurs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs
{
    class MemoryRepository : Abst
    {
       // List<ProductModel> products { get; set; }
        private static MemoryRepository instance;
        private MemoryRepository()
        {
            products = new List<ProductModel>();
        }
        public static MemoryRepository Instance
        {
            get
            {
                if (instance == null)                
                return instance = new MemoryRepository();
                return instance;

            }
        }


        protected override List<ProductModel> products { get; set; }

        public override void Refresh(string file)
        {
        }
        public override void Update()
        {
        }
    }
}
