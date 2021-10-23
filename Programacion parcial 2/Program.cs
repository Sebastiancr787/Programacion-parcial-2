using System;

namespace programacionparcial2
{
    class Program
    {

        public void buscarProducto(Dictionary<String,float> dictProductos){
            Console.WriteLine("Ingrese el nombre del producto a buscar");
            string productoBuscado = "";
            productoBuscado = Console.ReadLine();
            if (dictProductos.ContainsKey(productoBuscado)){
            Console.WriteLine("El precio es: " +
                            dictProductos[productoBuscado] +
                            " pesos");                            
            }
            else
            {
            Console.WriteLine("El producto no se encuentra en la tienda!");
            }
        }


        static void Main(string[] args)
        {



            Program program = new Program();
            int opcionMenu = 0;
            var dictProductos = new Dictionary<String, float>() {
                {"gaseosa", 2000},
                {"papas", 3000},
                {"agua", 1000},
                {"frutas", 500},
                {"gelatina", 1500},
                {"chocolate", 2300},
                {"cafe", 5000},
                {"fresas", 1500},
                {"carne", 10000},
                {"pollo", 8000},
                {"cerveza", 3500},
                {"mentas", 200},
                {"arepas", 4500},
                {"queso", 2500},
                {"pan", 3000},
                {"panzerotti", 3500}
                
            };
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
                                    
                                    program.buscarProducto(dictProductos);

                                    break;

                                case 2:
                                    Console.WriteLine("Suma rápida de productos");

                                    string productoCompraRapida = "";
                                    float totalSumaProd = 0;
                                    while(productoCompraRapida != "0"){
                                        Console.WriteLine("Ingrese el nombre de los productos que desea comprar, cuando desee detenerse ingrese 0: ");
                                        Console.WriteLine("Si desea buscar el precio de un producto, escriba -1");
                                        productoCompraRapida = Console.ReadLine();
                                        if(productoCompraRapida == "-1"){
                                            program.buscarProducto(dictProductos);
                                        }
                                        else
                                        {
                                            if (dictProductos.ContainsKey(productoCompraRapida)){
                                                totalSumaProd = totalSumaProd + dictProductos[productoCompraRapida];
                                                Console.WriteLine("Total actual: $" + totalSumaProd + " pesos");
                                            }
                                            else
                                            {
                                            Console.WriteLine("El producto no se encuentra en la tienda! No se sumo nada!");
                                            }
                                        }
                                        

                                    }
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
        }
    }
}