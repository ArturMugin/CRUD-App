using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_App
{
    internal class Product
    {
        public string Model { get; set; }

        public string Coin { get; set; }

        public string Note { get; set; }

        public Product(string model, string coin, string note)
        {
            Model = model;
            Coin = coin;
            Note = note;
        }
    }
}
