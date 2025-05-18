using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseneo._2__Factory_Method
{
    // Producto
    public interface IAuto
    {
        void Conducir();
    }
    // Productos concretos
    public class Sedan : IAuto
    {
        public void Conducir() => Console.WriteLine("Conduciendo un Sedán");
    }

    public class Deportivo : IAuto
    {
        public void Conducir() => Console.WriteLine("Conduciendo un Deportivo");
    }
    // Fábrica base
    public abstract class AutoFactory
    {
        public abstract IAuto CrearAuto();
    }

    // Fábricas concretas
    public class SedanFactory : AutoFactory
    {
        public override IAuto CrearAuto() => new Sedan();
    }

    public class DeportivoFactory : AutoFactory
    {
        public override IAuto CrearAuto() => new Deportivo();
    }

}
