using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoTriangulo.ConsoleApplication
{
    class Triangulo
    {
        public int ladoTriangulo01, ladoTriangulo02, ladoTriangulo03;
       

        public string DiferenciandoTipoDeTriangulo()
        {

            if (ladoTriangulo01 == ladoTriangulo02 && ladoTriangulo02 == ladoTriangulo03)
            {

                return "Triangulo Equilátero";
            }
            else if (ladoTriangulo01 != ladoTriangulo02 && ladoTriangulo02 != ladoTriangulo03 && ladoTriangulo01 != ladoTriangulo03)
            {

                return "Triangulo Escaleno";
            }
            else if (ladoTriangulo01 == ladoTriangulo02 && ladoTriangulo02 != ladoTriangulo03 || 
                ladoTriangulo01 == ladoTriangulo03 && ladoTriangulo01 != ladoTriangulo02 ||
                ladoTriangulo02 == ladoTriangulo03 && ladoTriangulo03 != ladoTriangulo01)
            {
                return "Triangulo Equilátero";
            }
            else
            {
                return "Triangulo invalido";
            }
            
        }
    }
}
