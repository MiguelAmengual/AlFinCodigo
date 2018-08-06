using System.Collections.Generic;
using System;

namespace AlFinCodigo
{
    public abstract class AbstractTask
    {
        private string title;
        private List<TagsTasks> tagsList;

        protected AbstractTask(string title)
        {
            this.Title = title;
            tagsList = new List<TagsTasks>();
        }

        protected AbstractTask(string title, List<TagsTasks> tagsList)
        {
            this.Title = title;
            this.tagsList = tagsList;
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
        public List<TagsTasks> TagsList
        {
            get
            {
                return this.tagsList;
            }
            set
            {
                this.tagsList = value;
            }
        }
        public void AddNewTag(TagsTasks newTag)
        {
            if (!DoesTheListHaveTheTag(newTag))
            {
                TagsList.Add(newTag);
            }
        }
        public void PrintTags()
        {
            foreach(TagsTasks tt in TagsList){

                Console.WriteLine(tt);
            }

        }
        private bool DoesTheListHaveTheTag(TagsTasks tag)
        {
            return TagsList.Contains(tag);
        }

        public override string ToString()
        {
            return "Title: " + Title;
        }
    }
}