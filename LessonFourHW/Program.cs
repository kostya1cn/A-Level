namespace LessonFourHW
{
    class Program
    {
        class TaskInfo
        {
            public bool IsCompleted { get; set; }
            public DateTime? CompletionDate { get; set; }
        }

        static Dictionary<string, TaskInfo> tasks = new Dictionary<string, TaskInfo>();


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Available commands: add-item, remove-item, mark-as, show, show-all, exit");
                Console.Write("Enter a command: ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add-item":
                        AddItem();
                        break;

                    case "remove-item":
                        RemoveItem();
                        break;

                    case "mark-as":
                        MarkAs();
                        break;

                    case "show":
                        Show();
                        break;

                    case "show-all":
                        ShowAll();
                        break;

                    case "exit":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid command. Please enter a valid command.");
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();

            if (!tasks.ContainsKey(task.ToLower()))
            {
                TaskInfo taskInfo = new TaskInfo
                {
                    IsCompleted = false,
                    CompletionDate = null
                };
                tasks.Add(task.ToLower(), taskInfo);
                Console.WriteLine("Task added.");
            }
            else
            {
                Console.WriteLine("Task already exists.");
            }
        }

        static void RemoveItem()
        {
            Console.WriteLine("Type * to delete all tasks, or the task name to delete only the task.");
            Console.Write("Enter task: ");
            string task = Console.ReadLine();

            if (task == "*")
            {
                tasks.Clear();
                Console.WriteLine("All tasks removed.");
                return;
            }

            if (tasks.ContainsKey(task.ToLower()))
            {
                tasks.Remove(task.ToLower());
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        static void MarkAs()
        {
            Console.Write("Enter status (1 - completed, 0 - not completed): ");
            if (!int.TryParse(Console.ReadLine(), out int status) || (status != 0 && status != 1))
            {
                Console.WriteLine("Invalid status. Please enter 0 or 1.");
                return;
            }

            Console.Write("Enter task: ");
            string task = Console.ReadLine();

            if (tasks.ContainsKey(task.ToLower()))
            {
                TaskInfo taskInfo = tasks[task.ToLower()];

                taskInfo.IsCompleted = status == 1;

                if (status == 1 && taskInfo.IsCompleted)
                {
                    Console.Write("Enter date (optional, leave blank for current date): ");
                    string dateInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(dateInput))
                    {
                        taskInfo.CompletionDate = DateTime.Now;
                        DateTime completionDate = DateTime.Now;
                        taskInfo.IsCompleted = true;
                        Console.WriteLine($"Task marked as completed on {completionDate.ToString("dd-MM-yyyy")}");
                    }
                    else if (DateTime.TryParse(dateInput, out DateTime customCompletionDate))
                    {
                        taskInfo.CompletionDate = customCompletionDate;
                        Console.WriteLine("Task marked as completed on " + customCompletionDate.ToString("dd-MM-yyyy"));
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Task not marked as completed.");
                    }
                }
                else
                {
                    taskInfo.IsCompleted = false;
                    Console.WriteLine("Task marked as not completed.");
                }
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        static void Show()
        {
            Console.Write("Enter status (1 - completed, 0 - not completed): ");
            if (!int.TryParse(Console.ReadLine(), out int status) || (status != 0 && status != 1))
            {
                Console.WriteLine("Invalid status. Please enter 0 or 1.");
                return;
            }

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            bool completedTasksFound = false;
            bool notCompletedTasksFound = false;

            foreach (var task in tasks)
            {
                if (task.Value.IsCompleted)
                {
                    completedTasksFound = true;
                }
                else
                {
                    notCompletedTasksFound = true;
                }
                if ((status == 1 && task.Value.IsCompleted) || (status == 0 && !task.Value.IsCompleted))
                {
                    if (task.Value.IsCompleted)
                    {
                        string completionDateInfo = task.Value.CompletionDate.HasValue ?
                                                    $", Completion Date: {task.Value.CompletionDate.Value.ToString("dd-MM-yyyy")}" :
                                                    "";
                        Console.WriteLine($"Task: {task.Key}, Completed: {task.Value.IsCompleted}{completionDateInfo}");
                    }
                    else
                    {
                        Console.WriteLine($"Task: {task.Key}, Completed: {task.Value.IsCompleted}");
                    }
                }
            }

            if (status == 1 && !completedTasksFound)
            {
                Console.WriteLine("No completed tasks found.");
            }
            if (status == 0 && !notCompletedTasksFound)
            {
                Console.WriteLine("No not completed tasks found.");
            }
        }

        static void ShowAll()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            foreach (var task in tasks)
            {
                string completionDateInfo = task.Value.CompletionDate.HasValue ?
                                            $", Completion Date: {task.Value.CompletionDate.Value.ToString("dd-MM-yyyy")}" :
                                            "";
                Console.WriteLine($"Task: {task.Key}, Completed: {task.Value.IsCompleted}{completionDateInfo}");
            }
        }
    }
}
