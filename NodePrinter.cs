using System;

namespace composite
{
    class NodePrinter
    {
        public void Print(Node node) {
          if (node != null)
          {
              node.Print();
              if(node.GetType() == typeof(Element)) {
                foreach (Node child in ((Element)node).Children)
                {
                  if (child != null)
                  {
                      Print(child);
                  }
                }
              }
          }
        }
    }
}
