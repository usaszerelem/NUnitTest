namespace Utils;

public class StringAnalytics
{
    public StringAnalytics(string str)
    {
        CountCharacterTypes(str.ToLower());
        CountWords(str);
    }

    private int _vowels = 0;
    private int _consonants = 0;
    private int _whitespace = 0; // spaces, tabs, and newlines are considered to be whitespace
    private int _special = 0;
    private int _words = 0;
    private int _digits = 0;

    public int Vowels   // property
    {
        get { return _vowels; }   // get method
    }

    public int Consonants   // property
    {
        get { return _consonants; }   // get method
    }

    public int Whitespace   // property
    {
        get { return _whitespace; }   // get method
    }

    public int Special   // property
    {
        get { return _special; }   // get method
    }

    public int Words   // property
    {
        get { return _words; }   // get method
    }

    public int Digits   // property
    {
        get { return _digits; }   // get method
    }

    private void CountCharacterTypes(string str)
    {
        char[] vowelArr = { 'a', 'e', 'i', 'o', 'u' };
        char[] specialChar = { '@', '"', '\\', '|', '!', '#', '$', '%', '&', '/', '(', ')', '=', '?', '»', '«', '£', '§', '€', '{', '}', '.', '-', ';', '<', '>', '_', ',' };


        for (int idx = 0; idx < str.Length; idx++)
        {
            char ch = str[idx];

            if (char.IsDigit(ch) == true)
            {
                _digits++;
            }
            else if (char.IsLetter(ch) == true)
            {
                if (vowelArr.Contains(ch) == true)
                {
                    _vowels++;
                }
                else
                {
                    _consonants++;
                }
            }
            else if (char.IsWhiteSpace(ch) == true)
            {
                _whitespace++;
            }
            else if (specialChar.Contains(ch) == true)
            {
                _special++;
            }
        }
    }

    private void CountWords(string str)
    {
        str = str.Trim();
        string [] words = str.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t', ';', ':' });

        foreach(string word in words)
        {
            if (word.Length > 0)
            {
                _words++;
            }
        }
    }
}

