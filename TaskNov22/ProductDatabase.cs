using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNov22
{
    internal class ProductDatabase
    {
        public Product[] Products=new Product[5];
        public int a=0;

        public void AddProduct(Product product)
        {
            if (Products[Products.Length-1]==null)
            {
                for(int i=0;i<Products.Length;i++)
                {
                    if(Products[i]==null)
                    {
                        Products[i]=product;
                        a = i;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The database is full.");
            }
        }
        
        public void SearchProduct(Product Product[])
        {

        }


    }
}
