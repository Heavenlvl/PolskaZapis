using System;

namespace PolskaZapis
{
    internal sealed class LinkedNode<T>
    {
        internal T Data { get; }
        internal LinkedNode<T> Link { get; set; }
        internal LinkedNode(T data = default) => Data = data;
    }
}