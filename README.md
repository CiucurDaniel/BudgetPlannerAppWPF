[![Made with](https://img.shields.io/badge/Made%20with-.NET%20Core%205.0-blue)](https://dotnet.microsoft.com/download/dotnet/5.0)

[![Framework UI](https://img.shields.io/badge/Framework%20UI-WPF-yellow)](https://dotnet.microsoft.com/download/dotnet/3.1)


[![Actions Status: build](https://github.com/CiucurDaniel/BudgetPlannerWPF/actions/workflows/continuos_integration.yml/badge.svg)](https://github.com/CiucurDaniel/BudgetPlannerWPF/actions?query=workflow%3A%22.NET%20CI%20worlflow%22)

# BudgetPlanner
WPF Windows application used to plan your monthly budget.

# Development team:

* Opra Andrei
* Ciucur Daniel

# Functionality

* Set monthly budgets for different types of categories (bills, groceries, economies, ...)
* Add you expenses
* View all your expenses
* Print expenses on PDF or TXT (optionally)
* Currency convertor

To get a beter understanding, have a look the following schemas:

![GraphDATABASE](BudgetPlanner/Documentation/Images/graph_schema.png?raw=true "Graph Database")

![UML DATABASE](BudgetPlanner/Documentation/Images/UML.JPG?raw=true "UML Database")


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
![RegisterScreen](BudgetPlanner/Documentation/UserManual/expenses_list_window.PNG)


## Expenses list screen

Here you can (after you click an expense category) you can see all expenses (belonging to the previously clicked category) that you made so far. You can perform different operations like sorting, adding, deleting.
![RegisterScreen](BudgetPlanner/Documentation/UserManual/expenses_list_window.PNG)


## Add new screen

From here you can add a new item that you bought, which belongs to the categoty that you are currently in. 
![RegisterScreen](BudgetPlanner/Documentation/UserManual/expenses_list_window.PNG)



## Budget status window

Here you can see a pie chart representing the status of your spendings. 
Note: The NuGet package with the chart has some bugs, sometimes puts a color more than once in a chart.
![RegisterScreen](BudgetPlanner/Documentation/UserManual/budget_status_window2.PNG)

