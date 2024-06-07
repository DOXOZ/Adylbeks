using System;
using System.Collections.Generic;

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
}