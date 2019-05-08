using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using ProjetoGrafos.DataStructure;
using System.Linq;

namespace EP
{
    /// <summary>
    /// EPAgent - searchs solution for the eight puzzle problem
    /// </summary>
    public class EightPuzzle : Graph
    {
        private int[] initState;
        private int[] target;

        /// <summary>
        /// Creating the agent and setting the initialstate plus target
        /// </summary>
        /// <param name="InitialState"></param>
        public EightPuzzle(int[] InitialState, int[] Target)
        {
            initState = InitialState;
            target = Target;
        }

        /// <summary>
        /// Accessor for the solution
        /// </summary>
        public int[] GetSolution()
        {
            return FindSolution();
        }

        /// <summary>
        /// Função principal de busca
        /// </summary>
        /// <returns></returns>
        private int[] FindSolution()
        {
            return null;
        }

        private List<Node> GetSucessors(Node n)
        {
            var listaVizinhos = new List<Node>();
            var limite = Convert.ToInt32(Math.Sqrt(n.Info.Length));
            

            for(int  i=0; i< limite;i++)
            {
                for(int j=0; j<limite;j++)
                {
                    n.Info[i][j]
                }
            }
            listaVizinhos.Add(new Node(null, ))

        }
        
        private int[][] BuildAnswer(Node n)
        {
            throw new NotImplementedException();
        }

        private bool TargetFound(Node n)
        {
            throw new NotImplementedException();
        }


    }
}

