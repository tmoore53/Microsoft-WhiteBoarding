using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_WB_Arthur
{
    public class Node
    {
        //Value inside the Node
        public string Data { get; set; }
        //Point to the Left
        public Node Left { get; set; }
        //Point to the right
        public Node Right { get; set; }
        //Constructor to set left and right to null
        public Node(string data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Identical Tree.
            Node tree1 = new Node("Thank you");
            Node tree2 = new Node("Thank you");
            tree1.Left = new Node("for your time");
            tree2.Left = new Node("for your time");
            tree1.Right = new Node("For the opportunity");
            tree2.Right = new Node("For the opportunity");
            //Call to my method.
            Console.WriteLine("When comparing tree1 and tree2 the result of if they are identical is {0}",IdenticalTrees(tree1, tree2));

            //Non-Identical Tree.
            Node tree3 = new Node("Thank you");
            tree3.Left = new Node("Microsoft");
            tree3.Right = new Node("For the opportunity");
            tree3.Left.Left = new Node("Hello");
            //Call to my Method.
            Console.WriteLine("When comparing tree1 and tree3 the result of if they are identical is {0}", IdenticalTrees(tree1, tree3));

            Console.WriteLine("{0} {1}", tree1.Data, tree1.Left.Data );

            Console.WriteLine("{0} {1}", tree1.Data, tree3.Left.Data);

        }
        public static bool IdenticalTrees(Node Root1, Node Root2)
        {
            //If each root is null then they are the same.
            if (Root1.Right != null && Root2.Right == null || Root1.Right == null && Root2.Right != null)
            {
                return false;
            }
            else if (Root1.Left != null && Root2.Left == null || Root1.Left == null && Root2.Left != null)
            {
                return false;
            }
            else if (Root1.Data != Root2.Data)
            {
                return false;
            }
            else
            {
                if (Root1.Left != null && Root2.Left != null)
                {
                    if (!IdenticalTrees(Root1.Left, Root2.Left))
                        return false;
                }
                if (Root1.Right != null && Root2.Right != null)
                {
                    if (!IdenticalTrees(Root1.Right, Root2.Right))
                        return false;
                }
            }
            return true;
        }


    }



}
