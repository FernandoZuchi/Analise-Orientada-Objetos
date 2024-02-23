public class ClassePai
{
    private int valor;
    // Valor maísculo, pode ser acessado pois é uma propriedade pública
    public int Valor
    {
        get { return valor; } // Retorna o valor minúsculo, que é privado e será impresso
        set { valor = value; } // Value é o valor que está sendo atribuido e será guardado na variável "valor"
    }

    // Método incrementar
    // Um método virtual é um método que pode ser sobreposto, pode colocar outra implementação por cima
    public virtual void Incrementar(int qtde)
    {
        valor += qtde;
    }
}