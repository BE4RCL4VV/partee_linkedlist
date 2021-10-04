using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partee_linkedlist
{
    public class LinkedList
    {
        public Node Head { get; set; }
    //Returns a reference to the first node; if no first, return null
        public Node getFirst()
        {
            if (Head == null)
            {
                return null;
            }
            else { return Head; }
        }
    //Add a new node to the front of the list
        public void addFirst(Node item)
        {
            Head = item;
        }
    //Returns a node with a matching item; if no match, return null
    // Currently Case INsensitive
        public Node Contains(Node item)
        {
            Node Current = Head;
            while (Current.Next != null)
            {
                if(Current.Data.ToLower() == item.Data.ToLower()) { return Current; }
                
                Current = Current.Next;
            }
            return null;            
        }
    //Removes node containing the item and links the two adjacent nodes together
    //  Currently case INsensitive
        public void Remove(Node item)
        {
            if(Head == null) { return; }
            if(Head.Data.ToLower() == item.Data.ToLower())
            {
                Head = Head.Next;
                return;
            }
            Node Current = Head;
            while(Current.Next != null)
            {
                if (Current.Next.Data.ToLower() == item.Data.ToLower())
                {
                    Current.Next = Current.Next.Next;
                    return;
                }
                Current = Current.Next;
            }
        }
    //Adds a node to the end of the list
        public void Add(Node NewNode)
        {
            NewNode.Next = null;
            Node Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = NewNode;
        }
    //Prints the entire list front to back.Breaking encapsulation here is permitted
        public void PrintAllNodes()
        {
            Node Current = Head;
            while (Current != null)
            {
                Console.WriteLine(Current.Data);
                if (Current.Next != null)
                { Current = Current.Next; }
                else
                    break;
            }
        }        
    }
}
