using System;


namespace abstracts
{
    abstract public class Node{
        string name;

        public Node(string name = "Default Name"){
            this.name = name;
            this.init_inputs();
            this.init_outputs();
            this.init_params();
        }
        
        public virtual void tick( Int64 tick_index ){}
        public virtual void init_params(){}
        public virtual void init_outputs(){}
        public virtual void init_inputs(){}
        
        protected struct storage {};

        public struct input_struct{};
        public input_struct inputs;

        public struct output_struct{};
        public output_struct outputs; 

        public struct parameter_struct{};
        public parameter_struct parameters;

        public struct callback_struct{};
        public callback_struct callbacks;
    }
}