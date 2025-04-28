using System.Threading.Tasks;


namespace TaskLb.Models
{
    public class TaskModel
    {
        public Guid Id { get; set; } // Уникальный идентификатор задачи
        public string Title { get; set; } // Название задачи
        public string Description { get; set; } // Описание задачи
       

        public DateTime Deadline { get; set; }

        public TaskModel(string title, string description)
        {
            Id = Guid.NewGuid(); // Генерируем уникальный идентификатор
            Title = title;
            Description = description;
           
        }
    }

}