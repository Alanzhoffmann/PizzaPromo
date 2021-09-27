namespace PizzaPromo.Web.Shared
{
    public class OfertaPizza
    {
        public OfertaPizza(string descricao, decimal valor, Pizzaria pizzaria)
        {
            Pizzas = new ListaPizza();

            Descricao = descricao;
            Valor = valor;
            Pizzaria = pizzaria;
        }

        public ListaPizza Pizzas { get; set; }
        public string Descricao { get; set; }
        public Pizzaria Pizzaria { get; set; }
        public decimal Valor { get; set; }
        public double AreaTotal => Pizzas.AreaTotal;
        public decimal AreaPorValor => (decimal)AreaTotal / Valor;
    }
}
