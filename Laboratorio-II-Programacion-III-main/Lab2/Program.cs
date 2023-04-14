using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Area> areas = new List<Area>();
            List<Category> categories = new List<Category>();
            List<Product> products = new List<Product>();

            areas.Add(new Area("Alimentos"));
            areas.Add(new Area("Limpieza"));
            areas.Add(new Area("Cuidado personal"));

            categories.Add(new Category("Frutas y verduras", areas[0]));
            categories.Add(new Category("Carnes y pescados", areas[0]));
            categories.Add(new Category("Limpieza del hogar", areas[1]));
            categories.Add(new Category("Limpieza de Autos", areas[1]));
            categories.Add(new Category("Cuidado del cabello", areas[2]));
            categories.Add(new Category("Higiene bucal", areas[2]));

            products.Add(new Product("Manzanas", "Frutícola del Valle", new DateTime(2023, 05, 30), new DateTime(2023, 04, 14), "Bolsa de 1 kg", 2.99, 10, categories[0]));
            products.Add(new Product("Pollo entero", "Agropecuaria Santa Marta", new DateTime(2023, 04, 20), new DateTime(2023, 04, 12), "Sin hueso, sin piel", 9.99, 5, categories[1]));
            products.Add(new Product("Pasta dental Colgate", "Colgate-Palmolive", new DateTime(2024, 03, 01), new DateTime(2023, 04, 01), "Blanqueamiento", 4.99, 20, categories[5]));

            Console.WriteLine("================================================\n" +
                              "  Bienvenido a la aplicación a SupermarcketApp\n" +
                              "\n" +
                              "Desarollado por: Alexander Zelaya & Marvin Rivas\n" +
                              "================================================");

            Employee employee = new Employee("employee", "2023");

            bool loginCorrecto = false;

            do
            {
                Console.WriteLine("     Por favor, ingrese sus credenciales:\n" +
                                  "================================================");

                Console.Write("Nombre de Usuario: ");
                string username = Console.ReadLine();

                Console.Write("Contraseña: ");
                string password = Console.ReadLine();

                if (employee.Username == username && employee.Password == password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("================================================\n" +
                                      "        Bienvenido Empleado, actualmente\n" +
                                      "             se encuentra Trabajando\n" +
                                      "================================================");
                    Console.ForegroundColor = ConsoleColor.White;

                    loginCorrecto = true;
                }
                else
                {
                    Console.WriteLine("================================================\n" +
                                      "Crendenciales incorrectas, intentelo nuevamente!\n" +
                                      "================================================");
                }
            } while (!loginCorrecto);

            while (true)
            {
                Console.WriteLine("             Areas del Supermercado\n" +
                                  "================================================");

                for (int i = 0; i < areas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {areas[i].Name}");
                }

                Console.WriteLine("================================================\n" +
                                  "            Categorías del Supermercado\n" +
                                  "================================================");

                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {categories[i].Name}");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("================================================\n" +
                                  "            Productos registrados\n" +
                                  "================================================");

                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name} ({products[i].Category.Name} - {products[i].Category.Area.Name}) - Proveedor: {products[i].Provider} - Precio {products[i].Price} - Unidades: {products[i].Units} - Fecha de Caducidad: {products[i].ExpirationDate}\n");
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("================================================\n" +
                              "Seleccione una opción: \n" +
                              "1. Crear área\n" +
                              "2. Crear categoría\n" +
                              "3. Crear producto\n" +
                              "4. Registrar venta\n" +
                              "5. Salir\n" +
                              "================================================\n" +
                              "opción: ");
                Console.ForegroundColor = ConsoleColor.White;

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Console.Write("================================================\n" +
                                      "Ingrese el nombre del área: ");
                        string areaName = Console.ReadLine();
                        areas.Add(new Area(areaName));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("================================================\n" +
                                          "             Área creada con éxito\n" +
                                          "================================================");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;

                    case 2:

                        Console.Write("================================================\n" +
                                      "Ingrese el nombre de la categoría: ");
                        string categoryName = Console.ReadLine();
                        Console.Write("================================================\n" +
                                      "Seleccione el área a la que pertenece la categoría:\n");

                        for (int i = 0; i < areas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {areas[i].Name}");
                        }

                        Console.Write("opción: ");
                        int areaOption = int.Parse(Console.ReadLine());

                        Category category = new Category(categoryName, areas[areaOption - 1]);
                        categories.Add(category);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("================================================\n" +
                                          "          Categoría creada con éxito\n" +
                                          "================================================");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;

                    case 3:

                        Console.Write("================================================\n" +
                                      "Ingrese el nombre del producto: ");
                        string productName = Console.ReadLine();
                        Console.Write("Ingrese el nombre del proveedor: ");
                        string providerName = Console.ReadLine();
                        Console.Write("Ingrese la fecha de caducidad (dd/mm/yyyy): ");
                        DateTime expirationDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.Write("Ingrese la fecha de entrada (dd/mm/yyyy): ");
                        DateTime entryDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.Write("Ingrese el detalle del producto: ");
                        string productDetails = Console.ReadLine();
                        Console.Write("Ingrese el precio del producto: ");
                        double productPrice = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de unidades del producto: ");
                        int productUnits = int.Parse(Console.ReadLine());
                        Console.Write("================================================\n" +
                            "Seleccione la categoría a la que pertenece el producto:\n");

                        for (int i = 0; i < categories.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {categories[i].Name} ({categories[i].Area.Name})");
                        }

                        int categoryOption = int.Parse(Console.ReadLine());

                        Product product = new Product(productName, providerName, expirationDate, entryDate, productDetails, productPrice, productUnits, categories[categoryOption - 1]);
                        products.Add(product);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("================================================\n" +
                                          "           Producto creado con éxito\n" +
                                          "================================================");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;

                    case 4:

                        Console.Write("================================================\n" +
                                      "Ingrese el nombre del cliente: ");
                        string userName = Console.ReadLine();

                        List<Product> selectedProducts = new List<Product>();

                        while (true)
                        {
                            Console.Write("================================================\n" +
                                          "Seleccione un producto para agregar a la venta:\n");

                            for (int i = 0; i < products.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {products[i].Name} ({products[i].Category.Name} - {products[i].Category.Area.Name})");
                            }

                            Console.Write("\n0. Terminar selección de productos\n" +
                                          "================================================\n" +
                                          "opción: ");
                            option = int.Parse(Console.ReadLine());

                            if (option == 0)
                            {
                                break;
                            }
                            else if (option > 0 && option <= products.Count)
                            {
                                selectedProducts.Add(products[option - 1]);
                            }
                            else
                            {
                                Console.WriteLine("Opción inválida. Intente de nuevo.");
                            }
                        }

                        double total = 0;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("================================================\n" +
                                      "Productos seleccionados: ");

                        foreach (Product p in selectedProducts)
                        {
                            Console.WriteLine($"{p.Name} - {p.Price}");
                            total += p.Price;
                        }

                        Console.WriteLine($"Total: {total}");
                        Console.WriteLine($"Venta registrada a nombre del cliente: {userName}.\n" +
                                           "================================================");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;

                    case 5:

                        Console.WriteLine("================================================\n" +
                                          "Gracias por utilizar la aplicación del supermercado.");

                        return;
                    default:

                        Console.WriteLine("================================================\n" +
                                          "Opción inválida. Intente de nuevo.");

                        break;
                }
            }
        }
    }
}
