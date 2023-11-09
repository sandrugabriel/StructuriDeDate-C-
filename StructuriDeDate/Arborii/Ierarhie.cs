using StructuriDeDate.Coada;
using StructuriDeDate.Coada.interfaces;
using StructuriDeDate.ListaSimpluInlantuita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Arborii
{
    public class Ierarhie
    {

        private TreeNode root = null;

        public TreeNode getTreeNode() { return root; }
        
        public string find(string cautat)
        {
            TreeNode searched = find(root, cautat);
            if (searched != null)
            {
                return searched.Data;
            }
            return null;
        }

        private TreeNode find(TreeNode current, String cautat)
        {

           
            if(current == null) { 
                return null;
            }
            else if(current.Data.Equals(cautat))
            {
                return current;
            }
            
            var left=find(current.Left, cautat);
            if(left != null)
            {
                return left;
            }

            return find(current.Right, cautat);

            
        }

        public void add(string parinte, string copil) { 
        

            if(find(parinte) == null)
            {
                root = new TreeNode();

                root.Left = null;
                root.Right = null;
                root.Data = copil;

            }
            else
            {

                TreeNode nou = new TreeNode();
                nou.Data = copil;
                nou.Left = null;
                nou.Right = null;

                TreeNode aux = find(root, parinte);

                if(aux.Left == null) { 
                
                    aux.Left = nou;
                    return;
                }
                else
                {
                    aux.Right = nou;
                    return;
                }

            }
        
        
        
        }

        public void afisare()
        {
            ICoada<TreeNode> coada = new Coada<TreeNode>();

            TreeNode treeNode = root;

            Console.WriteLine(treeNode.Data);

            treeNode = treeNode.Left;

            do
            {

                Console.WriteLine(treeNode.Data);

                coada.push(treeNode.Left);
                coada.push(treeNode.Right);
                //Console.WriteLine(coada.top().Data) ;
                treeNode = coada.top();

              //  Console.WriteLine(treeNode.Data);

                coada.pop();


            } while (treeNode !=null);

        }



    }
}
