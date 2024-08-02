using GuitarOOADDemo.Models;
using GuitarSpecOOADDemo.Models;
using static GuitarOOADDemo.Models.Enums;

namespace GuitarOOADDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GuitarSpec spec1 = new GuitarSpec(GuiterBuilder.Martin, "RG", GuiterType.Electric, Wood.Maple, Wood.Walnut);
            GuitarSpec spec2 = new GuitarSpec(GuiterBuilder.Fender, "Stratocaster", GuiterType.Electric, Wood.Alder, Wood.Alder);
            GuitarSpec spec3 = new GuitarSpec(GuiterBuilder.Fender, "Stratocaster", GuiterType.Electric, Wood.Alder, Wood.Alder);

            Guitar guitar1 = new Guitar("SNo1", 12000, spec1);
            Guitar guitar2 = new Guitar("SNo2", 30000, spec2);
            Guitar guitar3 = new Guitar("SNo3", 36700, spec3);


            //Guitar whatErinLikes = new Guitar("3", 45677, "fender", "strats", "electric", "Alder", "Alder");
            GuitarSpec whatErinLikes = new GuitarSpec( GuiterBuilder.Fender, "Stratocaster", GuiterType.Electric, Wood.Alder, Wood.Alder);


            Inventory inventory = new Inventory();
            inventory.guitars.Add(guitar1);
            inventory.guitars.Add(guitar2);
            inventory.guitars.Add(guitar3);
            
            LinkedList<Guitar> foundGuitars = inventory.Search(whatErinLikes);
            if (foundGuitars.Count > 0)
            {
                foreach (var foundGuitar in foundGuitars)
                {
                    Console.WriteLine($"Erin, you might like this:\n" +
                        $"We have a {foundGuitar.Specification.Builder},{foundGuitar.Specification.Model}, {foundGuitar.Specification.Type},{foundGuitar.Specification.Backwood}back and sides," +
                        $"{foundGuitar.Specification.Topwood } top\n" +
                        $"You can have it for {foundGuitar.Price}!");
                    Console.WriteLine("--------------------------");
                          //$"Price: {foundGuitar.Price}\n" +
                          //$"Serial Number: {foundGuitar.SerialNumber}\n" +
                          //$"Builder: {foundGuitar.Specification.Builder}\n" +
                          //$"Model: {foundGuitar.Specification.Model}\n" +
                          //$"Type: {foundGuitar.Specification.Type}\n" +
                          //$"Topwood: {foundGuitar.Specification.Topwood}\n" +
                          //$"Backwood: {foundGuitar.Specification.Backwood}\n");
                }
            }
            else
            {
                Console.WriteLine("Sorry Erin, We have nothing for you");
            }

        }
    }
}
