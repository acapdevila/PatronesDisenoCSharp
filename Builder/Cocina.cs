namespace Builder
{
    partial class Program
    {
        // Director
        public class Cocina
        {
            private PizzaBuilder _pizzaBuilder;

            public Pizza CocinarPizza(PizzaBuilder pizzaBuilder)
            {
                RecepcionarProximaPizza(pizzaBuilder);
                CocinarPizzaPasoAPaso();
                return PizzaPreparada;
            }

            public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)
            {
                _pizzaBuilder = pizzaBuilder;
            }

            public void CocinarPizzaPasoAPaso()
            {
                _pizzaBuilder.PasoPrepararMasa();
                _pizzaBuilder.PasoAñadirSalsa();
                _pizzaBuilder.PasoPrepararRelleno();
            }

            public Pizza PizzaPreparada
            {
                get { return _pizzaBuilder.ObtenerPizza(); }

            }

        }
    }
}
