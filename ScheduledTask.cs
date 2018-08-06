using System;
using System.Collections.Generic;
namespace AlFinCodigo
{

    public class ScheduledTask : Task
    {

        public ScheduledTask(string title, DateTime date) : base(title)
        {
            if (date.Year != DateTime.Today.Year)
            {
                throw new ArgumentException("The year must be the current year");
            }
            this.CreationDate = date;

        }
        
        public ScheduledTask(string title, string description, DateTime date) : base(title,description)
        {
            if (date.Year != DateTime.Today.Year)
            {
                throw new ArgumentException("The year must be the current year");
            }
            this.CreationDate = date;

        }
        public ScheduledTask(string title, string description, DateTime date, List<TagsTasks> tagsList) : base(title,tagsList,description)
        {
            if (date.Year != DateTime.Today.Year)
            {
                throw new ArgumentException("The year must be the current year");
            }
            this.CreationDate = date;

        }
        
        public DateTime CreationDate { get; private set; }

        public ScheduledTask(string title) : base(title)
        {
            this.CreationDate = DateTime.Today;
        }

        public override string ToString()
        {
            return base.ToString() + ", Date: " + CreationDate.ToShortDateString();
        }
    }

}