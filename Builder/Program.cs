namespace Builder
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // modeo tradicional
            var pizzaCuatroQuesosTradicional = new Pizza(
                tamaño: "Familiar",
                masa: "Cocido",
                salsa: "Roquefort",
                relleno: "mozzarela+gorgonzola+parmesano+ricotta");


            // con builder
            var cocina = new Cocina();
            cocina.RecepcionarProximaPizza(new CuatroQuesosBuilder("Familiar"));
            cocina.CocinarPizzaPasoAPaso();
            var pizzaCuatroQuesos = cocina.PizzaPreparada;

            var pizzaHawuaianaTradicional = new Pizza(
                tamaño: "Mediana",
                masa: "Sueva",
                salsa: "Dulce",
                relleno: "piña+tomate+jamón");


            cocina.RecepcionarProximaPizza(new HawaianaBuilder("Mediana"));
            cocina.CocinarPizzaPasoAPaso();
            var pizzaHawuaiana = cocina.PizzaPreparada;


            // con fluent builder
            var pizzaPersonalizada = PizzaFluentBuilder.Crear()
                                        .ConMasaSuave()
                                        .ConSalsaRoquefort()
                                        .AñadirMozzarela()
                                        .AñadirParmesano()
                                        .Cocinar();
        }
    }
}
