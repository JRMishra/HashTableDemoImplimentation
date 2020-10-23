using System;

namespace HashTableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTableBuilder hashTable = new HashTableBuilder();

            hashTable.Sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
	        hashTable.WordToCheck = "paranoid";

            Console.WriteLine($"Frequency of \"{hashTable.WordToCheck}\" is {hashTable.FindFrequencyOfWord()}");
        }
    }

}
