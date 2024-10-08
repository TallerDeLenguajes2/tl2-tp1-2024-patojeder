// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using espacioControlCadeteria;
using Microsoft.VisualBasic;
namespace espacioMenu
{
    

public class Menu{
    public static void DarDeAltaPedidoAlta(List<Pedidos> listaPedidos){
    int id=0;

    var nuevoPedido= new Pedidos();
    Console.WriteLine("Ingrese la direccion: ");
    nuevoPedido.Cliente.Direccion=Console.ReadLine();
    Console.WriteLine("Ingrese el nombre: ");
    nuevoPedido.Cliente.Nombre=Console.ReadLine();
    Console.WriteLine("Ingrese el telefono: ");
    nuevoPedido.Cliente.Telefono=Console.ReadLine();
    Console.WriteLine("Ingrese datos de referencia de la direccion: ");
    nuevoPedido.Cliente.DatosReferenciaDireccion=Console.ReadLine();
    Console.WriteLine("Ingrese observaciones: ");
    nuevoPedido.Obs=Console.ReadLine();
    nuevoPedido.Estado=EstadoPedido.cargado;
    nuevoPedido.Numero=listaPedidos.Count+1;
    listaPedidos.Add(nuevoPedido);
    
}

public static void AsignarPedido(List<Pedidos> listaDePedidos, List<Cadete> listaCadetes) {
    Console.WriteLine("Ingrese el numero de pedido que desea asignar:");
    int numero;
    int.TryParse(Console.ReadLine(), out numero);

    Console.WriteLine("Ingrese la id del cadete cuyo pedido desea asignar:");
    int id;
    int.TryParse(Console.ReadLine(), out id);

    if (listaDePedidos != null) {
        Pedidos pedidoAEliminar = null;

        foreach (var pedido in listaDePedidos) {
            if (pedido.Numero == numero) {
                foreach (var cadete in listaCadetes) {
                    if (cadete.Id == id) {
                        if (cadete.ListaPedidos == null) {
                            cadete.ListaPedidos = new List<Pedidos>();
                        }
                        pedido.Estado = EstadoPedido.pendiente;
                        cadete.ListaPedidos.Add(pedido);

                        pedidoAEliminar = pedido;
                        break;
                    }
                }
            }

            if (pedidoAEliminar != null) break;
        }

        if (pedidoAEliminar != null) {
            listaDePedidos.Remove(pedidoAEliminar);
        }
    } else {
        Console.WriteLine("No hay pedidos en la lista");
    }
}


//a este le tengo que cambiar para que controle segundonde este el pedido
public static void CambiarDeEstado(List<Cadete> listaDeCadetes){


            int numero;
            int bandera=0;
            
    do
    {
            Console.WriteLine("ingrese la id del pedido cuyo estado desea cambiar:");

            int.TryParse(Console.ReadLine(), out numero);

    } while (50 < numero  || numero < 0 );

            int estado;    

                do
                {
                                Console.WriteLine("Ingrese el nuevo estado del pedido: 0) cargado.\n 1) pendiente. \n 2) entregado. ");

                                int.TryParse(Console.ReadLine(), out estado);

                } while (estado>2 || estado<0);




    foreach (var cadete in listaDeCadetes)
    {
        if (cadete.ListaPedidos != null)
        {
            foreach (var pedido in cadete.ListaPedidos.ToList()) //  el ToList() se usa para evitar problemas de modificación durante la iteración
            {
                if (pedido.Numero == numero)
                {
                    pedido.Estado=(EstadoPedido)numero;
                    bandera=1;     
                    break;
                }
            }
        }
    }

    if (bandera==1)
    {
        Console.WriteLine("Estado del pedido cambiado con exito");
    }else
    {
        Console.WriteLine($"No se encontro el pedido de id: {numero}");
    }
    
}


public static void ReasignarPedido(List<Cadete> listaDeCadetes)
{
    int numero;
    int id;
    Pedidos pedidoAux = null;

    Console.WriteLine("Ingrese el número de pedido que quiere reasignar:");
    int.TryParse(Console.ReadLine(), out numero);

  
    foreach (var cadete in listaDeCadetes)
    {
        if (cadete.ListaPedidos != null)
        {
            foreach (var pedido in cadete.ListaPedidos.ToList()) //  el ToList() se usa para evitar problemas de modificación durante la iteración
            {
                if (pedido.Numero == numero)
                {
                    pedidoAux = pedido;
                    cadete.ListaPedidos.Remove(pedido);
                    break;
                }
            }
        }
    }

    // Verifico si se encontró el pedido
    if (pedidoAux == null)
    {
        Console.WriteLine("asasadasdsd Pedido no encontrado.");
        return;
    }

   
    do
    {
        Console.WriteLine("Ingrese el ID del cadete a asignar:");//id delk nuevo cadete
        int.TryParse(Console.ReadLine(), out id);
    } while (id < 0 || id >= listaDeCadetes.Count);

  
    var nuevoCadete = listaDeCadetes.FirstOrDefault(c => c.Id == id);
    if (nuevoCadete == null)
    {
        Console.WriteLine("Cadete no encontrado.");
        return;
    }


    if (nuevoCadete.ListaPedidos == null)
    {
        nuevoCadete.ListaPedidos = new List<Pedidos>();
    }

    nuevoCadete.ListaPedidos.Add(pedidoAux);

    Console.WriteLine("Pedido reasignado con éxito.");
}



public static void mostrarPedidosCadetes(List<Cadete> listaDeCadetes)
{

    foreach (var cadete in listaDeCadetes)
    {
       Console.WriteLine($"****     pedidos del cadete numero {cadete.Id}     *********");

       if (cadete.ListaPedidos!=null)
       {
        
        foreach (var pedido in cadete.ListaPedidos)
        {
            Console.WriteLine($"Direccion {pedido.Cliente.Direccion}");
            Console.WriteLine($"Nombre {pedido.Cliente.Nombre}");
            Console.WriteLine($"Telefono {pedido.Cliente.Telefono}");
            Console.WriteLine($"Referencia {pedido.Cliente.DatosReferenciaDireccion}");
            Console.WriteLine($"observaciones {pedido.Obs}");
            Console.WriteLine($"numero de pedido {pedido.Numero}");
            Console.WriteLine($"Estado PEDIDO: {pedido.Estado}");
        }

       }

        Console.WriteLine("+++++++++++++++++++++++++++++++");
    }
}

}

}
