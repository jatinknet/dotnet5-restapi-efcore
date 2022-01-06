using BookStore.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BookStore.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //using(var serviceScope=  applicationBuilder.ApplicationServices.CreateScope())
            //{
            //    var context= serviceScope.ServiceProvider.GetService<AppDBContext>();

            //    context.Books.AddRange(new Book()
            //    {
            //        Name = "Rich Dad Poor Dad",
            //        Description = "What the Rich Teach Their Kids About Money That the Poor and Middle Class Do Not! ",
            //        IsRead = true,
            //        DateRead = DateTime.Now.AddDays(-10),
            //        Genre ="Family & Relationships",
            //        Author = "Robert T. Kiyosaki",
            //        Rate =300,
            //        CoverUrl ="Https....",
            //        DateAdded=DateTime.Now.AddDays(-20)

            //    },
            //    new Book()
            //    {
            //        Name = "The Psychology of Money",
            //        Description = "Timeless lessons on wealth, greed, and happiness doing well with money isn?t necessarily about what you know. It?s about how you behave",
            //        IsRead = false,
                    
            //        Genre = "Analysis & Strategy",
            //        Author = "Morgn Housel",
            //        Rate = 340,
            //        CoverUrl = "Https....",
            //        DateAdded = DateTime.Now.AddDays(-10)

            //    });

            //    context.SaveChanges();
            //}
        }
    }
}
