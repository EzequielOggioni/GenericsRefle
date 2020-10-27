using Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenerica.Entidades
{
    public static class Inventario
    {
        public static List<Producto> Productos;
        public static List<Cliente> Clientes;
        public static List<Empleado> Empleados;

       static Inventario()
        {
            Productos = new List<Producto>();
            Clientes = new List<Cliente>();
            Empleados = new List<Empleado>();


            Clientes.Add(new Cliente("Seymour", "Skinner", 5805045, "Seeymourrr@gmail.com", "Bay St 786", 184745854));
            Clientes.Add(new Cliente("Homero", "Simpson", 78458250, "HomeroSimpson@gmail.com", "742 Evergreen Terrace", 1133457845));
            Clientes.Add(new Cliente("Marge", "Simpson", 50305045, "MargeSimpson@gmail.com", "742 Evergreen Terrace", 1133458854));
            Clientes.Add(new Cliente("Bart", "Simpson", 30458582, "BartSimpson@gmail.com", "742 Evergreen T", 456));
            Productos.Add(new Producto(001, "Duff", "Cerveza", 1.99F, 50));
            Productos.Add(new Producto(002, "Duff", "Cola", .99F, 65));
            Productos.Add(new Producto(003, "Duff", "Axe Spray", 9.95F, 27));
            Productos.Add(new Producto(004, "CandyLand", "Gomitas", 12.64F, 45));
            Productos.Add(new Producto(005, "CandyLand", "Veneno Para Ratas", 12.64F, 45));
            Productos.Add(new Producto(006, "Tomaco", "Masticable", 9.99F, 150));

            Empleados.Add(new Empleado("Apu", "Nahasapeemapetilon", 3000, "Apusin", "apusote123"));
            Empleados.Add(new Empleado("Sanjay", "Nahasapeemapetilon", 2100, "Sanjasin", "sanjasote123"));
            Empleados.Add(new Empleado("Lucas", "Rodriguez", 2500, "Lucas1234", "lucas1234"));
            Empleados.Add(new Empleado("Ezequiel", "Oggioni", 2500, "Eze1234", "ezequiel1234"));             




        }

    }
}
