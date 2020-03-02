using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tree
    {
        //member varaibles 
        TreeNode root;

        // constructor
        public Tree()
        {
            root = null;
        }

        // member methods
        
        public void AddToTree(int value)
        {
            TreeNode newNode = new TreeNode();
            newNode.value = value;

            if (root == null)
            {
                this.root = newNode;
            }
            else
            {
                SearchTree(this.root, value);
            }
        }
        public void SearchTree(TreeNode newRoot, int i)
        {
            if ( i > newRoot.value)
            {
                if (newRoot.rightNode == null)
                {
                    newRoot.rightNode = new TreeNode();
                    newRoot.rightNode.value = i;
                }
                else
                {
                    SearchTree(newRoot.rightNode, i);
                }
                
               
            }
            else
            {
                if ( newRoot.leftNode == null)
                {
                    newRoot.leftNode = new TreeNode();
                    newRoot.leftNode.value = i;
                }
                else
                {
                    SearchTree(newRoot.leftNode, i);
                }
             
            }
        }

    }
}
