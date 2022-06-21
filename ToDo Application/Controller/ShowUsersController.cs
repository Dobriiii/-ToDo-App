using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Application.Controller
{
    public class ShowUsersController
    {
        public List<UserTable> GetAllUsers()
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                return ex.UserTables.ToList();
            }
        }
        
        public void CreateUser(UserTable u)
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                var lastUser = ex.UserTables.ToList().LastOrDefault();
                if (lastUser == null)
                {
                    lastUser = new UserTable();
                    lastUser.Id = 0;
                }

                u.Id = lastUser.Id + 1;
                ex.UserTables.Add(u);
                ex.SaveChanges();
            }
        }
        public void UpdateUser(int id, UserTable u)
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                var UserToUpdate = ex.UserTables.Where(p => p.Id == id).FirstOrDefault();
                if (UserToUpdate != null)
                {
                    UserToUpdate.Id = u.Id;
                    UserToUpdate.Username = u.Username;
                    UserToUpdate.Password = u.Password;
                    UserToUpdate.Firstname = u.Firstname;
                    UserToUpdate.Lastname = u.Lastname;
                    ex.SaveChanges();
                }
            }
        }
        public void DeleteUser(int id)
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                var UserToDelete = ex.UserTables.Where(p => p.Id == id).FirstOrDefault();
                if (UserToDelete != null)
                {
                    ex.UserTables.Remove(UserToDelete);
                    ex.SaveChanges();
                }
            }
        }
    }
}
