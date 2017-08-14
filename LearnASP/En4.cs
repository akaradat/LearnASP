﻿using System;
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
                if (code[i] >= 32 && code[i] <= 126)
                {
                    pass += (char)((code[i] - 32 + 3) % 95 + 32);
                    pass += (char)((code[i] - 32 + 5) % 95 + 32);
                }
                else
                {
                    pass += code[i];
                    pass += code[i];
                }

                

            }
            return pass;
        }

        public override string DePass()
        {
            for (int i = 0; i < code.Length; i += 2)
            {
                if (code[i] >= 32 && code[i] <= 126)
                {
                    pass += (char)((code[i] - 126 - 3) % 95 + 126);
                }
                else
                {
                    pass += code[i];
                }
                
            }
            return pass;
        }
    }
}
