int opcionMenu = 0;
Console.WriteLine("Hola, bienvenido a la tienda el lago, elige una opcion\n");

while (opcionMenu!=9){

    Console.WriteLine(
                    "\n1.- Buscar producto " +
                    "\n2.- Suma de productos " +
                    "\n3.- pagar cuenta " +
                    "\n4.- Consultar cuenta cliente" +
                    "\n5.- Actualizar cuenta cliente " +
                    "\n6.- Calcular informe de ventas " +
                    "\n7.- Calcular cartera de clientes " +
                    "\n8.- Acerca de  " +
                    "\n9.- Salir "
                    );


    Console.WriteLine("Escriba el número de la opción elegida del menú: ");

    

    opcionMenu = Convert.ToInt16(Console.ReadLine());

    switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Buscar Producto: ");
                        break;

                    case 2:
                        Console.WriteLine("Suma de productos");
                        break;
                    case 3:
                        Console.WriteLine("pagar cuenta");
                        break;

                    case 4:
                        Console.WriteLine("Consultar cuenta cliente");
                        break;

                    case 5:
                        Console.WriteLine("Actualizar cuenta cliente");
                        break;

                    case 6:
                        Console.WriteLine("Calcular informe de ventas");
                        break;

                    case 7:
                        Console.WriteLine("Calcular cartera de clientes");
                        break;

                    case 8:
                        Console.WriteLine("Acerca de");
                        break;

                    case 9:
                        Console.WriteLine("salir");
                        break;

                    default:
                        Console.WriteLine("No ha seleccionado ninguna opcion");
                        break;

                }
}
