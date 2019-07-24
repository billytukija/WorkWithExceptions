using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithExceptions
{
    public class SaleException : Exception
    {
        public int Code { get; set; }

        public SaleException(int code, string mensagem) : base($"{mensagem}. Erro code: {code}")
        {
        }
    }
}
