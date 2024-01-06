﻿using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        // Realizando os testes com as classes Nokia e Iphone

        // Criando um objeto Nokia
        Smartphone nokia = new Nokia("123456789", "Nokia 8", "NokiaIMEI123", "4GB");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando um objeto iPhone
        Smartphone iphone = new Iphone("987654321", "iPhone 12", "IphoneIMEI456", "128GB");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}

