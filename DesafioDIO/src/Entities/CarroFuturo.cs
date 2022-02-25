namespace  DesafioDIO.src.Entities
{
    public class CarroFuturo:Carro
    {


        public override string Viajar()
        {
            return $@"{
                base.Viajar()}
                Viajará para o futuro !";
        }
    }
}