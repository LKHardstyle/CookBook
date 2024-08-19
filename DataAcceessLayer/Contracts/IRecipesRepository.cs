using DataAcceessLayer.CustomQueryResults;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessLayer.Contracts
{
    public interface IRecipesRepository
    {
        public event Action<string> OnError;
        public Task AddRecipe(Recipe recipe);
        public Task<List<RecipeWithType>> GetRecipe();
        public Task DeleteRecipe(int Id);
        public Task EditRecipe(Recipe recipe);
        public Task<List<Recipe>> GetAllRecipe();
    }
}
