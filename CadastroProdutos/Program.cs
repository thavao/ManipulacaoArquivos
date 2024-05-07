using CadastroProdutos;

string path = Environment.CurrentDirectory + @"\Arquivos\";
string file = "arquivo.txt";

bool CheckIfExists(string p, string f)
{
    if (!Directory.Exists(p))
    {
        Directory.CreateDirectory(p);
    }
    if (!File.Exists(p + f))
    {
        File.Create(p + f);
    }
    return true;
}
void SaveFile(List<Product> list, string p, string f)
{
    if (CheckIfExists(p, f))
    {
        StreamWriter sw = new(p + f);

        foreach (var item in list)
        {
            sw.WriteLine(item.ToString());
        }
        sw.Close();
    }
}

List<Product> LoadFile(string p, string f)
{
    List<Product> list = new List<Product>();
    if (CheckIfExists(p, f))
    {
        string[] data;
        foreach (var linha in File.ReadAllLines(p + f))
        {
            data = linha.Split(";");
            list.Add(new Product(int.Parse(data[0]), data[1], double.Parse(data[2]), int.Parse(data[3])));
        }

    }
    return list;
}

Product CreateProduct()
{
    Console.Write("Informe um id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Indorme a descrição: ");
    string description = Console.ReadLine();

    Console.Write("Informe o preço: ");
    double price = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a quantidade disponível: ");
    int qtd = int.Parse(Console.ReadLine());

    return new Product(id, description, price, qtd);
}

//List<Product> products = new();

/*products.Add(new Product(1, "Suco de Caju", 8.99, 78));
products.Add(new Product(1, "Mouse Gamer", 299, 20));*/




//SaveFile(products, path, file);

List<Product> products = LoadFile(path , file);
void ShowAll(List<Product> receivedList)
{
    foreach (var item in receivedList)
    {
        Console.WriteLine(item.ToString());
    }
}

ShowAll(products);


