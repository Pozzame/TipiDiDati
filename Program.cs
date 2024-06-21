Console.Clear();
string nome = Convert.ToString(10);
nome += 2;
Console.WriteLine(nome);
if (int.TryParse(nome, out int number)){
    number += 2;
    nome = Convert.ToString(number);}
else
   Console.WriteLine("Unable to parse string.");
Console.Write(nome);