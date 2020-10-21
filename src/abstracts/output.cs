using System;

namespace abstracts{
    public class Output<T>{
        
        public Func<T> calculate;
        public Node parent;
        public Output(Node parent, Func<T> calculator){
            this.parent = parent;
            this.calculate = calculator;
        }
    }
}