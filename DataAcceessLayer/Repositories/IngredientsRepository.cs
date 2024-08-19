using CookBook.Services;
using Dapper;
using DataAcceessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessLayer.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        public event Action<string> OnError;

        public event Action<string> OnSuccess;

        public async Task AddIngredient(Ingredient ingredient)
        {
            try
            {
                string query = @"insert into Ingredients 
                (Name, Weight, KcalPer100g, PricePer100g, Type)
                values(@Name, @Weight, @KcalPer100g, @PricePer100g, @Type)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {                   
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (SqlException ex)
            {
                string errorMessage = "";
                if (ex.Number == 2627)
                    errorMessage = "That ingredient already exists.";              
                else
                    errorMessage = "An error happend in the Database.";
                ErrorOccured(errorMessage);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while adding the Ingredient.";
                ErrorOccured(errorMessage);
            }
        }
        private void ErrorOccured(string errorMessage)
        {
            if(OnError != null)
            {
                OnError.Invoke(errorMessage);
                Logger.LogError(errorMessage, DateTime.Now);
            }                
        }
        private void SuccessfullyCompleted(string successMessage)
        {
            if(OnSuccess != null)
                OnSuccess.Invoke(successMessage);
        }
        public async Task<List<Ingredient>> GetIngredients(string? name = "")
        {
            try
            {
                string query = "select * from ingredients";
                if (!string.IsNullOrEmpty(name))
                    query += $" where name like '{name}%'";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<Ingredient>(query)).ToList();
                }
            }catch(Exception ex)
            {
                string errorMessage = "An error happend while getting Ingredients";
                ErrorOccured(errorMessage);
                return new List<Ingredient>();
            }
            
        }
        public async Task DeleteIngredient(Ingredient ingredient)
        {
            try
            {
                string query = $"Delete from Ingredients where Id = {ingredient.Id}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while Deleting Ingredients";
                ErrorOccured(errorMessage);
            }
            
        }
        public async Task EditIngredient(Ingredient ingredient)
        {
            try
            {
                string query = @"update Ingredients
                            set
                            Name = @Name,
                            Weight = @Weight,
                            KcalPer100g = @KcalPer100g,
                            PricePer100g = @PricePer100g,
                            Type = @Type
                            where Id = @Id";
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch(Exception ex)
            {
                string errorMessage = "An error happend while editing Ingredients";
                ErrorOccured(errorMessage);
            }
            
        }
        public async Task UpdateAmounts(List<RecipeIngredient> recipeIngredients)
        {
            string query = "";

            foreach (RecipeIngredient recipeIngredient in recipeIngredients)
            {
                string formattedAmount = recipeIngredient.Amount.ToString("0.00", CultureInfo.InvariantCulture);

                query += $@"update Ingredients
                            set
                            Weight = Weight - {formattedAmount}
                            where Id = {recipeIngredient.IngredientId} ";
            }
            try
            {                
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query);
                    SuccessfullyCompleted("SuccessFully Completed!");
                }
                
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while updating Ingredients";
                ErrorOccured(errorMessage);
            }
        }
    }
}
