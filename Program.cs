using System;

namespace AlFinCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            SeveralTasks();
        }

        public static void PrintingTags(){
            TaskList tl1 = new TaskList();
            //tl1.ne

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

        public static void ScheduledTaskAndNormalTaskTest()
        {
            TaskList tl1 = new TaskList();
            tl1.AddNewTask(new ScheduledTask("t1", DateTime.Today));
            tl1.AddNewTask(new Task("T2", "Description 2"));
            tl1.AddNewTask(new ScheduledTask("t3"));
            tl1.AddNewTask(new ScheduledTask("t4"));
            tl1.PrintAllTasks();
        }

        public static void CurrentYearTest()
        {
            TaskList tl1 = new TaskList();
            try
            {
                tl1.AddNewTask(new ScheduledTask("t1", new DateTime(2016, 5, 2)));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            tl1.PrintAllTasks();
        }

        public static void SeveralTasks()
        {
            TaskList tl1 = new TaskList();
            tl1.AddNewTask(new Task("T1","Description 1"));
            tl1.AddNewTask(new PriorityTask("T1",999));
            tl1.AddNewTask(new ScheduledTask("T3",new DateTime(2018,2,3)));
            tl1.AddNewTask(new ScheduledTask("T4"));
            tl1.PrintAllTasks();
        }
    }
}
