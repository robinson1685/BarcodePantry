using System;
using System.Collections.Generic;
using System.Text;

namespace Pantry.Model
{
    public class PantryList
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

    public List<PantryList> GetPantry()
    {
      List<PantryList> pantry = new List<PantryList>()
            {
                new PantryList()
                {
                    Name = "Apple",
                    Quantity = 1
                },

                new PantryList()
                {
                    Name = "Salt",
                    Quantity = 2
                },

                new PantryList()
                {
                    Name = "Bread",
                    Quantity = 3
                }
            };

      return pantry;
        }
    }
}
