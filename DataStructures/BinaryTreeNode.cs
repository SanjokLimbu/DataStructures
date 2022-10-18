using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTreeNode
    {
        private int Id;
        public BinaryTreeNode? Prev;
        public BinaryTreeNode? LeftNode;
        public BinaryTreeNode? RightNode;

        public BinaryTreeNode(int data)
        {
            Id = data;
        }
        public void Insert(int data)
        {
            if(data >= Id)
            {
                if(RightNode == null)
                {
                    RightNode = new BinaryTreeNode(data);
                    RightNode.Prev = this;
                }
                else
                {
                    RightNode.Insert(data);
                }            }
            else
            {
                if(LeftNode == null)
                {
                    LeftNode = new BinaryTreeNode(data);
                    LeftNode.Prev = this;                }
                else
                {
                    LeftNode.Insert(data);
                }
            }
        }
        public void InOrderTraversal()
        {
            if(LeftNode != null)
            {
                LeftNode.InOrderTraversal();
            }
            Console.Write(Id + "-> ");
            if(RightNode != null)
            {
                RightNode.InOrderTraversal();
            }
        }
        public void PreOrderTraversal()
        {
            Console.Write(Id + "-> ");
            if(LeftNode != null)
            {
                LeftNode.PreOrderTraversal();
            }
            if(RightNode != null)
            {
                RightNode.PreOrderTraversal();
            }
        }
        public void PostOrderTraversal()
        {
            if(LeftNode != null)
            {
                LeftNode.PostOrderTraversal();
            }
            if(RightNode != null)
            {
                RightNode.PostOrderTraversal();
            }
            Console.Write(Id + "-> ");
        }
        public void Find(int data)
        {
            if(data == this.Id)
            {
                Console.WriteLine(data + " Found.");
            }
            else if(data < this.Id && LeftNode != null)
            {
                LeftNode.Find(data);
            }
            else if(data > this.Id && RightNode != null)
            {
                RightNode.Find(data);
            }
            else
            {
                Console.WriteLine("Node not found.");
            }
        }
        public void Delete(int data)
        {
            
        }
    }
    public class BinaryTree
    {
        public BinaryTreeNode? FirstNode;
        public void Insert(int data)
        {
            if(FirstNode == null)
            {
                FirstNode = new BinaryTreeNode(data);
            }
            else
            {
                FirstNode.Insert(data);
            }
        }
        public void InOrderTraversal()
        {
            if(FirstNode != null)
            {
                FirstNode.InOrderTraversal();
            }
            else
            {
                Console.WriteLine("No nodes to traverse.");
            }
        }
        public void PreOrderTraversal()
        {
            if(FirstNode != null)
            {
                FirstNode.PreOrderTraversal();
            }
            else
            {
                Console.WriteLine("No nodes to traverse.");
            }
        }
        public void PostOrderTraversal()
        {
            if(FirstNode != null)
            {
                FirstNode.PostOrderTraversal();
            }
            else
            {
                Console.WriteLine("No nodes to traverse.");
            }
        }
        public void Find(int data)
        {
            if(FirstNode != null)
            {
                FirstNode.Find(data);
            }
            else
            {
                Console.WriteLine("Empty tree. New Node is created instead.");
                FirstNode = new(data);
            }
        }
        public void Delete(int data)
        {
            if(FirstNode != null)
            {
                FirstNode.Delete(data);
            }
            else
            {
                Console.WriteLine("No Nodes to delete found.");
            }
        }
    }
}
