using System;
using System.Text;
using System.Collections.Generic;

public class Graph
{
    private List<int>[] _adjacent;
    private int _vertex;
    private bool [] _visited;

    public Graph(int v)
    {
        _vertex = v;
        _visited = new bool [_vertex];
        _adjacent = new List<int>[_vertex];

        for (int i = 0; i < _vertex; ++i)
        {
            _adjacent[i] = new List<int>();
        }
    }

    public void Print()
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < _vertex; ++i)
        {
            var a = _adjacent[i];
            int listCount = a.Count;

            if (listCount > 0)
            {
                stringBuilder.Append($"Adjacent nodes for Node#{i}: ");

                for(int j = 0; j < listCount; ++j)
                {
                    stringBuilder.Append($"{j} ");
                }

                stringBuilder.Append("\n");
            }
        }

        Console.WriteLine(stringBuilder.ToString());
    }

    public void AddEdge(int u, int v)
    {
        _adjacent[u].Add(v);
    }

    public void RemoveEdge(int u, int v)
    {
        _adjacent[u].Remove(v);
    }

    public void DFS(int s)
    {
        _visited[s] = true;
        Console.Write($"{s}\t");
        int length = _adjacent[s].Count;

        for(int i = 0; i < length; ++i)
        {
            if(! _visited[_adjacent[s][i]])
            {
                DFS(_adjacent[s][i]);
            }
        }
    }

    public void BFS(int s)
    {
        var queue = new List<int>();
        _visited[s] = true;
        queue.Add(s);
        int temp, length;

        while(queue.Count != 0)
        {
            temp = queue[0];
            queue.RemoveAt(0);
            Console.Write($"{temp}\t");
            length = _adjacent[temp].Count;

            for(int j = 0; j < length; ++j)
            {
                if(! _visited[_adjacent[temp][j]])
                {
                    _visited[_adjacent[temp][j]] = true;
                    queue.Add(_adjacent[temp][j]);
                }
            }
        }
    }

    public void Reset_Visited()
    {
        _visited = new bool [_vertex];
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
        g.Reset_Visited();
        Console.WriteLine();
        g.DFS(3);
        g.Reset_Visited();
        Console.WriteLine();
        g.BFS(2);
        g.Reset_Visited();
        Console.WriteLine();
    }
}