using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.ArboriN
{
    public class ArboriN<T> where T : IComparable<T>
    {

        private TreeNodeN<T> _root = null;

        public TreeNodeN<T> getNode()
        {
            return _root;
        }

        public void afisare(TreeNodeN<T> node)
        {
            if (node != null)
            {

                Console.WriteLine(node.Value);
                if (node.Data != null)
                    for (int i = 0; i < node.Data.Count; i++)
                    {

                        afisare(node.Data[i]);

                    }
            }

        }

        public TreeNodeN<T> findByValue(TreeNodeN<T> node, T value)
        {
            if (node != null)
            {
                if (node.Value.CompareTo(value) == 2)
                {
                    return node;
                }

                for (int i = 0; i < node.Data.Count; i++)
                {

                    return findByValue(node.Data[i], value);

                }
            }

            return null;
        }

        public void Add(T parinte, T value)
        {

            if (_root == null || parinte == null)
            {
                _root = new TreeNodeN<T>();

                _root.Value = value;
                _root.Data = new List<TreeNodeN<T>>();

            }
            else
            {

                TreeNodeN<T> aux = findByValue(_root, parinte);

                TreeNodeN<T> nou = new TreeNodeN<T>();
                nou.Value = value;
                nou.Data = new List<TreeNodeN<T>>();
                if (aux.Data != null)
                    aux.Data.Add(nou);
                else
                {
                    aux.Data = new List<TreeNodeN<T>>() { nou};
                }

            }


        }

        public TreeNodeN<T> findByCopil(TreeNodeN<T> node, T value)
        {
            if (node != null)
            {
                for (int i = 0; i < node.Data.Count; i++)
                {
                    if (node.Data[i].Value.CompareTo(value) == 2)
                    {
                        return node;
                    }
                }

                for (int i = 0; i < node.Data.Count; i++)
                {

                    return findByCopil(node.Data[i], value);

                }
            }

            return null;
        }

        public void stergere(T value)
        {

            TreeNodeN<T> parinte = findByCopil(_root,value);

            for(int i=0;i<parinte.Data.Count;i++)
            {
                if (parinte.Data[i].Value.CompareTo(value) == 2)
                {
                    parinte.Data.RemoveAt(i);
                }
            }

        }



    }
}
