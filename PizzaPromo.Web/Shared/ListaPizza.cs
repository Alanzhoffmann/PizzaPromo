namespace PizzaPromo.Web.Shared
{
    public class ListaPizza : List<PizzaInfo>
    {
        public double AreaTotal => this.Sum(p => p.Area);

        public override string ToString()
        {
            var tamanhos = this.GroupBy(p => p.Tamanho)
                .OrderBy(g => g.Key)
                .Select(g => $"{g.Count()}x {g.Key}cm");

            return string.Join(", ", tamanhos);
        }
    }

    public record PizzaInfo(int Tamanho)
    {
        public double Area => Math.PI * Math.Pow(Tamanho / 2, 2);
    }
}
