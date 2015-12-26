using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Model
{   [Serializable]
    public class ProductModel
    {
        private int p;
        public int Id { get; set; }
        public string Name { get; private set; }
        public int Code { get; private set; }
        public int Count { get; private set; }
        public string Producer { get; private set; }
        

        public ProductModel(int id, string name, int code, int count, string producer)
        {
            Id = id;
            Name = name;
            Code = code;
            Count = count;
            Producer = producer;
        }

        public ProductModel(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public override string ToString()
        {

            return "Продукт " + Name + " шифр: " + Code + "; " + Count + " штук, произведено: " + Producer;
        }
    }
}
