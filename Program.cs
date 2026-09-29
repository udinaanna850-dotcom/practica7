Console.Write("Введите слово: ");
string s = Console.ReadLine().ToUpper();

Console.Write("Введите сдвиг: ");
int n = Convert.ToInt32(Console.ReadLine());

string abc = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

string result = "";

for (int i = 0; i < s.Length; i++)
{
    string bu = s.Substring(i, 1);
    int x = abc.IndexOf(bu);

    result += abc.Substring((x + n) % 33, 1);
}

Console.WriteLine("Зашифрованное слово: " + result);

string res = "";

for (int i = 0; i < result.Length; i++)
{
    string bu = result.Substring(i, 1);
    int x = abc.IndexOf(bu);

    res += abc.Substring((x - n + 33) % 33, 1);
}

Console.WriteLine("Расшифрованное слово: " + res);