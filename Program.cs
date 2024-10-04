// See https://aka.ms/new-console-template for more information
using espacioControlCadeteria;
using System.Text;
using espacioMenu;
using espacioArchivos;


if (!File.Exists("cadetes.csv"))
{
        Cadete.NuevosCadetes();
}
if (!File.Exists("cadeteria.csv"))
{
        Cadeteria.nuevaCadeteria();
}
var listaCadetes=ArchivosCSV.LeerCadetesDeCSV("cadetes.csv");
ArchivosCSV.LeerCadeteriaDeCSV("cadeteria.csv",listaCadetes);
int opcion=0;
int op;
var listaDePedidos=new List<Pedidos>();
do
{
        
    do
    {   
        Console.WriteLine("\nSeleccione la tarea a realizar: \n1)Dar de alta pedido.\n2)Asignar pedido a cadete.\n3)Cambiar pedido de estado.\n4)Reasignar el pedido a otro cadete.\n5)Salir.");
        int.TryParse(Console.ReadLine(), out op);

    } while (op>5 || op<1);

 switch (op)
 {  

    case 1:
           Menu.DarDeAltaPedidoAlta(listaDePedidos);
    break;


    case 2:
            Menu.AsignarPedido(listaDePedidos, listaCadetes);
    break;


    case 3:
            Menu.CambiarDeEstado(listaCadetes);
    break;


    case 4:
            Menu.ReasignarPedido(listaCadetes);
    break;

    case 5:
        //Pedidos.VerDatosCliente(listaDePedidos);
        //Menu.mostrarPedidosCadetes(listaCadetes);
    
    break;
    
    default:
    break;
 }

} while (op<5 && op>0);
