using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseneo._2__Factory_Method
{
    public interface IPago
    {
        void ProcesarPago();
    }

    public interface IFactura
    {
        void GenerarFactura();
    }

    public interface IImpuesto
    {
        decimal CalcularImpuesto(decimal monto);
    }
    public class PagoOxxo : IPago
    {
        public void ProcesarPago() => Console.WriteLine("Pagando con OXXO Pay (MX)");
    }

    public class FacturaCFDI : IFactura
    {
        public void GenerarFactura() => Console.WriteLine("Generando factura CFDI (MX)");
    }

    public class ImpuestoIVA : IImpuesto
    {
        public decimal CalcularImpuesto(decimal monto)
        {
            Console.WriteLine("Calculando IVA (16%) para MX");
            return monto * 0.16m;
        }
    }
    public class PagoSEPA : IPago
    {
        public void ProcesarPago() => Console.WriteLine("Procesando transferencia SEPA (EU)");
    }

    public class FacturaEuropea : IFactura
    {
        public void GenerarFactura() => Console.WriteLine("Generando factura Europea (EU)");
    }

    public class ImpuestoEU : IImpuesto
    {
        public decimal CalcularImpuesto(decimal monto)
        {
            Console.WriteLine("Calculando impuesto 20% para EU");
            return monto * 0.20m;
        }
    }
    public interface IPaisFactory
    {
        IPago CrearPago();
        IFactura CrearFactura();
        IImpuesto CrearImpuesto();
    }
    public class MexicoFactory : IPaisFactory
    {
        public IPago CrearPago() => new PagoOxxo();
        public IFactura CrearFactura() => new FacturaCFDI();
        public IImpuesto CrearImpuesto() => new ImpuestoIVA();
    }

    public class EuropaFactory : IPaisFactory
    {
        public IPago CrearPago() => new PagoSEPA();
        public IFactura CrearFactura() => new FacturaEuropea();
        public IImpuesto CrearImpuesto() => new ImpuestoEU();
    }
    public class TiendaInternacional
    {
        private readonly IPago _pago;
        private readonly IFactura _factura;
        private readonly IImpuesto _impuesto;

        public TiendaInternacional(IPaisFactory factory)
        {
            _pago = factory.CrearPago();
            _factura = factory.CrearFactura();
            _impuesto = factory.CrearImpuesto();
        }

        public void ProcesarOrden(decimal montoBase)
        {
            _pago.ProcesarPago();
            _factura.GenerarFactura();
            var impuesto = _impuesto.CalcularImpuesto(montoBase);
            Console.WriteLine($"Total con impuesto: {montoBase + impuesto:C}");
        }
    }

}
