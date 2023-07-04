using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;
            var activities = new List<Activity>
            {
                new Activity{
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                },
                 new Activity{
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "Eat",
                    City = "Belgium",
                    Venue = "Club"
                }, 
                new Activity{
                    Title = "Future Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                },
                 new Activity{
                    Title = "Future Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "chess",
                    City = "New york",
                    Venue = "Chess club"
                }, 
                new Activity{
                    Title = "Future Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                }, 
                new Activity{
                    Title = "Future Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                }, 
                new Activity{
                    Title = "Future Activity 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 7 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                }, 
                new Activity{
                    Title = "Future Activity 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "Bangalore",
                    Venue = "Cinema "
                },
            };


        await context.Activities.AddRangeAsync(activities);
        await context.SaveChangesAsync();

        }
    }
}