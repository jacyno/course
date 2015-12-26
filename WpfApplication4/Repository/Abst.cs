using Kurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Repository
{
    public abstract class Abst : IRepository
    {
        abstract protected List<ProductModel> products { get; set; }

        public void Add(ProductModel product)
        {
            products.Add(product);
        }

        public List<ProductModel> Filter(string field, string text)
        {
            if (field.Equals("id"))
            {
                return products.Where(item => Convert.ToString(item.Id).StartsWith(text) || Convert.ToString(item.Id) == text).ToList();
            }
            else
            {
                if (field.Equals("name"))
                {
                    return products.Where(item => item.Name.StartsWith(text) || item.Name == text).ToList();
                }
                else
                {
                    if (field.Equals("code"))
                    {
                        return products.Where(item => Convert.ToString(item.Code).StartsWith(text) || Convert.ToString(item.Code) == text).ToList();
                    }
                    else
                    {
                        if (field.Equals("count"))
                        {
                            return products.Where(item => Convert.ToString(item.Count).StartsWith(text) || Convert.ToString(item.Count) == text).ToList();
                        }
                        else
                        {
                            if (field.Equals("name"))
                            {
                                return products.Where(item => item.Name.StartsWith(text) || item.Name == text).ToList();
                            }
                        }
                    }
                }
            }
            return products.Where(item => item.Name.StartsWith(text) || item.Name == text).ToList();
        }

        
        public bool Del(ProductModel product)
        {

            if (products.Remove(product))
                return true;
            else
                return false;
        }

        public bool DelById(int id)
        {
            foreach (var item in products)
            {
                if (item.Id == id)
                {
                    products.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool Sort(string field)
        {
            switch (field)
            {
                case "id":
                    {
                        products.Sort(
                        delegate(ProductModel obj1, ProductModel obj2)
                        {
                            return obj1.Id.CompareTo(obj2.Id);
                        }
                        );
                    } break;
                case "name":
                    {
                        products.Sort(
                            delegate(ProductModel obj1, ProductModel obj2)
                            {
                                return obj1.Name.CompareTo(obj2.Name);
                            });
                    } break;
                case "code":
                    {
                        products.Sort(
                            delegate(ProductModel obj1, ProductModel obj2)
                            {
                                return obj1.Code.CompareTo(obj2.Code);
                            });
                    } break;
                case "count":
                    {
                        products.Sort(
                            delegate(ProductModel obj1, ProductModel obj2)
                            {
                                return obj1.Count.CompareTo(obj2.Count);
                            });
                    } break;
                case "producer":
                    {
                        products.Sort(
                            delegate(ProductModel obj1, ProductModel obj2)
                            {
                                return obj1.Producer.CompareTo(obj2.Producer);
                            });
                    } break;

                default:
                    return false;
            }
            return true;
        }

        public List<ProductModel> GetAll()
        {
            return products;
        }
        public void Change(ProductModel product1, ProductModel product2)
        {
            int i = 0;
            foreach (var item in products)
            {
                if (item == product1)
                {
                    break;
                }
                i++;
            }
            products[i] = product2;
        }
       /* public List<ProductModel> Filter(string field, string filterOption)
        {
            if (field.Equals(FILTER_FIELD_NAME))
            {
                products.Where(
                return products.Where(products => (products.Name.Equals(filterOption) || products.Name.StartsWith(filterOption))).ToList();
            }
            else throw new ArgumentException("Неверно задана опция!", "Фильтр");
        }*/
        public abstract void Update();
        public abstract void Refresh(string file);

    }

}
