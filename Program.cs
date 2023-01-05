
// EJERCICIO 1 / IF

string[] cupones = { "abc123", "zxv789" };

int descuento = 25;

int precio = 1000;

Console.WriteLine("Ingrese su nombre:");

string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su email:");

string email = Console.ReadLine();

Console.WriteLine("Ingrese cupón: ");

string cupon = Console.ReadLine();

int precio_final = 0;

if (cupones.Contains(cupon))
{

    precio_final = precio - ((descuento * precio) / 100);

    Console.WriteLine("Cupón es válido.");
    Console.WriteLine("Se ha aplicado un " + descuento + "% de descuento al precio del producto.");
    Console.WriteLine("Precio final de producto aplicando descuento: $" + precio_final);
}
else
{
    Console.WriteLine("Cupón no es válido, el producto mantiene el precio original de $" + precio);
}

// EJERCICIO 2 / SWITCH


string[] lenguajes = { "C#", "Java", "TypeScript", "PHP" };

Console.WriteLine("Seleccione un Lenguaje de Programación de la siquiente lista");

Console.WriteLine("Opción - Lenguaje");

Console.WriteLine("1 - C#");
Console.WriteLine("2 - Java");
Console.WriteLine("3 - TypeScript");
Console.WriteLine("4 - PHP");

Console.WriteLine("Escriba su preferencia: ");

int preferencia = Convert.ToInt32(Console.ReadLine());

switch (preferencia) {
    case 1:
        Console.WriteLine("Hola Mundo..... Ha seleccionado C#");
        break;
    case 2:
        Console.WriteLine("Ha seleccionado Java");
        break;
    case 3:
        Console.WriteLine("Ha seleccionado TypeScript");
        break;
    case 4:
        Console.WriteLine("Ha seleccionado PHP");
        break;
    default:
        Console.WriteLine("No ha seleccionado una opción válida");
        break;
        ;
}





