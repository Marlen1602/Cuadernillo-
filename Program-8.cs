namespace bono
{
    class program
    {
        static void Main(string[] args)
        {
            char turno;
            int grado;
            char grupo;

            Console.WriteLine("Grado al que pertenece 1=PRIMERO 2=SEGUNDO 3=TERCERO");
            grado = int.Parse(Console.ReadLine());
            Console.WriteLine("Grupo al que pertenece A O B");
            grupo = char.Parse(Console.ReadLine());
            Console.WriteLine("Turno al que pertenece m=matutino v=vespertino");
            turno = char.Parse(Console.ReadLine());

            if (grado == 1 && turno == 'm')
            { Console.WriteLine("HACER EL ARCO"); }
            else if (grado == 1 && turno == 'v')
            { Console.WriteLine("PONER ALTAR"); }

            if (grado == 2 && turno == 'm')
            { Console.WriteLine("HACER EL CAMINO DE FLORES"); }
            else if (grado == 2 && turno == 'v')
            { Console.WriteLine("AYUDAR A LOS DE PRIMERO CON EL ARCO"); }


            if (grado == 3 && grupo == 'A')
            { Console.WriteLine("AYUDAR A PONER EL ALTAR"); }
            else if (grado == 3 && grupo =='B')
            { Console.WriteLine("PRESENTAR CUADRILLA"); }
            
        }
    }
}