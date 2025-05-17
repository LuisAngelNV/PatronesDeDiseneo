using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseneo.Strategy
{
    public interface IEnemigos
    {
        void Atacar();
    }
    public class Mago : IEnemigos
    {
        public void Atacar()
        {
            Console.WriteLine("Lanzar echizo de restar vida");
        }
    }

    public class Guardian : IEnemigos
    {
        public void Atacar()
        {
            Console.WriteLine("Lanzar ataque con una espada envenenada");
        }
    }

    public class Orco : IEnemigos
    {
        public void Atacar()
        {
            Console.WriteLine("Atacan a los humanos con arcos y mazos");
        }
    }

    public class Enemigos
    {
        private IEnemigos _enemigos;
        public void EnemigoRandomaAtacar(IEnemigos enemigos)
        {
            _enemigos = enemigos;
        }

        public void enemigoAtaca()
        {
            _enemigos.Atacar();
        }
    }
}
