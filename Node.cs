using System;

namespace composite
{
    abstract class Node
    {
        virtual public string Name { get; set; }
        public Node(string name)
        {
            Name = name;
        }
        abstract public void Add(Node node);
        abstract public void Remove(Node node);
        abstract public Node GetById(int idx);
        abstract public void Print();
    }
}
