using System;
using System.Collections.Generic;
using System.Text;

namespace Helpdesk
{

    class History
    {
        //linkedlist list;
        linklist list;
        public History()
        {
            //     list = new linkedlist(); 
            list = new linklist();
        }
        public void PrintAll()
        {
            //       list.printnodes();
            list.showpages();

        }

        public void MoveBackwards()
        {
            list.backwardpage();
        }

        public void MoveForwards()
        {
            list.forwardpage();
        }

        public void VisitPage(string desc)
        {
            //        list.insertpage(desc);
            list.addnode(desc);
        }
    }
}
