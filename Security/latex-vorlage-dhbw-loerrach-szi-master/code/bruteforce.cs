public string Bruteforce(string password, char[] symbols)
{
    List<char> bruteforcepassword = new List<char>();

    if (password == new string(bruteforcepassword.ToArray()))
    {
        return new string(bruteforcepassword.ToArray());
    }

    while (password != new string(bruteforcepassword.ToArray()))
    {
        int length = bruteforcepassword.Count;
        char lastchar = bruteforcepassword[length - 1];
        int indexofcharinsymbols = Array.IndexOf(symbols, lastchar);

        if (indexofcharinsymbols != length - 1)
        {
            bruteforcepassword[length - 1] = symbols[indexofcharinsymbols + 1];
        }
        else
        {
            int iterator = bruteforcepassword.Count - 1;
            while (iterator > -1 && bruteforcepassword[iterator] == symbols[symbols.Length - 1])
            {
                bruteforcepassword[iterator] = symbols[0];
                iterator--;
            }

            if (iterator == -1)
            {
                bruteforcepassword.Add(symbols[0]);
            }
        }
    }

    return new string(bruteforcepassword.ToArray());
}
