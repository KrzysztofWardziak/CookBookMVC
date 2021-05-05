using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CookBookMVC.Domain.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int IngredientId { get; set; }
        public decimal Count { get; set; }
        public decimal Weight { get; set; }



        [ForeignKey("IngredientId")]
        public virtual Ingredient Category { get; set; }
    }
}
