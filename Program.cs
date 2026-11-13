
Stack<string> actionHistory = new Stack<string>();

// Add actions to the stack
actionHistory.Push("Move Forward");
actionHistory.Push("Open Chest");
actionHistory.Push("Drink Potion");

Console.WriteLine("Undoing Actions...\n");

// Undo actions until the stack is empty
while (actionHistory.Count > 0)
{
    string action = actionHistory.Pop();
    Console.WriteLine($"{action} undone");
}


// Reflection Questions:

// 1. What does LIFO mean?
// LIFO means Last In, First Out. The last item added to the stack is the first item removed.

// 2. Why would an undo system use a stack?
// An undo system uses a stack because the most recent action needs to be undone first.