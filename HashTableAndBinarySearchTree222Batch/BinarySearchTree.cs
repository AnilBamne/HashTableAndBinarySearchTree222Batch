using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchTree222Batch
{
    //Generic class of type <T> and implementing/inheriting IComparable interface.
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData               // Gets or sets the node data.
        {
            get;
            set;
        }
        public BinarySearchTree<T> leftTree { get; set; }       // Gets or sets the left tree.
        public BinarySearchTree<T> rightTree { get; set; }      // Gets or sets the right tree.
        //Initializing a new instance of the "BinarySearchTree{T}" class.
        public BinarySearchTree(T nodeData)
        {
            NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        //variables
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        // Insert method to add the specified item.
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.Insert(item);
                    leftCount++;                                    //counting no of elements inserted.
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.Insert(item);
                    rightCount++;
            }
        }
        // Display methode to display the nodes.
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightTree.Display();
            }
        }
        // Size method for checking whether all the elements shown in figure and BST are equal.
        public void getSize()
        {
            Console.WriteLine("Size of BST is = " + (1 + this.leftCount + this.rightCount));
        }
        // Is exists method check the specific element in BST.
        public bool IsExists(T element, BinarySearchTree<T> node)       //uc3
        {
            if (node == null)       //tree is empty
            {
                result = false;
            }
            else if (node.NodeData.Equals(element))                     //first node
            {
                Console.WriteLine("{0} Found in BST = ",node.NodeData);
                result= true;
            }
            else
            {
                Console.WriteLine("Current element is  in BST = " + node.NodeData);
                if (element.CompareTo(node.NodeData) < 0)               //search in left tree
                {
                    IsExists(element, node.leftTree);
                }
                else if (element.CompareTo(node.NodeData) > 0)               //search in right tree
                {
                    IsExists(element, node.rightTree);
                }
            }
            return result;
        }
    }
}
