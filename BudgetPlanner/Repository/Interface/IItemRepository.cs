using System;
using System.Collections.Generic;
using BudgetPlannerApp.Model;

namespace BudgetPlannerApp.Repository.Interface
{
    internal interface IItemRepository
    {
        bool AddNewItem(Item todoItem);

        List<Item> GetItems(int todoId);

        bool DeleteItem(Item item);

        bool UpdateItemPrice(int itemId, decimal newPrice);

        List<Item> FilterItems(string searchText, string selectedItem, DateTime date);
    }
}