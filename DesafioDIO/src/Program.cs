
using  DesafioDIO.src.Entities;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Carro carroPasseio = new Carro(1,"ZZZ-4550","Preto","2.0",
            new Modelo(1,"Voyage", 
            new Marca(1,"Volkswagen")),
            false
        );

        Carro carroEsporte = new Carro(
            2,
            "YYY-4550",
            "Amarelo",
            "4.3",
            new Modelo(1,"Mustang", 
            new Marca(1,"Ford")),
            true
        );

         CarroFuturo carroFuturo = new CarroFuturo(
            3,
            "WWW-4550",
            "Prata",
            "Velocidade da Luz",
            new Modelo(1,"ECC 1701", 
            new Marca(1,"Enterprise")),
            true
        );

        WriteLine(carroPasseio.ToString());
        WriteLine(carroPasseio.Viajar());
        WriteLine(carroEsporte.ToString());
        WriteLine(carroEsporte.Viajar());
        WriteLine(carroFuturo.ToString());
        WriteLine(carroFuturo.Viajar());

    }
} 

