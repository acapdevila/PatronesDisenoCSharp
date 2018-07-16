namespace Builder
{
    partial class Program
    {
        // La clase producto no puede ser inmutable
        //public class Pizza
        //{
        //    private readonly string _masa;
        //    private readonly string _salsa;
        //    private readonly string _relleno;
        //    private readonly string _tamaño;

        //    public Pizza(string tamaño, string masa, string salsa, string relleno)
        //    {
        //        _tamaño = tamaño;
        //        _masa = masa;
        //        _salsa = salsa;
        //        _relleno = relleno;
        //    }
        //}

        public class Pizza
        {
            public string Masa { get; set; }
            public string Salsa { get; set; }
            public string Relleno { get; set; }
            public string Tamaño { get; set; }

            public Pizza()
            {

            }

            public Pizza(string tamaño, string masa, string salsa, string relleno) : this()
            {
                Tamaño = tamaño;
                Masa = masa;
                Salsa = salsa;
                Relleno = relleno;
            }
        }
    }
}
