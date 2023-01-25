using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.Data_Structure
{
    public class Vertex
    {
        double key;
        int parent;
        int identifier;
        bool visited;

        public Vertex()
        {
            Key = int.MaxValue;
            Parent = -1;
        }

        public double Key { get => key; set => key = value; }
        public int Parent { get => parent; set => parent = value; }
        public int Identifier { get => identifier; set => identifier = value; }
        public bool Visited { get => visited; set => visited = value; }
    }
}
