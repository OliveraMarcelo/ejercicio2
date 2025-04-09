using System;

public class Program
{
    public static void Main()
    {
        //TODO : Clase de Vehiculo 
        Console.WriteLine("Hello World");
        Vehiculo vehiculo = new Vehiculo();
        Console.WriteLine("Marca: " + vehiculo.marca);
        //TODO: Clase de Autobus
        Autobus autobus = new Autobus();

        autobus.cargaDePasajeros(5);
        autobus.show();
    }

}
public class Vehiculo
{
    public string modelo = "";
    public string marca = "";
    public string color = "";
    public int numero_de_serie = 0;
    public void arrancar()
    {
        Console.WriteLine("El vehiculo arranco");
    }
    public void detener()
    {
        Console.WriteLine("El vehiculo se detuvo");
    }
    public void acelerar()
    {
        Console.WriteLine("El vehiculo acelero");
    }
    public void frenar()
    {
        Console.WriteLine("El vehiculo frenó");
    }

}
public class Camion : Vehiculo
{
    public int carga_maxima = 0;
    public int numero_de_ejes = 0;
    public int numero_de_llantas = 0;
    public void cargaDeMercancia(int carga_maxima)
    {
        Console.WriteLine($"Se cargo {carga_maxima} kg de mercancia en el camion");
        if (carga_maxima > 1000)
        {
            Console.WriteLine("El camion esta lleno");
        }
        else
        {
            this.carga_maxima = carga_maxima;
            Console.WriteLine($"{carga_maxima} kg se cargo ");
        }
    }
    public void descargaDeMercancia()
    {
        Console.WriteLine("Descarga de mercancia en el camion");
    }
    public void show()
    {
        Console.WriteLine($"Marca: {marca} \nModelo: {modelo} \nColor: {color} \nCarga maxima: {carga_maxima} \nNumero de ejes: {numero_de_ejes} \nNumero de llantas: {numero_de_llantas}");
    }
}
public class Auto : Vehiculo
{
    public int numero_de_puertas = 0;
    public int numero_de_asientos = 0;
    public void cargaDePasajeros(int numero_de_asientos)
    {
        Console.WriteLine($"Se cargo {numero_de_asientos}  pasajeros en el auto");
        if (numero_de_asientos > 4)
        {
            Console.WriteLine("El auto esta lleno");
        }
        else
        {
            this.numero_de_asientos = numero_de_asientos;
            Console.WriteLine($"{numero_de_asientos} se cargo ");
        }
    }
    public void descargaDePasajeros()
    {
        Console.WriteLine("Descarga de pasajeros en el auto");
    }
    public void show()
    {
        Console.WriteLine($"Marca: {marca} \nModelo: {modelo} \nColor: {color} \nNumero de puertas: {numero_de_puertas} \nNumero de asientos: {numero_de_asientos}");
    }
}

public class Autobus : Vehiculo
{
    public int capacidad_de_pasajeros = 4;
    public int numero_de_puertas = 0;
    public int numero_de_asientos = 0;
    public void cargaDePasajeros(int capacidad_de_pasajeros)
    {
        Console.WriteLine($"Se cargo {capacidad_de_pasajeros}  pasajeros en el autobus");
        if (capacidad_de_pasajeros > 4)
        {
            Console.WriteLine("El autobus esta lleno");
        }
        else
        {
            this.capacidad_de_pasajeros = capacidad_de_pasajeros;
            Console.WriteLine($"{capacidad_de_pasajeros} se cargo ");
        }
    }
    public void descargaDePasajeros()
    {
        Console.WriteLine("Descarga de pasajeros en el autobus");
    }
    public void show()
    {
        Console.WriteLine($"Marca: {marca} \nModelo: {modelo} \nColor: {color} \nCapacidad de pasajeros: {capacidad_de_pasajeros} \nNumero de puertas: {numero_de_puertas} \nNumero de asientos: {numero_de_asientos}");
    }
}
public class Animal
{
    public string especie = "";
    public int edad = 0;
    public string genero = "";
    public void alimentar()
    {
        Console.WriteLine("El animal fue alimentado");
    }
    public void reproducirse()
    {
        Console.WriteLine("El animal se reprodujo");
    }
    public void hacerSonido()
    {
        Console.WriteLine("El animal hizo un sonido");
    }

}
public class Perro : Animal
{
    public string raza = "";
    public void correr()
    {
        Console.WriteLine("El perro corre");
    }
    public void mostrarRaza()
    {
        Console.WriteLine($"La raza del perro es: {raza}");
    }
}
public class Gato : Animal
{
    public string raza = "";
    public void trepar()
    {
        Console.WriteLine("El gato trepa");
    }
}
public class Libro
{
    public string titulo = "";
    public string autor = "";
    public int año_de_publicacion = 0;
    public string genero = "";

    public void leer()
    {
        Console.WriteLine("El libro" + this.titulo + "fue leido");
    }
    public void cerrar()
    {
        Console.WriteLine("El libro" + this.titulo + "fue cerrado");
    }
    public void abrir()
    {
        Console.WriteLine("El libro" + this.titulo + "fue abierto");
    }

}
public class Biblioteca
{
    public string nombre = "";
    public string ubicacion = "";
    public string horario_apertura = "";
    public void agregarLibros()
    {
        Console.WriteLine("Se agregaron libros a la biblioteca");
    }
    public void prestarLibros()
    {
        Console.WriteLine("Se prestaron libros de la biblioteca");
    }
    public void devolverLibros()
    {
        Console.WriteLine("Se devolvieron libros a la biblioteca");
    }
    public void buscarLibrosPorTitulo()
    {
        Console.WriteLine("Se busco un libro por titulo en la biblioteca");
    }
    public void buscarLibrosPorAutor()
    {
        Console.WriteLine("Se busco un libro por autor en la biblioteca");
    }
}
public class CajeroAutomatico()
{
    public string ubicacion = "";
    public int numero_de_serie = 0;
    public int saldo_disponible = 0;
    public void retirarDinero()
    {
        Console.WriteLine("Se retiro dinero del cajero automatico");
    }
    public void depositarDinero()
    {
        Console.WriteLine("Se deposito dinero en el cajero automatico");
    }
    public void consultarSaldo()
    {
        Console.WriteLine("Se consulto el saldo en el cajero automatico");
    }
}

public class Departamento
{
    public string nombre = "";
    public string ubicacion = "";
    public int numero_de_empleados = 0;
    public void agregarEmpleado()
    {
        Console.WriteLine("Se contrato empleado en el departamento");
    }
    public void despedirEmpleados()
    {
        Console.WriteLine("Se despidieron empleados en el departamento");
    }
    public void mostrarEmpleados()
    {
        Console.WriteLine("Se mostraron los empleados del departamento");
    }
}
public class Empleado
{
    public string nombre = "";
    public void calcularSaldo()
    {
        Console.WriteLine("Se calculo el saldo del empleado");
    }
    public void asignarRol()
    {
        Console.WriteLine("Se asigno un rol al empleado");
    }
}
public class Rol{
    public string tipo_de_role = "";
    public string descripcion = "";

    public void mostrarRol()
    {
        Console.WriteLine("Se mostro el rol del empleado");
    }
}
