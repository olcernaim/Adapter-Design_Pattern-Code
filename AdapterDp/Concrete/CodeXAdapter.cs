using AdapterDp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDp
{
    public class CodeXAdapter : ICrypt
    {
        private CodeX _codeX;
        public CodeXAdapter(CodeX codeX)
        {
            _codeX = codeX;
        }
        public void decrypt(string text)
        {
            _codeX.TextDecyprt(text);
        }

        public void encrypt(string text)
        {
            _codeX.TextEncyprt(text);
        }
    }
}
