namespace sueldo
{
    class program
    {
        static void Main(string[]args)
        {
            int ki;
            double sueldo=0;

            Console.WriteLine("ingrese los kilometros recorridos durante la semana");
            ki=int.Parse(Console.ReadLine());

            if(ki>=1500)
                sueldo=ki*5;
            else if (ki<1500)
                sueldo=ki*3.5;
            Console.WriteLine("sueldo: "+ sueldo);
        }
    }
}
