using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class ToDoManager : IToDoManager
    {
        private List<ToDoTask> tasks = new List<ToDoTask>();

        public void AddTask()
        {
            Console.WriteLine("Enter the task description:");
            string description = Console.ReadLine();
            ToDoTask task = new ToDoTask(description);
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        public void DisplayTasks()
        {
            Console.WriteLine("ToDo List:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Description}");
            }
        }

        public void RemoveTask()
        {
            Console.WriteLine("Enter the task number to remove:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number!");
            }
        }

        public void EditTask()
        {
            Console.WriteLine("Enter the task number to edit:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                Console.WriteLine($"Current task: {tasks[taskNumber - 1].Description}");
                Console.WriteLine("Enter the new task description:");
                string newDescription = Console.ReadLine();
                tasks[taskNumber - 1].Description = newDescription;
                Console.WriteLine("Task edited successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number!");
            }
        }
    }
}
