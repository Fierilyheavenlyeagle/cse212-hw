
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three elements with different priorities.
    // Expected Result: Dequeue returns elements from highest to lowest priority.
    // Defect(s) Found: Incorrect priority selection or failure to remove the selected element.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple elements with equal priorities.
    // Expected Result: Elements with equal priorities are dequeued in FIFO order.
    // Defect(s) Found: Incorrect comparison when priorities are equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Higher", 10);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 5);

        Assert.AreEqual("Higher", priorityQueue.Dequeue());
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Call Dequeue on an empty priority queue.
    // Expected Result: An InvalidOperationException is thrown with the correct message.
    // Defect(s) Found: Missing or incorrect empty queue exception handling.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    [TestMethod]
    // Scenario: Dequeue the only element in the queue and then dequeue again.
    // Expected Result: The first call returns the element; the second throws an exception.
    // Defect(s) Found: Failure to remove dequeued elements from the queue.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("OnlyElement", 7);

        Assert.AreEqual("OnlyElement", priorityQueue.Dequeue());

        Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );
    }
    [TestMethod]
// Scenario: Enqueue three elements where the highest priority is the last element added.
// Expected Result: Highest, Medium, Low.
// Defect(s) Found: The loop fails to check the last element in the queue.
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();

        // Add elements with different priorities.
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("Highest", 10);

        // Verify dequeue order.
        Assert.AreEqual("Highest", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }
}
