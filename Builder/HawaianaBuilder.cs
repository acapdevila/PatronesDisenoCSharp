namespace Builder
{
    partial class Program
    {
        public class HawaianaBuilder : PizzaBuilder
        {
            public HawaianaBuilder(string tamaño)
            {
                Pizza = new Pizza
                {
                    Tamaño = tamaño
                };
            }
            public override void PasoPrepararMasa()
            {
                Pizza.Masa = "Suave";
            }

            public override void PasoAñadirSalsa()
            {
                Pizza.Salsa = "Dulce";
            }

            public override void PasoPrepararRelleno()
            {
                Pizza.Relleno = "piña+tomate+jamón";
            }
        }
    }
}
