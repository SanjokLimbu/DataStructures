// See https://aka.ms/new-console-template for more information
using DataStructures;

LinkList link = new();
link.AddNodes(1);
link.AddNodes(2);
link.AddNodes(3);
link.AddNodes(4);
link.AddNodes(5);
link.AddAfter(7, 1);
link.AddToBegnning(10);
link.DeleteNode(10);

link.Print();