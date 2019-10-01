using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace
    csnganxepstack
{

    class TestCharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du Ngan xep Stack");
            Console.WriteLine("------------------");
            SortedList ht = new SortedList();

            Stack st = new Stack();

            st.Push('U');
            st.Push('Y');
            st.Push('V');
            st.Push('T');

            Console.WriteLine("1 - Hien thi Stack hien tai: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('K');
            st.Push('H');
            Console.WriteLine("Gia tri co the pop tiep theo trong Stack la: {0}", st.Peek());
            Console.WriteLine("2 - Hien thi Stack hien tai: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Xoa cac gia tri!!!");
            st.Pop();
            st.Pop();

            Console.WriteLine("3 - Hien thi Stack hien tai: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}