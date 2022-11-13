namespace Cadeteria_2.Models
{
    public class PedidoModel
    {
        private static int autoIncremental;
        private int NroPedido;
        private string observacion { get; set; }
        private ClienteModel? cliente = null;
        private string[] estado = new string[4] { "Tomado", "En proceso", "Despachado", "Entregado" };
        private string estadoP;
        private double montoPaga;

        public PedidoModel(string observacion, int estado, double monto, string NombreCli, string direccion, string telefonoCli, string datosRefCli)
        {
            autoIncremental++;
            NroPedido = autoIncremental;
            this.observacion = observacion;
            estadoP = this.estado[estado];
            montoPaga = monto;
            CreaCliente(NombreCli, direccion, telefonoCli, datosRefCli);
        }

        //Metodo getter
        public int getNroPedido() { return NroPedido; }
        public string getObservacion() { return observacion; }
        public ClienteModel GetCliente() { return cliente; }
        public string getEstadoPedido() { return estadoP; }

        public double getMontoPagar() { return montoPaga; }

        //Metodo para mostrar el pedido
        public void muestraPedido()
        {
            Console.WriteLine($"------------------Nro Pedido:  {getNroPedido()}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Monto a pagar:               $ {getMontoPagar()}");
            Console.WriteLine($"Nombre cliente:                {GetCliente().getNombre()}");
            Console.WriteLine($"Direccion:                     {GetCliente().getDireccion()}");
            Console.WriteLine($"Datos de referencia:           {GetCliente().getDatosReferenciaDireccion()}");
            Console.WriteLine($"Telefono:                      {GetCliente().getTelefono()}");
            Console.WriteLine($"Id:                            {GetCliente().getID()}");
            Console.WriteLine($"Estado del pedido:             {getEstadoPedido()}");
        }

        //Metodo para crear al cliente
        private void CreaCliente(string NombreCli, string direccion, string telefonoCli, string datosRefCli)
        {
            cliente = new ClienteModel(NombreCli, direccion, telefonoCli, datosRefCli);
        }
    }
}
