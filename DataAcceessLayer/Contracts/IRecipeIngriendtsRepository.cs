using DataAcceessLayer.CustomQueryResults;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessLayer.Contracts
{
    public interface IRecipeIngriendtsRepository
    {
        public Task AddRecipeIngredient(RecipeIngredient recipeIngredient);
        public Task DeleteRecipeIngredient(int ingredientId, int recipeId);
        public Task EditRecipeIngredientAmount(RecipeIngredient recipeIngredient);
        public Task<List<RecipeIngredientWithNameAndAmount>> GetRecipeIngredients(int RecipeId);
        public Task<List<RecipeIngredient>> GetAllRecipeIngredients();
        
    }
}
