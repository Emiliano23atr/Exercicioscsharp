﻿using System;
using System.Collections.Generic;

using ExerciciosCsharp.Exercicios;

namespace ExerciciosCsharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Deixando tudo pronto", Exercicio001.Executar},
                {"Respondendo ao Usuário", Exercicio002.Executar},
                {"Somando dois números", Exercicio003.Executar},
                // Exercicio004
                {"Antecessor e Sucessor", Exercicio005.Executar},
                {"Dobro, Triplo, Raiz Quadrada", Exercicio006.Executar},
                {"Média Aritmética", Exercicio007.Executar},
                {"Conversor de Medidas", Exercicio008.Executar},
                {"Tabuada", Exercicio009.Executar},
                {"Conversor de Moedas", Exercicio010.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}