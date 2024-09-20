// See https://aka.ms/new-console-template for more information
namespace espacioControlCadeteria
{
    
public class Pedidos
{
    private int numero;
    private string obs;
    private Cliente cliente;
    private EstadoPedido estado;

    public int Numero { get => numero; set => numero = value; }
    public string Obs { get => obs; set => obs = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public EstadoPedido Estado { get => estado; set => estado = value; }

        public Pedidos(){
var nuevoCliente=new Cliente();
Cliente=nuevoCliente;
}



public void VerDireccionCliente(){

Console.WriteLine(cliente.Direccion);

}


public void VerDatosCliente(){
Console.WriteLine("******* Datos Cliente ******");
Console.WriteLine("Nombre: "+ cliente.Nombre);
Console.WriteLine("Direccion: "+ cliente.Direccion);
Console.WriteLine("Telefono: "+ cliente.Telefono);
Console.WriteLine("Datos de la direccion: "+ cliente.DatosReferenciaDireccion);
Console.WriteLine("*********************************************");

//corregir esto en tp2

}

}




}