using abstracts;
using parameters;
using System;
using generics;

namespace nodes{

    public class Float_To_String:Node{
        public Float_To_String( string name = "Default Float To String" ): base(name){
        }

        

        public new struct input_struct
        {
            public Input<float> Input_Float;
        }
        public new input_struct inputs = new input_struct();

        public override void init_inputs()
        {
            this.inputs.Input_Float = new Input<float>(this);
        }

        //Output Definition
        public new struct output_struct{
            public Output<string> Formated_Text;
        };
        public new output_struct outputs = new output_struct();
        
        public override void init_outputs(){
            this.outputs.Formated_Text = new Output<string>(this, () => { return this.inputs.Input_Float.calculate().ToString();}) ;
        }
        
    }

}