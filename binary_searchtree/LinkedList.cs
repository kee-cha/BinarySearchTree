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
                else if (current.left != null && data < current.data)
                {
                    current = current.left;
                }
                else if (data >= current.data && current.right == null)
                {
                    current.right = node;
                    break;
                }
                else if (current.right != null && data >= current.data)
                {
                    current = current.right;
                }
            }
        }

        public bool Search(int myData)
        {        
            Node current = root;
            while (true)
            {
                if (myData != current.data && myData > current.data && current.right != null)
                {
                    current = current.right;
                }
                else if (myData != current.data && myData < current.data && current.left != null)
                {
                    current = current.left;
                }
                else if (current.data == myData)
                {
                    Console.WriteLine($"Found your number {current.data}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Can't find your number {myData}");
                    return false;
                }
            }
        }
    }
}
    

