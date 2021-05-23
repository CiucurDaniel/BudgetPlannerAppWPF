using System;
using System.Windows;
using BudgetPlannerApp.Consts;
using BudgetPlannerApp.Model;
using BudgetPlannerApp.Repository;
using BudgetPlannerApp.Repository.Interface;

namespace BudgetPlannerApp
{
    public partial class NewListItem
    {
        private readonly IItemRepository _itemRepository = new ItemRepository();
        private readonly int _itemId;

        public NewListItem(int itemId)
        {
            InitializeComponent();
            _itemId = itemId;
            BuyDate.Text = DateTime.Now.ToShortDateString();
        }

        private void ButtonAddItem_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Description.Text) || string.IsNullOrEmpty(Name.Text) ||
                string.IsNullOrEmpty(BuyDate.Text))
            {
                MessageBox.Show(Messages.MissingInfo, "Fail",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var result = _itemRepository.AddNewItem(new Item
            {
                BuyDate = DateTime.Parse(BuyDate.Text),
                Description = Description.Text,
                Name = Name.Text,
                Price = Decimal.Parse(Price.Text),
                ToDoListId = _itemId
            });
            if (result)
            {
                DialogResult = true;
                MessageBox.Show(Messages.NewListItemAdded, "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show(Messages.SomethingWrong, "Fail",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                DialogResult = false;
            }
        }
    }
}