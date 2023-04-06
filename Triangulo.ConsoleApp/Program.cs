namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TipoDeTriangulo triangulo = new TipoDeTriangulo();
            triangulo.x = 10;
            triangulo.y = 50;
            triangulo.z = 50;

            Console.WriteLine("O triângulo é {0}", triangulo.CalcularTipoDeTriangulo());
        }
    }
}