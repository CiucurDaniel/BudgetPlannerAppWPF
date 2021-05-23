using System.Data.Entity;

namespace BudgetPlannerApp.Model
{
    internal class BudgetPlannerAppContext : DbContext
    {
        public BudgetPlannerAppContext() : base("BudgetPlannerAppContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BudgetPlannerAppContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}