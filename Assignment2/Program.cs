// See https://aka.ms/new-console-template for more information

using System.Text;

int TripleSum(int num1, int num2)
{
    if (num1 == num2)
    {
        return (num1 + num2) * 3;
    } 
    else
    {
        return num1 + num2;
    }
}

int AbsoluteDifference(int n)
{
    if (n < 51)
    {
        return 51 - n;
    } else
    {
        return (n - 51) * 3;
    }
}

bool CheckNums(int num1, int num2)
{
    if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool CheckInteger(int num)
{
    if ((num > 90 && num < 100) || (num > 190 && num < 200))
    {
        return true;
    } else
    {
        return false;
    }
}

string ModString(string str)
{
    if (str.Length >= 2)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            stringBuilder.Append(str.Substring(0, 2));
        }
        return stringBuilder.ToString();
    }
    else
    {
        return str;
    }
}

string FontBack(string str)
{
    if (str.Length >= 1)
    {
        StringBuilder stringBuilder = new StringBuilder();
        char firstChar = str.ElementAt(0);
        stringBuilder.Insert(0, firstChar);
        stringBuilder.Append(firstChar);
        return stringBuilder.ToString();
    }
    else
    {
        return str;
    }
}

bool CheckIfMulti(int num)
{
    if ((num % 3 == 0) && (num % 7 == 0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool CheckStr(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str.ElementAt(i) == 'z')
        {
            count++;
        }
    }
    return (count > 2) || (count < 4);
}

string CopyStr(string str, int c)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < c; i++)
    {
        sb.Append(str);
    }
    return sb.ToString();
}

int CountStr(string str)
{
    int count = 0;
    string subStr = str.Substring(str.Length - 1, 2);
    for (int i = 0; i < str.Length - 1; i++ )
    {
        if (str.Substring(i, 2) == subStr)
        {
            count++;
        }
    }
    return count;
}

string FizzBuzz(string str)
{
    StringBuilder stringBuilder = new StringBuilder();
    if (str.ElementAt(0) == 'F')
    {
        stringBuilder.Append("Fizz");
    }
    if (str.ElementAt(str.Length - 1) == 'B')
    {
        stringBuilder.Append("Buzz");
    }
    return stringBuilder.Length > 0 ? stringBuilder.ToString() : str; 

}

bool CheckNum(int x,  int y, int z)
{
    return y > x && y < z;
}

string Concat(string s1, string s2)
{
    return s1 + s2 + s2 + s1;
}

string FirstLast(string str)
{
    if (str.Length >= 2)
    {
        return str.Substring(1, str.Length - 1);
    }
    else
    {
        return str;
    }
}