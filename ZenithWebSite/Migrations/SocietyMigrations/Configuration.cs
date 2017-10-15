namespace ZenithWebSite.Migrations.SocietyMigrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\SocietyMigrations";
        }

        protected override void Seed(ZenithDataLib.Models.ApplicationDbContext context)
        {
            context.ActivityCategories.AddOrUpdate(a => new { a.ActivityCategoryId, a.ActivityDescription, a.CreationDate },
                GetActivityCategories().ToArray()
                );
            context.SaveChanges();

            context.Events.AddOrUpdate(e => new { e.EventId, e.DateFrom, e.DateTo, e.EnteredBy, e.ActivityCategoryId, e.CreationDate, e.IsActive },
                GetEvents(context).ToArray()
                );
            context.SaveChanges();

        }

        private List<ActivityCategory> GetActivityCategories()
        {
            List<ActivityCategory> activitycategories = new List<ActivityCategory>()
            {
                new ActivityCategory()
                {
                    ActivityDescription = "Senior's Golf Tournament",
                    CreationDate = new DateTime(2017, 1, 1, 9, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Leadership General Assembly Meeting",
                    CreationDate = new DateTime(2017, 1, 2, 10, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Youth Bowling Tournament",
                    CreationDate = new DateTime(2017, 1, 3, 11, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Young ladies cooking lessons",
                    CreationDate = new DateTime(2017, 1, 4, 12, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Youth craft lessons",
                    CreationDate = new DateTime(2017, 2, 1, 9, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Youth choir practice",
                    CreationDate = new DateTime(2017, 2, 2, 10, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Lunch",
                    CreationDate = new DateTime(2017, 2, 3, 11, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Pancake Breakfast",
                    CreationDate = new DateTime(2017, 2, 4, 12, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Swimming Lessons for the youth",
                    CreationDate = new DateTime(2017, 3, 1, 9, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Swimming Exercise for parents",
                    CreationDate = new DateTime(2017, 3, 2, 10, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Bingo Tournament",
                    CreationDate = new DateTime(2017, 3, 3, 11, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "BBQ Lunch",
                    CreationDate = new DateTime(2017, 3, 4, 12, 00, 0)
                },
                new ActivityCategory()
                {
                    ActivityDescription = "Garage Sale",
                    CreationDate = new DateTime(2017, 4, 1, 9, 00, 0)
                }
            };

            return activitycategories;
        }

        private List<Event> GetEvents(ApplicationDbContext context)
        {
            List<Event> events = new List<Event>()
            {
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 17, 8, 30, 0),
                    DateTo = new DateTime(2017, 10, 17, 10, 30, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Senior's Golf Tournament"),
                    CreationDate = new DateTime(2017, 10, 17, 8, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 18, 8, 30, 0),
                    DateTo = new DateTime(2017, 10, 18, 10, 30, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Leadership General Assembly Meeting"),
                    CreationDate = new DateTime(2017, 10, 18, 8, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 20, 17, 30, 0),
                    DateTo = new DateTime(2017, 10, 20, 19, 15, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Youth Bowling Tournament"),
                    CreationDate = new DateTime(2017, 10, 20, 17, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 20, 19, 00, 0),
                    DateTo = new DateTime(2017, 10, 20, 20, 00, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Young ladies cooking lessons"),
                    CreationDate = new DateTime(2017, 10, 20, 19, 00, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 21, 8, 30, 0),
                    DateTo = new DateTime(2017, 10, 21, 10, 30, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Youth craft lessons"),
                    CreationDate = new DateTime(2017, 10, 21, 8, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 21, 10, 30, 0),
                    DateTo = new DateTime(2017, 10, 21, 12, 00, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Youth choir practice"),
                    CreationDate = new DateTime(2017, 10, 21, 10, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 21, 12, 00, 0),
                    DateTo = new DateTime(2017, 10, 21, 13, 30, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Lunch"),
                    CreationDate = new DateTime(2017, 10, 21, 12, 00, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 22, 7, 30, 0),
                    DateTo = new DateTime(2017, 10, 22, 8, 30, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Pancake Breakfast"),
                    CreationDate = new DateTime(2017, 10, 22, 7, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 22, 8, 30, 0),
                    DateTo = new DateTime(2017, 10, 22, 10, 30, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Swimming Lessons for the youth"),
                    CreationDate = new DateTime(2017, 10, 22, 8, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 22, 8, 30, 0),
                    DateTo = new DateTime(2017, 10, 22, 10, 30, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Swimming Exercise for parents"),
                    CreationDate = new DateTime(2017, 10, 22, 8, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 22, 10, 30, 0),
                    DateTo = new DateTime(2017, 10, 22, 12, 00, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Bingo Tournament"),
                    CreationDate = new DateTime(2017, 10, 22, 10, 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 22, 12, 00, 0),
                    DateTo = new DateTime(2017, 10, 22, 13, 00, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "BBQ Lunch"),
                    CreationDate = new DateTime(2017, 10, 22, , 30, 0),
                    IsActive = true
                },
                new Event()
                {
                    DateFrom = new DateTime(2017, 10, 22, 13, 00, 0),
                    DateTo = new DateTime(2017, 10, 22, 18, 00, 0),
                    EnteredBy = "Eric Lin",
                    ActivityCategory = context.ActivityCategories.FirstOrDefault(a => a.ActivityDescription == "Garage Sale"),
                    CreationDate = new DateTime(2017, 10, 22, 13, 00, 0),
                    IsActive = true
                }
            };

            return events;
        }
    }
}
