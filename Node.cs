using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSLL
{
    internal class Node
    {
        // Value in the node
        public string Value { get; set; }
        
        // Value in the next node
        public Node Next { get; set; }

        // Index number
        public int Index { get; set; }
    }
}
