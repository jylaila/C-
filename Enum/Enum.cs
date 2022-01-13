namespace myApp.Enum
{
    enum Cor
    {
        Vermelho,
        Verde,
        Azul
    }

//caso não determine o tipo, será implicito int
    enum Alinhamento :sbyte{
        Esquerda = -1,
        Centro = 0,
        Direita = 1,
    }

}

