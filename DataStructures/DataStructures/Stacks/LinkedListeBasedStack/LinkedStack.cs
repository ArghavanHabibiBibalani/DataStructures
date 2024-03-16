﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedLists.DoblyLinkedList;
using DataStructures.LinkedLists.SinglyLinkedList;

namespace DataStructures.Stacks.LinkedListeBasedStack
{
    internal class LinkedStack<E> : IStack<E>
    {
        private IDoublyLinkedList<E> list = new DoublyLinkedList<E>();

        public LinkedStack(IDoublyLinkedList<E> l)
        {
            list = l;
        }

        public int Size()
        {
            return list.Size;
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public E Pop()
        {
            return list.RemoveFirst();
        }

        public void Push(E e)
        {
            list.AddFirst(e);
        }

        public E Top()
        {
            return list.FirstElement();
        }

        
    }
}
