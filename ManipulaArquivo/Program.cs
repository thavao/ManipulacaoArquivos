string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\source\repos\ManipulacaoArquivos\ManipulaArquivo\Arquivos\";
//retorna a pasta do usuário

string file = "arq.txt";


if (!File.Exists(path))
    Directory.CreateDirectory(path);

if (File.Exists(path + file))
{
    StreamReader sr = new(path + file);
    string s = sr.ReadToEnd();
    Console.Clear();
    Console.WriteLine(s);
    sr.Close();

    s += Console.ReadLine();

    StreamWriter sw = new(path + file);

    sw.WriteLine(s);
    sw.Close();

    Console.Clear();
    Console.WriteLine("Conteudo do arquivo");
    StreamReader sr2 = new(path + file);

    //Console.WriteLine(sr2.ReadToEnd());
    /*    for(int i = 0; i < 3; i++)
        {
            if(i == 2)
                Console.WriteLine(sr2.ReadLine());
            else
                sr2.ReadLine();
        }*/
    var retorno = File.ReadLines(path + file);

    sr2.Close();
}

/*StreamWriter sw = new(path + file);


Console.Write("Informe seu nome: ");
string s = Console.ReadLine();
sw.WriteLine(s);

Console.Write("Informe seu email: ");
s = Console.ReadLine();
sw.WriteLine(s);

sw.Close();

StreamReader sr = new(path + file);

Console.Clear();
Console.WriteLine(sr.ReadToEnd());
sr.Close();*/