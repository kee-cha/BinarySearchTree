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
            else
            {
                current = node;
            }
            current = root;
            while (true)
            {
                if (data < current.data)
                {
                    if (current.left == null)
                    {
                        current.left = node;
                        break;
                    }
                    else if (current.left != null)
                    {
                        current = current.left;
                    }
                }
                else if (data >= current.data)
                {
                    if (current.right == null)
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
        }
    }
}

