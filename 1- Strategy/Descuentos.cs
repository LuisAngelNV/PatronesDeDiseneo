using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseneo.Strategy
{

    public interface IDescuento
    {
        decimal Descuento(decimal a);
    }
    public class Normal : IDescuento
    {

        public decimal Descuento(decimal a)
        {
            decimal res = (a * 0.05m);
            return (a-res);
        }
    }
    public class Frecuente : IDescuento
    {
        public decimal Descuento(decimal a)
        {
            decimal res = (a * 0.10m);
            return (a - res);
        }
    }
    public class Promocion : IDescuento
    {
        public decimal Descuento(decimal a)
        {
            decimal res = (a * 0.15m);
            return (a - res);
        }
    }


    public class Descuentos
    {
        private IDescuento _descuento;
        public void DarDescuento(IDescuento descuento)
        {
            _descuento = descuento;
        }

        public void AplicarDescuento(decimal monto)
        {
            Console.WriteLine($"Tu pago es de: {_descuento.Descuento(monto)}");
        }
    }
}
