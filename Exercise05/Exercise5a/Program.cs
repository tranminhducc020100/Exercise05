using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z_v1();
            Print_a_2_z_v3();
            Print_a_2_z_v4();
            IsUpper(char c);
            
            {
                while(true)
                {
                    char c = Console.ReadKey().KeyChar;
                    Console.WriteLine(" " + Char2Code(c));
                }

            }
        }
        public static void Print_a_2_z_v1()
        {
            //char[] a = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 'y', 'u', 'v', 'w', 'x', 'y', 'z' };  
            //for (int i = 0; i < a.Length ; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            char c = ' ';
            for (int i = 97; i <= 122; i++)
            {
                c = (char)i;
                Console.Write(c);
            }
        }
        public static void Print_a_2_z_v3()
        {
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(c);
                c++;
            }
        }
        public static void Print_a_2_z_v4()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }
        }
        public static void Print_a_2_z_v5()
        {
            String s = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
        }

        public static int Char2Code(char c)
        {
            return (int)c;
        }
        //public static bool IsUpper(char c)
        //{
           
        //    if (int c = 65 && c <= 90)
        //    {
        //        Console.Write((char) + " , ");
        //        return true;

        //        return false;
        //    }
        //}
        //public static bool IsLower(char c)
        //{
        //    if(int i = 65; i <= 90; i++)
        //    return false;
        //}
        //public static char ToUpper(char c)
        //{
        //    return c;
        }
    }
}

