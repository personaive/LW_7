using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string file1 = "task1.txt";
        FileTasks.GenerateFile1(file1, 10);
        Console.WriteLine("Task 1 result: " + FileTasks.Task1_AverageMinMax(file1));

        string file2 = "task2.txt";
        FileTasks.GenerateFile2(file2, 3, 5);
        Console.WriteLine("Task 2 result: " + FileTasks.Task2_ProductEven(file2));

        string file3in = "task3_in.txt";
        string file3out = "task3_out.txt";
        FileTasks.GenerateFile3(file3in);
        FileTasks.Task3_FilterLines(file3in, file3out);

        Console.Write("Task 3 result: ");
        FileTasks.PrintFile(file3out);

        string file4 = "task4.bin";
        FileTasks.GenerateBinaryFile4(file4, 10);
        Console.WriteLine("Task 4 result: " + FileTasks.Task4_CountOddSquares(file4));

        List<int> l1 = new List<int> { 1, 2, 3, 4 };
        List<int> l2 = new List<int> { 3, 4, 5 };

        List<int> r6 = CollectionTasks.Task6_Intersection(l1, l2);

        Console.Write("Task 6 result: ");
        for (int i = 0; i < r6.Count; i++)
        {
            Console.Write(r6[i] + " ");
        }
        Console.WriteLine();

        LinkedList<int> list7 = new LinkedList<int>();
        list7.AddLast(1);
        list7.AddLast(2);
        list7.AddLast(3);

        CollectionTasks.Task7_ReverseAppend(list7);

        Console.Write("Task 7 result: ");

        LinkedListNode<int> current = list7.First;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }

        Console.WriteLine();

        string file9 = "task9.txt";
        CollectionTasks.GenerateFile9(file9);

        Console.WriteLine("Task 9 result: " + CollectionTasks.Task9_CountDifferentLetters(file9));
    }
}