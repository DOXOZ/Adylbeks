using System;

public class Task
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public override string ToString()
    {
        return $"{Description} - {(IsCompleted ? "Completed" : "Pending")}";
    }
}

public class Node
{
    public Task Task { get; set; }
    public Node Next { get; set; }

    public Node(Task task)
    {
        Task = task;
        Next = null;
    }
}

public class TaskLinkedList
{
    private Node head;

    public TaskLinkedList()
    {
        head = null;
    }

    public void AddTask(string description)
    {
        Task newTask = new Task(description);
        Node newNode = new Node(newTask);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void RemoveTask(string description)
    {
        if (head == null) return;

        if (head.Task.Description == description)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null && current.Next.Task.Description != description)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void PrintAllTasks()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Task);
            current = current.Next;
        }
    }

    public void MarkTaskAsCompleted(string description)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Task.Description == description)
            {
                current.Task.IsCompleted = true;
                return;
            }
            current = current.Next;
        }
    }

    public void EditTaskDescription(string oldDescription, string newDescription)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Task.Description == oldDescription)
            {
                current.Task.Description = newDescription;
                return;
            }
            current = current.Next;
        }
    }

    public void ClearAllTasks()
    {
        head = null;
    }

    public void PrintCompletedTasks()
    {
        Node current = head;
        while (current != null)
        {
            if (current.Task.IsCompleted)
            {
                Console.WriteLine(current.Task);
            }
            current = current.Next;
        }
    }

    public void PrintPendingTasks()
    {
        Node current = head;
        while (current != null)
        {
            if (!current.Task.IsCompleted)
            {
                Console.WriteLine(current.Task);
            }
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskLinkedList tasks = new TaskLinkedList();

        tasks.AddTask("Buy groceries");
        tasks.AddTask("Read a book");
        tasks.AddTask("Write some code");

        Console.WriteLine("All Tasks:");
        tasks.PrintAllTasks();

        tasks.MarkTaskAsCompleted("Read a book");

        Console.WriteLine("\nCompleted Tasks:");
        tasks.PrintCompletedTasks();

        Console.WriteLine("\nPending Tasks:");
        tasks.PrintPendingTasks();

        tasks.EditTaskDescription("Write some code", "Write more code");
        tasks.RemoveTask("Buy groceries");

        Console.WriteLine("\nAll Tasks after modifications:");
        tasks.PrintAllTasks();

        tasks.ClearAllTasks();
        Console.WriteLine("\nAll Tasks after clearing:");
        tasks.PrintAllTasks();
    }
}
