using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distribution_Managment_System.Data_Structure;

namespace Distribution_Managment_System.Algorithms
{
    public static class PrimAlgo
    {
        public static Vertex[] Prim(double[,] RegionGraphMat)
        {
            int VerticesNum = RegionGraphMat.GetLength(0);
            Vertex[] vertices= new Vertex[VerticesNum];
            for (int i =0; i< VerticesNum; i++ )
            {
                vertices[i] = new Vertex();
                vertices[i].Identifier= i;
            }

            vertices[0].Key = 0;
            Min_Queue<Vertex> Queue = new Min_Queue<Vertex>();
            for (int i = 0; i < VerticesNum; i++)
                Queue.Enqueue(vertices[i].Key, vertices[i]);

            while (Queue.GetCount() > 0)
            {
                Vertex minVertex = Queue.Dequeue();
                int u = minVertex.Identifier;

                vertices[u].Visited = true;
                double[] edges = new double[VerticesNum];
                for (int i = 0; i < VerticesNum; i++)
                    edges[i] = RegionGraphMat[minVertex.Identifier, i];// All adjacents

                for (int v = 0; v < edges.Length; v++)
                {
                    if (RegionGraphMat[u,v] > 0 && !vertices[v].Visited && RegionGraphMat[u,v] < vertices[v].Key)
                    {
                        vertices[v].Parent = u;
                        vertices[v].Key = RegionGraphMat[u, v];
                        Queue.UpdatePriority(vertices[v], vertices[v].Key);
                    }
                }
            }

            return vertices;
        }
    }
}
