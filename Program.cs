Console.Write("o objeto está se movendo(S/N)?");

bool estaSeMovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria? ");

bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (!estaSeMovendo)
{
    if(!deveria)
    {
        mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use WD-40.";
         
    }
}
else
{
    if(deveria)
    {
         mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use Silver Tape.";
    }
}    

Console.WriteLine(mensagem);