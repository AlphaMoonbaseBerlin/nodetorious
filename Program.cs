using System;

using nodes;
namespace nodetorius
{
    class Program
    {
        static void Main(string[] args)
        {
            
            File_Read_String reader_node = new File_Read_String(filepath: "testtext.txt");

            Uppercase_String uNode = new Uppercase_String();
            uNode.inputs.Input_Text.connect( reader_node.outputs.text_content );

            Console.WriteLine( uNode.outputs.Formated_Text.calculate() );
        }
    }
}
