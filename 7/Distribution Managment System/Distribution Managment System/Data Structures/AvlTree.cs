using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace avl
{
    public class Node
    {
        public int data;
        public Node l;
        public Node r;

        public Node(int data)
        {
            this.data = data;
        }
    }

    public class AvlTree
    {
        Node  root;
        
        public void insert(int input)
        {
            Node inserted_node = new Node(input);
            if (root==null)
            {
                root = inserted_node;
            }
            else
            {
                root=Insertv2(root,inserted_node);
            }
        }

        public Node Insertv2(Node root, Node inserted_node) 
        {
            if(root==null)
            {
                root = inserted_node;
            }
            else if(inserted_node.data<root.data)
            {
                root.l=Insertv2(root.l,inserted_node);
                root = balance(root);
            }
            else if (inserted_node.data > root.data)
            {
                root.r = Insertv2(root.r, inserted_node);
                root = balance(root);
            }

            return root;
        }

        public Node balance(Node root)
        {
            int balance = calculate_balance(root);
            if(balance>1)
            {
                if(calculate_balance(root.l)>0)
                {
                    root = LLrotate(root);
                }
                else
                {
                    root = LRrotate(root);
                }
            }

            else if(balance<-1)
            {
                if(calculate_balance(root.r)>0)
                {
                    root = RLrotate(root);
                }
                else
                {
                    root = RRrotate(root);
                }
            }
            return root;
        }

        public int calculate_balance(Node root)
        {
            int l = height(root.l);
            int r = height(root.r);
            int b = l - r;
            return b;
        }

        public Node RLrotate(Node root)
        {
            Node p = root.r;
            root.r = LLrotate(p);
            return RRrotate(root);
        }

        public Node LRrotate(Node root)
        {
            Node p = root.l;
            root.l=RRrotate(p);
            return LLrotate(root);
        }

        public Node LLrotate(Node root)
        {
            Node p = root.l;
            root.l=p.r;
            p.r = root;
            return p;
        }

        public Node RRrotate(Node root)
        {
            Node p = root.r;
            root.r = p.l;
            p.l = root;
            return p;
        }

        public int search(int n)
        {
            if((retrieve(root,n).data)==n)
            {
                return n;
            }
            else
            {
                return -1;
            }
        }

        public Node retrieve(Node root, int n)
        {
            if(root==null)
            {
                return null;
            }
            else if(root.data==n)
            {
                return root;
            }
            else if(n<root.data)
            {
                return retrieve(root.l, n);
            }
            else if(n>root.data)
            {
                return retrieve(root.r, n);
            }

            return root;
        }

        public void showtree()
        {
            if (root == null)
            {
                Console.WriteLine("Tree empty");
                return;
            }
            else
            {
                PreOrderTraversal(root);
                //Inordertraversal(root);
            }

        }

        public void Inordertraversal(Node root)
        {
            if(root!=null)
            {
                Inordertraversal(root.l);
                Console.WriteLine(root.data);
                Inordertraversal(root.r);
            }
        }

        public void PreOrderTraversal(Node root)
        {
            if (root!= null)
            {
                Console.WriteLine(root.data);
                PreOrderTraversal(root.l);
                PreOrderTraversal(root.r);
            }
        }

        public int getmax(int l, int r)
        {
            return l > r ? l : r;
        }

        public int height(Node root)
        {
            int h = 0;
            if(root!=null)
            {
                int l = height(root.l);
                int r = height(root.r);
                int x=getmax(l, r);
                h=x+1;
           
            }
            return h;
        }

        public void delete(int n)
        {
            root = remove(root,n);
        }

        public Node remove(Node root,int n)
        {
            Node p;
            if(root==null)
            {
                return null;
            }
            else
            {
                if(n<root.data)
                {
                    root.l = remove(root.l, n);
                    if(calculate_balance(root)==-2)
                    {
                        if(calculate_balance(root.r)<=0)
                        {
                            root=RRrotate(root);
                        }
                        else
                        {
                            root = RLrotate(root);
                        }
                    }
                }
                else if(n>root.data)
                {
                    root.r = remove(root.r, n);
                    if(calculate_balance(root)==2)
                    {
                        if(calculate_balance(root.l)>=0)
                        {
                            root = LLrotate(root);
                        }
                        else
                        {
                            root=LRrotate(root);
                        }    
                    }
                }
                else
                {
                    if (root.r != null)
                    {
                       
                        p = root.r;
                        while (p.l != null)
                        {
                            p = p.l;
                        }
                        root.data = p.data;
                        root.r = remove(root.r,p.data);
                        if (calculate_balance(root) == 2)
                        {
                            if (calculate_balance(root.l) >= 0)
                            {
                                root = LLrotate(root);
                            }
                            else 
                            { 
                                root = LRrotate(root); 
                            }
                        }
                    }
                    else
                    {   
                        return root.l;
                    }
                }
            }
            return root;

        }
    
    }

   

}
