/* Graph with DFS & BFS */

using System;
using System.Text;
using System.Collections.Generic;

public class Graph
{
    private List<int>[] adj;
    private bool [] visited;
    public int Vertex { get; set; }

    public Graph(int v)
    {
        Vertex = v;
        visited = new bool [v];
        adj = new List<int>[v];

        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void Print()
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < Vertex; i++)
        {
            var a = adj[i];

            if (a.Count > 0)
            {
                builder.Append("Adjacent nodes for Node#" + i + ": ");
                
                foreach (int j in a)
                {
                    builder.Append(j + " ");
                }

                builder.Append("\n");
            }
        }

        Console.WriteLine(builder.ToString());
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
    }

    public void RemoveEdge(int u, int v)
    {
        adj[u].Remove(v);
    }

    public void DFS(int s)
    {
        visited[s] = true;
        Console.Write(s + "\t");

        for(int i = 0; i < adj[s].Count; i++)
        {
            if(! visited[adj[s][i]])
            {
                DFS(adj[s][i]);
            }
        }
    }

    public void BFS(int s)
    {
        List<int> queue = new List<int>();
        visited[s] = true;
        queue.Add(s);

        while(queue.Count != 0)
        {
            int temp = queue[0];
            queue.RemoveAt(0);
            Console.Write(temp + "\t");

            for(int j = 0; j < adj[temp].Count; j++)
            {
                if(! visited[adj[temp][j]])
                {
                    visited[adj[temp][j]] = true;
                    queue.Add(adj[temp][j]);
                }
            }
        }
    }

    public void ResetVisited()
    {
        visited = new bool [Vertex];
    }

    public static void Main()
    {
        Graph g = new Graph(4);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);
        g.DFS(2);
        g.ResetVisited();
        Console.WriteLine();
        g.DFS(3);
        g.ResetVisited();
        Console.WriteLine();
        g.BFS(2);
        g.ResetVisited();
        Console.WriteLine();
    }
}