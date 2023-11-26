const string Sair = "tchau";

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("      Groot Chatbot\n");

Console.WriteLine("Converse com o Groot (Digite tchau para sair)\n");
Console.ResetColor();

string pergunta;
do
{
    Console.Write("Você: ");
    pergunta = Console.ReadLine()!;

    string resposta = RespostaGroot(pergunta);

    ExibeResposta(RespostaGroot(pergunta));

} while (pergunta.Trim().ToLower() != Sair);


void ExibeResposta(string resposta)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"                          Groot: {resposta}");
    Console.ResetColor();
}

string RespostaGroot(string pergunta)
{
    return pergunta.Trim().ToLower() == Sair ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}
