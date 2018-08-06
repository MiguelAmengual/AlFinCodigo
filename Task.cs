using System;
using System.Collections.Generic;
namespace AlFinCodigo
{
    public class Task : AbstractTask
    {
        private string description;
        public Task(string title, string description = "Without Description") : base(title)
        {
            this.Description = description;
        }

        public Task(string title,  List<TagsTasks> tagsList, string description = "Without Description") : base(title, tagsList)
        {
            this.Description = description;
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
            return base.ToString() + ", Description: " + Description;
        }

        private string Truncate(string description)
        {
            return description.Substring(0, 20);
        }
    }
}