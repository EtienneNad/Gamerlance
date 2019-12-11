

    for (var i = 1; i < 5; i++)
{
    a = i;
    b = 0;

    while (a > 0)
    {
        if (b < 0)
            b = b - i;
        else
            b = b + i;

        a = a - 1;
    }

    console.log( i + " : " + b);
}
