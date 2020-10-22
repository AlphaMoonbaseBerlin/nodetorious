namespace abstracts{
    abstract public class Parameter<T>{
        public int mode;
        public string label;
        public T static_value;
        public Parameter(string label, T start_value) {
            this.label = label;
            this.static_value = start_value;
        }
        public abstract T calculate();

    }
}