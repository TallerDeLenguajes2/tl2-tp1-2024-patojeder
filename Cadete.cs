// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using espacioArchivos;
namespace espacioControlCadeteria
{
    

public class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    private List<Pedidos> listaPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Pedidos> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }


public Cadete(int id, string nombre, string direccion, string telefono){
this.id=id;
this.nombre=nombre;
this.direccion=direccion;
this.telefono=telefono;
this.listaPedidos=null;

}


public static void NuevosCadetes(){
        var listaCadetes= new List<Cadete>();
        listaCadetes.Add(new Cadete(0,"davo","San loren 342","38156731"));        
        listaCadetes.Add(new Cadete(1,"Patricio","San juan 1212","38123431"));
        listaCadetes.Add(new Cadete(2,"Javier","Santiago 1521","38176231"));
        listaCadetes.Add(new Cadete(3,"Aquiles","san juan 2200","38156661"));
        listaCadetes.Add(new Cadete(4,"Hector","san juan 3100","385123321"));
        ArchivosCSV.GuardarCadetesEnCSV(listaCadetes,"cadetes.csv");
}

public void JornalACobrar(){

int total=0;
    foreach (var pedido in ListaPedidos)
    {
        if (pedido.Estado==EstadoPedido.entregado)
        {
            total=total + 500;
        }
    }

Console.WriteLine($"El jornal a cobrar por el cadete es: {total}");   
}

}


}