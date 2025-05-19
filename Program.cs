using PatronesDeDiseneo._2__Factory_Method;
using PatronesDeDiseneo.FactoryMethod;
using PatronesDeDiseneo.Strategy;
using static System.Net.Mime.MediaTypeNames;

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
//Console.WriteLine("________________________ Factory ejercicio - 2");

//Console.WriteLine("Seleccione metodo de pago: 1 = Paypal, 2 = MercadoPAgo");
//int opcion = int.Parse(Console.ReadLine());

//IRegionalFactory regionalFactory = opcion switch
//{
//    1 => new ProcesarPagoM(),
//    2 => new ProcesarPagoP(),
//    _ => throw new Exception("Opción inválida")
//};

//Tienda app = new Tienda(regionalFactory);
//app.ImprimeProceso();
Console.WriteLine("Seleccione país: 1 = México, 2 = Europa");
int opcion = int.Parse(Console.ReadLine());

IPaisFactory factoryMT = opcion switch
{
    1 => new MexicoFactory(),
    2 => new EuropaFactory(),
    _ => throw new Exception("País no soportado")
};

TiendaInternacional app = new TiendaInternacional(factoryMT);
app.ProcesarOrden(1000);
