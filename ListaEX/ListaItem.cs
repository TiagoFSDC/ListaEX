using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEX
{
    internal class ListItem
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListItem()
        {
            Begin = null;
            End = null;
        }

        public void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
        }

        public void InsertLast(Item i)
        {
            End.Next = i;
            End = i;
        }
        public void InsertMidle(Item i)
        {
            Item aux = Begin;
            //Console.WriteLine(aux.Value);
            Item aux2 = Begin.Next;
            //Console.WriteLine(aux2.Value + "\n");
            while (i.Value > aux2.Value)
            {
                aux = aux2;
                aux2 = aux2.Next;
                //Console.WriteLine(aux.Value);
            }
            i.Next = aux.Next;
            aux.Next = i;
            aux2 = aux.Next;

            //Console.WriteLine(aux.Next.Value);
            //Console.WriteLine(aux2.Value);
            //Console.WriteLine(End.Value);
        }

        public void Insert(Item i)
        {
            if (IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else 
            {
                if(i.Value <= Begin.Value)
                {
                    InsertFirst(i);
                }
                else
                {
                    if (i.Value >= End.Value)
                    {
                        InsertLast(i);
                    }
                    else
                    {
                        InsertMidle(i);
                    }
                }

            }
        }

        public bool IsEmpty()
        {
            if (Begin == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print(Item i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista Vazia! ");
            }
            else
            {
                if (Begin.Value == End.Value)
                {
                    Console.WriteLine("Lista: " + Begin.Value);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.Write("Lista: ");
                    Item aux = Begin;
                    while (aux.Value != End.Value)
                    {
                        Console.Write(aux.Value + " ");
                        aux = aux.Next;

                    }
                    Console.Write(aux.Value);
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
