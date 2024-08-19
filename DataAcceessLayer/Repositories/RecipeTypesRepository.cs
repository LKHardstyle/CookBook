using DataAcceessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Xml.Linq;
using CookBook.Services;

namespace DataAcceessLayer.Repositories
{
    public class RecipeTypesRepository : IRecipeTypesRepository
    {
        public event Action<string> OnError;

        public async Task AddRecipetype(RecipeType recipeType)
        {
            try
            {
                string query = @"INSERT INTO RecipeTypes
                               (Name) values (@Name)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeType);
                }
            }           
            catch (Exception ex)
            {
                string errorMessage = "An error happend while adding recipe type.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task<List<RecipeType>> GetRecipeTypes()
        {
            try
            {
                string query = "select * from RecipeTypes";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<RecipeType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while getting Recipe types";
                ErrorOccured(errorMessage);
                return new List<RecipeType>();
            }
        }
        private void ErrorOccured(string errorMessage)
        {
            OnError.Invoke(errorMessage);
            Logger.LogError(errorMessage, DateTime.Now);
        }
    }
}
