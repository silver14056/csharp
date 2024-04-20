string str = Console.ReadLine();

string GetDigitsFromString(string s)
{
    string stringDigits = "";

    foreach(char e in s)
    {
        if(char.IsAsciiDigit(e) == true)
        {
            stringDigits = stringDigits + e;
        }
    }
    return stringDigits;

}

int[] StringDigitToMass(string s)
{
    int[] digits = new int[s.Length];

    for(int i = 0; i < s.Length; i++)
    {
        digits[i] = s[i];
    }
    return digits;

}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

System.Console.WriteLine(GetDigitsFromString(str));
System.Console.WriteLine(GetDigitsFromString(str).Length);
PrintArray(StringDigitToMass(GetDigitsFromString(str)));