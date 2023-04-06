using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView_00
{
    class nodeLinkedList
    {
        public Node head;
        public Node tail;
        int size;

        public nodeLinkedList() {
            head = null;
            tail = null;

            size = 0;
        }

        public void insertFirst(int data) {
            Node newNode = new Node(data);
            if (this.head == null) {
                head = newNode;
                size = 0;
            }
            else {
                newNode.next = head;
                head = newNode;
                size++;
            }
        }


        // Insert last node
        public void insertLast(int data) {
            var newNode = new Node(data);
            Node tmp = this.head;

            while (tmp != null) {
                if (tmp.next == null) {
                    tmp.next = newNode;
                    newNode.next = null;
                    size++;
                    return;
                }

                tmp = tmp.next;
            }
        }


        public int getSize() {
            return this.size;
        }


        //      // Get at index
        public Node getAt(int index) {
            Node retVal = null;
            if (index > size || index < 0) {
                return retVal;
            }

            int counter = 0;
            Node tmp = head;
            while (tmp != null) {

                if (index == counter) {
                    return tmp;
                }

                tmp = tmp.next;
                counter++;
            }

            return retVal;
        }

        // Remove at index
        public Node removeAt(int index) {
            Node retVal = null;
            if (index > size || index < 0) {
                return retVal;
            }
    
            if (index==0) {
                retVal = head;
                head = head.next;
                return retVal;
            }

            int counter = 0;
            Node tmp = head;
            while (tmp != null) {

                if (index-1 == counter) {
                    retVal = tmp.next;
                    tmp.next = tmp.next.next;

                    size--;

                    break;
                }

                tmp = tmp.next;
                counter++;
            }

            return retVal;
        }



        // Insert at index
        public Node insertAt(int index, int data) {
            if (index < 0 || getSize() < index) {
                return null;
            }

            Node node = new Node(data);

            if (index == 0) {
                node.next = head;
                head = node;
                return head;
            }


            int count = 0;
            Node tmp = head;
            while (tmp!=null) {

                if (count == index-1) {
                    
                    node.next = tmp.next;
                    tmp.next = node;
                    size++;

                    break;


                }

                tmp = tmp.next;
                count++;
            }

            return node;

        }



        //Breton 2 ========================================================================================================




        public void Show() {
            Node tmp = head;
            while (tmp != null) {

                System.Console.WriteLine("Data:" + tmp.data);
                tmp = tmp.next;
            }
        }

        public void ShowByHead(Node vlNode)
        {
            Node tmp = vlNode;
            while (tmp != null)
            {
                System.Console.WriteLine("Data:" + tmp.data);
                tmp = tmp.next;
            }
        }

        public void displayLinkedList()
        {
            Node temp = this.head;
            StringBuilder res = new StringBuilder("[");
            while (temp != null)
            {
                res.Append(temp.data);
                
                temp = temp.next;
                if (temp != null)
                {
                    res.Append(", ");
                }
            }
            res.Append("]");

            System.Console.WriteLine("Data:" + res.ToString());
            
        }


    }



}