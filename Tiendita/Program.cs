using System;

namespace Tiendita
{
    class Producto
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public double Precio { get; set; }

        public Producto(string Nombre, int Codigo, double Precio)
        {
            this.Nombre = Nombre;
            this.Codigo = Codigo;
            this.Precio = Precio;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"El producto es {Nombre}, su codigo unico es {Codigo} y su precio es de {Precio}.");
        }
    }

    class Tienda
    {
        public double Precio { get; set; }

        public Tienda(double precio)
        {
            this.Precio = precio;
        }

        static int CalcularTotal(int producto)
        {
            if (producto == 0)
            {
                return producto;
            }
            else
            {
                return producto + CalcularTotal(producto-1);
            }
        }

        public void MostrarInfo2()
        {
            Console.WriteLine($"El costo total del producto es {Precio}");
        }         
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el nombre del producto");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Escriba el codigo de barra del producto");
            int Codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el precio del producto");
            double Precio = Convert.ToDouble(Console.ReadLine());

            Producto miTienda = new Producto(Nombre, Codigo, Precio);
            Tienda laTienda = new Tienda(Precio);

            miTienda.MostrarInfo();
            laTienda.MostrarInfo2();

            while (true)
            {
                Console.WriteLine("¿Desea agregar otro producto? (s/n)");
                string respuesta = Console.ReadLine();

                if (respuesta == "s")
                {
                    Console.WriteLine("Escriba el nombre del producto");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Escriba el codigo de barra del producto");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Escriba el precio del producto");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    miTienda.MostrarInfo();
                    laTienda.MostrarInfo2();
                }
                else
                {
                    break;
                }
            }
        }
    }
}