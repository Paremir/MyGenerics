using System;
using System.Collections.Generic;
using System.Text;

namespace Bor
{
    class Tree <T>
    {
        private Node<T> root;
        public int Count { get; set; }

        public Tree(T data)
        {
            root = new Node<T>('\0', data);
            Count = 1;
        }
        public void Add(string key,T data)
        {
            AddNode(key, data, root);
            
        }

        private void AddNode(string key, T data, Node<T> node)
        {
            if (key == null)
            {
                if (!node.IsWord)
                {
                    node.Data = data;
                    node.IsWord = true;
                }
            }
            else
            {
                var symbol = key[0];
                var subnode = node.TryFind(symbol);
                if (root.TryFind(symbol) != null)
                {
                    AddNode(key.Substring(1), data,subnode);
                }
                else
                {
                    var newNode = new Node<T>(key[0],data);
                    subnode.SubNodes.Add(key[0], newNode);
                    AddNode(key.Substring(1), data, subnode);
                }
            }
        }
        public void Remove()
        {

        }

        public T Search(string key)
        {

        }
    }
}
