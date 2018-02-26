using System.Collections.Generic;
using Pantry.Model;
using Xamarin.Forms;

namespace Pantry.ViewModel
{
    public class PantryViewModel
    {
        public List<PantryList> Pantry { get; set; }

        public PantryViewModel()
        {
        Pantry = new PantryList().GetPantry();
       
        }

    }
}
