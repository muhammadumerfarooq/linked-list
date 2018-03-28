using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helpdesk
{
    class mynode
    {
        public mynode next;
      //  public mynode previous;
        
        public string data;
        //mynode newnode;
        
    }
    class linklist
    {
        private mynode head;
        private mynode historyhead;
      public  linklist()
        {
            head = null;
            historyhead = null;
        }
        public void addnode(string page)
        {
            historyhead = null;

            mynode newnode = new mynode();
            newnode.data = page;
            newnode.next = null;
          //  newnode.previous = null;
          // newnode.history = false;
            if (head==null)
            {
                head = newnode;
            }
            else
            {
                newnode.next = head;
            //    head.previous = newnode;
                head = newnode;
            }
        }
        public void backwardpage()
        {
            mynode current = head;
           if (current!=null)
            {
                current.data = head.data;
                //current.history = head.history;
                head = head.next;
                current.next = null;

                if (historyhead==null)
                {
                    historyhead = current;
                        
                }
                else
                {
                    current.next = historyhead;
                    historyhead = current;
                }
            }
        }
        public void forwardpage()
        {
            mynode current = historyhead;

            if (current != null)
            {
                historyhead = historyhead.next;
                mynode newnode = new mynode();
                newnode.data = current.data;
                if (head == null)
                {

                    newnode.next = null;
                    head = newnode;
                }
                else
                {

                    newnode.next = head;
                    head = newnode;
                }


            }
        }
        public void showpages()
        {
            Console.WriteLine();
            Console.WriteLine("previously visited pages");
            mynode current = head;
            while(current!=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine("Future Divider Page");
            mynode historynode = historyhead;
            while(historynode != null)
            {
                Console.WriteLine(historynode.data);
                historynode = historynode.next;
            }

            Console.WriteLine();
        }


    }
}
