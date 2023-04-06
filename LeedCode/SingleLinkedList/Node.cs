using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView_00
{
    class Node
    {
        public int data;
        public Node next;

        public Node() {
            this.data = 0;
            this.next = null;
        }

        public Node(int vlData) {
            this.data = vlData;
        }
    }
}

