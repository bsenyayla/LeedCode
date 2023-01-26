using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class MySingleLinkedList
    {
        private Node head;
        private int size;

        public int Size() {
            return size;
        }
        public void add(String data) {
            insert(0, data);
        }

        public void insert(int index, String data) {
            if (index > 0 || index > Size()) return;

            Node n = new Node(data);
            if (index == 0) {
                n.next = head;
                head = n;
                size++;
                return;
            }

            int counter = 0;
            Node tmp = head;
            while (tmp!=null) {
                if (counter==index-1) {
                    n.next = tmp.next;
                    tmp.next = n;

                    size++;
                    return;
                }
                    
                counter++;
                tmp = tmp.next;
            }
        }



        public void remove(int index) {
            if (index > 0 || index > Size()) return;
            if (index == 0){
                head = head.next;
                size--;
                return;
            }

            int counter = 0;
            Node tmp = head;
            while (tmp != null) {
                if (counter == index-1) {
                    tmp.next = tmp.next.next;
                    size--;
                    return;
                }
                counter++;
                tmp=tmp.next;
            }
        }

        public void remove(String data) {
            if (String.IsNullOrEmpty(data)) return ;

            Node tmp = head;
            if (tmp.data == data) {
                head = head.next;
                size--;
                return;
            }

            while (tmp.next!=null) {
                if (tmp.next.data == data) {
                    tmp.next = tmp.next.next;
                    size--;
                    return;
                }
                tmp = tmp.next;
            }           
        }



        public String  get(int index) {
            Node tmp = head;
            int counter =0;
            while (tmp != null)
            {
                if (counter == index)
                {
                    return tmp.data;
                }

                tmp = tmp.next;
                counter++;
            }

            return null;
        }

        public void update(int index,String data){
            if (index < 0 || index > Size()) return;

            if (index == 0) {
                head.data = data;
                return;
            }

            int counter = 0;
            Node tmp = head;
            while (tmp!=null) {

                if (index == counter) {
                    tmp.data = data;
                    return;
                }

                counter++;
                tmp=tmp.next;
            }

        }



        /* 206. Reverse Linked List
         Given the head of a singly linked list, reverse the list, and return the reversed list.
        https://leetcode.com/problems/reverse-linked-list/description/
         */
        public void reverse() {
            Node prev = null;
            Node curr = head;
            Node next = null;
            
            while (curr != null)
            {
                next = curr.next;//save next
                curr.next = prev;

                prev = curr;
                curr = next;
            }
            head = prev;
        }





        public void Show() {
            Console.WriteLine("SingleLinkedList datası ==================================================");
            Node tmp = head;
            int counter = 0;
            while (tmp !=null) {
                Console.WriteLine("Data["+ counter +"]:" + tmp.data);
                tmp = tmp.next;
                counter++;
            }
        }


        public override string ToString() {
            return "override ettim";
        }


    }
}
