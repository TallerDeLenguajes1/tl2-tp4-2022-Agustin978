namespace Cadeteria_2.Models
{
    public class CadeteModel : PersonaModel
    {
        private float jornalACobrar;
        private List<PedidoModel> pedidos = new List<PedidoModel>();

        public List<PedidoModel> Pedidos { get => pedidos; set => pedidos = value; }

        public CadeteModel(string Nombre, string Direccion, string telefono/*, List<PedidoModel> pedidos*/) : base(Nombre, Direccion, telefono)
        {
            Pedidos = new List<PedidoModel>();
        }
        public PedidoModel getPedido(int pedido) { return pedidos[pedido]; }
        public List<PedidoModel> getPedidos() { return pedidos; }
        public float getJornal() { return jornalACobrar; }


        private void calculaJornalTotal()
        {
            foreach (var pedido in Pedidos)
            {
                if (string.Equals(pedido.getEstadoPedido(), "Entregado"))
                {
                    jornalACobrar += 300;
                    //this.logger.Info($"El cadete {this.getNombre()}, con id {this.getID()}, realizo una entrega");
                }
            }
        }

        public void agregaPedido(PedidoModel p)
        {
            Pedidos.Add(p);
            //this.logger.Info($"Se ingreso un nuevo pedido al cadete {this.getNombre()}");
        }

        public void eliminaPedido(int nro)
        {
            foreach (var pedido in pedidos.ToArray())
            {
                if (pedido.getNroPedido() == nro)
                {
                    Pedidos.Remove(pedido);
                    //this.logger.Info($"Se elimino un pedido al cadete {this.getNombre()}");
                }
            }
        }

        public void muestraPedidos()
        {
            foreach (var pedido in Pedidos)
            {
                pedido.muestraPedido();
                Console.WriteLine("\n");
            }
        }
    }
}
