using System.Collections.Generic;
using System;
namespace AlFinCodigo
{
    public class TaskList
    {
        private List<AbstractTask> toDoList;
        public TaskList()
        {
            this.toDoList = new List<AbstractTask>();
        }

        public List<AbstractTask> ToDoList
        {
            get
            {
                return this.toDoList;
            }
            set
            {
                this.toDoList = value;
            }
        }
        public void AddNewTask(AbstractTask newTask)
        {
            ToDoList.Add(newTask);
        }

        public AbstractTask GetTaskByIndex(int index)
        {
            ArgumentException(index);
            return ToDoList[index];
        }
        public void RemoveTaskByIndex(int index)
        {
            ArgumentException(index);
            ToDoList.RemoveAt(index);
        }
        public bool ExistTheIndexInTheList(int index)
        {
            if (index < 0 || index > ToDoList.Count)
            {
                return false;
            }
            return true;
        }
        public void PrintAllTasks()
        {
            ToDoList.ForEach(Console.WriteLine);
        }

        private void ArgumentException(int index)
        {
            if (!ExistTheIndexInTheList(index))
            {
                throw new System.ArgumentException("Index out of bounds");
            }
        }

        public void RemoveTaskByTag(TagsTasks tag)
        {
            foreach (var task in toDoList)
            {
                if (task.DoesTheTaskHaveTheTag(tag))
                {
                    RemoveTaskByIndex(toDoList.IndexOf(task));
                }
            }
        }
    }
}