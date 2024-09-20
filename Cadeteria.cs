// See https://aka.ms/new-console-template for more information
using espacioArchivos;
namespace espacioControlCadeteria
{
    

public class Cadeteria
{
    private string nombre;
    private string telefono;
    private string direccion;
    private List<Cadete> cadetes;
    public string Telefono { get => telefono; set => telefono = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }
    public string Direccion { get => direccion; set => direccion = value; }

        public Cadeteria(string nombre, string telefono, string direccion, List<Cadete> cadetes){

        this.nombre=nombre;
        this.telefono=telefono;
        this.cadetes=cadetes;
        this.direccion=direccion;
    }


    public static void nuevaCadeteria()
    {
        var nuevaCadeteria= new Cadeteria("PediloYAAA","154387451","Avenida Independencia 782" , null);
        ArchivosCSV.GuardarCadeteriaEnCSV("cadeteria.csv", nuevaCadeteria);
        
    }
}

}