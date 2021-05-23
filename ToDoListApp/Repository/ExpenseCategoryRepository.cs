using System.Collections.Generic;
using System.Linq;
using BudgetPlannerApp.Consts;
using BudgetPlannerApp.Model;
using BudgetPlannerApp.Repository.Interface;

namespace BudgetPlannerApp.Repository
{
    public class ExpenseCategoryRepository : IExpenseCategoryRepository
    {
        public bool AddExpenseCategory(string categoryName, decimal budget)
        {
            using (var db = new BudgetPlannerAppContext())
            {
                var newCategory = new ExpenseCategory
                {
                    Name = categoryName,
                    MonthlyBudget = budget,
                    UserId = SessionInfo.UserId
                };
                db.ExpenseCategories.Add(newCategory);
                var result = db.SaveChanges();
                return result > 0;
            }
        }

        public List<ExpenseCategory> GetExpenseCategoriesList()
        {
            using (var db = new BudgetPlannerAppContext())
            {
                return db.ExpenseCategories.Where(p => p.UserId == SessionInfo.UserId).ToList();
            }
        }

        public bool RemoveExpenseCategory(int id)
        {
            using (var db = new BudgetPlannerAppContext())
            {
                var toDo = new ExpenseCategory { Id = id };
                db.ExpenseCategories.Attach(toDo);
                db.ExpenseCategories.Remove(toDo);
                var result = db.SaveChanges();
                return result > 0;
            }
        }
    }
}