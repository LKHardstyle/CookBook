using DomainModel.Models;
using DataAcceessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using DataAcceessLayer.CustomQueryResults;
using CookBook.Services;

namespace DataAcceessLayer.Repositories
{
    public class RecipesRepository : IRecipesRepository
    {
        public event Action<string> OnError;
        private void ErrorOccured(string errorMessage)
        {
            OnError.Invoke(errorMessage);
            Logger.LogError(errorMessage, DateTime.Now);
        }

        public async Task AddRecipe(Recipe recipe)
        {
            try
            {
                string query = @"INSERT INTO Recipes
                               (Name, Description, Image, RecipeTypeId) 
                                values (@Name, @Description, @Image, @RecipeTypeId)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }
            }
            catch (SqlException sqlex)
            {
                if(sqlex.Number == 2627)
                {
                    string errorMessage = "That Recipe already exists!";
                    ErrorOccured(errorMessage);
                }
            }
            catch (Exception ex)
            {               
                string errorMessage = "An error happend while adding recipe.";
                ErrorOccured(errorMessage);
            }
        }

        public async Task<List<RecipeWithType>> GetRecipe()
        {
            try
            {
                string query = "select r.Id, r.Name, r.Description, rt.Name as 'Type', r.RecipeTypeId, r.Image from Recipes r join RecipeTypes rt on r.RecipetypeId = rt.Id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeWithType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting Recipe";
                ErrorOccured(errorMessage);
                return new List<RecipeWithType>();
            }
        }

        public async Task DeleteRecipe(int Id)
        {
            try
            {
                string query = $"Delete from Recipes where Id = {Id}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query);
                }
            }
            catch(Exception ex)
            {
                string errorMessage = "An error happend while Deleting Recipe";
                ErrorOccured(errorMessage);
            }            
        }

        public async Task EditRecipe(Recipe recipe)
        {
            try
            {
                string query = @"update Recipes
                            set
                            Name = @Name,
                            Description = @Description,
                            RecipeTypeId = @RecipeTypeId"
                            + (recipe.Image != null ? ",Image = @Image" : "") 
                            + " where Id = @Id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }
            }
            catch(Exception ex)
            {
                string errorMessage = "An error happend while editing Recipe";
                ErrorOccured(errorMessage);
            }
        }

        public async Task<List<Recipe>> GetAllRecipe()
        {
            try
            {
                string query = "select * from Recipes";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<Recipe>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting all recipes";
                ErrorOccured(errorMessage);
                return new List<Recipe>();
            }
        }
    }
}
