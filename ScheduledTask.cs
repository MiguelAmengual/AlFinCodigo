using System;
namespace AlFinCodigo
{
    public class ScheduledTask : Task
    {

        public ScheduledTask(Task task, DateTime date) : base(task.Title, task.Description)
        {
            this.CreationDate = date;
        }

        public ScheduledTask(Task task) : base(task.Title, task.Description)
        {

            this.CreationDate = DateTime.Today;
        }
        public DateTime CreationDate { get; private set; }

        public override string ToString()
        {
            return "Title: " + Title + ", Description: " + Description + ", " + CreationDate.ToShortDateString();
        }
    }
}