using System;
using System.IO;

public static class FileTasks
{
    public static void GenerateFile1(string path, int count)
    {
        Random random = new Random();
        StreamWriter writer = new StreamWriter(path);

        for (int i = 0; i < count; i++)
        {
            int value = random.Next(1, 100);
            writer.WriteLine(value);
        }

        writer.Close();
    }

    public static double Task1_AverageMinMax(string path)
    {
        StreamReader reader = new StreamReader(path);

        string line = reader.ReadLine();

        int min = int.Parse(line);
        int max = int.Parse(line);

        while (line != null)
        {
            int value = int.Parse(line);

            if (value < min)
            {
                min = value;
            }

            if (value > max)
            {
                max = value;
            }

            line = reader.ReadLine();
        }

        reader.Close();

        return (min + max) / 2.0;
    }

    public static void GenerateFile2(string path, int rows, int cols)
    {
        Random random = new Random();
        StreamWriter writer = new StreamWriter(path);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int value = random.Next(1, 20);
                writer.Write(value + " ");
            }

            writer.WriteLine();
        }

        writer.Close();
    }

    public static int Task2_ProductEven(string path)
    {
        StreamReader reader = new StreamReader(path);

        int product = 1;
        bool hasEven = false;

        string line = reader.ReadLine();

        while (line != null)
        {
            string[] parts = line.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] != "")
                {
                    int value = int.Parse(parts[i]);

                    if (value % 2 == 0)
                    {
                        product *= value;
                        hasEven = true;
                    }
                }
            }

            line = reader.ReadLine();
        }

        reader.Close();

        if (!hasEven)
        {
            return 0;
        }

        return product;
    }

    public static void GenerateFile3(string path)
    {
        StreamWriter writer = new StreamWriter(path);

        writer.WriteLine("Testing");
        writer.WriteLine("Тестирование");

        writer.Close();
    }

    public static void Task3_FilterLines(string inputPath, string outputPath)
    {
        StreamReader reader = new StreamReader(inputPath);
        StreamWriter writer = new StreamWriter(outputPath);

        string line = reader.ReadLine();

        while (line != null)
        {
            bool hasLatin = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    hasLatin = true;
                }
            }

            if (!hasLatin)
            {
                writer.WriteLine(line);
            }

            line = reader.ReadLine();
        }

        reader.Close();
        writer.Close();
    }

    public static void PrintFile(string path)
    {
        StreamReader reader = new StreamReader(path);

        string line = reader.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = reader.ReadLine();
        }

        reader.Close();
    }

    public static void GenerateBinaryFile4(string path, int count)
    {
        Random random = new Random();
        BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create));

        for (int i = 0; i < count; i++)
        {
            int value = random.Next(1, 20);
            writer.Write(value);
        }

        writer.Close();
    }

    public static int Task4_CountOddSquares(string path)
    {
        BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));

        int count = 0;

        while (reader.BaseStream.Position < reader.BaseStream.Length)
        {
            int value = reader.ReadInt32();

            if (value % 2 != 0)
            {
                count++;
            }
        }

        reader.Close();

        return count;
    }
}