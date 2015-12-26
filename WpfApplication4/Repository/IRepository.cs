using Kurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Repository
{
    public interface IRepository
    {
        void Add(ProductModel product);
        bool Del(ProductModel product);
        bool DelById(int id);
        bool Sort(string field);
        List<ProductModel> GetAll();
        void Update();
        void Change(ProductModel product1, ProductModel product2);
        void Refresh(string file);
        List<ProductModel> Filter(string field, string text);

    }
}
