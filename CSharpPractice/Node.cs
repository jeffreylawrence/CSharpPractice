using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Node
    {
        Node next = null;
        Node prev = null;
        int data;

        public Node(int d)
        {
            data = d;
        }

        void appendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;
            while(n.next != null)
            {
                n = n.next;
            }
            n.next = end;
            end.prev = n.next;
        }

        

        void removeDuplicates()
        {
            Node n = this;
            if(n.next != null)
            {

            }
        }
        
    }
}
