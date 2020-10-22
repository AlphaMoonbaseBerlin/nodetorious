using abstracts;
using parameters;
using System;
using generics;

namespace nodes{

    public class Uppercase_String:Node{
        public Uppercase_String( string name = "Default Uppercase" ): base(name){
            this.parameters.Text_Content.static_value = "Not so fast my boy";
        }

        public new struct input_struct
        {
            public Input<string> Input_Text;
        }
        public new input_struct inputs = new input_struct();

        public override void init_inputs()
        {
            this.inputs.Input_Text = new Input<string>(this);
        }

        //Output Definition
        public new struct output_struct{
            public Output<string> Formated_Text;
        };
        public new output_struct outputs = new output_struct();
        
        public override void init_outputs(){
            this.outputs.Formated_Text = new Output<string>(this, () => { return this.inputs.Input_Text.calculate().ToUpper();}) ;
        }
        
        // Parameter Definition
        public new struct parameter_struct{
            public String_Parameter Text_Content;
        }
        public new parameter_struct parameters = new parameter_struct();
        
        public override void init_params(){
            this.parameters.Text_Content = new String_Parameter("Text Content", "Hello World");
        }
    }

}