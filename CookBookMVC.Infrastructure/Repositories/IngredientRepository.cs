using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookBookMVC.Domain.InterfaceRepository;
using CookBookMVC.Domain.Model;

namespace CookBookMVC.Infrastructure.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly Context _context;

        public IngredientRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<Ingredient> GetAllIngredients()
        {
            return _context.Ingredients;
        }

        public int AddIngredient(Ingredient ingredient)
        {
            if (_context.Ingredients.Any(x => x.Name == ingredient.Name))
            {
                return 0;
            }

            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient.Id;
        }

        public void DeleteIngredient(int ingredientId)
        {
            var ingredientToDelete = _context.Ingredients.Find(ingredientId);
            if (ingredientToDelete != null)
            {
                _context.Ingredients.Remove(ingredientToDelete);
                _context.SaveChanges();
            }
        }

        public void EditIngredient(Ingredient ingredient)
        {
            _context.Attach(ingredient);
            _context.Entry(ingredient).Property("Name").IsModified = true;
        }

        public Ingredient GetIngredientById(int id)
        {
            var ingredient = _context.Ingredients.FirstOrDefault(x => x.Id == id);
            return ingredient;
        }
    }
}
