using System;
using app;
using nodes;

namespace nodetorius
{
    class Program
    {
        static void Main(string[] args)
        {
            app.app main_app = new app.app(1);


            File_Read_String reader_node = main_app.create_node<File_Read_String>();
            reader_node.parameters.Filepath.static_value = "testtext.txt";

            Uppercase_String uNode = main_app.create_node<Uppercase_String>();
            uNode.inputs.Input_Text.connect( reader_node.outputs.text_content );

            Terminal_String_Output output_node = main_app.create_node<Terminal_String_Output>();
            output_node.inputs.Text_Input.connect( uNode.outputs.Formated_Text );

            main_app.loop = () => {return true;};

            main_app.start();
        }
    }
}
