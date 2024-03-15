using AdapterDp.Concrete;
using AdapterDp.Interface;
using System;

namespace AdapterDp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrypt crypt = new CryptA();
            crypt.encrypt("123");
            crypt.decrypt("12345");

            crypt = new CryptB();
            crypt.encrypt("321");
            crypt.decrypt("54321");

            CodeX xcode = new CodeX();
            crypt = new CodeXAdapter(xcode);
            crypt.encrypt("abc");
            crypt.decrypt("abcd");

            //Console.WriteLine("Hello World!");
        }
    }
}
