using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
    internal class DoublyLinkedList<E>
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
            public E getElement() 
            { 
                return element; 
            }

            public Node<E> getNext()
            {
                return next;
            }

            public Node<E> getPrev()
            {
                return prev;
            }

            public void setPrev(Node<E> p)
            {
                prev = p;
            }

            public void setNext(Node<E> n)
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
            header.setNext(trailer);
        }

        public int getSize()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }
        
        public E firstElement()
        {
            E first;

            if (isEmpty())
            {
                first = default(E);
            }
            else
            {
                first = header.getNext().getElement();
            }

            return first;
        }

        public E lastElement()
        {
            E last ;

            if (isEmpty())
            {
                last = default(E);
            }
            else
            {
                last = header.getPrev().getElement();
            }

            return last;
        }

        public void addFirst(E e)
        {
            addBetween(e, header, header.getNext());
        }

        public void addLast(E e)
        {
            addBetween(e, trailer.getPrev(), trailer);
        }

        public E removeFirst()
        {
            E result;
            if (isEmpty())
            {
                result = default(E);
            }
            else
            {
                result = removeNode(header.getNext());
            }

            return result;

        }

        public E removeLast()
        {
            E result;
            if (isEmpty())
            {
                result = default(E);
            }
            else
            {
                result = removeNode(trailer.getPrev());
            }

            return result;

        }

        private void addBetween(E e, Node<E> preducessor,  Node<E> successor)
        {
            Node<E> newNode = new Node<E>(e, preducessor, successor);

            preducessor.setNext(newNode);
            successor.setPrev(newNode);

            size++;
        }

        private E removeNode(Node<E> node)
        {
            Node<E> preducessor = node.getPrev();
            Node<E> successor = node.getNext();

            preducessor.setNext(successor);
            successor.setPrev(preducessor);

            size--;

            return node.getElement();
        }

    }
}
