using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaSimples
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

        public void Insert(Item i)
        {
            if (IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else
            {
                //Find(i);
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
                        InsertMiddle(i);
                    }
                }

            }
        }

        public void InsertLast(Item i)
        {
            End.Next = i;
            End = i;

        }

        public void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
        }

        public bool Find(Item f) 
        {
            Item aux = Begin;
            while (aux.Next != null)
            {
                if(aux.Value == f.Value)
                {
                    return true;
                }
                else
                {
                    aux = aux.Next;
                }
                return false;
            }
        }

        public bool IsEmpty()
        {
            return true;
        }

        public void Print() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista Vazia.");
            }
            else
            {
                Find();
            }
        }
    }
}
