using System.Collections.Generic;

namespace abstracts{
    public abstract class connectable<T>{
        public connectable(){
            this.connections = new List<connectable<T>>();
        }

        public abstract bool connect( connectable<T> target);

        public void add_connection( connectable<T> target ){
            this.connections.Add( target );
        }

        public void remove_connection( connectable<T> target){
            this.connections.Remove( target );
        }

        public Node parent;

        public abstract bool disconnect( int index );
        public abstract bool disconnect( connectable<T> target);
        public abstract bool disconnect();
        public abstract T calculate();
        public List< connectable<T> > connections;
    }
}