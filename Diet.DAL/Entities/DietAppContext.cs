using Diet.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Diet.DAL.Entities
{
    public class DietAppContext : DbContext
    {
        // Your context has been configured to use a 'DietAppContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Diet.DAL.Entities.DietAppContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DietAppContext' 
        // connection string in the application configuration file.
        public DietAppContext()
            : base("name=DietAppContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Activity> Activities { get; set; }
         public virtual DbSet<Category> Categories { get; set; }
         public virtual DbSet<Food> Foods { get; set; }
         public virtual DbSet<Meal> Meals { get; set; }
         public virtual DbSet<MealFood> MealFoods { get; set; }
         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<UserActivity> UserActivities { get; set; }
         public virtual DbSet<UserBC> UserBCs { get; set; }
         public virtual DbSet<UserDetail> UserDetails { get; set; }
         public virtual DbSet<UserNotification> UserNotifications { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}