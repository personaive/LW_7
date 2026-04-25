using System;
using System.Collections.Generic;
using System.IO;

public static class CollectionTasks
{
    public static List<int> Task6_Intersection(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < list1.Count; i++)
        {
            int value = list1[i];
            bool exists = false;

            for (int j = 0; j < list2.Count; j++)
            {
                if (list2[j] == value)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                bool alreadyAdded = false;

                for (int k = 0; k < result.Count; k++)
                {
                    if (result[k] == value)
                    {
                        alreadyAdded = true;
                    }
                }

                if (!alreadyAdded)
                {
                    result.Add(value);
                }
            }
        }

        return result;
    }

    public static void Task7_ReverseAppend(LinkedList<int> list)
    {
        List<int> temp = new List<int>();

        LinkedListNode<int> current = list.First;

        while (current != null)
        {
            temp.Add(current.Value);
            current = current.Next;
        }

        for (int i = temp.Count - 1; i >= 0; i--)
        {
            list.AddLast(temp[i]);
        }
    }

    public static void GenerateFile9(string path)
    {
        StreamWriter writer = new StreamWriter(path);

        writer.WriteLine("Тестирование");
        writer.WriteLine("Testing");

        writer.Close();
    }

    public static int Task9_CountDifferentLetters(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("File does not exist: " + path);
            return 0;
        }

        HashSet<char> letters = new HashSet<char>();

        StreamReader reader = new StreamReader(path);

        string line = reader.ReadLine();

        while (line != null)
        {
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if ((c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё')
                {
                    letters.Add(c);
                }
            }

            line = reader.ReadLine();
        }

        reader.Close();

        return letters.Count;
    }
}