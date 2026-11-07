using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Shapovalova.Classes
{
    public class Electronic:Shop
    {
        public string Accum {  get; set; }
        public string Speed { get; set; }
        public Electronic(string Name, int Price, string Accum, string Speed) : base(Name, Price)
        {
            this.Accum=Accum;
            this.Speed=Speed;
        }
    }
}
