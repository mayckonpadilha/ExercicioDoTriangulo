using System;

namespace ExercicioDoTriangulo.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.ladoTriangulo01 = 10;
            triangulo.ladoTriangulo02 = 10;
            triangulo.ladoTriangulo03 = 10;

            Console.WriteLine("Os valores que voce informou são referentes ao trinagulo" + triangulo.DiferenciandoTipoDeTriangulo());
        }
    }
}
