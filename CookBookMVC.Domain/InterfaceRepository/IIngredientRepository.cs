using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookBookMVC.Domain.Model;

namespace CookBookMVC.Domain.InterfaceRepository
{
    public interface IIngredientRepository
    {
        IQueryable<Ingredient> GetAllIngredients();
        int AddIngredient(Ingredient ingredient);
        void DeleteIngredient(int ingredientId);
        void EditIngredient(Ingredient ingredient);
        Ingredient GetIngredientById(int id);
    }
}
