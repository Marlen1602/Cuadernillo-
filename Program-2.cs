namespace dolares_a_pesos_soles
    {
    class program
    {
        static void Main(string[] args)
        {
            int opcion;
            double cant, to;
            Console.WriteLine("**DOLARES A PESOS MEXICANOS O A SOLES ARGENTINOS**");
            Console.WriteLine("Ingrese la cantidad de dolares");
            cant = double.Parse(Console.ReadLine());
            Console.WriteLine("¿A qué los desea convestir?");
            Console.WriteLine("1.- Pesos mexicanos");
            Console.WriteLine("2.- Soles argentinos");
            opcion = int.Parse(Console.ReadLine());
            to = 0;
            if (opcion == 1)

                to = cant * 19.88;

            else if (opcion == 2)

                to = cant * 4.00;

            else 
                Console.WriteLine("error");

             Console.WriteLine("la cantidad equivale a " + to); 


        }
    }
}
