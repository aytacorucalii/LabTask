
// 1-100 araliginda cəm

//int sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    sum += i;
//}
//Console.WriteLine(" cəm: " + sum);



// while ile

//int sum = 0;
//int i = 1;
//while (i <= 100)
//{
//    sum += i;
//    i++;
//}
//Console.WriteLine(" cəm: " + sum);



//  1-100 arasinda cem ededler cemi
//int sum = 0;
//int i = 0;
//for (int i = 0; i <= 100 ; i++)
//{
//    if (i%2==0)
//    {
//        sum += i;
//    }
//}

//Console.WriteLine( "cem;" + sum);


//// while ile
//int sum = 0;
//int i = 1;
//while (1<=100)
//{
//    if (i%2==0)
//    {
//        sum += i;
//        i++;
//    }
//}
//Console.WriteLine("cem;" + sum);











//Console.ReadLine("3reqemli eded daxil et;");
//int i = 0;
//if (i<=100)
//{
//    Console.WriteLine(i%10);

//}


Console.WriteLine("bal daxil edin");
int number = 1;
while (number >= 0)
{
    switch (number)
    {
        case int n when (n >= 91 && n <= 100):
            Console.WriteLine("A");
            break;
        case int n when (n >= 81 && n <= 90):
            Console.WriteLine("B");
            break;
        case int n when (n >= 71 && n <= 80):
            Console.WriteLine("C");
            break;
        case int n when (n >= 61 && n <= 70):
            Console.WriteLine("D");
            break;
        case int n when (n >= 51 && n <= 60):
            Console.WriteLine("E");
            break;
        default:
            Console.WriteLine("Kesr");
            break;
    }

 
}
