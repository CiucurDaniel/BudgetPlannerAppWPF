using System.Collections.Generic;
using BudgetPlannerApp.Model;

namespace BudgetPlannerApp.Repository.Interface
{
    internal interface IExpenseCategoryRepository
    {
        bool AddExpenseCategory(string categoryName, decimal budget);

        List<ExpenseCategory> GetExpenseCategoriesList();

        bool RemoveExpenseCategory(int id);
    }
}