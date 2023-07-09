int score;
score = Convert.ToInt32(Console.ReadLine());
{
    if (88 <= score && score <= 100)
        Console.WriteLine(" Success - AA ");
    else if (81 <= score && score < 88)
        Console.WriteLine(" Success - BA ");
    else if (74 <= score && score < 81)
        Console.WriteLine(" Success - BB ");
    else if (67 <= score && score < 74)
        Console.WriteLine(" Success - CB ");
    else if (60 <= score && score < 67)
        Console.WriteLine(" Success - CC ");
    else if (0 <= score && score < 60)
        Console.WriteLine(" Fail - FF ");
    else  Console.WriteLine("Invalid Score");
}


Console.WriteLine();

{
    string command;
    Console.Write("Lütfen Yazınız:");
    command = Console.ReadLine();
    switch (command)
    {
        case "start": Console.WriteLine("Game is starting"); break;
        case "stop": Console.WriteLine("Game stopped"); break;
        case "wait": Console.WriteLine("Game paused"); break;
        default: Console.WriteLine("Command not found"); break;
    }
    Console.Read();
}


Console.WriteLine();


{
    int value = 15;
    int num = 1;
    int sum = 0;
    while (num <= value)
    {
        sum += num;
        num += 1;
    }
    Console.WriteLine(sum);
}


Console.WriteLine();

{ 
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        { Console.WriteLine(i); }
    }
    Console.ReadKey();
}





