using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1____Logica_de_prog
{
    public static class Utilidades
    {
        public static int ToInt(this string input)
            => int.TryParse(input, out var number) ? number : default;
    }
}
