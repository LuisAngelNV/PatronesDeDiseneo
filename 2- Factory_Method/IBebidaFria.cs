using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatronesDeDiseneo._2__Factory_Method
{
    // Intercace
    public interface IBebidaFria
    {
        void Servir();
    }
    //  Clases que lo aplican
    public class Agua : IBebidaFria {
        public void Servir() => Console.WriteLine("Sirviendo un agua fria");
    }
    public class Refresco : IBebidaFria{
        public void Servir() => Console.WriteLine("Sirviendo un refresco frio");
    }
    public class Jugo : IBebidaFria {
        public void Servir() => Console.WriteLine("Sirviendo un jugo frio");
    }
    // Fábrica base
    public abstract class BebidaFriaFactory
    {
        public abstract IBebidaFria CrearBebida();
    }
    public class AguaFactory : BebidaFriaFactory
    {
        public override IBebidaFria CrearBebida() => new Agua();
    }
    public class RefrescoFactory : BebidaFriaFactory
    {
        public override IBebidaFria CrearBebida() => new Refresco();
    }
    public class JugoFactory : BebidaFriaFactory
    {
        public override IBebidaFria CrearBebida() => new Jugo();
    }
}
