
public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
       
        int copiaValor = originalValue;
        copiaValor++;

        
        Product copiaProducto = product;
        copiaProducto.ModificarDescripcion(product.Description + " - Modificado");

        
        return $"{originalValue}-{copiaValor}-{product.Description}";
    }
}