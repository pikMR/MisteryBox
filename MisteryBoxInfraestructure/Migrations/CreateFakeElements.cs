using Bogus;
using MisteryBoxInfraestructure.Models;
using MisteryBoxInfraestructure.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisteryBoxInfraestructure.Migrations
{
    public class CreateFakeElements
    {
        public static void CreateFakesInDB()
        {
            var db = new Context();

            Randomizer.Seed = new Random(100000);
            var itemCocinas = new[] { "cuchara", "tenedor", "plato", "palillo", "sartén" };
            var itemMarcaCocinas = new[] { "superstore" , "agnelli","aidapt","albainox","alfi"};
            var itemRopas = new[] { "camisa", "pantalón", "zapato", "bufanda", "gafas" };
            var itemMarcaRopas = new[] { "chicco","zara","lacoste","charanga","calvin klein","nike","adidas"};
            var itemTecnologias = new[] { "Funda","Movil","Portatil","SmartWatch","Teclado","Ratón" };
            var itemMarcaTecnologias = new[] { "apple", "xiaomi", "motorola", "nokia", "samsung" };
            var colores = new[] {"rojo","amarillo","verde","azul","negro","blanco","marrón","violeta" };

            var testCocina = new Faker<Cocina>()
                .RuleFor(u => u.Name, (f) => String.Format("{0} de {1} color {2}", f.PickRandom(itemCocinas), f.PickRandom(itemMarcaCocinas), f.PickRandom(colores)));
            var testRopa = new Faker<Ropa>()
                .RuleFor(u => u.Name, (f) => String.Format("{0} de {1} color {2}", f.PickRandom(itemRopas), f.PickRandom(itemMarcaRopas), f.PickRandom(colores)));
            var testTech = new Faker<Tecnologia>()
                .RuleFor(u => u.Name, (f) => String.Format("{0} de {1} color {2}", f.PickRandom(itemTecnologias), f.PickRandom(itemMarcaTecnologias), f.PickRandom(colores)));

            var elementsCocina = testCocina.Generate(30000);
            var elementsRopa = testRopa.Generate(30000);
            var elementsTech = testTech.Generate(30000);

            db.Cocinas.AddRange(elementsCocina);
            db.Ropas.AddRange(elementsRopa);
            db.Tecnologias.AddRange(elementsTech);

            db.SaveChanges();
        }
        
        //db.Clients.Add(new Client() { Name = "Carlos dos Santos" });
        //db.Clients.Add(new Client() { Name = "Jose da Silva" });
        //db.Clients.Add(new Client() { Name = "Antonio das Couves" });
        //db.SaveChanges();
    }
}
