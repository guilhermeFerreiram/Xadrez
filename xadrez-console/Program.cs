using xadrez;
using tabuleiro;
using xadrez_console;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

    tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
    tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 3));
    tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(6, 4));

    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();