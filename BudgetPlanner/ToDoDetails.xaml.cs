using System;
using System.Windows;
using System.Windows.Controls;
using BudgetPlannerApp.Consts;
using BudgetPlannerApp.Model;
using BudgetPlannerApp.Repository;
using BudgetPlannerApp.Repository.Interface;

namespace BudgetPlannerApp
{
    public partial class ToDoDetails
    {
        private readonly IExpenseCategoryRepository _categoriesRepository = new ExpenseCategoryRepository();
        private readonly IItemRepository _itemRepository = new ItemRepository();
        private readonly int _id;

        public ToDoDetails(int id, string text)
        {
            InitializeComponent();
            _id = id;
            TodoName.Content = text;
            LoadToDoItems();
            DatePicker.Text = DateTime.Now.ToShortDateString();
        }

        public void LoadToDoItems()
        {
            var result = _itemRepository.GetItems(_id);
            expensesItemsListView.ItemsSource = result;
        }

        private void NavigateToMainPage()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void ListRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(Messages.ListRemove, "Remove List",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes) return;
            _categoriesRepository.RemoveExpenseCategory(_id);
            NavigateToMainPage();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToMainPage();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            var newListItem = new NewListItem(_id);
            if (newListItem.ShowDialog() != true) return;
            LoadToDoItems();
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = expensesItemsListView.SelectedItem;
            if (selectedItem != null)
            {
                var selectedToDoItem = (Item)selectedItem;
                var result = _itemRepository.DeleteItem(selectedToDoItem);
                if (result)
                {
                    MessageBox.Show(Messages.ItemRemoved, "Success",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    LoadToDoItems();
                }
                else
                {
                    MessageBox.Show(Messages.SomethingWrong, "Fail",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(Messages.ChooseItem, "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var date = DateTime.Parse(DatePicker.Text);
            var result = _itemRepository.FilterItems(SearchText.Text, Status.Text, date);
            expensesItemsListView.ItemsSource = result;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            SearchText.Text = "";
            Status.SelectedIndex = 0;
            LoadToDoItems();
        }
    }
}