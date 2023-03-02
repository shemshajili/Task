string repeat(string word, int count)
{
    string line = "";

    for (int i = 1; i <= count; i++)
    {
        line += word;
    }
    Console.WriteLine(line);
    return line;
}
repeat("Salam Aleykum", 3);