using abstracts;

namespace parameters{

    public class Float_Parameter:Parameter<float>{
        
        public Float_Parameter(string label, float start_value) : base(label, start_value){

        }
        
        public override float _calculate(){
            return this.static_value;
        }
        
    }
}