namespace  DesafioDIO.src.Entities
{
    public class CarroFuturo:Carro
    {

        public CarroFuturo(int id, string placa, string cor, string motor, Modelo modelo, bool turbo):base(id, placa, cor, motor, modelo, turbo)
        {
            this.Id=id;
            this.Placa=placa;
            this.Cor=cor;
            this.Motor=motor;
            this.Modelo=modelo;
        }

        public override string Viajar()
        {
            return $@"{
                base.Viajar()}
                        100 anos no futuro !";
        }
    }
}