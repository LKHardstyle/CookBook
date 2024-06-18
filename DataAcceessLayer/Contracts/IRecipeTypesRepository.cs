using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessLayer.Contracts
{
    public interface IRecipeTypesRepository
    {
        public event Action<string> OnError;
        public Task AddRecipetype(RecipeType recipeType);
        public Task<List<RecipeType>> GetRecipeTypes();
    }
}
