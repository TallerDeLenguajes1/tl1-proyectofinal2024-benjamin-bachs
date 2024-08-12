// See https://aka.ms/new-console-template for more information
using System.Text;

Console.ForegroundColor = ConsoleColor.Red;
String title = @"
 _             _   _ _ _   _                   _____                               
| |           | | | | | | (_)                 /  __ \                              
| |     __ _  | | | | | |_ _ _ __ ___   __ _  | /  \/ __ _ _ __ _ __ ___ _ __ __ _ 
| |    / _` | | | | | | __| | '_ ` _ \ / _` | | |    / _` | '__| '__/ _ \ '__/ _` |
| |___| (_| | | |_| | | |_| | | | | | | (_| | | \__/\ (_| | |  | | |  __/ | | (_| |
\_____/\__,_|  \___/|_|\__|_|_| |_| |_|\__,_|  \____/\__,_|_|  |_|  \___|_|  \__,_|
                                                                                   
                                                                                   
";
CentrarTexto(title);
Console.ResetColor();
String s = "Presione cualquier boton para continuar";
CentrarTexto(s);
Console.ReadKey(false);
Console.Clear();
MaquinaEscribir("   Un meteorito ha caido en la Facultad de Ciencias Exactas, solo una carrera\n   podra seguir dictándose, pelea para ser la última carrera en pie.");
ClearBuffer();
Console.ReadKey(false);
Console.Clear();
String menu = @"
   _   _   _   _  
  / \ / \ / \ / \ 
 ( M | e | n | u )
  \_/ \_/ \_/ \_/ 

";

System.Console.WriteLine(menu);

(int left, int top) = Console.GetCursorPosition();
int option = 1;
ConsoleKeyInfo key;
bool isSelected = false;

while (!isSelected)
{
	Console.SetCursorPosition(left, top);
  if(option == 1)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nueva partida");
    Console.ResetColor();
    Console.WriteLine("Cargar partida");
  }
  else
  {
    Console.WriteLine("Nueva partida");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Cargar partida");
    Console.ResetColor();
  }

	key = Console.ReadKey(false);

	switch (key.Key)
	{
		case ConsoleKey.UpArrow:
			option = option == 1 ? 2 : option - 1;
			break;

		case ConsoleKey.DownArrow:
			option = option == 2 ? 1 : option + 1;
			break;

		case ConsoleKey.Enter:
			isSelected = true;
			break;
	}
}

static void CentrarTexto(String ascii){
    var lines = ascii.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
    var longestLength = lines.Max(line => line.Length);
    var leadingSpaces = new string(' ', (Console.WindowWidth - longestLength) / 2);
    var centeredText = string.Join(Environment.NewLine, lines.Select(line => leadingSpaces + line));
    Console.WriteLine(centeredText);
}

static void MaquinaEscribir(string message)
{
    for (int i = 0; i < message.Length; i++)
    {
        Console.Write(message[i]);
        System.Threading.Thread.Sleep(60);
    }
}

static void ClearBuffer(){
  while(Console.KeyAvailable){
    Console.ReadKey(false);
  }
}
