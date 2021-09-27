namespace PizzaPromo.Web.Shared
{
    public class Pizzaria
    {
        public Pizzaria(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public decimal Frete { get; set; } = 0;
    }
}
