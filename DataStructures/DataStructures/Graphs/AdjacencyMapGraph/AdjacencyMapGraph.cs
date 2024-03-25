using DataStructures.Lists.PositionalLists.LinkesPositionalList;
using DataStructures.Lists.PositionalLists;

namespace DataStructures.Graphs.AdjacencyMapGraph
{
    public class AdjacencyMapGraph<V, E> : IGraph<V, E>
    {
        private bool isDirected;
        private IPositionalList<IVertex<V>> vertices;
        private IPositionalList<IEdge<E>> edges;
        public AdjacencyMapGraph(bool directed) 
        {
            isDirected = directed;
            vertices = new LinkedPositionalList<IVertex<V>>();
            edges = new LinkedPositionalList<IEdge<E>>();
        }

        public bool IsDirected => isDirected;

        public IEnumerable<IEdge<E>> Edges()
        {
            return (IEnumerable<IEdge<E>>)edges;
        }

        public IVertex<V>[] EndVertices(IEdge<E> e)
        {
            throw new NotImplementedException();
        }

        public IEdge<E> GetEdge(IVertex<V> u, IVertex<V> v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEdge<E>> IncomingEdges(IVertex<V> v)
        {
            InnerVertex<V, E> vert = (InnerVertex<V, E>)v;
            return vert.GetIncoming().Values as IEnumerable<IEdge<E>>;
        }

        public int InDegree(IVertex<V> v)
        {
            InnerVertex<V, E> vert = (InnerVertex<V, E>)v;

            return vert.GetIncoming().Count;
        }

        public IEdge<E> InsertEdge(IVertex<V> u, IVertex<V> v, E element)
        {
            throw new NotImplementedException();
        }

        public IVertex<V> InsertVertex(V element)
        {
            throw new NotImplementedException();
        }

        public int NumEdges()
        {
            return edges.Size();
        }

        public int NumVertices()
        {
            return vertices.Size();
        }

        public IVertex<V> Opposite(IVertex<V> v, IEdge<E> e)
        {
            throw new NotImplementedException();
        }

        public int OutDegree(IVertex<V> v) 
        {
            InnerVertex<V, E> vert = (InnerVertex<V, E>)v;

            return vert.GetOutgoing().Count; //////////??????? is there anything wrong?
        }

        public IEnumerable<IEdge<E>> OutgoingEdges(IVertex<V> v)
        {
            InnerVertex<V, E> vert = (InnerVertex<V, E>)v;
            return vert.GetOutgoing().Values as IEnumerable<IEdge<E>>;
        }

        public void RemoveEdge(IEdge<E> e)
        {
            throw new NotImplementedException();
        }

        public void RemoveVertex(IVertex<V> v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVertex<V>> Vertices()
        {
            return (IEnumerable<IVertex<V>>)vertices;
        }
    }
}
