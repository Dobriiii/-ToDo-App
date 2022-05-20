using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Application.Model;

namespace ToDo_Application.Controller
{
    public class LoginController
    {
        public string ShowMessage(string username, string password)
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                var existingUser = ex.UserTables.Where(u => u.Username == username).FirstOrDefault();
                if (existingUser != null)
                {
                    if (existingUser.Password == password)
                    {
                        return null;
                    }
                    else
                    {
                        return "Wrong Password";
                    }
                }
                else
                {
                    return "No such user!";
                }
            }
        }
    }
}
