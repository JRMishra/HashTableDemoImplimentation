using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProject
{
    class HashTableBuilder
    {
        public string Sentence { get; set; } = "To be or not to be";
        public string WordToCheck { get; set; } = "be";

        private MyMappingNode<string, int> myMap;

        public int FindFrequencyOfWord()
        {
            string[] words = Sentence.Split(' ');
            MyMappingNode<string, int> map = new MyMappingNode<string, int>(10);

            foreach (string word in words)
            {
                if (map.GetValue(word) == 0)
                    map.AddValue(word, 1);
                else
                {
                    var freq = map.GetValue(word) + 1;
                    map.SetValue(word, freq);
                }
            }
            int count = map.GetValue(WordToCheck);
            myMap = map;
            return count;
        }

        public void RemoveWord(string wordToRemove)
        {
            MyMappingNode<string, int> map = myMap;
            map.RemoveValue(wordToRemove);
            Console.WriteLine($"Frequency of \"{wordToRemove}\" after removal is {map.GetValue(wordToRemove)} ");
        }
    }
}
