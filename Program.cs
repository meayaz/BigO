// Big O Notation (Lineer): Yazdığımız kodların karmaşıklığını gösteren bir teknik.
// Zaman ve yer karmaşıklığını gösteririr. Yazdığımız ne kadar verimli ve ne kadar zamanda çalıştığını gösterir.
// Time Complexity Space Complexity
// Brute Force O(n) => En kötü senaryoyu düşünür.

// log(n) => En iyi senaryoyu ifade eder.
// log2 16 => 4 -- 16/2 = 8, 8/2 =4, 4/2 = 2, 2/2 = 1 => bu işlemi 4 kere yaptım.

// O(log n) O(1), O(n), O(n log n), O(n^2), O(2^n), O(n!)

//BigOn(5);
//BigOn2(5);
//LogN(64);
//NLogN(4);
NFactorial(5);

static void BigOn(int n) // tek döngü girdi çıktı O(n)
{
    for(int i = 0; i < n; i++)
    {
        System.Console.WriteLine(i);
    }
}

static void BigOn2(int n) // 2 döngü yani O(n^2)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            System.Console.WriteLine($"{i} {j}");
        }
    }
}

static void LogN(decimal n)
{
    while(n > 1)
    {
        n = Math.Floor(n / 2);

        System.Console.WriteLine(n);
    }
}

static void NLogN(decimal n) //Sorting Algoritm
{
    decimal limit = n;
    
    while(n > 1)
    {
        n = Math.Floor(n / 2);

        for(int i = 0; i < limit; i++)
        {
            System.Console.WriteLine(i);
        }
    }
}

static void NFactorial (int n)
{
    if(n == 0)
        System.Console.WriteLine(1);
    
    for(int i = 1; i < n; i++)
    {
        System.Console.WriteLine(i);    
        NFactorial(n -1); //Recursive
    }
}