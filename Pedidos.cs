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


public static void VerDatosCliente(List<Pedidos> listaDePedidos){
    foreach (var pedido in listaDePedidos)
    {
Console.WriteLine("******* Datos Cliente ******");
Console.WriteLine("Nombre: "+ pedido.Cliente.Nombre);
Console.WriteLine("Direccion: "+ pedido.cliente.Direccion);
Console.WriteLine("Telefono: "+ pedido.cliente.Telefono);
Console.WriteLine("Datos de la direccion: "+ pedido.cliente.DatosReferenciaDireccion);
Console.WriteLine("*********************************************");        
    }


//corregir esto en tp2

}

}




}