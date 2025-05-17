using PatronesDeDiseneo.Strategy;

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
