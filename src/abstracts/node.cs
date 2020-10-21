using System;


namespace abstracts
{
    abstract public class Node{
        string name;

        public Node(string name){
            this.name = name;
            this.init_inputs();
            this.init_outputs();
            this.init_params();
        }
        
        public abstract void tick( Int64 tick_index );
        public virtual void init_params(){}
        public virtual void init_outputs(){}
        public virtual void init_inputs(){}
        public Input[] inputs;
        public struct output_struct{};
        public output_struct outputs; 
        public struct parameter_struct{};
        public parameter_struct parameters;

    }
}