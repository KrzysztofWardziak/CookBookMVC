using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CookBookMVC.Application.InterfaceService;
using CookBookMVC.Application.ViewModels.Ingredient;
using CookBookMVC.Domain.InterfaceRepository;
using CookBookMVC.Domain.Model;

namespace CookBookMVC.Application.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IMapper _mapper;

        public IngredientService(IMapper mapper, IIngredientRepository ingredientRepository)
        {
            _mapper = mapper;
            _ingredientRepository = ingredientRepository;
        }


        public ListIngredientForListVm GetAllIngredients(string searchString)
        {
            var ingredient = _ingredientRepository.GetAllIngredients().Where(p => p.Name.StartsWith(searchString))
                .ProjectTo<IngredientVm>(_mapper.ConfigurationProvider).ToList();

            var ingredientList = new ListIngredientForListVm()
            {
                Ingredients = ingredient,
                SearchString = searchString
            };

            return ingredientList;
        }

        public int AddIngredient(IngredientVm ingredient)
        {
            var ing = _mapper.Map<Ingredient>(ingredient);
            var id = _ingredientRepository.AddIngredient(ing);
            return id;
        }

        public void DeleteIngredient(int ingredientId)
        {
           _ingredientRepository.DeleteIngredient(ingredientId);
        }

        public void EditIngredient(IngredientVm ingredient)
        {
            var ing = _mapper.Map<Ingredient>(ingredient);
            _ingredientRepository.EditIngredient(ing);
        }

        public IngredientVm GetIngredientById(int id)
        {
            var ing = _ingredientRepository.GetIngredientById(id);
            var ingVm = _mapper.Map<IngredientVm>(ing);
            return ingVm;
        }
    }
}
