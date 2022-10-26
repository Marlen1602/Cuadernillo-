namespace la_diva
{
    class program
    {
        static void Main(string[]args)
        {
            double prec, total, des;
            Console.WriteLine("ingresa el precio de la chamarra");
                prec=double.Parse(Console.ReadLine());

            if (prec>=800)
            {
                des = (prec * 0.10);
                total = (prec - des);
            }
            else
            { des = prec * 0.05;
                total = prec - des;
            }
            Console.WriteLine("el total a pagar es "+total );

        }
    }
}