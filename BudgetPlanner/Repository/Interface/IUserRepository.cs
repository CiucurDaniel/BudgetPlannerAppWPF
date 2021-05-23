using BudgetPlannerApp.Model;

namespace BudgetPlannerApp.Repository.Interface
{
    public interface IUserRepository
    {
        User CheckLogin(string username, string password);

        bool RegisterUser(string username, string password);
    }
}