namespace Builder
{
    partial class Program
    {
        public class CuatroQuesosBuilder : PizzaBuilder
        {
            public CuatroQuesosBuilder(string tamaño)
            {
                Pizza = new Pizza
                {
                    Tamaño = tamaño
                };
            }
            public override void PasoPrepararMasa()
            {
                Pizza.Masa = "Cocido";
            }

            public override void PasoAñadirSalsa()
            {
                Pizza.Salsa = "Roquefort";
            }

            public override void PasoPrepararRelleno()
            {
                Pizza.Relleno = "mozzarela+gorgonzola+parmesano+ricotta";
            }
        }
    }
}
