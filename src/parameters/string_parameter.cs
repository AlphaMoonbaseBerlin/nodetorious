using abstracts;

namespace parameters{

    public class String_Parameter:Parameter<string>{
        
        public String_Parameter(string label, string start_value) : base(label, start_value){

        }
        
        public override string _calculate(){
            return this.static_value;
        }
        
    }
}