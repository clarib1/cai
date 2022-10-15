using System;

namespace cai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                var cliente = Cliente.PedirString("nombre de cliente", 30);
                var contrasena = Cliente.PedirString("contraseña", 30);

                if (cliente != "jperez" || contrasena != "1234")
                {
                    Console.WriteLine("usuario o contraseña invalido");
                }
                //el prototipo viene acompañado de un doc que dice que el unico usuario que se puede
                //usar el jperez y contraseña 1234

                else
                {
                    break;
                }
            }
            int opcionsinValidar;
            //mostras menu principal
            int opcion = MenuPrincipal(opcionsinValidar);

            if (opcion == 1)
            {
                //bienvenido primer caso de uso
            }

            else if (opcion == 2)
            {
                //bienvenido segundo caso de uso
            }

            else if (opcion == 3)
            {
                //bienvenido tercer caso de uso
            }
        }
        public static int MenuPrincipal( int opcion)
        {
            Console.WriteLine("Seleccione una opcion del menu");
            Console.WriteLine("[1] Solicitar servicio");
            Console.WriteLine("[2] Consultar estado de cuenta");
            Console.WriteLine("[3] Consultar seguimiento de pedido");
            Console.WriteLine("[4] Salir");

            return opcion;
        }

    }


}
