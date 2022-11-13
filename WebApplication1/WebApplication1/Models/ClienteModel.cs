namespace Cadeteria_2.Models
{
    public class ClienteModel : PersonaModel
    {
        private string DatosReferenciaDireccion;
        public ClienteModel(string Nombre, string direccion, string telefono, string datosReferencia) : base(Nombre, direccion, telefono)
        {
            DatosReferenciaDireccion = datosReferencia;
        }

        //Metodo getter
        public string getDatosReferenciaDireccion() { return DatosReferenciaDireccion; }
        //Metodo setter
        public void setDatosReferenciaDireccion(string datosReferencia) { DatosReferenciaDireccion = datosReferencia; }

        public override string ToString()
        {
            return "Nombre: " + getNombre() + "---Direccion: " + getDireccion() + "---Referencia de direccion: " + getDatosReferenciaDireccion() + "---Telefono: " + getTelefono() + "---ID: " + getID();
        }
    }
}
