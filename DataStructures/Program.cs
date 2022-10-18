﻿// See https://aka.ms/new-console-template for more information
using DataStructures;

//LinkList link = new();
//link.AddNodes(1);
//link.AddNodes(2);
//link.AddNodes(3);
//link.AddNodes(4);
//link.AddNodes(5);
//link.AddAfter(7, 1);
//link.AddToBegnning(10);
//link.DeleteNode(10);

//link.Print();
BinaryTree binaryTree = new();
binaryTree.Insert(50);
binaryTree.Insert(55);
binaryTree.Insert(60);
binaryTree.Insert(40);
binaryTree.Insert(20);
binaryTree.Insert(45);
binaryTree.Insert(10);
binaryTree.Insert(15);
binaryTree.Insert(9);
binaryTree.InOrderTraversal();
Console.WriteLine(".");
binaryTree.PreOrderTraversal();
Console.WriteLine(".");
binaryTree.PostOrderTraversal();
Console.WriteLine(".");
binaryTree.Find(2);