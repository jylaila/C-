using System;
using myApp.Heranca;

// compilador Roslyn
int numerodevezes = 5;

for(int i = 0; i< numerodevezes; i++){
    Console.WriteLine($"Bem-vindo ao curso de C# {i}");
}

Ponto p = new Ponto(10,20);
Ponto3D p2 = new Ponto3D (10,20,30);
p2.CalcularDistancia3();
Ponto3D.Calcular(); //chamada método estático