namespace AlFinCodigo
{
    public abstract class AbstractTask
    {
        private string title;
        protected AbstractTask(string title)
        {
            this.Title = title;
        }
        protected string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public override string ToString()
        {
            return "Title: " + Title;
        }
    }
}