using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarSpecOOADDemo.Models;
using static GuitarOOADDemo.Models.Enums;

namespace GuitarOOADDemo.Models
{
    internal class Inventory
    {
        public List<Guitar> guitars = new List<Guitar>();

        public void AddGuitar(string serialNum, double price, GuitarSpec specification)
        {
            Guitar guitar = new Guitar(serialNum, price, specification);
            guitars.Add(guitar);
            Console.WriteLine("Added succesfully");
        }


        public Guitar GetGuitar(string serialNum)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber == serialNum)
                    return guitar;
            }
            return null;
        }

        //this returns the list of matching guitars
        public LinkedList<Guitar> Search(GuitarSpec cliGuitar)
        {
            var matchingGuitars = new LinkedList<Guitar>();

            foreach (var guitar in guitars)
            {
                var guitarSpec = guitar.Specification;

                //ignoring price and the serial num
                //if (guitarSpec.Builder == cliGuitar.Builder && guitarSpec.Model == cliGuitar.Model && guitarSpec.Type == cliGuitar.Type && guitarSpec.Backwood == cliGuitar.Backwood && guitarSpec.Topwood == cliGuitar.Topwood)
                //    matchingGuitars.AddLast(guitar);
                //or
                if (guitar.Specification.Matches(cliGuitar))
                    matchingGuitars.AddLast(guitar);

            }
            return matchingGuitars;


        }


    }
}
