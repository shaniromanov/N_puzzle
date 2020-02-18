using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_puzzle
{
    class Node
    {
        public State State { get; }
        public Node Parent { get; }
        public Direction Direction { get; }
    }
}
