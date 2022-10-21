using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria2_0.Models
{
    public class ClienteModel: PersonaModel
    {
        private string DatosReferenciaDireccion;
        public ClienteModel(string Nombre, string direccion, string telefono, string datosReferencia):base(Nombre,direccion,telefono)
        {
            this.DatosReferenciaDireccion = datosReferencia;
        }

        //Metodo getter
        public string getDatosReferenciaDireccion(){return this.DatosReferenciaDireccion;}
        //Metodo setter
        public void setDatosReferenciaDireccion(string datosReferencia){this.DatosReferenciaDireccion = datosReferencia;}

        public override string ToString()
        {
            return "Nombre: "+this.getNombre()+"---Direccion: "+this.getDireccion()+"---Referencia de direccion: "+this.getDatosReferenciaDireccion()+"---Telefono: "+this.getTelefono()+"---ID: "+this.getID();
        }
    }
}