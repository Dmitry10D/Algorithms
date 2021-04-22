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

        public ILinkedList HeadNode;

        public ILinkedList TailNode;

        public void AddNote (int value)
        {
            Node node = new Node {Value = value };

        }
    }

    public interface ILinkedList
    {
        Node HeadNode { get; set; }
        Node TailNode { get; set; }
        int GetCount(); // возвращает количество элементов в списке
        void AddNote(int value); //добавляет новый элемент списка
        void AddNoteAfter(Node node, int value); //добавляет новый элемент списка после определенного элемента
        void RemoveNode(int index); //удаляет элемент по порядковому номеру
        void RemoveNode(Node node); //удаляет указанный элемент
        Node FindNote(int searchValue); //ищет элемент по его значению
    }
}
