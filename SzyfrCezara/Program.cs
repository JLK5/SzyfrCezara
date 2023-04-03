string ToAsciicaesar(string clearText, int key)
{
    clearText = clearText.ToUpper();
    string encryptedText = "";
    foreach (char c in clearText)
    {
        int asciiCode = (int)c;
        asciiCode += key;
        if(asciiCode > 90)
        {
            asciiCode = 26;
        }
        encryptedText += (char)asciiCode;
    }
    return encryptedText;
}


string FromAsciicaesar(string encryptedText, int key)
{

    string clearText = "";
    foreach (char c in encryptedText)
    {
        int asciiCode = (int)c;
        asciiCode += key;
        if (asciiCode < 65 && asciiCode != 32)
        {
            asciiCode += 26;
        }
        clearText += (char)asciiCode;
    }
    return clearText;
}
string ToArrayCaesar(string clearText, int key)
{
    string chars = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTIVWYZŹŻ";
    char[] charArray = chars.ToCharArray();
        clearText = clearText.ToUpper();
    string encryptedText = "";
    foreach (char c in clearText) 
    {
        int charIndex = Array.IndexOf(charArray, c);
        charIndex += key;
        if (charIndex > charArray.Length - 1)
        {
            charIndex -= charArray.Length;
        }
        encryptedText += charArray[charIndex];
    }
    return encryptedText;
}
string text = "TEKST DO ZASZYFROWANIA";
string cypher = ToAsciicaesar(text, 3);
Console.WriteLine("Zaszyfrowany tekst (ascii): " + cypher);

text = FromAsciicaesar(cypher, 3);
Console.WriteLine("Odszywfrowany tekst (ascii): " + text);

Console.WriteLine("Zaszyfrowany Tekst (ascii): " + ToArrayCaesar("Zażółć gęślą jaźń", 3));