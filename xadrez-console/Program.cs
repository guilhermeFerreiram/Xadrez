﻿using xadrez;
using tabuleiro;
using xadrez_console;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.tab);

        Console.WriteLine("");
        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

        bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();

        Console.Clear();
        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

        Console.WriteLine("");
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutaMovimento(origem, destino);
    }
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();