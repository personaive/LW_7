using System;
using System.Collections.Generic;
using System.IO;

public static class CollectionTasks
{
    public static List<T> Task6_Intersection<T>(List<T> list1, List<T> list2)
    {
        List<T> result = new List<T>();

        for (int i = 0; i < list1.Count; i++)
        {
            T value = list1[i];
            bool exists = false;

            for (int j = 0; j < list2.Count; j++)
            {
                if (list2[j].Equals(value))
                {
                    exists = true;
                }
            }

            if (exists)
            {
                bool alreadyAdded = false;

                for (int k = 0; k < result.Count; k++)
                {
                    if (result[k].Equals(value))
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

    public static void Task7_ReverseAppend<T>(LinkedList<T> list)
    {
        List<T> temp = new List<T>();

        LinkedListNode<T> current = list.First;

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
