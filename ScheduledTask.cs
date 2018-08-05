using System;
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

        public ScheduledTask(string title) : base(title)
        {

            this.CreationDate = DateTime.Today;
        }
        public DateTime CreationDate { get; private set; }

        public override string ToString()
        {
            return base.ToString() + ", " + CreationDate.ToShortDateString();
        }
    }

}