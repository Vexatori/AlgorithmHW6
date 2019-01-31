using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW6
{
    class Program
    {
        static void Main( string[] args )
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.InsertFromFile( @"D:\str.txt" );
            binaryTree.PrintBinaryTree( binaryTree );
            Console.WriteLine();
            binaryTree.PrintBinaryTree( binaryTree.Search( 6 ) );
            Console.WriteLine();
            binaryTree.PreOrderTravers( binaryTree );
            Console.WriteLine();
            binaryTree.InOrderTravers(binaryTree);
            Console.WriteLine();
            binaryTree.PostOrderTravers(binaryTree);
        }
    }
}