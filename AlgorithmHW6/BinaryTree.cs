using System;
using System.IO;
using System.Linq;
using System.Net;

namespace AlgorithmHW6
{
    public class BinaryTree
    {
        private int? _value;
        private BinaryTree _leftTree;
        private BinaryTree _rightTree;

        /// <summary>
        /// Метод добавляет элемент в дерево
        /// </summary>
        /// <param name="i"></param>
        public void Add( int i )
        {
            if ( _value == null )
            {
                _value = i;
            }
            else
            {
                if ( i > _value )
                {
                    if ( _rightTree == null )
                    {
                        _rightTree = new BinaryTree();
                    }

                    _rightTree.Add( i );
                }
                else if ( i < _value )
                {
                    if ( _leftTree == null )
                    {
                        _leftTree = new BinaryTree();
                    }

                    _leftTree.Add( i );
                }
            }
        }

        /// <summary>
        /// Метод считывает элементы из файла и поочередно добавляет их в дерево. Первый элемент в файле будет корнем.
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public void InsertFromFile( string path )
        {
            int[] arr = File.ReadAllText( path ).Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries )
                            .Select( int.Parse ).ToArray();
            foreach ( var num in arr )
            {
                this.Add( num );
            }
        }

        /// <summary>
        /// Поиск заданного узла, если узел не будет найдет, то выкинет ошибку
        /// </summary>
        /// <param name="i">Искомый узел</param>
        /// <returns></returns>
        public BinaryTree Search( int i )
        {
            if ( _value == i )
            {
                return this;
            }
            else if ( _value > i )
            {
                if ( _leftTree != null )
                {
                    return _leftTree.Search( i );
                }
                else
                {
                    throw new ArgumentException( "Узла в дереве нет" );
                }
            }
            else
            {
                if ( _rightTree != null )
                {
                    return _rightTree.Search( i );
                }
                else
                {
                    throw new ArgumentException( "Узла в дереве нет" );
                }
            }
        }

        /// <summary>
        /// Вывод дерева
        /// </summary>
        /// <param name="tree"></param>
        public void PrintBinaryTree( BinaryTree tree )
        {
            if ( tree != null )
            {
                Console.Write( $"{tree._value}" );
                if ( tree._leftTree != null || tree._rightTree != null )
                {
                    Console.Write( "(" );
                    if ( tree._leftTree != null )
                    {
                        PrintBinaryTree( tree._leftTree );
                    }
                    else
                    {
                        Console.Write( "NULL" );
                    }

                    Console.Write( "," );
                    if ( tree._rightTree != null )
                    {
                        PrintBinaryTree( tree._rightTree );
                    }
                    else
                    {
                        Console.Write( "NULL" );
                    }

                    Console.Write( ")" );
                }
            }
        }

        /// <summary>
        /// Вывод дерева по обходу КЛП
        /// </summary>
        /// <param name="tree"></param>
        public void PreOrderTravers( BinaryTree tree )
        {
            if ( tree != null )
            {
                Console.Write( $"{tree._value} " );
                PreOrderTravers( tree._leftTree );
                PreOrderTravers( tree._rightTree );
            }
        }

        /// <summary>
        /// Вывод дерева по обходу ЛКП
        /// </summary>
        /// <param name="tree"></param>
        public void InOrderTravers( BinaryTree tree )
        {
            if ( tree != null )
            {
                InOrderTravers( tree._leftTree );
                Console.Write( $"{tree._value} " );
                InOrderTravers( tree._rightTree );
            }
        }

        /// <summary>
        /// Вывод дерева по обходу ЛПК
        /// </summary>
        /// <param name="tree"></param>
        public void PostOrderTravers( BinaryTree tree )
        {
            if ( tree != null )
            {
                PostOrderTravers( tree._leftTree );
                PostOrderTravers( tree._rightTree );
                Console.Write( $"{tree._value} " );
            }
        }
    }
}