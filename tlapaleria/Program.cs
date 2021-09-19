using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tlapaleria
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Variables Productos
            string idProduct;
            string name;
            string price;
            string description;
            string quantity;

            // Variables Empleados
            string idEmployee;
            string nameEmployee;
            string ageEmployee;
            string emailEmployee;
            string mobileEmployee;

            // Variables Sucursales
            string idStore;
            string nameStore;
            string emailStore;
            string mobileStore;
            string addressStore;

            // Variables generales
            string path_products = @"c:\products.txt";
            string path_employees = @"c:\empoyees.txt";
            string path_stores = @"c:\stores.txt";

            string option;
            string[] readText;
            string createText;
            try
            {
                do
                {
                    Console.WriteLine("Tlapaleria Luna");
                    Console.WriteLine("Ingrese la opcion");
                    Console.WriteLine("1 Productos");
                    Console.WriteLine("2 Empreados");
                    Console.WriteLine("3 Sucursales");
                    Console.WriteLine("= = = = = = = = = = =");
                    option = Console.ReadLine();
                    Console.Clear();

                    switch (option)
                    {
                        // Registra nuevo producto
                        case "1":

                            do
                            {
                                Console.WriteLine("Ingrese la opcion");
                                Console.WriteLine("1 Registrar producto");
                                Console.WriteLine("2 Mostrar productos");
                                Console.WriteLine("3 Actualizar producto");
                                Console.WriteLine("4 Eliminar producto");
                                Console.WriteLine("Precione s para terminar.");
                                Console.WriteLine("= = = = = = = = = = =");
                                option = Console.ReadLine();
                                Console.Clear();

                                switch (option)
                                {
                                    // Registra nuevo producto
                                    case "1":
                                        if (!File.Exists(path_products))
                                        {
                                            Console.WriteLine("Ingrese codigo de producto");
                                            idProduct = Console.ReadLine();

                                            Console.WriteLine("Ingrese nombre");
                                            name = Console.ReadLine();

                                            Console.WriteLine("Ingrese precio");
                                            price = Console.ReadLine();

                                            Console.WriteLine("Ingrese descripcion");
                                            description = Console.ReadLine();

                                            Console.WriteLine("Ingrese cantidad");
                                            quantity = Console.ReadLine();

                                            createText = idProduct + " " + name + " " + price + " " + description + " " + quantity + Environment.NewLine;

                                            File.WriteAllText(path_products, createText);



                                        }
                                        Console.WriteLine("Ingrese codigo de producto");
                                        idProduct = Console.ReadLine();

                                        Console.WriteLine("Ingrese nombre");
                                        name = Console.ReadLine();

                                        Console.WriteLine("Ingrese precio");
                                        price = Console.ReadLine();

                                        Console.WriteLine("Ingrese descripcion");
                                        description = Console.ReadLine();

                                        Console.WriteLine("Ingrese cantidad");
                                        quantity = Console.ReadLine();

                                        createText = idProduct + " " + name + " " + price + " " + description + " " + quantity + Environment.NewLine;

                                        File.AppendAllText(path_products, createText);

                                        break;

                                    // Muestra lista de productos
                                    case "2":
                                        Console.WriteLine("Productos registrados.");
                                        readText = File.ReadAllLines(path_products);
                                        foreach (string s in readText)
                                        {
                                            Console.WriteLine(s);
                                        }
                                        break;

                                    // Actualiza Producto
                                    case "3":
                                        readText = File.ReadAllLines(path_products);
                                        Console.WriteLine("Ingrese el codigo");
                                        idProduct = Console.ReadLine();



                                        foreach (string s in readText)
                                        {
                                            if (s.Contains(idProduct))
                                            {
                                                var index = Array.IndexOf(readText, s);
                                                Console.WriteLine(s);


                                                Console.WriteLine("Ingrese nombre");
                                                name = Console.ReadLine();

                                                Console.WriteLine("Ingrese precio");
                                                price = Console.ReadLine();

                                                Console.WriteLine("Ingrese descripcion");
                                                description = Console.ReadLine();

                                                Console.WriteLine("Ingrese cantidad");
                                                quantity = Console.ReadLine();

                                                createText = idProduct + " " + name + " " + price + " " + description + " " + quantity;

                                                readText[index] = createText;


                                                File.WriteAllText(path_products, string.Join(Environment.NewLine, readText));

                                            }
                                        }

                                        break;

                                    // Elimina Producto seleccionado
                                    case "4":

                                        readText = File.ReadAllLines(path_products);
                                        Console.WriteLine("Ingrese el codigo");
                                        idProduct = Console.ReadLine();

                                        var newLines = readText.Where(line => !line.Contains(idProduct));

                                        File.WriteAllLines(path_products, newLines);


                                        break;
                                    default:
                                        Console.WriteLine("No se encontro la opcion...");
                                        break;

                                }
                                Console.WriteLine("¿Desea hacer otra consulta de productos?, ingrese 'S' para continuar");
                                option = Console.ReadLine();

                            } while (option == "s" || option == "S");

                            break;

                        case "2":
                            Console.WriteLine("Empleados");
                            do
                            {
                                Console.WriteLine("Ingrese la opcion");
                                Console.WriteLine("1 Registrar empleado");
                                Console.WriteLine("2 Mostrar empleados");
                                Console.WriteLine("3 Actualizar empleado");
                                Console.WriteLine("4 Eliminar empleado");
                                Console.WriteLine("Precione s para terminar.");
                                Console.WriteLine("= = = = = = = = = = =");
                                option = Console.ReadLine();
                                Console.Clear();

                                switch (option)
                                {
                                    // Registra nuevo employee
                                    case "1":
                                        if (!File.Exists(path_employees))
                                        {
                                            Console.WriteLine("Ingrese codigo de empleado");
                                            idEmployee = Console.ReadLine();

                                            Console.WriteLine("Ingrese nombre");
                                            nameEmployee = Console.ReadLine();

                                            Console.WriteLine("Ingrese correo electrónico");
                                            emailEmployee = Console.ReadLine();

                                            Console.WriteLine("Ingrese edad");
                                            ageEmployee = Console.ReadLine();

                                            Console.WriteLine("Ingrese numero telefonico");
                                            mobileEmployee = Console.ReadLine();

                                            createText = idEmployee + " " + nameEmployee + " " + emailEmployee + " " + ageEmployee + " " + mobileEmployee + Environment.NewLine;

                                            File.WriteAllText(path_employees, createText);



                                        }
                                        Console.WriteLine("Ingrese codigo de empleado");
                                        idEmployee = Console.ReadLine();

                                        Console.WriteLine("Ingrese nombre");
                                        nameEmployee = Console.ReadLine();

                                        Console.WriteLine("Ingrese correo electrónico");
                                        emailEmployee = Console.ReadLine();

                                        Console.WriteLine("Ingrese edad");
                                        ageEmployee = Console.ReadLine();

                                        Console.WriteLine("Ingrese numero telefonico");
                                        mobileEmployee = Console.ReadLine();

                                        createText = idEmployee + " " + nameEmployee + " " + emailEmployee + " " + ageEmployee + " " + mobileEmployee + Environment.NewLine;

                                        File.AppendAllText(path_employees, createText);

                                        break;

                                    // Muestra lista de empleados
                                    case "2":
                                        Console.WriteLine("Empleados registrados.");
                                        readText = File.ReadAllLines(path_employees);
                                        foreach (string s in readText)
                                        {
                                            Console.WriteLine(s);
                                        }
                                        break;

                                    // Actualiza empleados
                                    case "3":
                                        readText = File.ReadAllLines(path_employees);
                                        Console.WriteLine("Ingrese el codigo de empleado");
                                        idEmployee = Console.ReadLine();



                                        foreach (string s in readText)
                                        {
                                            if (s.Contains(idEmployee))
                                            {
                                                var index = Array.IndexOf(readText, s);
                                                Console.WriteLine(s);


                                                Console.WriteLine("Ingrese nombre");
                                                nameEmployee = Console.ReadLine();

                                                Console.WriteLine("Ingrese correo electrónico");
                                                emailEmployee = Console.ReadLine();

                                                Console.WriteLine("Ingrese edad");
                                                ageEmployee = Console.ReadLine();

                                                Console.WriteLine("Ingrese numero telefonico");
                                                mobileEmployee = Console.ReadLine();

                                                createText = idEmployee + " " + nameEmployee + " " + emailEmployee + " " + ageEmployee + " " + mobileEmployee;


                                                readText[index] = createText;


                                                File.WriteAllText(path_employees, string.Join(Environment.NewLine, readText));

                                            }
                                        }

                                        break;

                                    // Elimina tienda seleccionado
                                    case "4":
                                        Console.WriteLine("Eliminar empleado");
                                        readText = File.ReadAllLines(path_employees);
                                        Console.WriteLine("Ingrese el codigo de empleado");
                                        idEmployee = Console.ReadLine();

                                        var newLines = readText.Where(line => !line.Contains(idEmployee));

                                        File.WriteAllLines(path_employees, newLines);


                                        break;
                                    default:
                                        Console.WriteLine("No se encontro la opcion...");
                                        break;

                                }
                                Console.WriteLine("¿Desea hacer otra consulta de empleados?, ingrese 'S' para continuar");
                                option = Console.ReadLine();

                            } while (option == "s" || option == "S");
                            break;

                        case "3":
                            Console.WriteLine("Tiendas");
                            do
                            {
                                Console.WriteLine("Ingrese la opcion");
                                Console.WriteLine("1 Registrar tienda");
                                Console.WriteLine("2 Mostrar tiendas");
                                Console.WriteLine("3 Actualizar tienda");
                                Console.WriteLine("4 Eliminar tienda");
                                Console.WriteLine("Precione s para terminar.");
                                Console.WriteLine("= = = = = = = = = = =");
                                option = Console.ReadLine();
                                Console.Clear();

                                switch (option)
                                {
                                    // Registra nuevo store
                                    case "1":
                                        if (!File.Exists(path_stores))
                                        {
                                            Console.WriteLine("Ingrese codigo de tienda");
                                            idStore = Console.ReadLine();

                                            Console.WriteLine("Ingrese nombre de tienda");
                                            nameStore = Console.ReadLine();

                                            Console.WriteLine("Ingrese correo electrónico");
                                            emailStore = Console.ReadLine();

                                            Console.WriteLine("Ingrese direccion");
                                            addressStore = Console.ReadLine();

                                            Console.WriteLine("Ingrese numero telefonico");
                                            mobileStore = Console.ReadLine();

                                            createText = idStore + " " + nameStore + " " + emailStore + " " + addressStore + " " + mobileStore + Environment.NewLine;

                                            File.WriteAllText(path_stores, createText);



                                        }
                                        Console.WriteLine("Ingrese codigo de tienda");
                                        idStore = Console.ReadLine();

                                        Console.WriteLine("Ingrese nombre de tienda");
                                        nameStore = Console.ReadLine();

                                        Console.WriteLine("Ingrese correo electrónico");
                                        emailStore = Console.ReadLine();

                                        Console.WriteLine("Ingrese direccion");
                                        addressStore = Console.ReadLine();

                                        Console.WriteLine("Ingrese numero telefonico");
                                        mobileStore = Console.ReadLine();

                                        createText = idStore + " " + nameStore + " " + emailStore + " " + addressStore + " " + mobileStore + Environment.NewLine;

                                        File.AppendAllText(path_stores, createText);

                                        break;

                                    // Muestra lista de tiendas
                                    case "2":
                                        Console.WriteLine("Tiendas registradas.");
                                        readText = File.ReadAllLines(path_stores);
                                        foreach (string s in readText)
                                        {
                                            Console.WriteLine(s);
                                        }
                                        break;

                                    // Actualiza tiendas
                                    case "3":
                                        Console.WriteLine("Actualizar tienda");
                                        readText = File.ReadAllLines(path_stores);
                                        Console.WriteLine("Ingrese el codigo de tienda");
                                        idStore = Console.ReadLine();



                                        foreach (string s in readText)
                                        {
                                            if (s.Contains(idStore))
                                            {
                                                var index = Array.IndexOf(readText, s);
                                                Console.WriteLine(s);


                                                Console.WriteLine("Ingrese nombre de tienda");
                                                nameStore = Console.ReadLine();

                                                Console.WriteLine("Ingrese correo electrónico");
                                                emailStore = Console.ReadLine();

                                                Console.WriteLine("Ingrese direccion");
                                                addressStore = Console.ReadLine();

                                                Console.WriteLine("Ingrese numero telefonico");
                                                mobileStore = Console.ReadLine();


                                                createText = idStore + " " + nameStore + " " + emailStore + " " + addressStore + " " + mobileStore;


                                                readText[index] = createText;


                                                File.WriteAllText(path_stores, string.Join(Environment.NewLine, readText));

                                            }
                                        }

                                        break;

                                    // Elimina tienda seleccionado
                                    case "4":
                                        Console.WriteLine("Eliminar tienda");
                                        readText = File.ReadAllLines(path_stores);
                                        Console.WriteLine("Ingrese el codigo de tienda");
                                        idStore = Console.ReadLine();

                                        var newLines = readText.Where(line => !line.Contains(idStore));

                                        File.WriteAllLines(path_stores, newLines);


                                        break;
                                    default:
                                        Console.WriteLine("No se encontro la opcion...");
                                        break;

                                }
                                Console.WriteLine("¿Desea hacer otra consulta de tiendas?, ingrese 'S' para continuar");
                                option = Console.ReadLine();

                            } while (option == "s" || option == "S");
                            break;

                        default:
                            Console.WriteLine("No se encontro la opcion...");
                            break;
                    }

                            Console.WriteLine("¿Volver al menu principal?, ingrese 'S' para continuar");
                    option = Console.ReadLine();

                } while (option == "s" || option == "S");



            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
