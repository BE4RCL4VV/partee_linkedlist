using System;

namespace partee_linkedlist
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList userList = new LinkedList();
            string userInput = "0";
            string userNode;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("------  Welcome to the Linked list  ------\n" +
                                    "\tPlease select an option: ");
                Console.WriteLine("\t1.  Show Head\n" +
                                    "\t2.  Add an Item\n" +
                                    "\t3.  Remove Item\n" +
                                    "\t4.  Search for Item\n" +
                                    "\t5.  Print List of Items\n" +
                                    "\t6.  Exit");
                userInput = Console.ReadLine();
    // Show Head
                if (userInput == "1")
                {
                    if (userList.getFirst() == null)
                    {
                        Console.WriteLine("There is no Head");
                    }
                    else
                    {
                        Console.WriteLine("The Head is: " + userList.getFirst().Data.ToString());                       
                    }
                }
   // Add Item
                else if (userInput == "2")
                {
                    Console.WriteLine("Please enter the item you wish to add: ");
                    userNode = Console.ReadLine();
                    if (userList.getFirst() == null)
                    {
                       userList.addFirst(new Node(userNode));
                    }
                    else
                    {                        
                        userList.Add(new Node(userNode));                      
                    }
                    Console.WriteLine(userNode + " was added to the list");
                }
   // Remove item
                else if (userInput == "3")
                {
                    Console.WriteLine("Which Item would you like to Remove?");
                    userNode = Console.ReadLine();
                    userList.Remove(new Node(userNode));
                    Console.WriteLine(userNode + " was Removed");
                }
   // Search for item
                else if (userInput == "4")
                {
                    Console.WriteLine("Which Item would you like to Find?");
                    userNode = Console.ReadLine();
                    if (userList.Contains(new Node(userNode)) == null)
                    {
                        Console.WriteLine("The List does NOT contain that Item");
                    }
                    else
                    {
                        Console.WriteLine(userNode + " was found in the List");
                    }
                }
   // Print all nodes
                else if (userInput == "5")
                {
                    userList.PrintAllNodes();
                }
                else if (userInput == "6") { break; }
                else 
                {
                    Console.WriteLine("Please enter a valid choice");
                }
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadLine();
            }
        }
    }
    
}
