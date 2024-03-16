using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
    public class DoublyLinkedList<E> : IDoublyLinkedList<E>
    {
        private class Node<E>
        {
            private E element;
            private Node<E> prev;
            private Node<E> next;

            public Node(E e, Node<E> p, Node<E> n)
            {
                element = e;
                prev = p;
                next = n;
            }
            public E GetElement()
            {
                return element;
            }

            public Node<E> GetNext()
            {
                return next;
            }

            public Node<E> GetPrev()
            {
                return prev;
            }

            public void SetPrev(Node<E> p)
            {
                prev = p;
            }

            public void SetNext(Node<E> n)
            {
                next = n;
            }
        }

        private Node<E> header;
        private Node<E> trailer;
        private int size = 0;

        public DoublyLinkedList()
        {
            header = new Node<E>(default(E), null, null);
            trailer = new Node<E>(default(E), header, null);
            header.SetNext(trailer);
        }

        public int Size => size;

        public bool IsEmpty()
        {
            return size == 0;
        }

        public E FirstElement()
        {
            if (IsEmpty())
            {
                return default(E);
            }
            return header.GetNext().GetElement();
        }

        public E LastElement()
        {
            if (IsEmpty())
            {
                return default(E);
            }
            return trailer.GetPrev().GetElement();
        }

        public void AddFirst(E e)
        {
            AddBetween(e, header, header.GetNext());
        }

        public void AddLast(E e)
        {
            AddBetween(e, trailer.GetPrev(), trailer);
        }

        public E RemoveFirst()
        {
            if (IsEmpty())
            {
                return default(E);
            }
            return RemoveNode(header.GetNext());
        }

        public E RemoveLast()
        {
            if (IsEmpty())
            {
                return default(E);
            }
            return RemoveNode(trailer.GetPrev());
        }

        private void AddBetween(E e, Node<E> predecessor, Node<E> successor)
        {
            Node<E> newNode = new Node<E>(e, predecessor, successor);

            predecessor.SetNext(newNode);
            successor.SetPrev(newNode);

            size++;
        }

        private E RemoveNode(Node<E> node)
        {
            Node<E> predecessor = node.GetPrev();
            Node<E> successor = node.GetNext();

            predecessor.SetNext(successor);
            successor.SetPrev(predecessor);

            size--;

            return node.GetElement();
        }

        public override string ToString()
        {
            string output = "{ ";
            Node<E> current = header.GetNext();
            for (int i = 0; i < size; i++)
            {
                output += current.GetElement().ToString();
                if (i != size - 1)
                {
                    output += ", ";
                }
                current = current.GetNext();
            }
            output += " }";
            return output;
        }
    }
}
