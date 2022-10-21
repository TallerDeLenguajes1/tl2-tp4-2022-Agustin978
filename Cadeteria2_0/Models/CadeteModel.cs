using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria2_0.Models
{
    public class CadeteModel: PersonaModel
    {
        private float jornalACobrar;
        private List<PedidoModel> pedidos;
        
        public CadeteModel(string Nombre, string Direccion, string telefono/*, List<PedidoModel> pedidos*/):base(Nombre, Direccion, telefono)
        {
            this.pedidos = null;
        }
        public PedidoModel getPedido(int pedido){return this.pedidos[pedido];}
        public List<PedidoModel> getPedidos(){return this.pedidos;}
        public float getJornal(){return this.jornalACobrar;}

        private void calculaJornalTotal()
        {
            foreach(var pedido in this.pedidos)
            {
                if(string.Equals(pedido.getEstadoPedido(),"Entregado"))
                {
                    this.jornalACobrar += 300;
                    //this.logger.Info($"El cadete {this.getNombre()}, con id {this.getID()}, realizo una entrega");
                }
            }
        }

        public void agregaPedido(PedidoModel p)
        {
            this.pedidos.Add(p);
            //this.logger.Info($"Se ingreso un nuevo pedido al cadete {this.getNombre()}");
        }

        public void eliminaPedido(int nro)
        {
            foreach(var pedido in this.pedidos.ToArray())
            {
                if(pedido.getNroPedido() == nro)
                {
                    this.pedidos.Remove(pedido);
                    //this.logger.Info($"Se elimino un pedido al cadete {this.getNombre()}");
                }
            }
        }

        public void muestraPedidos()
        {
            foreach(var pedido in this.pedidos)
            {
                pedido.muestraPedido();
                Console.WriteLine("\n");
            }
        }
        }
}