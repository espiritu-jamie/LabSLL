using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSLL
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public ulong Count { get; set; }

        public LinkedList()
        {
            Head = null;

        }

        public void AddFirst(string value)
        {
            // Create new node
            Node newNode = new Node();

            // Set the value of new node
            newNode.Value = value;

            // Get the node at head
            Node head = this.Head;

            // Set the next of new node to node at head
            newNode.Next = head;

            // Set the head to the new node
            this.Head = newNode;

            // Increment count
            this.Count = this.Count + 1;
        }

        public void AddLast(string value)
        {
            // Create new node
            Node newNode = new Node();

            // Set the value of the node
            newNode.Value = value;

            // List is empty
            if (this.Head == null)
            {
                // Add new node to the head
                this.Head = newNode;
            }

            // List is not empty
            else
            {
                // Set last node to head
                Node lastNode = this.Head;

                // Loop through list while the next of the node is not null (last node is not yet reached)
                // If next of the node is null, the last node is at end of list
                while (lastNode.Next != null)
                {
                    // Move forward through list by setting the last node to the next
                    lastNode = lastNode.Next;
                }

                // Set the next of the last node to the new node
                lastNode.Next = newNode;
            }

            this.Count = this.Count + 1;
        
    }

        public void RemoveFirst()
        {
            // Set the head
            Node head = this.Head;

            // If list is empty
            if (head == null)
            {
                // Throw exception
                throw new InvalidOperationException("SLL is empty");
            }

            // If there is only one node in list
            else if (head.Next == null)
            {
                // Remove the one node
                this.Head = null;
            }

            // If there is more than one node in list
            else
            {
                // Set the head of list to the next node (second node) to remove the first node
                this.Head = this.Head.Next;
            }
            

            this.Count = this.Count - 1;
        }

        public void RemoveLast()
        {
            // Set the head
            Node head = this.Head;

            // List is empty
            if (head == null)
            {
                // Throw Exception
                throw new InvalidOperationException("SLL is empty");
            }

            // List has one node
            else if (head.Next == null)
            {
                // Remove the one node
                this.Head = null;
            }

            // List has more than one node
            else
            {
                // Set the last node to the head
                Node lastNode = this.Head;

                // Loop through list until third to last node
                while (lastNode.Next.Next != null)
                {
                    // Set last node to second last node
                    lastNode = lastNode.Next;
                }

                // Delete the last node
                lastNode.Next = null;

                this.Count = this.Count - 1;
            }
        }

        public string GetValue(int index)
        {
            Node currentNode = this.Head;
            // Loop until node at index is reached (current node)
            for (int i = 0; i < index; i += 1)
            {
                // Set the current node to the next 
                currentNode = currentNode.Next;
            }

            // When index is reached, the value of the current node is returned
            return currentNode.Value;   
        }
    }
}
