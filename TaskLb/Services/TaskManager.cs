using TaskLb.Models;
using System.Collections.Generic;

namespace TaskLb.Services
{
    public class TaskManager
    {
        private List<TaskModel> tasks = new List<TaskModel>();

        // Добавляет новую задачу
        public void AddTask(TaskModel task)
        {
            tasks.Add(task);
        }

        // Удаляет задачу по её идентификатору
        public bool RemoveTask(Guid taskId)
        {
            var task = tasks.Find(t => t.Id == taskId);
            if (task != null)
            {
                tasks.Remove(task);
                return true;
            }
            return false;
        }
    }
}