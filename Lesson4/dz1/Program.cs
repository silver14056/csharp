//принять строку
//выбрать цифры в новую строку
//заполнить массив цифрами из строки
//
//
//
//
//
//



string str = Console.ReadLine();
string stringOfDigits = GetDigitsFromString(str);
int lengthOfDigits = stringOfDigits.Length;
int numbers = Convert.ToInt32(stringOfDigits);
int[] digits = StringDigitToMass(numbers, lengthOfDigits);
PrintArray(digits);

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
    Console.WriteLine(stringDigits);
    return stringDigits;

}

int[] StringDigitToMass(int num, int numLength)
{
    int[] digits = new int[numLength];

    for(int i = 0; i < digits.Length; i++)
    {
        digits[i] = num % 10;
        num = num / 10;
    }
    return FlipArray(digits);

}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] FlipArray(int[] arr)
{
    int[] flipArr = new int[arr.Length];

    for (int i = 0; i < flipArr.Length; i++)
    {
        flipArr[i] = arr[arr.Length - 1 - i];
    }

    return flipArr;
}