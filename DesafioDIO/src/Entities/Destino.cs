namespace DesafioDIO.src.Entities
{
    public class Destino
    {
        public int Id { get; set; }
        public string Cidade { get; set; }

        public double Distancia { get; set; }

        public Destino(int id, string cidade, double distancia)
        {
            this.Id=id;
            this.Cidade=cidade;
            this.Distancia=distancia;
        }
    }
}