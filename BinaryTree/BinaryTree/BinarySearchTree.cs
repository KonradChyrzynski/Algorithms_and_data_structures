using System.Xml.Linq;

namespace BinaryTreeNs
{
    class GFG
    {
        static public void Main()
        {
            Console.WriteLine("Main Method");
        }
    };

    public class BinaryTree 
    {
        public class BinaryTreeNode 
        {
            public BinaryTreeNode(int _value) 
            {
                value = _value;
                parent = null;
                left = null;
                right = null;
            }

            public BinaryTreeNode parent;
            public BinaryTreeNode left;
            public BinaryTreeNode right;
            public int value;
        }

        private int size;
        private BinaryTreeNode root;

        // O(logn)
        public bool add(int value) 
        {
            BinaryTreeNode newNode = new BinaryTreeNode(value);
            if (root == null)
            {
                root = newNode;
                size++;
                return true;
            }
            else 
            {
                BinaryTreeNode current = this.root;
                while (true) 
                {
                    if (current.value == value) 
                    {
                        return false;
                    }
                    if (current.value > newNode.value)
                    {
                        if (current.left == null)
                        {
                            newNode.parent = current;
                            current.left = newNode;
                            size++;
                            break;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                    else if (current.value < newNode.value) 
                    {
                        if (current.right == null)
                        {
                            newNode.parent = current;
                            current.right = newNode;
                            size++;
                            break;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                }
            }
            return true;
        }

        public BinaryTreeNode maxNode(BinaryTreeNode entryNode = null)
        {

            BinaryTreeNode node = entryNode == null ? this.root : entryNode;
            while (node.right != null) 
            {
                node = node.right;
            }
            return node;
        }

        public BinaryTreeNode minNode(BinaryTreeNode entryNode = null) 
        {
            BinaryTreeNode node = entryNode == null ? this.root : entryNode;
            while (node.left != null)
            {
                node = node.left;
            }
            return node;
        }

        //public BinaryTreeNode succesorOfANode(BinaryTreeNode entryNode) 
        //{
        //    if (entryNode.right != null) 
        //    {
        //        return minNode(entryNode.right);
        //    }
        //    BinaryTreeNode tempNode = entryNode.parent;
        //    while (tempNode.left != entryNode && tempNode != null) 
        //    {

        //    }
        //}

        //    define BST_FIND_SUCCESSOR(Node):
        //if (Node->right != NULL)
        //    return BST_SEARCH_MIN_KEY(Node->right)
        //Node_tmp = Node->parent
        //while (Node_tmp != NULL and Node_tmp->left != Node)
        //    Node = Node_tmp
        //    Node_tmp = Node_tmp->parent
        //return Node_tmp

        public List<int> in_order_traversal() 
        {
            List<int> outputarray = new List<int> ();
            Stack<int> stack = new Stack<int>();
            BinaryTreeNode current = this.root;
            while (stack.Count == 0 || current != null) 
            {
                while (current != null) 
                {
                    stack.Push(current.value);
                    current = current.left;
                }

                outputarray.Add(stack.Pop());
                current = current.right;
            }

            return outputarray;
        }


        public bool find(int value) 
        {
            if (root == null) return false;
            return find(value, root);
        }

        // O(logn)
        public bool find(int value, BinaryTreeNode node) 
        {
            if (value == node.value) return true;
            if (value < node.value && node.left == null) return false;
            if (value > node.value && node.right == null) return false;
            if (value < node.value) return find(value, node.left);
            return find(value, node.right);
        }

    }
}