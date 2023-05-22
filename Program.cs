using System;

namespace Start_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Console.WriteLine("isim");
            string name = Console.ReadLine();
            Console.WriteLine("soyisim");
            string surname = Console.ReadLine();

            Console.WriteLine("merhaba " + name + " " + surname);

            int deger;
            deger = 2;
            string degisken = " ";
            byte b = 5; //1 byte
            sbyte c = 5; //1 byte
            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2; //2 byte
            int i = 2; //4 byte 
            Int32 i32 = 2; //4 byte 
            Int64 i64 = 2; //8 byte
            uint ui = 2; //4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8byte 

            //reel
            float f = 5; //4 byte 
            double d = 5; //8 byte
            decimal de = 5; //16 byte 

            char ch = '2'; //2 byte
            string str = "ozge"; //sınırsız
            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);


            Console.WriteLine(deger);
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;
            string str1 = string.Empty;
            str1 = "ozge acikgul";
            string ad = "ozge";
            string soyad = "acikgul";
            string tamisim = ad + " " + soyad;

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            bool bll = 10 < 2;

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);































            Console.ReadKey();

        }
    }
}
