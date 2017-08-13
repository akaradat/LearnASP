using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class En4 : Encrypt
    {
        public En4(string code) : base(code)
        {
        }

        public override string EnPass()
        {
            for (int i = 0; i < code.Length; i++)
            {
                pass += (char)((code[i] - 32 + 3) % 96 + 32);
                pass += (char)((code[i] - 32 + 5) % 96 + 32);

            }
            return pass;
        }

        public override string DePass()
        {
            for (int i = 0; i < code.Length; i += 2)
            {
                pass += (char)((code[i] - 126 - 3) % 96 + 126);
            }
            return pass;
        }
    }
}
