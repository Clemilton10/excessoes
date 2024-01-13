using excecoes;

internal class Program
{
	private static void Main()
	{
		int numero = 1;
		while (numero > 0)
		{
			numero = GetNumber();
			Console.WriteLine($"Número digitado: {numero}");
		}
	}

	private static int GetNumber()
	{
		try
		{
			string userInput = ObterTextoDoUsuario();
			int numero = ObterNumero(userInput);
			return numero;
		}

		//catch (ArgumentNullException)
		//{
		//	Console.WriteLine("Erro: O texto não pode ser nulo.");
		//}

		//catch (ArgumentException)
		//{
		//	Console.WriteLine("Erro: O texto não pode ser vazio ou conter apenas espaços em branco.");
		//}
		catch (NuloException ex)
		{
			Console.WriteLine(ex.Message);
			return -3;
		}
		catch (TextoVazioException ex)
		{
			Console.WriteLine(ex.Message);
			return -2;
		}
		catch (NumeroInvalidoException ex)
		{
			Console.WriteLine(ex.Message);
			return -1;
		}
		catch (NumeroMenorException ex)
		{
			Console.WriteLine(ex.Message);
			return 0;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return -4;
		}
	}

	private static string ObterTextoDoUsuario()
	{
		Console.Write("Digite um número maior ou igual a 1: ");

		string userInput = Console.ReadLine();

		if (userInput == null)
		{
			throw new NuloException();
		}

		if (string.IsNullOrEmpty(userInput))
		{
			throw new TextoVazioException();
		}

		return userInput;
	}

	private static int ObterNumero(string userInput)
	{
		if (!int.TryParse(userInput, out int numero))
		{
			throw new NumeroInvalidoException(userInput);
		}

		if (numero < 1)
		{
			throw new NumeroMenorException(numero);
		}

		return numero;
	}
}