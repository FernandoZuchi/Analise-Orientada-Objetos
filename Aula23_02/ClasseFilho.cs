public class ClasseFilho : ClassePai // Dizendo que a ClasseFilho herda da ClassePai - Herda tudo
{
    private int valor2;
    // Valor maísculo, pode ser acessado pois é uma propriedade pública
    public int Valor2
    {
        get { return valor2; } // Retorna o valor minúsculo, que é privado e será impresso
        set { valor2 = value; } // Value é o valor que está sendo atribuido e será guardado na variável "valor"
    }

    public override void Incrementar(int qtde)
    {
        base.Incrementar(qtde); // Chamando o incrementar da classe Pai utilizando "base"
        Valor2 += qtde;
    }
}

// Obs: Nas sugestões do VSCode o cubo representa método