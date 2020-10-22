using nodes;
using System;
using System.Collections.Generic;

using abstracts;


namespace app{

    public class app{

        public app(int fps){
            this.Nodes = new System.Collections.Hashtable();
            this.sleep_time = 1000/fps;
            this.milliseconds_elapsed = 0;
            this.running = true;
        }
        Int32 sleep_time;
        Int64 milliseconds_elapsed;
        public Func<bool> loop;
        bool running;

        public void start(){
            this.running = true;
            this._loop();
        }

        public void stop(){
            this.running = false;
        }

        void _loop(){
            this.loop();
            this.tick_nodes();
            System.Threading.Thread.Sleep( this.sleep_time );
            this.milliseconds_elapsed += this.sleep_time;
            if ( this.running) { this._loop(); }
        }
        void tick_nodes(){
            foreach(System.Collections.DictionaryEntry entry in this.Nodes){
                Node next_node = (Node)entry.Value;
                next_node.tick( this.milliseconds_elapsed );
            }
        }


        public T create_node<T>()
            where T : Node
        {
            string id = Guid.NewGuid().ToString();
            Type Nodetype = typeof(T);
            
            T newNode = (T)Convert.ChangeType( Activator.CreateInstance(Nodetype, id), Nodetype);
            this.Nodes.Add(id, newNode);
            return newNode;
        }

        public T get_node<T>( string id){
            object node_from_hash = this.Nodes[id];
            
            if ( node_from_hash.GetType() != typeof(T) ){ 
                return default(T); 
            }
            return (T)Convert.ChangeType( node_from_hash, typeof(T) );
        }
        
        System.Collections.Hashtable Nodes;
        
    }
}