// See https://aka.ms/new-console-template for more information

string tar;
Console.WriteLine("       Cajero automático");
Console.WriteLine("");
Console.WriteLine("¿Usted ya ingresó su tarjeta?");
tar = Console.ReadLine();
if (tar == "si" || tar == "SI" || tar == "Si")
{
    Console.WriteLine("Ingrese su NIP: ");
    string nip = Console.ReadLine();
    int contador = nip.Length;
    if(contador == 4)
    {
        int opc;
        Console.WriteLine("      Menu de operaciones");
        Console.WriteLine("1.- Retiro");
        Console.WriteLine("2.- Deposito");
        Console.WriteLine(" Eliga una opción: ");
        opc = int.Parse(Console.ReadLine());
        switch (opc)
        {
            case 1:
                int retiro;
                string datos;
                Console.WriteLine("Ingrese la cantidad a retirar: ");
                retiro = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" Retiro exitoso");
                Console.WriteLine("");
                Console.WriteLine("Cantidad retirada: " + retiro);
                break;
            case 2:
                Console.WriteLine("Ingrese los 18 digitos de la tarjeta: ");
                string cuenta = Console.ReadLine();
                int contador2 = cuenta.Length;
                if (contador2 == 18)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el monto de deposito: ");
                    int deposito = int.Parse(Console.ReadLine());
                    Console.WriteLine("Deposito exitoso");
                    Console.WriteLine("");
                    Console.WriteLine("       Datos de deposito");
                    Console.WriteLine("No. tarjeta: " + cuenta);
                    Console.WriteLine("Deposito: " + deposito);
                }
                else
                {
                    Console.WriteLine("Datos incorrectos");
                }
                break;
            default:
                Console.WriteLine("Error, el dato ingresado es incorrecto");
                break;
        }
    }
    else
    {
        Console.WriteLine("NIP incorrecto");
    }
}
else
{
    Console.WriteLine("Por favor ingrese su tarjeta");
}
Console.ReadKey();


