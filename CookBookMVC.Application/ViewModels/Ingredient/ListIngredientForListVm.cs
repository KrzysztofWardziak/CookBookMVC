using System;
using System.Collections.Generic;
using System.Text;

namespace CookBookMVC.Application.ViewModels.Ingredient
{
    public class ListIngredientForListVm
    {
        public List<IngredientVm> Ingredients { get; set; }
        public string SearchString { get; set; }
    }
}
