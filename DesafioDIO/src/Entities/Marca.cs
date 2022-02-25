namespace DesafioDIO.src.Entities
{
    public class Marca
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public Marca(int id, String nome)
        {
            this.Id=id;
            this.Nome=nome;
        }
    }
}