using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLabs.Repository
{
    public class LocalStateRepository
    {
        private UserModel? user;
        private List<string> categories = new List<string>();
        private List<TaskModel> tasks = new List<TaskModel>();

        public static LocalStateRepository Instance { get; private set; } = new LocalStateRepository();
    
        public static LocalStateRepository GetInstance() { return Instance; }

        public bool IsAuthorized()
        {
            return GetCurrentUser() != null;
        }

        public void SetUser(UserModel user)
        {
            this.user = user;
        }

        public UserModel? GetCurrentUser()
        {
            return this.user;
        }

        public List<string> GetCategories()
        {
            return categories;
        }

        public void AddCategory(string category)
        {
            categories.Add(category);
        }

        public void RemoveCategory(string category)
        {
            categories.Remove(category);
        }

        public List<TaskModel> GetTasks()
        {
            return tasks;
        }

        public void AddTask(TaskModel task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(TaskModel task)
        {
            tasks.Remove(task);
        }
    }
}
