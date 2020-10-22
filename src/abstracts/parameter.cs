using generics;

namespace abstracts{
    abstract public class Parameter<T>:connectable<T>{
        public int mode;
        public string label;
        public T static_value;
        public Parameter(string label, T start_value) {
            this.label = label;
            this.static_value = start_value;
        }

        public abstract T _calculate();
        public override T calculate()
        {
            if( this.connections.Count > 0) {
                return this.connections[0].calculate();
            }

            return this._calculate();
        }


        public override bool connect(connectable<T> target)
        {
            if ( target.GetType() != typeof( Output<T> ) ){   return false; }
            this.disconnect();

            this.add_connection( target );
            target.add_connection( this );
            return true;
        }

        public override bool disconnect()
        {
            foreach (connectable<T> target in this.connections){
                target.disconnect( this );
            }
            return true;
        }

        public override bool disconnect(connectable<T> target)
        {
            target.remove_connection( this );
            return true;
        }

        public override bool disconnect(int index)
        {
            if ( this.connections.Count >  index ) { return false;}
            connectable<T> target = this.connections[index];
            target.remove_connection( this );
            this.remove_connection( target );

            return true;
        }


    }
}