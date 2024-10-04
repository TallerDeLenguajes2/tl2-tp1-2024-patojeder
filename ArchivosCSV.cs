// See https://aka.ms/new-console-template for more information
using System.Text;
using espacioControlCadeteria;
namespace espacioArchivos{
public class ArchivosCSV{


        public static void GuardarCadetesEnCSV(List<Cadete> cadetes, string archivoRuta)
        {
            var csv = new StringBuilder();
            csv.AppendLine("ID,Nombre,Direccion,Telefono");

            foreach (var cadete in cadetes)
            {
                var linea = $"{cadete.Id},{cadete.Nombre},{cadete.Direccion},{cadete.Telefono}";
                csv.AppendLine(linea);
            }

            File.WriteAllText(archivoRuta, csv.ToString());
        }

        public static List<Cadete> LeerCadetesDeCSV(string archivoRuta)
        {
            var listaCadetes = new List<Cadete>();
            var lineas = File.ReadAllLines(archivoRuta);

            foreach (var linea in lineas.Skip(1)) // Omite la primera línea (cabecera)
            {
                var valores = linea.Split(',');

                //el formato es: ID,Nombre,Direccion,Telefono
                if (valores.Length >= 4)
                {
                    int id = int.Parse(valores[0]);
                    string nombre = valores[1];
                    string direccion = valores[2];
                    string telefono = valores[3];

                    listaCadetes.Add(new Cadete(id, nombre, direccion, telefono));
                }
            }

            return listaCadetes;
        }


       //********************************************************************************************************************************************** 
        public static void GuardarCadeteriaEnCSV(string archivoRuta, Cadeteria infoCadeteria)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Nombre, Telefono, Direccion");

            var linea = $"{infoCadeteria.Nombre ?? "N/A"},{infoCadeteria.Telefono ?? "N/A"},{infoCadeteria.Direccion ?? "N/A"}";
            csv.AppendLine(linea);

            File.WriteAllText(archivoRuta, csv.ToString());
        }

        public static Cadeteria LeerCadeteriaDeCSV(string archivoRuta, List<Cadete> listaDeCadetes)
        {
            var lineas = File.ReadAllLines(archivoRuta);

            // leo a partir de la segunda linea, se omite la cabecera
            if (lineas.Length > 1)
            {
                var valores = lineas[1].Split(',');

                if (valores.Length >= 2)
                {
                    string nombre = valores[0];
                    string telefono = valores[1];
                    string direccion = valores[2];


                    // se crea la cadeteria solo con el nombre, telefono y direccion
                    return new Cadeteria(nombre, telefono, direccion, listaDeCadetes);
                }
            }

            return null; // Retorna null si el archivo no tiene el formato esperado
        }
    }
}