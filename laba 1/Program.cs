using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 1000050; i++)
        {
            linkedList.AddLast(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Час додавання LinkedList: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        bool found = linkedList.Contains(500050);
        stopwatch.Stop();
        Console.WriteLine("Час пошуку LinkedList: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        linkedList.Remove(500050);
        stopwatch.Stop();
        Console.WriteLine("Час видалення LinkedList: " + stopwatch.Elapsed + " мс");


        Console.WriteLine();

        ArrayList arrayList = new ArrayList();
        Stopwatch stopwatch1 = Stopwatch.StartNew();
        for (int i = 0; i < 1000050; i++)
        {
            arrayList.Add(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Час додавання ArrayList: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        bool found1 = arrayList.Contains(500050);
        stopwatch.Stop();
        Console.WriteLine("Час пошуку ArrayList: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        arrayList.Remove(500050);
        stopwatch.Stop();
        Console.WriteLine("Час видалення ArrayList: " + stopwatch.Elapsed + " мс");

        Console.WriteLine();

        SortedSet<int> sortedSet = new SortedSet<int>();


        Stopwatch stopwatch2 = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++)
        {
            sortedSet.Add(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Час додавання SortedSet: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        bool found2 = sortedSet.Contains(500050);
        stopwatch.Stop();
        Console.WriteLine("Час пошуку SortedSet: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        sortedSet.Remove(500050);
        stopwatch.Stop();
        Console.WriteLine("Час видалення SortedSet: " + stopwatch.Elapsed + " мс");
        Console.WriteLine();


        HashSet<int> hashSet = new HashSet<int>();


        Stopwatch stopwatch3 = Stopwatch.StartNew();
        for (int i = 0; i < 1000050; i++)
        {
            hashSet.Add(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Час додавання HashSet: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        bool found3 = hashSet.Contains(500050);
        stopwatch.Stop();
        Console.WriteLine("Час пошуку HashSet: " + stopwatch.Elapsed + " мс");


        stopwatch.Restart();
        hashSet.Remove(50000);
        stopwatch.Stop();
        Console.WriteLine("Час видалення HashSet: " + stopwatch.Elapsed + " мс");
        Console.ReadKey();
    }
}