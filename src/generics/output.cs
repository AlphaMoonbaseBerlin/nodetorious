using abstracts;
using System;

namespace generics{

    public class Output<T>:connectable<T>{
         public Output(Node parent, Func<T> calculator){
            this.parent = parent;
            this.calculate_delegate = calculator;
        }

        public override bool connect(connectable<T> target)
        {
            if ( target.GetType() != typeof( Output<T> ) ){   return false; }

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

        Func<T> calculate_delegate;
        public override T calculate()
        {
            return calculate_delegate();
        }

     
    }
}