using DataAcceessLayer.Contracts;
using DataAcceessLayer.CustomQueryResults;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAcceessLayer.Repositories
{
    public class RecipeIngredientsRepository : IRecipeIngriendtsRepository
    {
        public event Action<string> OnError;
        private void ErrorOccured(string errorMessage)
        {
            OnError.Invoke(errorMessage);
        }
        public async Task AddRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            try
            {
                string query = @$"insert into RecipeIngredients
                (RecipeId, IngredientId, Amount)
                values (@RecipeId, @IngredientId, @Amount)";
                                

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeIngredient);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while adding Recipe Ingredient";
                ErrorOccured(errorMessage);                
            }
        }

        public async Task DeleteRecipeIngredient(int ingredientId, int recipeId)
        {
            try
            {
                string query = $"Delete from RecipeIngredients where IngredientId = {ingredientId} and RecipeId = {recipeId}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while Deleting Recipe Ingredient";
                ErrorOccured(errorMessage);
            }
        }

        public async Task EditRecipeIngredientAmount(RecipeIngredient recipeIngredient)
        {
            try
            {
                string query = @$"update RecipeIngredients
                            set
                            Amount = {recipeIngredient.Amount}
                            where IngredientId = {recipeIngredient.IngredientId} and RecipeId = {recipeIngredient.RecipeId}";                            

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeIngredient);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while editing Amount of Recipe Ingredient";
                ErrorOccured(errorMessage);
            }
        }

        public async Task<List<RecipeIngredientWithNameAndAmount>> GetRecipeIngredients(int RecipeId)
        {
            try
            {
                string query = @$"Select I.Name, Ri.IngredientId, RI.Amount 
                            from Ingredients I join RecipeIngredients RI
                            on I.Id = RI.IngredientId
                            where ri.RecipeId={RecipeId}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeIngredientWithNameAndAmount>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting Recipe Ingredients.";
                ErrorOccured(errorMessage);
                return new List<RecipeIngredientWithNameAndAmount>();
            }            
        }
    }
}
