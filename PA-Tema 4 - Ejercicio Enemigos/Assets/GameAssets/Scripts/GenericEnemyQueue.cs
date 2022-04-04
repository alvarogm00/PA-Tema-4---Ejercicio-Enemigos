using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyQueue<T> where T : class
{
    public Node head; //Primer nodo de la fila
    public Node tail; //Último nodo de la fila
    public int count; //Número de nodos totales

    //Los nodos tienen la información del tipo genérico además del nodo anterior y posterior
    public class Node
    {
        //propiedades del nodo
        public T data;
        public Node next;
        //Constructor del nodo
        public Node(T t)
        {
            next = null;
            data = t;
        }
    }

    //Añadir un nuevo nodo a la fila
    public void PonerALaFila(T t)
    {
        Node n = new Node(t);
        n.next = tail;
        tail = n;
    }

    //Quitar el primer nodo de la fila y devolver el valor
    public T QuitarDeLaFila()
    {
        T data = head.data;
        head = head.next;
        return data;
    }

}
