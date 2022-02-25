namespace DesafioDIO.src.Entities
{
    public class Modelo
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Marca Marca { get; set; }

        public Modelo(int id, string nome, Marca marca)
        {
            this.Id = id;
            this.Nome = nome;
            this.Marca = marca;
        }

    }
}