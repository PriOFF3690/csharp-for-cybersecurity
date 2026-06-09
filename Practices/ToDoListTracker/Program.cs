using System;

class Task
{
    string title,description;
    static int id=1;
    public Task(string title,string description)
    {
        this.title = title;
        this.description = description;
    }
    void PrintTask()
    {
        Console.WriteLine($"{id}\t{title}\t{description}");
    }
    void EditTask(string title="",string description="")
    {
        this.title = title==""?this.title:title;
        this.description = description==""?this.description:description;
    }
    ~Task()
    {
        Console.WriteLine("Task Deleted");
    }
}


class Program
{
    static void PrintMainScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("*************************");
        Console.WriteLine("*   To-Do List Tracker  *");
        Console.WriteLine("*************************");
        Console.WriteLine(" 1. Show To-Do List");
        Console.WriteLine(" 2. Add To-Do Task");
        Console.WriteLine(" 3. Edit To-Do Task");
        Console.WriteLine(" 4. Delete To-Do Task");
        Console.WriteLine(" 5. Exit");
        Console.WriteLine("\n Enter Option: ");
    }

    static void PrintEditTaskScreen(List<Task> tasks)
    {
        int choice;
        start:
        Console.WriteLine("\n");
        Console.WriteLine("*************************");
        Console.WriteLine("*      To-Do  List      *");
        Console.WriteLine("*************************");
        Console.WriteLine();
        using (StreamReader reader = new StreamReader("tasklist.txt"))
        {
            string task = reader.ReadToEnd();
            Console.WriteLine(task);
            if (task == "")
            {
                Console.WriteLine("List is empty");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                return;
            }
        }
        Console.Write("Enter ID: ");
        try{
            choice = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please valid ID");
            goto start;
        }
        int task_id=0;
        foreach(Task task1 in tasks)
        {
            task_id++;
        }
        if(choice>0 && choice < task_id)
        {
            Console.WriteLine($"Invalid ID Range...");
            goto start;
        }
    }

    static void PrintShowListScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("*************************");
        Console.WriteLine("*      To-Do  List      *");
        Console.WriteLine("*************************");
        Console.WriteLine();
        using (StreamReader reader = new StreamReader("tasklist.txt"))
        {
            string tasks = reader.ReadToEnd();
            Console.WriteLine(tasks);
        }
        Console.Write("\nPress any key to continue...");
        Console.ReadKey();
    }

    static Task PrintAddTaskScreen()
    {
        Console.WriteLine("\n");
        Console.WriteLine("*************************");
        Console.WriteLine("*     Add To-Do Task    *");
        Console.WriteLine("*************************");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        return new Task(title,description);        
    }
    static void Main()
    {
        List<Task> tasks = new List<Task>();
        int choice;
        MainScreen:
        PrintMainScreen();
        try
        {
            choice = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please enter valid integer...");
            goto MainScreen;
        }
        switch (choice)
        {
            case 1:
                PrintShowListScreen();
                Console.ReadKey();
                goto MainScreen;
            case 2:
                tasks.Append<Task>(PrintAddTaskScreen());
                goto MainScreen;
            case 3:
                PrintEditTaskScreen(tasks);
                goto MainScreen;
            case 4:
            default:
                Console.WriteLine("Please Select Valid Option...");
                break;
        }
    }
}