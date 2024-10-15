string s;
    
s = "abcdba";

if(mirror(s))
{
    Console.WriteLine($"{s} - Mirror");
}
else
{
    Console.WriteLine($"{s} - Not Mirror");
}


s = "abccba";
if (mirror(s))
{
    Console.WriteLine($"{s} - Mirror");
}
else
{
    Console.WriteLine($"{s} - Not Mirror");
}

s = "abcba";
if (mirror(s))
{
    Console.WriteLine($"{s} - Mirror");
}
else
{
    Console.WriteLine($"{s} - Not Mirror");
}

Boolean mirror(string s)
{

    Boolean bRetval = true;

    int n = s.Length;

    for (int i = 0, j = n - 1; i < n / 2; i++, j--)
    {
        if (s[i] == s[j])
        {
            continue;
        }
        else
        {
            bRetval = false;
            break;
        }
    }

    return (bRetval);
}