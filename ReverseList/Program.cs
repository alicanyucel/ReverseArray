using System;

class Program
{
    static void Main()
    {
        
        int[] dizi = { 1, 2, 3, 4, 5 };

        int[] tersDizi = new int[dizi.Length];

      
        for (int i = 0; i < dizi.Length; i++)
        {
            tersDizi[i] = dizi[dizi.Length - 1 - i];
        }

        // Ters çevrilmiş diziyi konsola yazdır
        foreach (var item in tersDizi)
        {
            Console.Write(item + " ");

        }
        Console.ReadKey();
    }
}
