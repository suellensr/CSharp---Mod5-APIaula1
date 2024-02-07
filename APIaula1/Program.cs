namespace APIAula1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            var listaImoveis = new List<Imovel>();
            int contadorId = 3;
            listaImoveis.Add(new Imovel(01, "Beco Diagonal", "Casa", 300000.00m));
            listaImoveis.Add(new Imovel(02, "Rua dos Bobos", "Apartamento", 150000.00m));

            app.MapGet("/imovel", () => listaImoveis);

            //app.MapGet("/imovel/{id}/{endereco}", (int id, string endereco) =>
            //{
            //    return new { Texto = $"id: {id} - endereço: {endereco}" };
            //});

            app.MapGet("/imovel/{id}", (int id) =>
            {
                var imovel = listaImoveis.FirstOrDefault(i => i.Id == id);
                return imovel;
            });

            app.MapPost("/imovel", (Imovel imovel) =>
            {
                imovel.Id = contadorId++;
                listaImoveis.Add(imovel);
                return Results.Created($"/imovel/{imovel.Id}", imovel);
            });

            app.Run();
        }
    }
}
