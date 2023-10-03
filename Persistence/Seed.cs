using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post",
                        Body = "Hello How are you doing?",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second post",
                        Body = "It is nice and sunny outside today",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Third post",
                        Body = "Rise and Shine and conquer your Goals!",
                        Date = DateTime.Now.AddDays(-10)
                    }
                };
                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}