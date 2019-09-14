using System;

class MainClass {
  public static void Main () {
    int entrada, qtd = 0, aux = 0, qtd_total = 0;
    
    Console.WriteLine ("Digite um número par maior que 2");
    entrada = Convert.ToInt32(Console.ReadLine());

    int[] primo = new int[entrada];

    if(((entrada%2) == 0) && (entrada > 2)) {
      for (int x=2; x<=entrada; x++){
        for(int y=1; y<=x; y++){
          if((x%y) == 0){
            qtd++;
          }
        }
        if(qtd == 2){
          primo[aux] = x;
          aux++;
          qtd_total++;
        }
        qtd = 0;
      }
    }
    else {
      Console.WriteLine("Número inválido! Tente novamente.");
    }

    for(int a = 0; a < qtd_total; a++){
      for(int b = a; b < qtd_total; b++){
        if((primo[a] + primo[b]) == entrada){
          Console.WriteLine("Números primos somados: {0} e {1}", primo[a], primo[b]);
        }
      }
    }
  }
}