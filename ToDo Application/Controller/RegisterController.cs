using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Application.Controller
{
    public class RegisterController
    {
        public void AddUser(UserTable u)
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
    }
}
