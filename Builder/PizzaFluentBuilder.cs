namespace Builder
{
    partial class Program
    {
        public class PizzaFluentBuilder
        {
            private readonly Pizza _pizza;

            public static PizzaFluentBuilder Crear()
            {
                return new PizzaFluentBuilder();
            }

            private PizzaFluentBuilder()
            {
                _pizza = new Pizza();
            }


            public PizzaFluentBuilder ConMasaSuave()
            {
                _pizza.Masa = "Suave";
                return this;

            }

            public PizzaFluentBuilder ConMasaCocida()
            {
                _pizza.Masa = "Cocido";
                return this;
            }

            public PizzaFluentBuilder ConSalsaRoquefort()
            {

                _pizza.Salsa = "Roquefort";
                return this;

            }

            public PizzaFluentBuilder ConSalsaPicante()
            {
                _pizza.Salsa = "Picante";
                return this;
            }

            public PizzaFluentBuilder AñadirMozzarela()
            {
                _pizza.Relleno = _pizza.Relleno + "+mozzarela";
                return this;
            }
            public PizzaFluentBuilder AñadirParmesano()
            {
                _pizza.Relleno = _pizza.Relleno + "+parmesano";
                return this;
            }

            public Pizza Cocinar()
            {
                return _pizza;
            }
        }
    }
}
