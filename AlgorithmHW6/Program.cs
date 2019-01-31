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
            binaryTree.InsertFromFile( @"D:\str.txt" ); //<- Файл должен иметь подобную структуру "8 9 15 12 6 6 12 16 0 0 0 5"
            binaryTree.PrintBinaryTree( binaryTree );

            Console.WriteLine();

            //Поиск узла в дереве
            binaryTree.PrintBinaryTree( binaryTree.Search( 6 ) );

            Console.WriteLine();

            //Вывод дерева по обходу КЛП
            binaryTree.PreOrderTravers( binaryTree );

            Console.WriteLine();

            //Вывод дерева по обходу ЛКП
            binaryTree.InOrderTravers(binaryTree);

            Console.WriteLine();

            //Вывод дерева по обходу ЛПК
            binaryTree.PostOrderTravers(binaryTree);
        }
    }
}