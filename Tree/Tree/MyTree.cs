using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tree
{
    class MyTree
    {
        public TreeNode Root;
        public List<int> list = new List<int>();
        public List<List<int>> mylist = new List<List<int>>();
        public void add(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode();
                Root.Value = value;
                list.Add(Root.Value);
            }
            else
            {
                TreeNode elem = Root;
                elem = equals(value, elem);
                if (elem.Value > value)
                {
                    elem.Left = new TreeNode();
                    elem.Left.Value = value;
                    elem.Left.Parent = elem;
                }
                else 
                {
                    elem.Right = new TreeNode();
                    elem.Right.Parent = elem;
                    elem.Right.Value = value;
                }
            }
        }
        TreeNode equals(int value, TreeNode elem)
        {
            if (value == elem.Value)
            {
                return elem;
            }
            else
            {
                if (value > elem.Value)
                {
                    if (elem.Right == null)
                    {
                        return (elem);
                    }
                    else
                    {
                        elem = elem.Right;
                        return equals(value, elem);

                    }
                }
                else
                {
                    if (elem.Left == null)
                    {
                        return (elem);
                    }
                    else
                    {
                        elem = elem.Left;
                        return equals(value, elem);
                    }
                }
            }
            
        }
        public void delete(int value)
        {   
            TreeNode elem = equals(value, Root);
            TreeNode smena = new TreeNode();
            if (elem.Left != null)
            {
                smena = elem.Left;
                while (smena.Right != null)
                {
                    smena = smena.Right;
                }
                elem.Value = smena.Value;
                smena = null;
            }
            else
            {
                smena = elem.Right;
                while (smena.Left != null)
                {
                    smena = smena.Left;
                }
                elem.Value = smena.Value;
                smena = null;
            }
        }
        public void find(int value)
        {
            TreeNode elem = equals(value, Root);
        }
        public void CLR(TreeNode elem)
        {
            if (elem.Left != null)
                list.Add(elem.Left.Value);
            if (elem.Right != null)
                list.Add(elem.Right.Value);
            if (elem.Left != null)
                CLR(elem.Left);
            if (elem.Right != null)
                CLR(elem.Right);
        }

    }
}
