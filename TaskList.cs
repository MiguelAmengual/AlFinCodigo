using System.Collections.Generic;
using System;
namespace AlFinCodigo
{
    public class TaskList
    {
        private List<Task> taskList;
        public TaskList()
        {
            this.taskList = new List<Task>();
        }

        public void AddNewTask(Task newTask)
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