using abstracts;
using parameters;
using System;
using generics;

namespace nodes{

    public class File_Read_String:Node{

        //-- Init --//

        public File_Read_String( string name = "Default File Read", string filepath = "" ): base(name){
            this.parameters.Filepath.static_value = filepath;
        }

        //-- Node Logic Definition --//
        public override void tick( long tick_index ){
            // Implement logic that will be called every frame. 
            // Can be uncommented when not implemented
        }


        //Following Definitions are all optional


        //-- Output Definition --//
        public new struct output_struct{
            //Uncomment for definition ->
            public Output<string> text_content;
            //can be accese by this.output_name
        };
        public new output_struct outputs = new output_struct();
        
        public override void init_outputs(){
            //Uncomment for definition ->
            this.outputs.text_content = new Output<string>(this, () => { 
                string filepath = this.parameters.Filepath.calculate();
                
                return System.IO.File.Exists(filepath) ? System.IO.File.ReadAllText( filepath ) : "";
                } );
            //has to match the the definition of the struct
            //define a delegate function as the seconds arguments for custom calculation logic.
            
        }
        
        //-- Parameter Definition --//
        public new struct parameter_struct{
            //Uncomment for definition ->
            public String_Parameter Filepath;
            //can be accesed via this.parameters.Parameter_Name
        }
        public new parameter_struct parameters = new parameter_struct();
        
        public override void init_params(){
            //Uncomment for definition ->
            this.parameters.Filepath = new String_Parameter("Filepath", "");
            //has to match parameter struct.
        }
    }

}