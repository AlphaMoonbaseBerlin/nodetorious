using System;

using nodes;
namespace nodetorius
{
    class Program
    {
        static void Main(string[] args)
        {
           Static_String myNode = new Static_String( "Foo Bar" );
           Console.WriteLine( myNode.outputs.Formated_Text.calculate() );
           myNode.parameters.Text_Content.static_value = "Changing it arround and getting the calculation";
           Console.WriteLine( myNode.outputs.Formated_Text.calculate() );
            
        }
    }
}
