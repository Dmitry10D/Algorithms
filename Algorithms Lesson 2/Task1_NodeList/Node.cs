using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_NodeList
{
    public class Node: ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public Node HeadNode;

        public Node TailNode;

        public void AddNote (int value)
        {
            if (HeadNode != null)
            {

                var node = HeadNode;

                while (node.NextNode != null)
                {
                    node = node.NextNode;
                }

                var newNode = new Node { Value = value };
                node.NextNode = newNode;
                newNode.PrevNode = node;
            }
            else
            {
                HeadNode = new Node { Value = value };
            }
        }

        public void AddNoteAfter(Node node, int value)
        {
            try
            {
                var curNode = HeadNode;
                while (curNode != node)
                {
                    curNode = curNode.NextNode;
                }

                if (curNode.NextNode == null)
                {
                    AddNote(value);
                }
                else
                {
                    Node newNode = new Node { Value = value };
                    newNode.NextNode = curNode.NextNode;
                    newNode.PrevNode = curNode;

                    curNode.NextNode = newNode;
                    newNode.NextNode.PrevNode = newNode;
                }
            }
            catch 
            {
                Console.WriteLine("Node not found");
            }
        }

        public void RemoveNode(int index)
        {
            //if (index == 0)
            //{
            //    var newHeadNode = HeadNode.NextNode;
            //    HeadNode.NextNode = null;
            //    HeadNode
            //}
            var curNode = HeadNode;
            for (var i= 0; i<=index; i++)
            {
                curNode = curNode.NextNode;
            }

            curNode.NextNode.PrevNode = curNode.PrevNode;
            curNode.PrevNode.NextNode = curNode.NextNode;
        }

        public void RemoveNode(Node node)
        {
            var curNode = HeadNode;
            while (curNode != node)
            {
                curNode = curNode.NextNode;
            }

            curNode.NextNode.PrevNode = curNode.PrevNode;
            curNode.PrevNode.NextNode = curNode.NextNode;
        }

        public Node FindNote(int searchValue)
        {
            var curNode = HeadNode;
            while(curNode != null)
            {
                if (curNode.Value == searchValue)
                    return curNode;

                curNode = curNode.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            int count = 0;
            var curNode = HeadNode;

            if (HeadNode == null)
                return 0;

            while (curNode.NextNode != null)
            {
                curNode = curNode.NextNode;
                count++;
            }
            return count;
        }

    }

    public interface ILinkedList
    {
        
        int GetCount(); // возвращает количество элементов в списке
        void AddNote(int value); //добавляет новый элемент списка
        void AddNoteAfter(Node node, int value); //добавляет новый элемент списка после определенного элемента
        void RemoveNode(int index); //удаляет элемент по порядковому номеру
        void RemoveNode(Node node); //удаляет указанный элемент
        Node FindNote(int searchValue); //ищет элемент по его значению
    }
}
