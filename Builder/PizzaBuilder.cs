namespace Builder
{
    partial class Program
    {
        public abstract class PizzaBuilder
        {
            // Protected para que las clases que implementen puedan acceder
            protected Pizza Pizza;
            public string Tamaño { get; set; }

            public Pizza ObtenerPizza() { return Pizza; }



            // Un paso para cada una de las propiedades
            public virtual void PasoPrepararMasa()
            {

            }

            public virtual void PasoAñadirSalsa()
            {

            }

            public virtual void PasoPrepararRelleno()
            {

            }

            public virtual void PasoDoblarPoizza()
            {

            }

        }
    }
}
