using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf hr = new Leaf();
            hr.Tag("HR");
            Leaf br = new Leaf();
            br.Tag("BR");
            Container div = new Container();
            div.Tag("DIV");
            div.Add(hr);
            div.Add(br);

            Leaf img = new Leaf();
            img.Tag("img");
            Container span = new Container();
            span.Tag("SPAN");
            span.Add(div);
            span.Add(img);

            Container html = new Container();
            html.Tag("HTML");
            html.Add(span);

            Console.WriteLine("Generated HTML is-");
            Console.WriteLine($"{html.GetInnerHtml()}");
        }
    }
}
