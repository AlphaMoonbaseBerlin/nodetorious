using abstracts;
using parameters;
using System;

namespace nodes{

    public class Static_String:Node{
        public Static_String( string name ): base(name){
            this.parameters.Text_Content.static_value = "Not so fast my boy";
        }

        public override void tick( long tick_index ){
            Console.WriteLine( this.parameters.Text_Content.calculate() );
        }

        //Output Definition
        public new struct output_struct{
            public Output<string> Formated_Text;
        };
        public new output_struct outputs = new output_struct();
        
        public override void init_outputs(){
            this.outputs.Formated_Text = new Output<string>(this, () => { return this.parameters.Text_Content.calculate();}) ;
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