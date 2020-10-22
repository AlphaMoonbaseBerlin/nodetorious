using System;

using nodes;
namespace nodetorius
{
    class Program
    {
        static void Main(string[] args)
        {
            Static_String myNode = new Static_String( "Foo Bar" );
            Uppercase_String uNode = new Uppercase_String("Uppercase");
            uNode.inputs.Input_Text.connect( myNode.outputs.Formated_Text );
            Console.WriteLine( uNode.outputs.Formated_Text.calculate() );
        }
    }
}
