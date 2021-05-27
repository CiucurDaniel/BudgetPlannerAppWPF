[![Made with](https://img.shields.io/badge/Made%20with-.NET%20Core%205.0-blue)](https://dotnet.microsoft.com/download/dotnet/5.0)

[![Framework UI](https://img.shields.io/badge/Framework%20UI-WPF-yellow)](https://dotnet.microsoft.com/download/dotnet/3.1)


# BudgetPlanner
WPF Windows application used to plan your monthly budget.

# Development team:

* Opra Andrei
* Ciucur Daniel

# Functionality

* Set monthly budgets for different types of categories (bills, groceries, economies, ...)
* Add you expenses
* View all your expenses
* Group your expenses into categories
* Currency convertor (using an API)


# User manual

Below we will take a look at the interfaces and functionalities that our app has.


## Register screen

This is the register screen, here you can register for a new account.


![RegisterScreen](BudgetPlanner/Documentation/UserManual/register_window.PNG)


## Login screen
This is the login screen, here you can login in order to access the app.


![RegisterScreen](BudgetPlanner/Documentation/UserManual/register_window.PNG)


## Home screen

This is the homescreen, here you will see a menu in the left where you can navigate to other parts of the app. In the middle you will see a list of your categories of expenses, you can of course add new ones or delete them. If you click an expense category you can log and see your expenses from that category.


![RegisterScreen](BudgetPlanner/Documentation/UserManual/homescreen_windows.PNG)

## Currency converter screen

This is the currency converter window, from here you can perform currency convertions, you will get tha rate in real time via an API.


![CurrencyConverterScreen](BudgetPlanner/Documentation/UserManual/currency_converter_window.PNG)


## Expenses list screen

Here you can (after you click an expense category) you can see all expenses (belonging to the previously clicked category) that you made so far. You can perform different operations like sorting, adding, deleting.


![ExpenseList](BudgetPlanner/Documentation/UserManual/expenses_list_window.PNG)


## Add new item screen

From here you can add a new item that you bought, which belongs to the categoty that you are currently in. 


![AddNewItemScreen](BudgetPlanner/Documentation/UserManual/add_new_item_window.PNG)



## Budget status window

Here you can see a pie chart representing the status of your spendings. 
Note: The NuGet package with the chart has some bugs, sometimes puts a color more than once in a chart.


![BudgetStatusScreen](BudgetPlanner/Documentation/UserManual/budget_status_window2.PNG)

