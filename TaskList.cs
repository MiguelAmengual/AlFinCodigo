using System.Collections.Generic;
using System;
namespace AlFinCodigo
{
    public class TaskList
    {
        private List<AbstractTask> taskList;
        public TaskList()
        {
            this.taskList = new List<AbstractTask>();
        }

        public void AddNewTask(AbstractTask newTask)
        {
            this.taskList.Add(newTask);
        }

        public void RemoveTaskByIndex(int index)
        {
            if (!CanTheIndexBeRemoved(index))
            {
                throw new System.ArgumentException("Index out of bounds");
            }
            int indexCopy = index-1;
            this.taskList.RemoveAt(indexCopy);
        }
        public bool CanTheIndexBeRemoved(int index)
        {
            int indexCopy = index - 1;
            if (indexCopy < 0 || indexCopy > this.taskList.Count-1)
            {
                return false;
            }
            return true;
        }
        public void PrintAllTasks()
        {
            this.taskList.ForEach(Console.WriteLine);
        }
    }
}