using System.Linq;
using BudgetPlannerApp.Model;
using BudgetPlannerApp.Repository.Interface;

namespace BudgetPlannerApp.Repository
{
    public class UserRepository : IUserRepository
    {
        public User CheckLogin(string username, string password)
        {
            using (var db = new BudgetPlannerAppContext())
            {
                var result = db.Users.FirstOrDefault(p => p.UserName == username && p.Password == password);
                return result;
            }
        }

        public bool RegisterUser(string username, string password)
        {
            using (var db = new BudgetPlannerAppContext())
            {
                var user = new User
                {
                    UserName = username,
                    Password = password
                };
                db.Users.Add(user);
                var result = db.SaveChanges();
                return result > 0;
            }
        }
    }
}