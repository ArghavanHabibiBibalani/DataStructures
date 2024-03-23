using DataStructures.Lists.PositionalLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs.AdjacencyMapGraph
{
    internal class InnerVertex<V, E> : IVertex<V>
    {
        private V element;
        private IPosition<IVertex<V>> position;
        private Dictionary<InnerVertex<V, E>, List<IEdge<E>>> outGoing;
        private Dictionary<InnerVertex<V, E>, List<IEdge<E>>> inComing;

        public InnerVertex(V e, bool graphIsDirected)
        {
            element = e;
            outGoing = new Dictionary<InnerVertex<V, E>, List<IEdge<E>>>();

            if (graphIsDirected)
            {
                inComing = new Dictionary<InnerVertex<V, E>, List<IEdge<E>>>();
            }
            else
            {
                inComing = outGoing;
            }
        }
        public V Vertex => element;

        public void setPosition(IPosition<IVertex<V>> p) 
        { 
            position = p; 
        }

        public IPosition<IVertex<V>> getPosition() 
        { 
            return position; 
        }

        public Dictionary<InnerVertex<V, E>, List<IEdge<E>>> GetOutgoing() 
        {
            return outGoing; 
        }
        public Dictionary<InnerVertex<V, E>, List<IEdge<E>>> GetIncoming() 
        { 
            return inComing; 
        }
    }

}
