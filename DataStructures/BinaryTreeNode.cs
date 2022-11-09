using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataStructures
{
    public class BinaryTreeNode
    {
        private int _Id;
        public BinaryTreeNode? Prev;
        public BinaryTreeNode? LeftNode;
        public BinaryTreeNode? RightNode;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

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
        public BinaryTreeNode Find(int data)
        {
            if(data == this.Id)
            {
                return this;
            }
            else if(data < this.Id && LeftNode != null)
            {
                return LeftNode.Find(data);
            }
            else if(data > this.Id && RightNode != null)
            {
                return RightNode.Find(data);
            }
            else
            {
                return null;
            }
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
        public BinaryTreeNode Find(int data)
        {
            if(FirstNode != null)
            {
                return FirstNode.Find(data);
            }
            else
            {
                Console.WriteLine("Empty tree. New Node is created instead.");
                FirstNode = new(data);
                return null;
            }
        }
        private BinaryTreeNode GetLastNode(BinaryTreeNode node)
        {
            BinaryTreeNode parentOfLastNode = node;
            BinaryTreeNode LastNode = node;
            BinaryTreeNode current = node.RightNode;

            while(current != null){
                parentOfLastNode = LastNode;
                LastNode = current;
                current = current.LeftNode;
            }
            if(LastNode != node.RightNode)
            {
                parentOfLastNode.LeftNode = LastNode.RightNode;
                LastNode.RightNode = node.RightNode;
            }
            LastNode.LeftNode = node.LeftNode;

            return LastNode;
        }
        public void Delete(int data)
        {
            BinaryTreeNode? current = FirstNode;
            BinaryTreeNode? parent = FirstNode;
            bool isLeftChild = false;
            //Empty node
            if (current == null)
            {
                Console.WriteLine("No Nodes to delete.");
            }
            //Find the node
            while (current != null && current.Id != data)
            {
                parent = current;
                if(data < current.Id && current.LeftNode != null)
                {
                    current = current.LeftNode;
                    isLeftChild = true;
                }
                else
                {
                    if(current.RightNode != null)
                    {
                        current = current.RightNode;
                        isLeftChild = false;
                    }
                }
            }
            if(current == null)
            {
                Console.WriteLine("No Nodes to delete.");
            }
            else if(current.RightNode == null && current.LeftNode == null)
            {
                if(current == FirstNode)
                {
                    FirstNode = null;
                }
                else
                {
                    if (isLeftChild)
                    {
                        parent.LeftNode = null;
                    }
                    else
                    {
                        parent.RightNode = null;
                    }
                }
            }
            else if(current.RightNode == null)
            {
                if(current == FirstNode)
                {
                    FirstNode = current.LeftNode;
                }
                else
                {
                    if (isLeftChild)
                    {
                        parent.LeftNode = current.LeftNode;
                    }
                    else
                    {
                        parent.RightNode = current.LeftNode;
                    }
                }
            }
            else if(current.LeftNode == null)
            {
                if(current == FirstNode)
                {
                    FirstNode = current.RightNode;
                }
                else
                {
                    if (isLeftChild)
                    {
                        parent.LeftNode = current.RightNode;
                    }
                    else
                    {
                        parent.RightNode = current.RightNode;
                    }
                }
            }
            else
            {
                BinaryTreeNode LastNode = GetLastNode(current);
                if(current == FirstNode)
                {
                    FirstNode = LastNode;
                }
                else if (isLeftChild)
                {
                    parent.LeftNode = LastNode;
                }
                else
                {
                    parent.RightNode = LastNode;
                }
            }
            
        }

    }
}
