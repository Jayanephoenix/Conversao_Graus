using System;

class MainClass {
  public static void Main (string[] args) {
    double grauF, grauC;
    
    Console.WriteLine ("Digite abaixo a temperatura em F° para convertermos em C°");
    grauF = double.Parse (Console.ReadLine ());
    
    grauC = (grauF - 32)/1.8;
    
    Console.WriteLine ("A temperatura em Celsius é: "+grauC+"°");
    
    Console.ReadKey ();
  }
}