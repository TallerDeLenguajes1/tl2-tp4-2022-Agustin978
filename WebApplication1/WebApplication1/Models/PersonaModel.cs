namespace Cadeteria_2.Models
{
    public class PersonaModel
    {
        private string Nombre;
        private string Direccion;
        private string Telefono;
        private int ID;
        private static int autoincremental;

        public PersonaModel(string nombre, string direccion, string telefono)
        {
            autoincremental++;
            ID = autoincremental;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            //ID = iD;
        }
        //Metodos Getter
        public string getNombre() { return Nombre; }
        public string getDireccion() { return Direccion; }
        public string getTelefono() { return Telefono; }
        public int getID() { return ID; }
        //Metodos setter
        public void setNombre(string Nombre) { this.Nombre = Nombre; }
        public void setDireccion(string direccion) { Direccion = direccion; }
        public void setTelefono(string telefono) { Telefono = telefono; }
    }
}
