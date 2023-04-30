using Delegates.Model;

OperacaoMatematica delegateMath = (x, y) => new Operacao().Soma(x, y);
int result = await delegateMath(10, 20);

Console.WriteLine(result);

/// <summary>
/// Eles permitem que você passe um método como parâmetro para outro método
/// </summary>
/// <param name="x">Valor X</param>
/// <param name="y">Valor Y</param>
/// <returns>Int</returns>
public delegate Task<int> OperacaoMatematica(int x, int y);
