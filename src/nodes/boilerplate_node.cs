using abstracts;
using parameters;
using System;
using generics;

namespace nodes{

    public class boilderplate:Node{

        //-- Init --//

        public boilderplate( string name = "Default Uppercase" ): base(name){
            // Implement logic for initialisation
        }

        //-- Node Logic Definition --//
        public override void tick( long tick_index ){
            // Implement logic that will be called every frame. 
            // Can be uncommented when not implemented
        }


        //Following Definitions are all optional

        //-- Input Definition --//
        public new struct input_struct
        {   
            //Uncomment for definition ->
            //public Input<generic_type> input_name;
            //can be accese by this.inputs.input_name
        }

        public new input_struct inputs = new input_struct();

        public override void init_inputs()
        {
            //Uncomment for definition ->
            //this.inputs.input_name = new Input<generic_type>(this);
            //has to match the the definition of the struct
        }

        //-- Output Definition --//
        public new struct output_struct{
            //Uncomment for definition ->
            //public Output<generic_type> output_name;
            //can be accese by this.output_name
        };
        public new output_struct outputs = new output_struct();
        
        public override void init_outputs(){
            //Uncomment for definition ->
            //this.inputs.input_name = new Input<generic_type>(this, () => { return calculation; } );
            //has to match the the definition of the struct
            //define a delegate function as the seconds arguments for custom calculation logic.
            
        }
        
        //-- Parameter Definition --//
        public new struct parameter_struct{
            //Uncomment for definition ->
            //public Type_Parameter Parameter_Name;
            //can be accesed via this.parameters.Parameter_Name
        }
        public new parameter_struct parameters = new parameter_struct();
        
        public override void init_params(){
            //Uncomment for definition ->
            //this.parameters.Text_Content = new String_Parameter(label, start_value);
            //has to match parameter struct.
        }
    }

}