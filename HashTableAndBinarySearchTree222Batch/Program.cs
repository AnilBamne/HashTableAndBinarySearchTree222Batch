using System;

namespace HashTableAndBinarySearchTree222Batch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable And BinarySearchTree Programs");
            Console.WriteLine("\nPlease choose program number to execute");
            Console.WriteLine("1:Hash table uc1\n2:Hash table uc2\n3:Hash table uc3\n4:Binary Search tree uc1\n5:Binary Search tree uc2\n6:Binary Search tree uc3");
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
                    String paragraph3 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(paragraph3);
                    break;
                case 4:
                    BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
                    bst.Insert(30);
                    bst.Insert(70);
                    bst.Display();
                    break;
                case 5:
                    BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    binarySearchTree.getSize();
                    break;
                case 6:
                    BinarySearchTree<int> binarySearchTree1 = new BinarySearchTree<int>(56);
                    binarySearchTree1.Insert(30);
                    binarySearchTree1.Insert(70);
                    binarySearchTree1.Insert(22);
                    binarySearchTree1.Insert(40);
                    binarySearchTree1.Insert(60);
                    binarySearchTree1.Insert(95);
                    binarySearchTree1.Insert(11);
                    binarySearchTree1.Insert(65);
                    binarySearchTree1.Insert(3);
                    binarySearchTree1.Insert(16);
                    binarySearchTree1.Insert(63);
                    binarySearchTree1.Insert(67);
                    binarySearchTree1.Display();
                    binarySearchTree1.getSize();
                    bool result = binarySearchTree1.IsExists(63, binarySearchTree1);
                    Console.WriteLine(result);
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
            //Hash table uc3 : removing "avoidable" word from the paragraph and printing occurances again
            string removeWord = "avoidable";                                   
            hashTabe.Remove(removeWord);
            Console.WriteLine("\n Removed an word --> {0}\n", removeWord);
            hashTabe.Display();
        }
    }
}
