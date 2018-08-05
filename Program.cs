using System;

namespace AlFinCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            TruncateTest();
        }

        public static void Test1()
        {
            TaskList tl1 = new TaskList();
            tl1.AddNewTask(new Task("Task1 ", " prueba1"));
            tl1.AddNewTask(new Task("Task2 ", " prueba2"));
            tl1.AddNewTask(new Task("Task3 ", " prueba3"));
            tl1.AddNewTask(new Task("Task4 ", " prueba4"));
            tl1.AddNewTask(new Task("Task5 ", " prueba5"));
            tl1.PrintAllTasks();
            Console.WriteLine("-----------------------------------------------");
            try
            {
                tl1.RemoveTaskByIndex(6);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            tl1.PrintAllTasks();
        }

        public static void TruncateTest()
        {
            Task t1 = new Task("T1", "abcdefghijklmnopqrstuvwxyz");
            Console.WriteLine(t1.ToString());
        }

        public static void OptionalTaskDescription()
        {
            Task t1 = new Task("T1");
            Console.WriteLine(t1.ToString());
        }
    }
}
