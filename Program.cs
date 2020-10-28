using System;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Node document = new Element("document");

            Node body = new Element("body");
            Attribute bodyLangAttr = new Attribute("lang");
            bodyLangAttr.Value = "en";
            body.Add(bodyLangAttr);
            Node helloText = new Text("Hello Composite Design Pattern!");
            Node h1 = new Element("h1");
            h1.Add(helloText);
            body.Add(h1);

            Node head = new Element("head");
            Node titleText = new Text("Composite Demo");
            Node title = new Element("title");
            title.Add(titleText);
            head.Add(title);

            document.Add(head);
            document.Add(body);

            new NodePrinter().Print(document);
        }
    }
}
