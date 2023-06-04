public string DictionaryAttack(string password, List<string> dictionary)
{
foreach (string word in dictionary)
{
if (password == word)
{
return word;
}
}
return null;
}