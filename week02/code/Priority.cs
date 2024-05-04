public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and Priority: Bob (1), Tim (5), Sue (3)
        // to ensure the dequeue method is working correctly
        // Expected Result: 
        // [Bob (Pri:1), Tim (Pri:5), Sue (Pri:3)]
        // [Bob (Pri:1), Sue (Pri:3)]
        // [Bob (Pri:1)]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        Console.WriteLine(priorityQueue);
        for (int i = 0; i < 3; i++) {
            priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue);
        }

        // Defect(s) Found: I found that the dequeue method was not removing
        // I also found that the priority was not being determined correctly when removing
        // items from the queue. The for loop in the dequeue method was looping through
        // all items except the last item, which made Bob the second one taken off instead 
        // of the last one. 
        //

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Try to get the item from an empty queue
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 2");
        for (int i = 0; i < priorityQueue.GetLength() + 1; i++) {
            priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue);
        }

        // Defect(s) Found: I added a getter function to get the length of the 
        // queue and check to make sure that part worked correctly and it did. 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: create a queue with the following people and Priority: Bob (1), Tim (5), Sue (3) and
        // Tom (5) to see if the 2 values of the same priority are removed correctly
        // Expected Result: 
        // [Bob (Pri:1), Tim (Pri:5), Sue (Pri:3), Tom (Pri:5)]
        // [Bob (Pri:1), Sue (Pri:3), Tom (Pri:5)]
        // [Bob (Pri:1), Sue (Pri:3)]
        // [Bob (Pri:1)]
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Tom", 5);
        Console.WriteLine(priorityQueue);
        for (int i = 0; i < 4; i++) {
            priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue);
        }

        // Defect(s) Found: I found that the dequeue method was not removing
        // the first item of the same top priority. It was removing the last.
        // I changed the check to be if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
        // instead of if (_queue[index].Priority >= _queue[highPriorityIndex].Priority), 
        // so that the first item of the same priority is removed first.

        // Add more Test Cases As Needed Below


        Console.WriteLine("---------");

        // Test 4
        // Scenario: Create a queue with the following people and Priority: Bob (1), Tim (5), Sue (3) and
        // Tom (5)
        // Expected Result: 
        // [Bob (Pri:1)]
        // [Bob (Pri:1), Tim (Pri:5)]
        // [Bob (Pri:1), Tim (Pri:5), Sue (Pri:3)]
        // [Bob (Pri:1), Tim (Pri:5), Sue (Pri:3), Tom (Pri:5)]
        Console.WriteLine("Test 4");
        priorityQueue.Enqueue("Bob", 1);
        Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Tim", 5);
        Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Sue", 3);
        Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Tom", 5);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found:
    }
}