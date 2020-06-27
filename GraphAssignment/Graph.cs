using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace GraphAssignment
{
    public class Graph
    {
        const int ResetEdge = 0;
        public List<String> VerticesList;
        public List<bool> Marks;
        public List<List<int>> Edges;
        public int NumberOfVertices;

        public Graph()
        {
            NumberOfVertices = 0;
            VerticesList = new List<String>();
            Marks = new List<bool>();
            Edges = new List<List<int>>();
        }

        ~Graph()
        {
            VerticesList = null;
            Marks = null;            
        }
        public void ClearMarks()
        {
            for (int i = 0; i < Marks.Count; i++)
                Marks[i] = false;
        }

        public bool IsMarked(string vertex)
        {
            int index = IndexIs(vertex);
            return Marks[index];
        }

        public void MarkVertex(string vertex)
        {
            int index = IndexIs(vertex);
            Marks[index] = true;
        }

        public void AddVertex(String vertex)
        {
            VerticesList.Add(vertex);
            Marks.Add(false);
            NumberOfVertices++;


            if (Edges != null)
            {
                foreach (var x in Edges)
                    x.Add(0);
            }

            List<int> mylist = new List<int>();
            for (int i = 0; i < NumberOfVertices; i++)
                mylist.Add(0);
            Edges.Add(mylist);
        }

        public void RemoveVertex(String vertex)
        {
            Edges.RemoveAt(IndexIs(vertex));
            foreach (var x in Edges)
                x.RemoveAt(IndexIs(vertex));

            Marks.RemoveAt(IndexIs(vertex));
            VerticesList.RemoveAt(IndexIs(vertex));
            NumberOfVertices--;

        }

        public int IndexIs(string vertex)
        {
            int index = 0;
            while (!(vertex == VerticesList[index]))
                index++;
            return index;
        }

        public void AddEdge(String fromVertex, string toVertex, int weight)
        {
            // Post: Edge (fromVertex, toVertex) is stored in edges.
            int row;
            int column;
            row = IndexIs(fromVertex);
            column = IndexIs(toVertex);
            Edges[row][column] = weight;
        }

        public void RemoveEddge(String fromVertex, string toVertex)
        {
            int row;
            int column;
            row = IndexIs(fromVertex);
            column = IndexIs(toVertex);
            Edges[row][column] = 0;
        }

        public int WeightIs(String fromVertex, String toVertex)
        {
            // Post: Function value = weight associated with the
            // edge (fromVertex, toVertex).
            int row;
            int column;
            row = IndexIs(fromVertex);
            column = IndexIs(toVertex);
            return Edges[row][column];
        }

        public Queue<String> GetToVertices(String vertex, Queue<String> adjvertexQ)
        {
            int fromIndex;
            int toIndex;

            fromIndex = IndexIs(vertex);
            for (toIndex = 0; toIndex < NumberOfVertices; toIndex++)
            {
                if (Edges[fromIndex][toIndex] != ResetEdge)
                    adjvertexQ.Enqueue(VerticesList[toIndex]);
            }
            return adjvertexQ;
        }

        public void ShowMap()
        {
            Console.Write("" + "\t");
            foreach (bool b in Marks)
                Console.Write(b + "\t");
            Console.WriteLine("");

            Console.Write("" + "\t");
            foreach (string s in VerticesList)
                Console.Write(s + "\t");
            Console.WriteLine("");

            for (int row = 0; row < NumberOfVertices; row++)
            {
                Console.Write(VerticesList[row] + "\t");
                for (int col = 0; col < NumberOfVertices; col++)
                    Console.Write(Edges[row][col] + "\t");
                Console.WriteLine("");
            }
        }

        public bool ColumnIsEmpty(string vertex)
        {
            bool result = true;
            foreach (var x in Edges)
                if (x[IndexIs(vertex)] != 0)
                    result = false;
            return result;
        }

        public bool RowIsEmpty(string vertex)
        {
            bool result = true;
            foreach (var x in Edges[IndexIs(vertex)])
                if (x != 0)
                    result = false;
            return result;
        }

        public List<string> Displaydetails()
        {
            List<string> result = new List<string>();
            result.Add("Departure \t Distance \t Arrival \n");
            result.Add("\n");
            for (int row = 0; row < Edges.Count; row++)
            {
                for (int col = 0; col < Edges[row].Count; col++)
                {
                    if (Edges[row][col] != 0)
                        result.Add(VerticesList[row] + "\t\t" + Edges[row][col] + "\t\t" + VerticesList[col]);
                }
            }

            return result;
        }
    }
}