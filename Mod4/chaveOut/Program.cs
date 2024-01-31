Console.WriteLine("###  OUT  ###");
Console.WriteLine();

Console.WriteLine("Informe o raio do Círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double permimetro = circulo.CalculaPerimetro(raio);
double area = circulo.CalcularArea(raio);

Console.WriteLine("Perímetro da Circunferencia: " + permimetro);
Console.WriteLine();
Console.WriteLine("Área da Circunferencia: "+ area);
Console.WriteLine();

Circulos circulus = new();

double circunferencia = circulus.CalculaAreaPerim(raio, out double area1); // Retorna mais do que o valor do metodo
Console.WriteLine("Perímetro da Circunferencia: " + circunferencia);
Console.WriteLine();
Console.WriteLine("Área da Circunferencia: " + area1);//houve um retono forçado pelo OUT!

Console.ReadKey();

// Exemplo sem o uso do out
public class Circulo
{
    public double CalcularArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio,2);
        return area;
    }

    public double CalculaPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
//Fim

// Com o uso de out
public class Circulos
{
   public double CalculaAreaPerim(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}//fim