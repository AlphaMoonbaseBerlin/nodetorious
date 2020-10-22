using abstracts;
using parameters;
using System;
using generics;

namespace nodes{

    public class Terminal_String_Output:Node{

        //-- Init --//

        public Terminal_String_Output( string name = "Default Terminal_String_Output" ): base(name){
            // Implement logic for initialisation
        }

        //-- Node Logic Definition --//
        public override void tick( long tick_index ){
            Console.WriteLine( this.inputs.Text_Input.calculate() );
        }


        //Following Definitions are all optional

        //-- Input Definition --//
        public new struct input_struct
        {   
            public Input<string> Text_Input;
        }
        public new input_struct inputs = new input_struct();
        public override void init_inputs()
        {
            this.inputs.Text_Input = new Input<string>(this);
        }
    }

}