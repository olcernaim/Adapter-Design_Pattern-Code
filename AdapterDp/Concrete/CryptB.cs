using AdapterDp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDp.Concrete
{
    public class CryptB : ICrypt
    {
        public void decrypt(string text)
        {
            Console.WriteLine("B " +text);
        }

        public void encrypt(string text)
        {
            Console.WriteLine("B " + text);

        }
    }
}
