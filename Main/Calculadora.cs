namespace New.Talents;

public class Calculadora
{

    private List <string> listaHistorico;
    public Calculadora ()
    {
        listaHistorico = new List<string>();
    }

    public int Soma(int num1, int num2)
    {
        int resultado = num1+num2;
        listaHistorico.Insert(0, "Resultado:"+ resultado);

        return resultado;
    }

    public int Subtrair(int num1, int num2)
    {
        int resultado = num1-num2;
        listaHistorico.Insert(0, "Resultado:"+ resultado);


        return resultado;
    }

    public int Multiplicar(int num1, int num2)
    {
        int resultado = num1*num2;
        listaHistorico.Insert(0, "Resultado:"+ resultado);


        return resultado;
    }

    public int Dividir(int num1, int num2)
    {
        int resultado = num1/num2;
        listaHistorico.Insert(0, "Resultado:"+ resultado);

        return resultado;
    }

    public List<string> historico ()
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count() - 3);
        return listaHistorico;
    }


}
