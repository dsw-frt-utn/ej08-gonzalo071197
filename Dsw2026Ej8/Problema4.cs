public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        double _suma = 0;
        int _cantidadValidas = 0;

        
        int?[] notas = { nota1, nota2, nota3 };

        foreach (var nota in notas)
        {
            
            if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
            {
                suma += nota.Value;
                cantidadValidas++;
            }
        }

        
        if (cantidadValidas == 0) return 0;

        return suma / cantidadValidas;
    }
}