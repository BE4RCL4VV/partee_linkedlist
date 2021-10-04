using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partee_linkedlist
{
    public class Node
    {
        private string _data;
        private Node _next;
        //private Node _previous;
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
        //public Node Previous
        //{
        //    get { return _previous;}
        //    set { _previous = value; }
        //}

        public Node(string Data)
        {
            _data = Data;
        }
    }
}
