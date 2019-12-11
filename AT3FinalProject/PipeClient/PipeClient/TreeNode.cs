﻿// Bryce Huston
// 30003673
// 10/12/2019
// Programming III
// AT3 Project

namespace PipeClient
{
    class TreeNode<T>
    {
        public T Element { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T element)
        {
            this.Element = element;
        }

        public override string ToString()
        {
            string nodeString = "[" + this.Element + " ";

            // Leaf node
            if (this.Left == null && this.Right == null)
            {
                nodeString += " (Leaf) ";
            }

            if (this.Left != null)
            {
                nodeString += "Left: " + this.Left.ToString();
            }

            if (this.Right != null)
            {
                nodeString += "Right: " + this.Right.ToString();
            }

            nodeString += "] ";

            return nodeString;
        }

    }
}
