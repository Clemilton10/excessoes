namespace excecoes
{
	public class NuloException : Exception
	{
		public NuloException() :
		base("Erro: O valor não pode ser nulo.")
		{ }
	}
	public class TextoVazioException : Exception
	{
		public TextoVazioException() :
		base("Erro: O texto não pode ser vazio.")
		{ }
	}
	public class NumeroInvalidoException : Exception
	{
		public NumeroInvalidoException(string userInput) :
		base($"Erro: Não foi possível converter o texto ({userInput}) em número.")
		{ }
	}
	public class NumeroMenorException : Exception
	{
		public NumeroMenorException(int numero) :
		base($"Erro: O número ({numero}) deve ser maior que zero.")
		{ }
	}
}
