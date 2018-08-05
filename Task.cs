namespace AlFinCodigo
{
    public class Task
    {
        private string description;
        public Task(string title, string description = "Without Description")
        {
            this.Title = title;
            this.Description = description;
        }
        public string Title
        {
            get;
            private set;
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            private set
            {
                /* con un hermoso ternario
                this.description = value.Length > 20 ? Truncate(value) : value;
                 */
                if (value.Length > 20)
                {
                    this.description = Truncate(value);
                }
                else
                {
                    this.description = value;
                }
            }
        }
        public override string ToString()
        {
            return "Title: " + Title + ", Description: " + Description;
        }

        private string Truncate(string description)
        {
            return description.Substring(0, 20);
        }
    }
}