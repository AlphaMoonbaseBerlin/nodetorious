using abstracts;

namespace generics{

    public class Input<T>:connectable<T>{
        public Input( Node parent){
            this.parent = parent;
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

        public override T calculate()
        {
            return this.connections[0].calculate();
        }
    }
}