using Microsoft.AspNetCore.Mvc;
using PizzaPromo.Web.Shared;

namespace PizzaPromo.Web.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzasController
    {
        public OfertaPizza[] Get()
        {
            var pizzariaDonCorleone = new Pizzaria("Pizzaria Don Corleone");
            var pizzariaVicenza = new Pizzaria("Vicenza");

            var ofertaPizzaBaby = new OfertaPizza("Pizza baby peru/chester", 9.90m, pizzariaDonCorleone)
            {
                Pizzas = new ListaPizza
                {
                    new PizzaInfo(20)
                }
            };

            var ofertaPizzaMedia = new OfertaPizza("Pizza média peito de peru", 19.90m, pizzariaDonCorleone)
            {
                Pizzas = new ListaPizza
                {
                    new PizzaInfo(30)
                }
            };

            var ofertaComboMediaDoces = new OfertaPizza("Combo média + broto doce", 65m, pizzariaDonCorleone)
            {
                Pizzas = new ListaPizza
                {
                    new PizzaInfo(30),
                    new PizzaInfo(25)
                }
            };

            var ofertaGigantePromo = new OfertaPizza("Pizza gigante promo", 38.9m, pizzariaVicenza)
            {
                Pizzas = new ListaPizza
                {
                    new PizzaInfo(40)
                }
            };

            var ofertas = new[]
            {
                ofertaPizzaBaby, ofertaPizzaMedia, ofertaComboMediaDoces, ofertaGigantePromo
            };

            return ofertas;
        }
    }
}
