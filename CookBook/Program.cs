using CookBook.Services;
using CookBook.UI;
using DataAcceessLayer.Contracts;
using DataAcceessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace CookBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Initializes the application configuration settings
            ApplicationConfiguration.Initialize();
            
            //Configures and registers services (Dependencies) for the application
            ServiceCollection services = ConfigureServices();            
            
            //Provides the services with their Dependencies
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            //Instance of the starting Form of the Application
            var startForm = serviceProvider.GetRequiredService<HomeForm>();
            //Runs the application
            Application.Run(startForm);
        }

        static ServiceCollection ConfigureServices()
        {
            //Collection of registered Services
            ServiceCollection services = new ServiceCollection();
            
            //Registers Contracts for the Repositories
            services.AddTransient<IIngredientsRepository>(_ => new IngredientsRepository());
            services.AddTransient<IRecipeTypesRepository>(_ => new RecipeTypesRepository());
            services.AddTransient<IRecipesRepository>(_ => new RecipesRepository());
            services.AddTransient<IRecipeIngriendtsRepository>(_ => new RecipeIngredientsRepository());

            //Registers Forms for Dependency Injection, without Data Sharing(one instance each)
            services.AddTransient<IngredientsForm>();
            services.AddTransient<RecipesForm>();
            services.AddTransient<RecipeTypesForm>();
            services.AddTransient<RecipeIngredientsForm>();
            services.AddTransient<AmountForm>();
            services.AddTransient<FoodManagerForm>();
            services.AddTransient<FoodManagerCache>();
            services.AddTransient<HomeForm>();
            services.AddTransient<SecretForm>();

            //Registers Forms for Dependency Injection, with Data Sharing(one instance over all)
            services.AddSingleton(DesktopFileWatcher.Instance);
            services.AddSingleton(StyleWatcher.Instance);

            //Returns the configured Services
            return services;
        }
    }
}