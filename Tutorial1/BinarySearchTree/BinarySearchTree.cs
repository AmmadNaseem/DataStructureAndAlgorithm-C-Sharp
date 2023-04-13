using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tutorial1.LinkedList;

namespace Tutorial1.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;
        public void Insert(int key,string value) {
            Root = InsertItem(Root,key,value);
        }

        //========================= IN ORDER TRAVERSAL===================   
        public void PrintInOrderTraversal()
        {
            InOrderTraversal(Root);
        }

        private void InOrderTraversal(TreeNode node)
        {
            if (node !=null)
            {
                InOrderTraversal(node.LeftChild);
                Console.WriteLine(node.Key+ " " +node.Value);   
                InOrderTraversal(node.RightChild);
            }

        }

        //=======================PRE- ORDER TRAVERSAL==============
        public void PrintPreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }

        private void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Key + " " + node.Value);
                PreOrderTraversal(node.LeftChild);
                PreOrderTraversal(node.RightChild);
            }

        }

        //=======================POST- ORDER TRAVERSAL==============
        public void PrintPostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }

        private void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.LeftChild);
                PostOrderTraversal(node.RightChild);
                Console.WriteLine(node.Key + " " + node.Value);

            }

        }

        //================print trees===============
        public void PrintRandomNodes(TreeNode node)
        {
      
            if (node == null) return;

            // Print the current node's value
            Console.Write(node.Key+ " "+ node.Value + "\n ");

            // Randomly traverse the left and right subtrees
            Random rand = new Random();
            if (rand.Next(2) == 0)
            {
                PrintRandomNodes(node.LeftChild);
                PrintRandomNodes(node.RightChild);
            }
            else
            {
                PrintRandomNodes(node.RightChild);
                PrintRandomNodes(node.LeftChild);
            }
        }



        public TreeNode InsertItem(TreeNode node,int key,string value) {

            TreeNode newNode = new TreeNode(key,value);

            //if this is the first time you insert, create the root
            if (node==null)
            {
                node = newNode;
                return node;
            }

            //if this is the first insert,traverse,find null,insert
            if (key<node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild=InsertItem(node.RightChild,key,value);
            }

            return node;

        }

        //================tranverse the tree===============
        public string Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;

        }
        private TreeNode? Find(TreeNode node, int key)
        {
            if (node ==null || node.Key==key)
            {
                return node;
            }
            else if (key<node.Key)
            {
                return Find(node.LeftChild, key);
            }
            else if(key>node.Key)
            {
                return Find(node.RightChild, key);
            }
            return null;
        }
    }
}
