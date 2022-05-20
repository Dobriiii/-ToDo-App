using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Application.Model;

namespace ToDo_Application.Controller
{
    public class ShowTasksController
    {
        public List<TaskTable> GetTaskTables()
        {
            using(ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                return ex.TaskTables.ToList();
            }
        }
        public void CreateTask(TaskTable t)
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                var lastTask = ex.TaskTables.ToList().LastOrDefault();
                if (lastTask == null)
                {
                    lastTask = new TaskTable();
                    lastTask.Id = 0;

                }

                t.Id = lastTask.Id + 1;
                ex.TaskTables.Add(t);
                ex.SaveChanges();
            }
        }
        public void UpdateTask(int id , TaskTable t)
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                var TaskToUpdate = ex.TaskTables.Where(p => p.Id == id).FirstOrDefault();
                if (TaskToUpdate != null)
                {
                    TaskToUpdate.Id = t.Id;
                    TaskToUpdate.Tasks = t.Tasks;
                    TaskToUpdate.Date = t.Date;
                    ex.SaveChanges();

                }
            }
        }
        public void DeleteStudent(int id)
        {
            using (ToDoAppDbEntities ex = new ToDoAppDbEntities())
            {
                var TaskToDelete = ex.TaskTables.Where(p => p.Id == id).FirstOrDefault();
                if (TaskToDelete != null)
                {
                    ex.TaskTables.Remove(TaskToDelete);
                    ex.SaveChanges();
                }
            }
        }
    }
}
