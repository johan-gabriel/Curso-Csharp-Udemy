/*
 Constantes são valores que não podem ser mudados...
 
 
 */
Console.WriteLine("Constantes");
// como se declara
const int ANO = 2023;
const int MES = 05;
const int DIA = 10;

const float DIAS_POR_MES = (float)DIA / (float)MES;

// calculando a área de um circulo.

const float PI = 3.14f;
double r, area =0, perimetro =0;

Console.WriteLine("Quanto vale o raio do circulo: ");
r = Convert.ToDouble(Console.ReadLine());

area = PI * Math.Pow(r,2);
perimetro = 2 * PI * r;

Console.WriteLine("A área do circulo ==> " + area);
Console.WriteLine("O perímetro do circulo ==> " + perimetro);



Console.ReadKey();
