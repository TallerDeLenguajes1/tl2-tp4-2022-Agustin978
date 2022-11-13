using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria_2.Models
{
    public class helper
    {
        //private List<CadeteModel> cadetes = new List<CadeteModel>();
        private static string path = @"C:\Cursos\Programacion_UNT\Taller_de_Lenguajes_2\MVCintentoProp\WebApplication1\WebApplication1\archivos\cadetes";
        private static string ext = ".csv";

        /*
        public helper()
        {
            //this.path = path;
            //this.ext = ext;
            //compruebaCarpeta();
            CargaCadetes();
        }*/

        private void compruebaCarpeta() //Compruebo la existencia del archivo, y en caso de no existir lo creo
        {
            if (!File.Exists(path + ext))
            {
                var myFile = File.Create(path + ext);
                myFile.Close();
            }
        }

        public List<CadeteModel> CadetesAlmacenados()
        {
            compruebaCarpeta();
            List<CadeteModel> cadetes = new List<CadeteModel>();
            using (FileStream archivo = new FileStream(path + ext, FileMode.Open))
            {
                using (StreamReader stReader = new StreamReader(archivo))
                {
                    string cad = "";
                    while ((cad = stReader.ReadLine()) != null)
                    {
                        var datos = cad.Split(",");
                        cadetes.Add(new CadeteModel(datos[1], datos[2], datos[3]));
                    }
                }
            }
            return cadetes;

            //string[] CSVobjects = File.ReadAllLines(this.path + this.ext);
            /*foreach(var obj in CSVobjects)
            {
                var valores = obj.Split(',');
                this.cadetes.Add(new CadeteModel(valores[1], valores[2], valores[3]));
            }*/
        }

        /*
        public List<CadeteModel> getCadetes()
        {
            return this.cadetes;
        }*/

        public void agregaCadeteCSV(CadeteModel cadete)
        {
            string lineaCad = $"{cadete.getID()},{cadete.getNombre()},{cadete.getDireccion()},{cadete.getTelefono()}";
            //System.IO.AppendAllText(this.path + this.ext, lineaCad);
            using (FileStream arquivo = new FileStream(path + ext, FileMode.Append))
            {
                using (StreamWriter strWriter = new StreamWriter(arquivo))
                {
                    strWriter.WriteLine(lineaCad);
                }
            }
        }
    }
}
