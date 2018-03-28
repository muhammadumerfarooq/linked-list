using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helpdesk
{
    class node
    {
        public string page;
        public node next;     /***  using here two pointers one that points from head to below and one that points from head to above like stack
                                    when element is inserted it is always inserted on top of head  */
        public node prev;
        public node ()
        {

        } 
    }
    class linkedlist
    {
        private node head;

       public linkedlist()      // as we can see that in document that the head always contians string like "pages in your future so
        {                        // i m inserting the node on head whose noe previous and next pointers are null
            node newnode = new Helpdesk.node();
            newnode.page = "Pages in your 'future'";
            newnode.next = null;
            newnode.prev = null;
            head = newnode;
        }

        public void printnodes()   // printing a node is simple it start from head and goes to top then it preints from top to bottom
        {
            node curnode = head;
            while(curnode.prev!=null)
            {
                curnode = curnode.prev;
            }
            Console.WriteLine("Printing Elements from tail to top");
            while (curnode!=null)
            {
                Console.WriteLine(curnode.page);
                curnode = curnode.next;
            }

        }
        public void insertpage(String s)   // insert page is simple we are inserting it on top of head always so a new node a created 
        {                                   // then a temporary node start from head and reaches to top where it check if theere is no more node on top
            node curnode = head;           // then it inserts the new node there 
            while(curnode.prev!=null)
            {
                curnode = curnode.prev;
            }
            node newnode = new node();
            newnode.page = s;
            newnode.prev = null;
            curnode.prev = newnode;
            newnode.next = curnode;
        }
        public void forward()  // in forward method the node that is blow then head it is removed then it is placed on top of list 
        { 
            node mynode = null;
            node headnext = head;
            if (headnext.next!=null)
            {
                mynode = headnext.next;
                headnext.next = mynode.next;
                mynode.next = null;
                mynode.prev = null;
            }
            if (mynode != null) { 
            node curnode = head;
            while (curnode.prev != null)
            {
                curnode = curnode.prev;
            }

            curnode.prev = mynode;
            mynode.next = curnode;
            }
        }
        public void backward()
        {
            // in  backward method the node that is on top of list is moved down to head so first we place a temporary node
            // in which head is placed and temporary node moves to top and finds the top most node then it takes that node or removes that node from top 
            // and place it under  the head node 
            node prevtop = head;
            node topnode = head;
            while(topnode.prev!=null)
            {
                prevtop = topnode;
                topnode = topnode.prev;
            }
            if (topnode != prevtop) { 
            prevtop.prev = null;
            topnode.next = null;
            topnode.prev = null;

            node curnode = head;
            topnode.next = curnode.next;
            curnode.next = topnode;
            topnode.prev = curnode;
            }
        }
    }
}
