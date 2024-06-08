Todo list
Используется linked list

что выводится:
All Tasks:
Buy groceries - Pending
Read a book - Pending
Write some code - Pending

Completed Tasks:
Read a book - Completed

Pending Tasks:
Buy groceries - Pending
Write some code - Pending

All Tasks after modifications:
Write more code - Pending

All Tasks after clearing:

что вводится:
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
