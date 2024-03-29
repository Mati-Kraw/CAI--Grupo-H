﻿namespace CAIGrupoH
{
    internal class Region
    {
        //Propiedades Recepcion
        public string? TipoRecepcion { get; set; }
        public string? RetiroRegion { get; set; }
        public string? RetiroProvincia { get; set; }
        public string? RetiroLocalidad { get; set; }
        public string? RetiroDireccion { get; set; }
        public string? RetiroDireccionNumero { get; set; }
        public string? RetiroSucursal { get; set; }

        //Propiedades Entrega
        public string? TipoEntrega { get; set; }
        public string? EntregaRegion { get; set; }
        public string? EntregaProvincia { get; set; }
        public string? EntregaLocalidad { get; set; }
        public string? EntregaDireccion { get; set; }
        public string? EntregaDireccionNumero { get; set; }
        public string? EntregaSucursal { get; set; }

        // Retiro del paquete para ser enviado
        public static Region RetiroPaquete()
        {
            Console.Clear();
            var tipoRecepcion = new Region();
            while (true)
            {
                int menuOrigenPaquete = Validaciones.ValidarMenuPrincipal("Seleccione la opción que mas le convenga: ", "1. Retiro del paquete en puerta.\n2. Presentación en sucursal.", 1, 2);
                if (menuOrigenPaquete == 1)
                {
                    // No implementado.
                    Console.WriteLine("No implementado.\n");
                    Console.WriteLine("Ingrese cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    continue;
                    /*
                    tipoRecepcion.TipoRecepcion = "Retiro en puerta";

                    // Region de retiro
                    var region = Validaciones.ValidarStringIngresado("Ingrese la region donde se retira el paquete: ", "");
                    tipoRecepcion.RetiroRegion = region;

                    // Provincia de retiro
                    var provincia = Validaciones.ValidarStringIngresado("Ingrese la provincia donde se retira el paquete: ", "");
                    tipoRecepcion.RetiroProvincia = provincia;

                    // Localidad de retiro
                    var localidad = Validaciones.ValidarStringIngresado("Ingrese la localidad donde se retira el paquete:", "");
                    tipoRecepcion.RetiroLocalidad = localidad;

                    // Dirección exacta de retiro                   
                    var direccionCalle = Validaciones.ValidarStringIngresado("Ingrese la calle donde se realizara el retiro del paquete:", "Aclaración: solo la calle.");
                    var direccionNumero = Validaciones.ValidarIntIngresado("Ingrese la altura de la calle donde se realizara el retiro del paquete:", 0, 4);
                    tipoRecepcion.RetiroDireccion = direccionCalle;
                    tipoRecepcion.RetiroDireccionNumero = direccionNumero;
                    */
                }
                if (menuOrigenPaquete == 2)
                {
                    tipoRecepcion.TipoRecepcion = "Retiro en sucursal";

                    // Region de retiro
                    Console.Clear();
                    do
                    {
                        var region = Validaciones.ValidarStringIngresado("Ingrese la region donde se retira el paquete: ", "").ToLower();

                    // Hardcodeado
                   
                        if (region != "caba")
                        {
                            // No implementado.
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        tipoRecepcion.RetiroRegion = region;
                        break;
                    } while (true);
                    

                    // Provincia de retiro
                    Console.Clear();
                    do
                    {
                        var provincia = Validaciones.ValidarStringIngresado("Ingrese la provincia donde se retira el paquete:", "").ToLower();

                    // Hardcodeado
                    
                        if (provincia != "buenos aires")
                        {
                            // No implementado.
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        tipoRecepcion.RetiroProvincia = provincia;
                        break;
                    } while (true);
                    

                    // Localidad de retiro
                    Console.Clear();
                    do
                    {
                        var localidad = Validaciones.ValidarStringIngresado("Ingrese la localidad donde se retira el paquete:", "").ToLower();

                    // Hardcodeado
                   
                        if (localidad != "belgrano")
                        {
                            // No implementado.
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        tipoRecepcion.RetiroLocalidad = localidad;
                        break;
                    } while (true);
                    

                    // Sucursal de retiro
                    Console.Clear();
                    do
                    {
                        var nombreSucursal = Validaciones.ValidarStringIngresado("Ingrese la sucursal donde se realizara el retiro del paquete:", "").ToLower();

                    // Hardcodeado
                    
                        if (nombreSucursal != "belgrano")
                        {
                            // No implementado.
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        tipoRecepcion.RetiroSucursal = nombreSucursal;
                        break;
                    } while (true);
                    
                }
                break;
            }
            return tipoRecepcion;
        }

        //Entrega del paquete en destino
        public static Region EntregaPaquete()
        {
            var tipoEntrega = new Region();
            while (true)
            {
                Console.Clear();
                int menuEntregaPaquete = Validaciones.ValidarMenuPrincipal("Seleccione la opción que mas le convenga: ", "1. Entrega del paquete en puerta.\n 2. Retiro en sucursal.", 1, 2);
                if (menuEntregaPaquete == 1)
                {
                    // No implementado.
                    Console.WriteLine("No implementado.\n");
                    Console.WriteLine("Ingrese cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    continue;
                    /*
                    tipoEntrega.TipoEntrega = "Entrega en puerta";

                    // Region de entrega
                    var region = Validaciones.ValidarStringIngresado("Ingrese la region donde se entrega el paquete: ", "");
                    tipoEntrega.EntregaRegion = region;

                    // Provincia de entrega
                    var provincia = Validaciones.ValidarStringIngresado("Ingrese la provincia donde se entrega el paquete: ", "");
                    tipoEntrega.EntregaProvincia = provincia;

                    // Localidad de entrega
                    var localidad = Validaciones.ValidarStringIngresado("Ingrese la localidad donde se entrega el paquete:", "");
                    tipoEntrega.EntregaLocalidad = localidad;

                    // Dirección exacta de entrega               
                    var direccionCalle = Validaciones.ValidarStringIngresado("Ingrese la calle donde se realizara la entrega del paquete:", "Aclaración: solo la calle.");
                    var direccionNumero = Validaciones.ValidarIntIngresado("Ingrese la altura de la calle donde se realizara la entrega del paquete:", 0, 4);
                    tipoEntrega.EntregaDireccion = direccionCalle;
                    tipoEntrega.EntregaDireccionNumero = direccionNumero;
                    */
                }
                if (menuEntregaPaquete == 2)
                {
                    tipoEntrega.TipoEntrega = "Entrega en sucursal";

                    // Region de entrega
                    Console.Clear();
                    do
                    {
                        var region = Validaciones.ValidarStringIngresado("Ingrese la region donde se entrega el paquete: ", "").ToLower();

                    // Hardcodeado
                    
                        if (region != "NOA")
                        {
                            //No implemetado
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            continue;

                        }
                        tipoEntrega.EntregaRegion = region;
                        break;
                    } while (true);
                    

                    // Provincia de entrega
                    Console.Clear();
                    do
                    {
                        var provincia = Validaciones.ValidarStringIngresado("Ingrese la provincia donde se entrega el paquete: ", "").ToLower();

                    // Hardcodeado
                   
                        if (provincia != "catamarca")
                        {
                            // No implementado.
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        tipoEntrega.EntregaProvincia = provincia;
                        break;
                    } while (true);
                    

                    // Localidad de entrega
                    Console.Clear();
                    do
                    {
                        var localidad = Validaciones.ValidarStringIngresado("Ingrese la localidad donde se entrega el paquete:", "").ToLower();

                    // Hardcodeado
                   
                        if (localidad != "san fernando del valle de catamarca")
                        {
                            // No implementado.
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        tipoEntrega.EntregaLocalidad = localidad;
                        break;

                    } while (true);
                    

                    // Sucursal de entrega
                     Console.Clear();
                    do
                    {
                        var nombreSucursal = Validaciones.ValidarStringIngresado("Ingrese la sucursal donde se realizara el retiro del paquete:", "").ToLower();

                    // Hardcodeado
                    
                        if (nombreSucursal != "san fernando del valle de catamarca")
                        {
                            // No implementado.
                            Console.WriteLine("No implementado.\n");
                            Console.WriteLine("Ingrese cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        tipoEntrega.EntregaSucursal = nombreSucursal;
                        break;
                    } while (true);
                    
                }
                break;
            }
            return tipoEntrega;
        }
    }
}