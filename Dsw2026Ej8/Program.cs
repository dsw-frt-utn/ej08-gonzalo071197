namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Teclado Mecánico", 45000.50m);
            Console.WriteLine(etiqueta);
        }
    }
}
