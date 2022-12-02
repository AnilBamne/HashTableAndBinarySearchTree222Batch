using System;

namespace HashTableAndBinarySearchTree222Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable And BinarySearchTree Programs");
            Console.WriteLine("\nPlease choose program number to execute");
            Console.WriteLine("1:Hash table uc1\n2:Hash table uc2\n3:Hash table uc3\n4:");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    String paragraph1 = "To be or not to be";
                    CountNumbOfOccurence(paragraph1);
                    break;
                case 2:
                    String paragraph2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(paragraph2);
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        //Hash Table uc1:count the  no.of occurance of each word in a sentance.
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(" ");              //splitting the each word separeted by spaces and storing them in array

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Words and their occurance is : ");
            hashTabe.Display();
        }
    }
}
