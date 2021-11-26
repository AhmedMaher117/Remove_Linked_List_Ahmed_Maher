using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Linked_List_Ahmed_Maher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> MaherList = new LinkedList<string>();

            LinkedListNode<string> MaherhNode = MaherList.AddFirst("Venom");
            MaherList.AddFirst("TF");
            MaherList.AddFirst("Optimus prime");
            MaherList.AddFirst("Halo");
            MaherList.AddFirst("Naruto");
            MaherList.AddFirst("Madara Uchiha");
            MaherList.AddFirst("Mortal Kombat");
            MaherList.AddFirst("Scorpion");
            MaherList.AddBefore(MaherhNode, "Kill Zone");
            MaherList.AddLast("Metal Gear Solid");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("The linked List Before Deletion:  ");
            Console.WriteLine("----------------------------------");
            foreach (var item in MaherList)
            {
                Console.Write(item + ",");
            }

            MaherList.RemoveFirst();
            MaherList.RemoveLast();
            MaherList.Remove("Metal Gear Solid");
            MaherList.Remove("TF");
            MaherList.Remove("Venom"); 
            MaherList.Remove("Metal Gear Solid");

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("The linked List After Deletion: ");
            Console.WriteLine("--------------------------------");

            foreach (var item in MaherList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
