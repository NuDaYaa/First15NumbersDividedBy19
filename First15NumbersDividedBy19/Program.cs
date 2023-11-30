    int count = 0;
    int number = 100;

    while (count < 15)
    {
        if (number % 19 == 0)
        {
            Console.WriteLine(number);
            count++;
        }

        number++;
    }
