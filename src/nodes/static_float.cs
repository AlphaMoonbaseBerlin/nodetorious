using abstracts;
using parameters;
using System;
using generics;

namespace nodes{

    public class Static_Float:Node{
        public Static_Float( string name = "Default Static String" ): base(name){
        }

        //Output Definition
        public new struct output_struct{
            public Output<float> Static_Float;
        };
        public new output_struct outputs = new output_struct();
        
        public override void init_outputs(){
            this.outputs.Static_Float = new Output<float>(this, () => { return this.parameters.Float_Value.calculate();}) ;
        }
        
        // Parameter Definition
        public new struct parameter_struct{
            public Float_Parameter Float_Value;
        }
        public new parameter_struct parameters = new parameter_struct();
        
        public override void init_params(){
            this.parameters.Float_Value = new Float_Parameter("Text Content", 1.0f);
        }
    }

}