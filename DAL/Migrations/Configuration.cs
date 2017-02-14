namespace DAL.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(DAL.ApplicationContext context)
        {
            
            context.Students.AddOrUpdate(s => s.Id, new Student { FirstName = "Bharat", LastName = "Sontam" }, new Student { FirstName = "John", LastName = "Eric" });

            context.Instructors.AddOrUpdate(i => i.Id, new Instructor { FirstName = "Omar", LastName="Iqbal" }, new Instructor { FirstName = "Challoo", LastName="Rajab" });
            context.Departments.AddOrUpdate(d => d.Moniker, new Department { Name="Computer Science", Moniker = "CS" }, new Department { Name="Mechanical", Moniker="MECH" });
        }
    }
}
