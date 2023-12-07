using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Arborii
{
    public class TreeNode : IComparable<TreeNode>
    {

        public TreeNode Left {  get; set; }

        public TreeNode Right {  get; set; }

        public string Data { get; set; }

        public int CompareTo(TreeNode? other)
        {
            throw new NotImplementedException();
        }
    }
}
