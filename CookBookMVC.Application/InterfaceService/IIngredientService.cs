using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookBookMVC.Application.ViewModels.Ingredient;

namespace CookBookMVC.Application.InterfaceService
{
    public interface IIngredientService
    {
        
        ListIngredientForListVm GetAllIngredients(string searchString);
        int AddIngredient(IngredientVm ingredient);
        void DeleteIngredient(int ingredientId);
        void EditIngredient(IngredientVm ingredient);
        IngredientVm GetIngredientById(int id);
    }
}
