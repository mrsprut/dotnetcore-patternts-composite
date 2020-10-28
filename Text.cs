using System;

namespace composite
{
    class Text : Node
    {
        override public string Name { get {return "text";} set {}}
        public string Value { get; set; }
        public Text(string value) : base(value)
        {
            Value = value;
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
          System.Console.WriteLine($"Text = {Value}");
        }
    }
}
