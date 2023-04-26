using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ToDo Console App!");
            IToDoManager manager = new ToDoManager(); // zmienione na ToDoManager

            while (true)
            {
                Console.WriteLine("\nSelect operation: (1) Add task, (2) Display tasks, (3) Remove task, (4) Edit task, (5) Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddTask();
                        break;
                    case 2:
                        manager.DisplayTasks();
                        break;
                    case 3:
                        manager.RemoveTask();
                        break;
                    case 4:
                        manager.EditTask();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
