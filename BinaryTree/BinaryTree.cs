using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{

    public class Node
    {
        public int item;
        public Node Left;
        public Node Right;

        public Node(int item)
        {
            Left = null;
            Right = null;
            this.item = item;
        }
    }

    public class BinaryTree
    {
        Node head;

        public BinaryTree()
        {
            head = null;
        }


        public Node FindNode( int n )
        {
            Node tmp = head;

            while (tmp != null)
            {
                if (tmp.item == n)
                {
                    return tmp;
                }

                tmp = (n < tmp.item) ? tmp.Left : tmp.Right;
            }

            return null;
        }

        public void AddNode( int n )
        {
            if (head == null)
            {
                head = new Node(n);
                return;
            }
            Node tmp = head;

            while ( true ) {
                if (n < tmp.item)
                {
                    if(tmp.Left == null)
                    {
                        tmp.Left = new Node(n);
                        break;
                    }

                    tmp = tmp.Left;
                }
                else
                {
                    if (tmp.Right == null)
                    {
                        tmp.Right = new Node(n);
                        break;
                    }

                    tmp = tmp.Right;
                }
            }
        }
    }
}
