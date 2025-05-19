using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


/*
 Cada región ofrece:
Un sistema de pago (ej: PayPal o MercadoPago)
Un tipo de factura (Factura Europea o CFDI mexicano)


 Una interfaz IRegionalFactory con los métodos CrearPago() y CrearFactura().
Las interfaces IPago y IFactura.
Las clases concretas para Europa y América.
Una clase cliente Tienda que reciba una IRegionalFactory.
 */
namespace PatronesDeDiseneo.FactoryMethod
{
    // Elementos abstractos
    public interface IPago
    {
        void Procesando();
    }
    public interface IFactura
    {
        void GenerarFactura();
    }
    // Proceso de facturas - 
    public class ProcesarPagoMercadoPago : IPago 
    {
        public void Procesando() => Console.WriteLine("Procesando pago con MercadoPago.");
    }
    public class GeneraFacturaEuropea: IFactura
    {
        public void GenerarFactura() => Console.WriteLine("Generando factura CFDI.");

    }
    public class ProcesarPagoPaypal : IPago
    {
        public void Procesando() => Console.WriteLine($"Procesando pago con PayPal.");
    }
    public class GeneraFacturaCFDI : IFactura
    {
        public void GenerarFactura() => Console.WriteLine("Generando factura Europea.");
    }
    // Fábrica abstracta
    public interface IRegionalFactory
    {
        IPago CrearPago();
        IFactura CrearFactura();
    }

    // Porcesar pago MercadoPago - CFDI
    public class ProcesarPagoM : IRegionalFactory
    {
        public IPago CrearPago() => new ProcesarPagoMercadoPago();
        public IFactura CrearFactura() => new GeneraFacturaEuropea();
    } 
    // Porcesar pago Paypal - Europea
    public class ProcesarPagoP: IRegionalFactory
    {
        public IPago CrearPago() => new ProcesarPagoPaypal();
        public IFactura CrearFactura() => new GeneraFacturaCFDI();
    }
    public class Tienda
    {
        private readonly IPago _IPago;
        private readonly IFactura _Factura;

        public Tienda(IRegionalFactory IregionalFactory)
        {
            _IPago = IregionalFactory.CrearPago();
            _Factura = IregionalFactory.CrearFactura();
        }
        public void ImprimeProceso()
        {
            _IPago.Procesando();
            _Factura.GenerarFactura();

        }
    }
}
