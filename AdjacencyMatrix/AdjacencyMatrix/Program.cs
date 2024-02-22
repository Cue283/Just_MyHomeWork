﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vertex_list = new string[] { "A", "B", "C", "D","E" };
            int[,] adj_list = new int[,] { {0, 1, 0, 0, 1},
                                           {1, 0, 0, 1, 0},
                                           {0, 0, 0, 1, 1},
                                           {0, 1, 1, 0, 0},
                                           {1, 0, 1, 0, 0} };
            Console.Write("Input source city (A, B, C, D, E) : ");
            string src = Console.ReadLine().ToUpper();
            int src_index = FindIndex(vertex_list, src);
            Console.Write("Input destination city (A, B, C, D, E) : ");
            string desc = Console.ReadLine().ToUpper();
            int desc_index = FindIndex(vertex_list, desc);
            if (adj_list[src_index, desc_index] != 0)
                Console.WriteLine("You can go from {0} to {1}",
                vertex_list[src_index], vertex_list[desc_index]);
            else
                Console.WriteLine("You cannot go from {0} to {1}",
                vertex_list[src_index], vertex_list[desc_index]);
            // stack
            DFSTraversal(vertex_list, adj_list);
            //queue
            BFSTraversal(vertex_list, adj_list);
        }
        
        
        static int FindIndex(string[] vertex_list, string data)
        {
            for (int i = 0; i < vertex_list.Length; i++)
            {
                if (data == vertex_list[i])
                    return i;
            }
            return -1;
        }
        
        static void DFSTraversal(string[] vertex_list, int[,] adj_list)
        {
            Stack S = new Stack();
            //creating check list
            int[] check_list = new int[vertex_list.Length];
            for (int i = 0; i < check_list.Length; ++i)
                check_list[i] = 0;
            //starting vertex
            int vertex = 0;
            string traversal = vertex_list[vertex];
            //check in list
            check_list[vertex] = 1;
            //row
            int k = 1;
            while (k < adj_list.GetLength(0))
            {
                //column
                for (int j = 0; j < adj_list.GetLength(1); ++j)
                {
                    if ((adj_list[vertex, j] != 0) && (check_list[j] ==
                    0) && (!S.Contains(j)))
                        S.Push(j);
                }
                vertex = (int)S.Pop();
                traversal += " " + vertex_list[vertex];
                check_list[vertex] = 1;
                ++k;
            }
            Console.WriteLine(traversal);
        }
        static void BFSTraversal(string[] vertex_list, int[,] adj_list)
        {

            //Coding !!
            Queue S = new Queue();
            //creating check list
            int[] check_list = new int[vertex_list.Length];
            for (int i = 0; i < check_list.Length; ++i)
                check_list[i] = 0;
            //starting vertex
            int vertex = 0;
            string traversal = vertex_list[vertex];
            //check in list
            check_list[vertex] = 1;
            //row
            int k = 1;
            while (k < adj_list.GetLength(0))
            {
                //column
                for (int j = 0; j < adj_list.GetLength(1); ++j)
                {
                    if ((adj_list[vertex, j] != 0) && (check_list[j] ==
                    0) && (!S.Contains(j)))
                        S.Enqueue(j);
                }
                vertex = (int)S.Dequeue();
                traversal += " " + vertex_list[vertex];
                check_list[vertex] = 1;
                ++k;
            }
            Console.WriteLine(traversal);
        }
    }
}
