using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class DataStructures
{
	public LinkedList ()
	{
		public Node Head { get; set; }
		public Node Current { get; set; }

		public class Node
	{
			public int value { get; set; }
			public Node next { get; set}
			public Node (int value)
		{
			this.value = value;
			this.next = null;

		}

	}
		public override string ToString()
	{
		string spitout = "";
		if (Head != null)
		{
			spitout += $"{{{Current.value}}}";
			while(Current.next != null)
			{
				Current = Current.next;
				spitout += $" >>>>>> {{{Current.value}}}";
			}
		}
		return spitout;
	}
	public void Insert(int newInfo)
	{
		Node newNode = new Node(newInfo);
		if (Head != null)
		{
			newNode.next = Head;
		}
		Head = newNode;
		Current = newNode;
	}
	public bool Includes(int data)
	{
		try
		{
			if (Head == null)
			{
				return false;
			}
			else
			{
				Node current = Head;
				while (current.next != null)
				{
					if (current.value == data)
					{
						return true;
					}
					current = current.next;

				}
				return false;
			}
		}
	}

	public void Append(int newInfo)
		{
			Node newNode = new Node(newInfo);
			Node current = Head;
			while (current.next != null)
			{
				current = current.next;
			}
			current.next = newNode;
		}
	public void InsertBefore(int info, int newInfo)
	{
		Node newNode = new Node(newInfo);
		Node current = Head;
		Node prevNode = null;
		newNode.next = current;
		while (current != null)
		{
			if(current.value == info)
			{
				prevNode.next = newNode;
				newNode = current;
				break;

			}

			else
			{
				prevNode = current;
				current = current.next
			}
		}
	}
	public void insertAfter(int info, int newInfo)
	{

	}
	}
	}
}
