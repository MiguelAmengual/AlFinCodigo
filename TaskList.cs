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

        public List<AbstractTask> ToDoList{
            get{
                return this.toDoList;
            }
            set{
                this.toDoList = value;
            }
        }
        public void AddNewTask(AbstractTask newTask)
        {
            ToDoList.Add(newTask);
        }

        public void GetTaskByIndex(int index)
        {
            if (!ExistTheIndexInTheList(index))
            {
                throw new System.ArgumentException("Index out of bounds");
            }
            int indexCopy = index-1;
            
            //ToDoList.;
        }
        public void RemoveTaskByIndex(int index)
        {
            if (!ExistTheIndexInTheList(index))
            {
                throw new System.ArgumentException("Index out of bounds");
            }
            int indexCopy = index-1;
            ToDoList.RemoveAt(indexCopy);
        }
        public bool ExistTheIndexInTheList(int index)
        {
            int indexCopy = index - 1;
            if (indexCopy < 0 || indexCopy > ToDoList.Count-1)
            {
                return false;
            }
            return true;
        }
        public void PrintAllTasks()
        {
            ToDoList.ForEach(Console.WriteLine);
        }
    }
}