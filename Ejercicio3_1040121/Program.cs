
using Ejercicio3_1040121;

class Program()
{
    private Scanner scanner = new Scanner();
    public static void Main(string[] args)
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("Elija una opcion \nProblema1\t=1 \nProblema2\t=2 \nProblema3\t=3 \nSalir\t=4");
            opcion = Int32.Parse(Console.ReadLine());
            Menu(opcion);
        }
        Console.ReadKey();
    }
    public static void Menu(int opcion)
    {
        try
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Eligio el problema 1");
                    leerArchivo(1);
                    break;
                case 2:
                    Console.WriteLine("Eligio el problema 2");
                    try
                    {
                        Console.WriteLine("Introduzca la fecha");
                        string fechaManual = Console.ReadLine();
                        ejercicio2(fechaManual);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hubo un error "+ e);
                        break;
                    }
                    
                    break;
                case 3:
                    Console.WriteLine("Eligio el problema 3");
                    leerArchivo(3);
                    break;
                case 4:
                    Console.WriteLine("Eligio Salir");
                    break;
                default:
                    Console.WriteLine("No existe");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Tiene el siguiente error "+ e);
            throw;
        }

    }
    public static void leerArchivo(int ejercicio)
    {
        try
        {
            string acumulador = "";
            Console.WriteLine("Digame el path ");
            string path = Console.ReadLine();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    switch (ejercicio)
                    {
                        case 1:
                            ejercicio1(line);
                            break;
                        case 3:
                            acumulador += line;
                            break;
                    }
                }
                if (ejercicio ==3)
                {
                    ejercicio3(acumulador);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Esta este error "+e );
            throw;
        }
    }
    public static void ejercicio1(string placa)
    {
        Console.WriteLine("Placa "+placa);
        Console.WriteLine(Scanner.ScannerPlacas(placa));
    }
    public static void ejercicio2(string fecha)
    {
        Console.WriteLine("Fecha "+fecha);
        Console.WriteLine(Scanner.ScannerFechas(fecha)); 
    }
    public static void ejercicio3(string set)
    {
        Console.WriteLine("Set "+set);
        Console.WriteLine(Scanner.ScannerSets(set)); 
    }
}