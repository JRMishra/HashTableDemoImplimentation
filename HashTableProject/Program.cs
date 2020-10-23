using System;

namespace HashTableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTableBuilder hashTable = new HashTableBuilder();

            //Console.WriteLine("Enter a sentence");
            //hashTable.Sentence = Console.ReadLine();

            //Console.Write("Word to check frequency : ");
            //hashTable.WordToCheck = Console.ReadLine();

            Console.WriteLine($"Frequency of \"{hashTable.WordToCheck}\" is {hashTable.FindFrequencyOfWord()}");
        }
    }

}
