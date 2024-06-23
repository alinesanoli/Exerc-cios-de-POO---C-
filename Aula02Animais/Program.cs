namespace AULA03ANIMAIS
{
    
class Program {
  public static void Main (string[] args) {
    Cachorro seshu = new Cachorro("Seshu", 12, "Latido", "Preta");
    seshu.Latir();
    seshu.Movimentar();

    Passaro bird = new Passaro("Bird", 2, "Piado", 320, "Águia-Real");
    bird.Movimentar();
    bird.VelocidadeDoMovimento();
  }
}

}
