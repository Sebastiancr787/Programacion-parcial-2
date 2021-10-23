using System;
using System.Collections;

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
            float totalSumaProd = 0;
            float pagoDelCliente = 0;
            float totalInformeVentas = 0;
            float totalAdeudadoClientes = 0;
            ArrayList arlistInformeVentas = new ArrayList();




            var dictClientes = new Dictionary<string, float>() {
                {"1000873268", 500},
                {"1234567890", -2500},
                {"0987654321", 0},
                {"4620474027", 20000},
                {"7403801830", 5000},
                {"9573028404", -10000},
                {"6473936497", 0 },
                {"1840572038", -4500},
                {"0948208293", 0},
                {"0002783934", 0},
                {"6462828345", -7800},
                {"1836549163", 0},

            };
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
                                "\n3.- Pagar cuenta " +
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
                                    totalSumaProd = 0;
                                    string productoCompraRapida = "";
                                    
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
                                                if(productoCompraRapida != "0"){
                                                    Console.WriteLine("El producto no se encuentra en la tienda! No se sumo nada!");
                                                }
                                                    
                                            }
                                        }
                                        

                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Pagar cuenta");
                                    Console.WriteLine("\n¿El cliente va a fiar? Ingrese 1 si va a fiar, cualquier cosa de lo contrario: ");
                                    string vaAFiar = "0";
                                    vaAFiar = Console.ReadLine();
                                    if (vaAFiar == "1"){
                                        Console.WriteLine("El total fiado es:  " + totalSumaProd);
                                        arlistInformeVentas.Add(totalSumaProd);
                                    }
                                    else
                                    {   
                                        do{
                                        Console.WriteLine("\nIngrese cuanto dinero le entregó el cliente: ");
                                        
                                        pagoDelCliente = float.Parse(Console.ReadLine());
                                        if (pagoDelCliente < totalSumaProd){
                                            Console.WriteLine("Ese dinero no es suficiente para pagar la suma de productos, intente otra vez: ");
                                        }
                                        } while(pagoDelCliente < totalSumaProd);
                                        
                                        float devueltaCliente = 0;
                                        devueltaCliente = pagoDelCliente - totalSumaProd; 
                                        Console.WriteLine("Su devuelta es de :$" + devueltaCliente + " pesos!");
                                        arlistInformeVentas.Add(totalSumaProd);
                                        
                                    }
                                    
                                    break;

                                case 4:
                                    Console.WriteLine("Consultar cuenta cliente");

                                    Console.WriteLine("\nIngrese el ID del cliente: ");
                                    string inputIdCliente = "0000000000";
                                    inputIdCliente = Console.ReadLine();
                                    if(!dictClientes.ContainsKey(inputIdCliente)){
                                        Console.WriteLine("Ese ID no se encuentra en la base de datos!");
                                    }
                                    else{
                                        if (dictClientes[inputIdCliente] > 0){
                                            Console.WriteLine("Tiene a favor un saldo de :$" + dictClientes[inputIdCliente] + " pesos");
                                        }
                                        if (dictClientes[inputIdCliente] == 0){
                                            Console.WriteLine("Esta a paz y salvo");
                                        }
                                        if (dictClientes[inputIdCliente] < 0){
                                            Console.WriteLine("Esta con una deuda de :$" + dictClientes[inputIdCliente] + " pesos");
                                        }
                                    }
                                    break;

                                case 5:
                                    Console.WriteLine("Actualizar cuenta cliente");
                                    Console.WriteLine("\nIngrese el ID para actualizar: ");
                                    string id2Actualizar = "";
                                    id2Actualizar = Console.ReadLine();
                                    if(dictClientes.ContainsKey(id2Actualizar)){ 
                            
                                    
                                        Console.WriteLine("\nIngrese el nuevo valor de la cuenta:  ");
                                        float nuevoValorCuenta = 0;
                                        nuevoValorCuenta = float.Parse(Console.ReadLine());
                                        dictClientes[id2Actualizar] = nuevoValorCuenta;

                                        Console.WriteLine("La cuenta del cliente con id " + id2Actualizar + " ha sido actualizada correctamente!");
                                    
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese usuario no existe!");    
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("Calcular informe de ventas");
                                    totalInformeVentas = 0;
                                    int contadorCompras = 1;
                                    foreach (float i in arlistInformeVentas){
                                        Console.WriteLine("-Compra #" + contadorCompras + ":  " + i + "$ -");
                                        contadorCompras = contadorCompras + 1;
                                        totalInformeVentas = totalInformeVentas + i;
                                    }
                                    Console.WriteLine("El total del informe de ventas es de: $" + totalInformeVentas + " pesos");
                                    break;

                                case 7:
                                    Console.WriteLine("Calcular cartera de clientes");
                                    totalAdeudadoClientes = 0;
                                    foreach(var item  in dictClientes){
                                        if (item.Value < 0){
                                            totalAdeudadoClientes = totalAdeudadoClientes + item.Value;
                                        }

                                    }
                                    Console.WriteLine("El total adeudado por todos los clientes de la tienda es de: $" + totalAdeudadoClientes);
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