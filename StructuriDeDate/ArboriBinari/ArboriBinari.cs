using StructuriDeDate.Coada.interfaces;
using StructuriDeDate.Coada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.ArboriBinari
{
    public class ArboriBinari<T> where T : IComparable<T>
    {


        private TreeNode<T> _root = null;

        public TreeNode<T> getNode() { return _root; }


        public void add(T data, TreeNode<T> aux)
        {
            if (_root == null)
            {
                _root = new TreeNode<T>();

                _root.Left = null;
                _root.Right = null;
                _root.Data = data;
                //  Console.WriteLine(_root.Data);
            }
            else
            {
                TreeNode<T> nou = new TreeNode<T>();
                nou.Data = data;
                nou.Left = null;
                nou.Right = null;

                if (aux.Data.CompareTo(data) >0)
                {
                    if (aux.Left == null)
                    {
                        aux.Left = nou;
                       

                    }
                    else
                    {
                        add(data, aux.Left);
                    }
                }
                else
                {
                    if (aux.Right == null)
                    {
                        aux.Right = nou;
                    }
                    else
                    {
                        add(data, aux.Right);
                    }
                }

            }
        }

        public void maximul(T maxi)
        {
           
            ICoada<TreeNode<T>> coada = new Coada<TreeNode<T>>();

            TreeNode<T> root = _root;

            do
            {
                if(root.Data.CompareTo(maxi) >= 1)
                {
                    maxi = root.Data;
                }
                    
                if(root.Left != null)
                    coada.push(root.Left);

                if(root.Right != null)
                    coada.push(root.Right);

                root = coada.top();

                coada.pop();

            }while(root != null);


            Console.WriteLine("User-ul maxim este:\n"+maxi.ToString());
        }

        public void minimul(T mini)
        {

            ICoada<TreeNode<T>> coada = new Coada<TreeNode<T>>();

            TreeNode<T> root = _root;

            do
            {
                if (root.Data.CompareTo(mini) == -1)
                {
                    mini = root.Data;
                }

                if (root.Left != null)
                    coada.push(root.Left);

                if (root.Right != null)
                    coada.push(root.Right);

                root = coada.top();

                coada.pop();

            } while (root != null);


            Console.WriteLine("User-ul Minim este:\n"+mini.ToString());
        }

        //Afisarea pe nivel
        public void afisare()
        {

            ICoada<TreeNode<T>> coada = new Coada<TreeNode<T>>();

            TreeNode<T> treeNode = _root;
            // Console.WriteLine(treeNode.Left.Left.Data);

            do
            {
                Console.WriteLine(treeNode.Data);

                if (treeNode.Left != null)
                {
                    coada.push(treeNode.Left);
                }

                if (treeNode.Right != null)
                {
                    coada.push(treeNode.Right);
                }

                treeNode = coada.top();

                coada.pop();

            } while (treeNode != null);

        }

        //Afisarea in preordine
        public void afisarePreordine(TreeNode<T> start)
        {

            if(start != null) {
                
               Console.WriteLine(start.Data);            

                afisarePreordine(start.Left);
                afisarePreordine(start.Right);
            }



        }

        //Afisarea in inordine
        public void afisareiInordine(TreeNode<T> start)
        {
            if (start != null)
            {
                afisareiInordine(start.Left);
                Console.WriteLine(start.Data);
                afisareiInordine(start.Right);
            }
        }
        
        //Afisarea in postordine
        public void afisarePostordine(TreeNode<T> start)
        {
            if (start != null)
            {
                afisarePostordine(start.Left);
                afisarePostordine(start.Right);
                Console.WriteLine(start.Data);
            }
        }

    }
}
