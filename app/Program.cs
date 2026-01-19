// // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//defiinir datos basicos
string libro = "Don quijote";
int entero = 100;
float numDecimal = 3.1416;
bool autorizado = true;
bool seleccionado = false;


//listas con memoria determinada uansdo int para numeros enteros
int[] numeros = { 23, 45, 16, 37, 3, 99, 22};
Console.WriteLine(numeros[0]);

//listas de texto usando string 
string[] animales = {"Perrito", "Gatito", "Conejo" };

// lista mixta para varios tipos de datos
dynamic[] datosMixtos = { "texto", 21, true, lista};


//listas mas felxibles en cuanto a tamaño
List<int> numeros = new List<int> { 23, 45, 16, 37, 3, 99, 22};
Console.WriteLine(string.Join(",",numeros));


// dictonarios      

Dictionary<int, string> jugadores = new Dictionary<int , string>();
jugadores.Add(10, "Messsi");
jugadores.Add(7, "Cristiano");

Console.WriteLine(jugadores[7]);


//constantes en el que el valor de la variable no cambia
const float pi = 3.14169265359; 

// operadores 
Console.WriteLine(1 + 1);
Console.WriteLine(1 - 1);
Console.WriteLine(10 * 1);
Console.WriteLine(10 / 1);

// operadores comparativos
Console.WriteLine(4 == 4);
Console.WriteLine(4 != 5);
Console.WriteLine(4 < 5);
Console.WriteLine(4 >= 5); 

Console.WriteLine(true && true);
Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(true && true);

Console.WriteLine(true || true);
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(true || true);

// condicionales 

bool autorizado = true;

if (autorizado)
{
    Console.WriteLine("Puede ingresar");
}
else
{
    Console.WriteLine("No puede ingresar");
}

// otro ej con condicionales pero mas complejo

int entero = 100;

if (entero == 99)
{
    Console.WriteLine("Es 99");
}
else if (entero == 100)
{
    Console.WriteLine("Es 100");
}
else
{
    Console.WtriteLine(" No es 99 ni 100");
} 

// condicional tgipo switch

string color = "amarillo";

switch (color)
{
    case "verde":
    Console.WriteLine("Exito");
    break;
    case "amarillo":
    Console.WirteLine("Advertencia");
    break;
    default:
    Console.WriteLine("Advertncia");
    break;
}

//funciones

//sumar
int sumar(int primero, int segundo)
{
    return primero + segundo;
}

int resultado = sumar(3, 4);
Console.WriteLine(resultado);

//multiplicar
void multiplicar(int primero, int segundo)
{
    Console.WriteLine(primero * segundo); 
}

 multiplicar(entero, 2);

// para imprimir elementos de una lista
void imprimirPrimerElemento(string[] lista)
{
    Console.WriteLine(lista[0]);
}

imprimirPrimerElemento(animales);

// funciones mas complejas (algotitmo de ordenamiento quicksort)

List<int> quicksort(List<int> lista)
{
    if (lista.Count <= 1)
    {
        return lista;
    }
    
    int pivote = lista[0];
    List<int> izquierda = new List<int>();
    lista<int> derecha = new List<int>();
    for (int i = 1; i < lista.Count; i++)
    {
        if (lista[i] < pivote)
        {
            izquierda.Add(lista[i]);
        }
        else
        {
            derecha.Add(lista[i]);

        }
    }
    List<int> primero = quicksort(izquierda);
    List<int> medio = new List<int> { pivote };
    List<int> segundo = quicksort(izquierda);
    primero.AddRange(medio);
    primero.AddRange(segundo);
    return primero;
    
};

// Bucles en c#

string[] animales = {"perro", "gato", "tigre"};

foreach( string animal in animales)
{
    Console.WriteLine(animal);

}

// ejemplo de un bucle que multiplica una lista  x2
void multiplicar(int primero, int segundo)
{
    Console.WritLine(primero * segundo);
}

int numeros = {23, 45, 16, 37, 3, 99, 22};
foreach (int numero in numeros)
{
    multicplicar(numero * 2);
}

int entero = 100;
iknt emergencia = 911;

while (entero <= emergencia)
{
    Console.WriteLine(entero);
    entero++;
}

// clases

//modulos