using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
namespace NodeRemove
{
    class Program
    {
        static void Print(Node<int>p)
        {
            if (p.GetNext() == null)
                Console.WriteLine(p.GetValue());
            else
            {
                Console.Write($"{p.GetValue()}, ");
                Print(p.GetNext());

             }
        }
        static Node<int> Build (int[] ar)
        {
            Node<int> first = new Node<int>(ar[0]);
            Node<int> p = first;
            for (int i=1; i < ar.Length; i++)
            {
                p.SetNext(new Node<int>(ar[i]));
                p = p.GetNext();
            }
            return first;
        }
        static Node<int> RemoveOdd (Node<int> head)
        {
            throw new NotImplementedException();
        }
        static Node<int> RemoveAt (Node<int> head, int place)
        {
            //input => node representing head of linked list
            // output=> returns new node Representing linked list
            throw new NotImplementedException();
        }
        static Node<int> RemoveAll (Node<int> head, int value)
        {
            // input => node representing head of linked list and a value (int)
            // output => node representing the new begining of linked list without nodes with VALUE
            throw new NotImplementedException();
        }
        static void RemoveDuplicates (Node<int> p)
        { // input => node representing head of linked list
            // output => a linked list with all values appearing only once

        }
        static void Main(string[] args)
        {
            int[] ar = { 2, 3, 5, 6, 7, 11, 18 };
            Node<int> a = Build(ar);
            Print(a);
            a = RemoveOdd(a);
            Print(a);
            ar = new int[] { 3, 5, 1, 4, 8, 9, 24 };
            Node<int> b = Build(ar);
            Print(b);
            b = RemoveOdd(b);
            Print(b);
            Console.ReadKey();

        }
    }
}
