using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    internal class TipoDeTriangulo
    {
        public double x;
        public double y;
        public double z;

        public string CalcularTipoDeTriangulo()
        {
            if (x < y + z && y < x + z && z < x + y)
            {
                return "Equilátero";
            }
            else if (x == y || y == z || y == x)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";

            }
        }
    } 

}
