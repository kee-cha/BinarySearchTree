using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace binary_searchtree
{
    public class LinkedList
    {
        Node root;
        Node current;

        public void InsertAtEnd(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }
            current = root;
            while (true)
            {
                if (data < current.data && current.left == null)
                {
                    current.left = node;
                    break;
                }
                else if (current.left != null)
                {
                    current = current.left;
                }
                else if (data >= current.data && current.right == null)
                {
                    current.right = node;
                    break;
                }
                else if (current.right != null)
                {
                    current = current.right;
                }
            }
        }

        public bool Search(int myData)
        {
            if (myData == root.data)
            {
                Console.WriteLine("Found your number");
                return true;
            }
            current = root;
            while (true)
            {
                if (myData != current.data && myData.CompareTo(current.data) > 0 && current.right != null)
                {
                    current = current.right;
                }
                else if (myData != current.data && myData.CompareTo(current.data) < 0 && current.left != null)
                {
                    current = current.left;
                }
                else if (current.data == myData)
                {
                    Console.WriteLine("Found your number");
                    return true;
                }
                else
                {
                    Console.WriteLine("Can't find your number");
                    return false;
                }
            }
        }
    }
}
    

