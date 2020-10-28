using System;
using System.Collections.Generic;

namespace composite
{
    class Element : Node
    {
        public List<Node> Children { get; } = new List<Node>();
        public Element(string name) : base(name)
        {
            
        }
        override public void Add(Node node) {
          Children.Add(node);
        }
        override public void Remove(Node node)  {
          Children.Remove(node);
        }
        override public Node GetById(int idx)  {
          return Children[idx];
        }
        override public void Print() {
          System.Console.WriteLine($"Element '{Name}'");
        }
    }
}
