// See https://aka.ms/new-console-template for more information

String title = @"
 _             _   _ _ _   _                   _____                               
| |           | | | | | | (_)                 /  __ \                              
| |     __ _  | | | | | |_ _ _ __ ___   __ _  | /  \/ __ _ _ __ _ __ ___ _ __ __ _ 
| |    / _` | | | | | | __| | '_ ` _ \ / _` | | |    / _` | '__| '__/ _ \ '__/ _` |
| |___| (_| | | |_| | | |_| | | | | | | (_| | | \__/\ (_| | |  | | |  __/ | | (_| |
\_____/\__,_|  \___/|_|\__|_|_| |_| |_|\__,_|  \____/\__,_|_|  |_|  \___|_|  \__,_|
                                                                                   
                                                                                   
";
centrarTexto(title);
String s = "Presione cualquier boton para continuar";
centrarTexto(s);
Console.ReadLine();
Console.Clear();
String menu = @"
   _   _   _   _  
  / \ / \ / \ / \ 
 ( M | e | n | u )
  \_/ \_/ \_/ \_/ 

";
System.Console.WriteLine(menu);
System.Console.WriteLine("1. Nueva partida");
System.Console.WriteLine("2. Cargar partida");
Console.ReadLine();

static void centrarTexto(String ascii){
    var lines = ascii.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
    var longestLength = lines.Max(line => line.Length);
    var leadingSpaces = new string(' ', (Console.WindowWidth - longestLength) / 2);
    var centeredText = string.Join(Environment.NewLine, lines.Select(line => leadingSpaces + line));
    Console.WriteLine(centeredText);
}
