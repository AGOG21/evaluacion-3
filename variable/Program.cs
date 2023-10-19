
var numero1 = 5;
var numero2 = 7;
Console.WriteLine("Por favor, ingresa la suma de " + numero1 + " y " + numero2 + ": ");
var respuesta = Console.ReadLine();
var resultado = Convert.ToInt32(respuesta);
var esCorrecto = resultado == (numero1 + numero2);
Console.WriteLine("Tu respuesta es " + esCorrecto);

var nume = 7;
Console.WriteLine("Por favor, ingresa el doble de " + nume + ": ");
var seria= Console.ReadLine();
var es = Convert.ToInt32(seria);
var esCorrect = es == (nume * 2);
Console.WriteLine("Tu respuesta es " + esCorrecto);

var n = 42;
Console.WriteLine("Por favor, ingresa el número " + n + ": ");
var res = Console.ReadLine();
var numeroIngresado = Convert.ToInt32(res);
var esverdadero = numeroIngresado == n;
Console.WriteLine("Tu respuesta es " + esverdadero);

var num = 10;

Console.WriteLine("El valor inicial es " + num);

num++;

Console.WriteLine("Después de incrementar, el valor es " + num);

num--;

Console.WriteLine("Después de decrementar, el valor es " + num);

const double PI = 3.14159265359;

double radio = 5.0;
double area = PI * radio * radio;

Console.WriteLine("El valor de PI es constante: " + PI);

Console.WriteLine("Dado un radio de " + radio + " unidades,");

Console.WriteLine("El área de un círculo es: " + area + " unidades cuadradas.");