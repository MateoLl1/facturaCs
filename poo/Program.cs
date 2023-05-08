using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo
{
    class Program
    {
        public static ClienteVenta objCliente = new ClienteVenta();
        public static bool error = true;
        static void Main(string[] args)
        {
            metodoXConsola();
            calcularEdad();
            Console.WriteLine("------------------------");
            Console.WriteLine("|    DETALLE VENTA     |");
            Console.WriteLine("------------------------");
            validarCamposVacios(6);
            Console.ReadKey();
            Console.Clear();
            logoMateo();
            Console.ForegroundColor = ConsoleColor.Blue;
            imprimirInfo();
            

        }

        private static void calcularEdad()
        {
            objCliente.Edad = DateTime.Now.Year - objCliente.Anio;
        }

        private static void logoMateo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@" _____            _               ");
            Thread.Sleep(400);
            Console.WriteLine(@"|_   _|          | |              ");
            Thread.Sleep(400);
            Console.WriteLine(@"  | | _ __  _ __ | | ___  _ __ ___");
            Thread.Sleep(400);
            Console.WriteLine(@"  | || '_ \| '_ \| |/ _ \| '__/ _ \");
            Thread.Sleep(400);
            Console.WriteLine(@" _| || | | | |_) | | (_) | | |  __/");
            Thread.Sleep(400);
            Console.WriteLine(@" \___/_| |_| .__/|_|\___/|_|  \___|");
            Thread.Sleep(400);
            Console.WriteLine(@"           | |                     ");
            Thread.Sleep(400);
            Console.WriteLine(@"           |_|                     ");
        }

        private static void validarCamposVacios(int a)
        {
            error = true;
            do
            {
                String campo="";
                
                switch (a)
                {
                    case 1: ///CAMPO NOMBRE
                        Console.Write("| ");
                        Console.Write(" Nombre cliente -> ");
                        campo = Console.ReadLine();
                        if (campo.Length == 0)
                        {
                            MessageBox.Show("Llene el campo");
                        }
                        else
                        {
                            error = false;
                            objCliente.Nombre = campo;
                        }
                        break;
                    case 2: ///CAMPO APELLIDO
                        Console.Write("| ");
                        Console.Write(" Apellido cliente -> ");
                        campo = Console.ReadLine();
                        if (campo.Length == 0)
                        {
                            MessageBox.Show("Llene el campo");
                        }
                        else
                        {
                            error = false;
                            objCliente.Apellido = campo;
                        }
                        break;
                    case 3: ///CAMPO FECHA
                        Console.Write("| ");
                        string dia, mes, año;
                        Console.WriteLine("Fecha de nacimiento dd/mm/aaaa |");
                        Console.Write(" |Dia| ");
                        dia = Console.ReadLine();
                        Console.Write(" |Mes| ");
                        mes = Console.ReadLine();
                        Console.Write(" |Año| ");
                        año = Console.ReadLine();
                        if (dia=="")
                        {
                            MessageBox.Show("Llene el campo");
                        }else if (mes == "")
                        {
                            MessageBox.Show("Llene el campo");
                        }else if (año == "")
                        {
                            MessageBox.Show("Llene el campo");
                        }
                        else
                        {
                            try
                            {
                                objCliente.Dia = Convert.ToInt32(dia);
                                objCliente.Mes = Convert.ToInt32(mes);
                                objCliente.Anio = Convert.ToInt32(año);
                                error = false;
                            }
                            catch (System.FormatException e)
                            {
                                MessageBox.Show("Solo numeros");
                            }
                            
                        }
                        break;
                    case 4: ///CAMPO CREDITO
                        Console.WriteLine("     ------------------------------");
                        Console.Write("     | ");
                        Console.WriteLine("¿El cliente tiene credito? |");
                        Console.WriteLine("     |     1. Si                  |");
                        Console.WriteLine("     |     2. No                  |");
                        Console.Write("     -> ");
                        campo = Console.ReadLine();
                        if (campo.Length == 0)
                        {
                            MessageBox.Show("Llene el campo");
                        }
                        else
                        {
                            if (campo == "1")
                            {
                                error = false;
                                objCliente.Credito = true;
                                Console.WriteLine("     ------------------------------");
                            }
                            else if (campo == "2")
                            {
                                objCliente.Credito = false;
                                error = false;
                                Console.WriteLine("     ------------------------------");
                            }
                            else
                            {
                                MessageBox.Show("Solo son dos opciones");
                            }
                        }
                        break;

                    case 5: ///CAMPO Direccion
                        
                        Console.Write("| ");
                        Console.Write("Direccion -> ");
                        campo = Console.ReadLine();
                        if (campo.Length == 0)
                        {
                            MessageBox.Show("Llene el campo");
                        }
                        else
                        {
                            error = false;
                            objCliente.Direccion = campo;
                        }
                        break;
                    case 6: ///CAMPO Precio
                        Console.Write("| ");
                        Console.Write("Valor del producto -> ");
                        campo = Console.ReadLine();
                        if (campo.Length == 0)
                        {
                            MessageBox.Show("Llene el campo");
                        }
                        else
                        {
                            try
                            {
                                objCliente.Precio = Convert.ToDouble(campo);
                                double precio = objCliente.Precio;
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine($"| El precio mas iva es ${precio = (precio * 0.12) + precio}");
                                Console.WriteLine("------------------------------------");
                                error = false;
                            }
                            catch (System.FormatException e)
                            {
                                MessageBox.Show("Solo numeros");
                            }
                            
                        }
                        break;
                    default: break;
                }
            } while (error == true);

        }

        private static void metodoXConsola()
        {
            Console.WriteLine("----------------------------------------------");
            Console.Write("| ");
            Console.Write("             INVENTARIO CLIENTES          ");
            Console.WriteLine(" |");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("----------------------------------------------");
            validarCedula();
            Console.WriteLine("----------------------------------------------");
            validarCamposVacios(1);
            Console.WriteLine("----------------------------------------------");
            validarCamposVacios(2);
            Console.WriteLine("----------------------------------------------");
            validarCamposVacios(3);
            Console.WriteLine("----------------------------------------------");
            validarCamposVacios(5);
            Console.WriteLine("----------------------------------------------");
            validarCamposVacios(4);
            
        }


        /*METODOS*/

      
        private static int generarNumeroAleatorio()
        {
            Random ran = new Random();
            int num = ran.Next(0, 1001);
            return num;
        }

        private static void imprimirInfo()
        {
            Console.WriteLine("--------------------------------------+");
            Console.WriteLine($"|          FACTURA #{generarNumeroAleatorio()}              |");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"    FECHA: {DateTime.Now}   ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     //////  INFORMACION CLIENTE   ///");
            Console.WriteLine($"     CEDULA: {objCliente.Cedula}");
            Console.WriteLine($"     CLIENTE: {objCliente.Nombre + " " + objCliente.Apellido}");
            Console.WriteLine($"     EDAD: {objCliente.Edad}");
            Console.WriteLine($"     DIRECCION: {objCliente.Direccion}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     //////   DESCRIPCION    //////");
            Console.WriteLine($"     SUBTOTAL: {objCliente.Precio}");
            Console.WriteLine($"     IVA: {(objCliente.Precio * 0.12)}");
            Console.WriteLine($"     TOTAL: {objCliente.Precio + (objCliente.Precio*0.12)}");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }

        private static void validarCedula()
        {
            do
            {
                String cedula = "";
                error = true;
                Console.Write("| ");
                Console.Write(" Digite la cedula -> ");
                cedula = Console.ReadLine();
                if (cedula.Length > 0)
                {
                    char index = cedula[0];
                    if (index == '0')
                    {
                        MessageBox.Show("Cedula no empieza con 0");
                    }
                    else if (cedula.Length != 10)
                    {
                        MessageBox.Show("Son diez digitos");
                    }
                    else
                    {
                        try
                        {
                            objCliente.Cedula = Convert.ToInt32(cedula);

                            error = false;
                        }
                        catch (System.FormatException e)
                        {
                            MessageBox.Show("Solo numero");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese algo");
                }
            } while (error==true);
        }

    }
}
