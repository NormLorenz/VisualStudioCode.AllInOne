using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.SqlServer;
using Microsoft.Framework.DependencyInjection;

namespace VisualStudioCode.WebAPI.Models
{
    public static class SampleData
    {
        public static async Task InitializeSalesDBDatabaseAsync(IServiceProvider serviceProvider)
        {
            using (var db = serviceProvider.GetService<SalesDbContext>())
            {
                var sqlServerDatabase = db.Database as SqlServerDatabase;
                if (sqlServerDatabase != null)
                {
                    if (await sqlServerDatabase.EnsureCreatedAsync())
                    {
                        await InsertTestData(serviceProvider);
                    }
                }
                else
                {
                    await InsertTestData(serviceProvider);
                }
            }
        }

        private static async Task InsertTestData(IServiceProvider serviceProvider)
        {
            var products = GetProducts();
            await AddOrUpdateAsync(serviceProvider, a => a.Name, products);
            var codes = GetCodes();
            await AddOrUpdateAsync(serviceProvider, a => a.Display, codes);
        }

        private static async Task AddOrUpdateAsync<TEntity>(
            IServiceProvider serviceProvider,
            Func<TEntity, object> propertyToMatch, IEnumerable<TEntity> entities)
            where TEntity : class
        {
            // Query in a separate context so that we can attach existing entities as modified
            List<TEntity> existingData;
            using (var db = serviceProvider.GetService<SalesDbContext>())
            {
                existingData = db.Set<TEntity>().ToList();
            }

            using (var db = serviceProvider.GetService<SalesDbContext>())
            {
                foreach (var item in entities)
                {
                    db.Entry(item).State = existingData.Any(g => propertyToMatch(g).Equals(propertyToMatch(item)))
                        ? EntityState.Modified
                        : EntityState.Added;
                }
                await db.SaveChangesAsync();
            }
        }

        private static Code[] GetCodes()
        {
            var codes = new Code[]
            {
                new Code { Display = "Unknown", Value = "" },
                new Code { Display = "Alabama", Value = "AL" },
                new Code { Display = "Alaska", Value = "AK" },
                new Code { Display = "Arizona", Value = "AZ" },
                new Code { Display = "Arkansas", Value = "AR" },
                new Code { Display = "California", Value = "CA" },
                new Code { Display = "Colorado", Value = "CO" },
                new Code { Display = "Connecticut", Value = "CT" },
                new Code { Display = "Delaware", Value = "DE" },
                new Code { Display = "Florida", Value = "FL" },
                new Code { Display = "Georgia", Value = "GA" },
                new Code { Display = "Hawaii", Value = "HI" },
                new Code { Display = "Idaho", Value = "ID" },
                new Code { Display = "Illinois", Value = "IL" },
                new Code { Display = "Indiana", Value = "IN" },
                new Code { Display = "Iowa", Value = "IA" },
                new Code { Display = "Kansas", Value = "KS" },
                new Code { Display = "Kentucky", Value = "KY" },
                new Code { Display = "Louisiana", Value = "LA" },
                new Code { Display = "Maine", Value = "ME" },
                new Code { Display = "Maryland", Value = "MD" },
                new Code { Display = "Massachusetts", Value = "MA" },
                new Code { Display = "Michigan", Value = "MI" },
                new Code { Display = "Minnesota", Value = "MN" },
                new Code { Display = "Mississippi", Value = "MS" },
                new Code { Display = "Missouri", Value = "MO" },
                new Code { Display = "Montana", Value = "MT" },
                new Code { Display = "Nebraska", Value = "NE" },
                new Code { Display = "Nevada", Value = "NV" },
                new Code { Display = "New Hampshire", Value = "NH" },
                new Code { Display = "New Jersey", Value = "NJ" },
                new Code { Display = "New Mexico", Value = "NM" },
                new Code { Display = "New York", Value = "NY" },
                new Code { Display = "North Carolina", Value = "NC" },
                new Code { Display = "North Dakota", Value = "ND" },
                new Code { Display = "Ohio", Value = "OH" },
                new Code { Display = "Oklahoma", Value = "OK" },
                new Code { Display = "Oregon", Value = "OR" },
                new Code { Display = "Pennsylvania", Value = "PA" },
                new Code { Display = "Rhode Island", Value = "RI" },
                new Code { Display = "South Carolina", Value = "SC" },
                new Code { Display = "South Dakota", Value = "SD" },
                new Code { Display = "Tennessee", Value = "TN" },
                new Code { Display = "Texas", Value = "TX" },
                new Code { Display = "Utah", Value = "UT" },
                new Code { Display = "Vermont", Value = "VT" },
                new Code { Display = "Virginia", Value = "VA" },
                new Code { Display = "Washington", Value = "WA" },
                new Code { Display = "West Virginia", Value = "WV" },
                new Code { Display = "Wisconsin", Value = "WI" },
                new Code { Display = "Wyoming", Value = "WY" },
                new Code { Display = "American Samoa", Value = "AS" },
                new Code { Display = "District of Columbia", Value = "DC" },
                new Code { Display = "Federated States of Micronesia", Value = "FM" },
                new Code { Display = "Guam", Value = "GU" },
                new Code { Display = "Marshall Islands", Value = "MH" },
                new Code { Display = "Northern Mariana Islands", Value = "MP" },
                new Code { Display = "Palau", Value = "PW" },
                new Code { Display = "Puerto Rico", Value = "PR" },
                new Code { Display = "Virgin Islands", Value = "VI" },
                new Code { Display = "Armed Forces Africa", Value = "AE" },
                new Code { Display = "Armed Forces Americas", Value = "AA" },
                new Code { Display = "Armed Forces Canada", Value = "AE" },
                new Code { Display = "Armed Forces Europe", Value = "AE" },
                new Code { Display = "Armed Forces Middle East", Value = "AE" },
                new Code { Display = "Armed Forces Value = Pacific", Value = "AP" }
            };
            
            return codes;
        }

        private static Product[] GetProducts()
        {
            var products = new Product[] 
            { 
                new Product { Name = "Tomato Soup", Category = "Groceries", Price = 1.09M },
                new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M },
                new Product { Name = "Wrench", Category = "Hardware", Price = 24.99M },
                new Product { Name = "Eggs", Category = "Groceries", Price = 2.50M }
            };

            return products;
        }
    }
}