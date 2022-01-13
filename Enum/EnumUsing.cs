namespace myApp.Enum
{
    public class EnumUsing
    {
        
    static void ImprimirCor(Cor cor)
    {
        switch (cor)
        {
            case Cor.Vermelho:
                Console.WriteLine("Vermelho");
                break;
            case Cor.Verde:
                Console.WriteLine("Verde");
                break;
            case Cor.Azul:
                Console.WriteLine("azul");
                break;
        }
    }
    }
}