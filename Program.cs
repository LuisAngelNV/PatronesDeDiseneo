using PatronesDeDiseneo._2__Factory_Method;
using PatronesDeDiseneo.Strategy;

// Patron Strategi

Console.WriteLine("________________________ Strategy");
Descuentos descuentos = new Descuentos();
descuentos.DarDescuento(new Promocion());
//descuentos.DescuentoUser(343);
List<IDescuento> descuentos1 = new List<IDescuento>()
{
    new Promocion(),
    new Frecuente(),
    new Normal()
};
foreach (var desc in descuentos1)
{
    descuentos.DarDescuento(desc);
    Console.WriteLine($"Aplicando descuento: {desc.GetType().Name}");
    descuentos.AplicarDescuento(343);
}
List<IEnemigos> enemigos = new List<IEnemigos>()
{
    new Mago(),
    new Orco(),
    new Guardian()
};
foreach (var item in enemigos)
{
    item.Atacar();
}
Console.WriteLine("________________________ Factory");
AutoFactory factory = new SedanFactory();  // Se puede cambiar a DeportivoFactory
IAuto auto = factory.CrearAuto();          // No se usa "new" directamente
auto.Conducir();

Console.WriteLine("________________________ Factory ejercicio");
BebidaFriaFactory bebidaFriaUno= new AguaFactory();
IBebidaFria bebidaFria = bebidaFriaUno.CrearBebida();
bebidaFria.Servir();


BebidaFriaFactory bebidaDos = new JugoFactory();  
IBebidaFria bebidaFriaDos = bebidaDos.CrearBebida();
bebidaFriaDos.Servir();



