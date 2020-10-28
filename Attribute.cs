using System;

namespace composite
{
    class Attribute : Node
    {
        public string Value { get; set; }
        public Attribute(string name) : base(name)
        {
            
        }
        override public void Add(Node node) {
          throw new NotImplementedException();
        }
        override public void Remove(Node node)  {
          throw new NotImplementedException();
        }
        override public Node GetById(int idx)  {
          throw new NotImplementedException();
        }
        override public void Print() {
          System.Console.WriteLine($"Attribute '{Name}' = {Value}");
        }
    }
}
