namespace DesafioDIO.src.Entities
{
    public class Carro: Veiculo
    {
        List<Destino> _destinos = new List<Destino>(){
            new Destino(1,"Cuiabá",1020.3),
            new Destino(2,"Belo Horizonte",354),
            new Destino(3,"Manaus", 4560.9)
        };

        public bool Turbo { get; set; }
        
        public List<Destino> Destinos { 
            get => _destinos;       
         }

        public Carro(int id, string placa, string cor, string motor, Modelo modelo, bool turbo)
        {
            this.Id=id;
            this.Placa=placa;
            this.Cor=cor;
            this.Motor=motor;
            this.Modelo=modelo;
            this.Turbo=turbo;
        }

        public override string ToString()
        {
            return $@"
                    Código: {this.Id}
                    Placa: {this.Placa}
                    Cor: {this.Cor}
                    Motor: {this.Motor}
                    Modelo: {this.Modelo.Nome}
                    Marca: {this.Modelo.Marca.Nome}
                    Turbinado: {(this.Turbo ? "Sim":"Não")}";
        }

        public string Viajar()
        {
            Random rnd = new Random();
            Destino destino = this.Destinos.ElementAt(rnd.Next(this.Destinos.Count()));
            return $@"
                    Viajar para:
                        Cidade: {destino.Cidade}
                        Distância: {destino.Distancia} KMs";
        }

    }

}