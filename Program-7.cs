namespace bono_navideño
{
    class program
    {
        static void Main(string[]args)
        {
            double bono, suel, total;
            int ch;
            string nom;
            Console.WriteLine("nombre de empleado:");
            nom=Console.ReadLine();
            Console.WriteLine("sueldo:");
            suel=double.Parse(Console.ReadLine());
            Console.WriteLine("cantidad de hijos:");
            ch=int.Parse(Console.ReadLine());

            if (ch >= 3)
                bono = (ch * 10);
            else 
                bono= (ch * 20);
            
            total = bono + suel;
            Console.WriteLine("el bono navideño es de $"+total+" pesos");

        }
    }
}