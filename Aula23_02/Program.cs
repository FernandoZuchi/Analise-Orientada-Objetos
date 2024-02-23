internal class Program
{
    private static void Main(string[] args)
    {
        // Declarando a váriavel objPai, instânciando a ClassePai
        ClassePai objPai = new ClassePai();

        objPai.Valor = 100;
        objPai.Incrementar(10);

        ClasseFilho objFilho = new ClasseFilho();
        objFilho.Valor = 200;
        objFilho.Valor2 = 50;
        objFilho.Incrementar(20); // Herdou o método Incrementar() da ClassePai

        System.Console.WriteLine($"Valor pai: {objPai.Valor}");
        System.Console.WriteLine($"Valor filho: {objFilho.Valor}");
    }
}