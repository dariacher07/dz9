using System.Text;
public class BCipher : ICipher
{
    private string capitalLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    private string lowercaseLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    private char Replacement(char letter)
    {
        string alphabet;
        if (char.IsUpper(letter))
        {
            alphabet = capitalLetters;
        }
        else
        {
            alphabet = lowercaseLetters;
        }
        int index = alphabet.IndexOf(letter);
        if (index != -1)
        {
            int newIndex = alphabet.Length - 1 - index;
            return alphabet[newIndex];
        }
        return letter; 
    }
    public string Encode(string letter)
    {
        if (string.IsNullOrEmpty(letter))
            return letter;
        StringBuilder letters = new StringBuilder(letter.Length);
        foreach (char lt in letter)
        {
            letters.Append(Replacement(lt));
        }
        return letters.ToString();
    }
    public string Decode(string letter)
    {
        return Encode(letter);
    }
}

