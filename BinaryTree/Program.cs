using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree b = new BinaryTree();
            b.AddNode(100);

            //left subtree
            b.AddNode(75);
            b.AddNode(83);
            b.AddNode(64);

            //Right subtree
            b.AddNode(150);
            b.AddNode(167);
            b.AddNode(125);

            Console.WriteLine(b.FindNode(125).item);
        }
    }
}
