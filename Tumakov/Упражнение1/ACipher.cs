using System.Text;
public class ACipher : ICipher
{
    private string capitalLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    private string lowercaseLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    private char Shift(char letter, int shift)
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
            int newIndex = (index + shift) % alphabet.Length;
            if (newIndex < 0)
                newIndex += alphabet.Length;
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
            letters.Append(Shift(lt, 1));
        }
        return letters.ToString();
    }
    public string Decode(string letter)
    {
        if (string.IsNullOrEmpty(letter))
            return letter;
        StringBuilder letters = new StringBuilder(letter.Length);
        foreach (char lt in letter)
        {
            letters.Append(Shift(lt, -1));
        }
        return letters.ToString();
    }
}

