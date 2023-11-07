using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
     public class MyStack<Type>
     {
         private Type[] values;
         public int Conut = -1;


         public MyStack()
         {
             values = new Type[10];
         }

         public void Push(Type value)
         {

             if (IsFull())
             {


                 values = Expansion();
             }

             values[++Conut] = value;
         }
         public Type Pop()
         {
             if (IsEmpty())
             {
                 throw new IndexOutOfRangeException();
             }
             return values[Conut--];
         }

         public bool IsFull()
         {
             return Conut == values.Length - 1;
         }
         public bool IsEmpty()
         {
             return Conut == 0;
         }

         public Type Peep()
         {
             if (IsEmpty())
             {
                 throw new IndexOutOfRangeException();
             }
             return values[Conut];
         }

         private Type[] Expansion()
         {
             var result = new Type[Conut * 2];

             for (int i = 0; i < values.Length; i++)
             {
                 result[i] = values[i];
             }
             return result;
         }

     }
}
