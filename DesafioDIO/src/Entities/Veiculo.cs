namespace  DesafioDIO.src.Entities
{
    public abstract class Veiculo
    {
        public int Id { get; set; } 
        public string Placa { get; set; }   
        public string Cor { get; set; } 
        public string Motor { get; set; }

        public Modelo Modelo { get; set; }

    }
}