using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDp.Interface
{
    public interface ICrypt
    {
        void encrypt(string text);
        void decrypt(string text);
    }
}
