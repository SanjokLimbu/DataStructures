using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkNode
    {
        private int Id;
        public LinkNode? Prev;
        public LinkNode? Next;

        public LinkNode(int data)
        {
            Id = data;
        }
        public void Push(int data)
        {
            if (Next == null)
            {
                LinkNode newNode = new(data);
                Next = newNode;
                newNode.Prev = this;
            }
            else
            {
                Next.Push(data);
            }
        }
        public void AddAfter(int data, int index, int count)
        {
            if(count == index)
            {
                LinkNode newNode = new(data);
                newNode.Next = Next;
                newNode.Prev = this;
                Next.Prev = newNode;
                Next = newNode;
            }
            else if(Next == null)
            {
                Console.WriteLine("No valid index found. Created new Node instead.");
                Next = new(data);
            }
            else
            {
                count++;
                Next.AddAfter(data, index, count);
            }
        }
        public void DeleteNode(int index, int count)
        {
            if(count == index)
            {
                Next = Next.Next;
                Next.Next.Prev = this;
            }
            else if(Next == null)
            {
                Console.WriteLine("Invalid index to delete.");
            }
            else
            {
                count++;
                Next.DeleteNode(index, count);
            }
        }
        public void Print()
        {
            Console.Write(Id + "-> ");
            if(Next != null)
            {
                Next.Print();
            }
        }
    }

    public class LinkList
    {
        public LinkNode? FirstNode;
        public void AddNodes(int data)
        {
            if(FirstNode == null)
            {
                FirstNode = new(data);
            }
            else
            {
                FirstNode.Push(data);
            }
        }
        public void AddToBegnning(int data)
        {
            if(FirstNode == null)
            {
                FirstNode = new(data);
            }
            else
            {
                LinkNode node = new(data);
                node.Next = FirstNode;
                FirstNode = node;
            }
        }
        public void AddAfter(int data, int index)
        {
            int currentIndex = 0;
            if(FirstNode != null)
            {
                FirstNode.AddAfter(data, index, currentIndex);
            }
            else
            {
                Console.WriteLine("Invalid list. New node is created Instead.");
                FirstNode = new(data);
            }
        }
        public void DeleteNode(int index)
        {
            if(FirstNode != null)
            {
                if(index == 0)
                {
                    LinkNode node = FirstNode;
                    FirstNode = node.Next;
                    FirstNode.Prev = null;
                }
                else
                {
                    int currentIndex = 1;
                    FirstNode.DeleteNode(index, currentIndex);
                }
            }
            else
            {
                Console.WriteLine("Empty Nodes.");
            }
        }
        public void Print()
        {
            if(FirstNode != null)
            {
                FirstNode.Print();
            }
        }
    }
}
