using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarSpecOOADDemo.Models;
using static GuitarOOADDemo.Models.Enums;

namespace GuitarOOADDemo.Models
{
    internal class Guitar
    {

        public string SerialNumber { get; set; }
        public double Price { get; set; }

        public GuitarSpec Specification { get; }

        public Guitar(string serialNum, double price, GuitarSpec specification)
        {

            SerialNumber = serialNum;
            Price = price;
            Specification = specification;
        }

        //public override string ToString()
        //{
            
        //}



    }
}

