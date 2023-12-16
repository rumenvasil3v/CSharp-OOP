using System;
using P02.Graphic_Editor.Contracts;

namespace P02.Graphic_Editor
{
    class StartUp
    {
       static void Main(string[] args)
        {
            try
            {
                IShape circle = new Circle();
                GraphicEditor editor = new GraphicEditor();
                editor.DrawShape(circle);

                IShape rectangle = new Rectangle();
                GraphicEditor editor2 = new GraphicEditor();
                editor2.DrawShape(rectangle);

                IShape square = new Square();
                GraphicEditor editor3 = new GraphicEditor();
                editor3.DrawShape(square);

                IShape hexagon = new Hexagon();
                GraphicEditor editor4 = new GraphicEditor();
                editor3.DrawShape(hexagon);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ParamName);
            }
        }
    }
}
