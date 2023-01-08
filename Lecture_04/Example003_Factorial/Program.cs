//int Factorial(int n)
double Factorial(int n) //Заменили int на double, т.к. int не вмещает в себя такие большие
    //числа и показывает их как отрицательные.
{
    if (n == 1)
        return 1;
    else return n * Factorial(n - 1);
}
//System.Console.WriteLine(Factorial(3)); //1*2*3 = 6
for (int i = 1; i < 40; i++) //Вариант решения через цикл.
{
    //System.Console.WriteLine(Factorial(i)); 
    System.Console.WriteLine($"{i}! = {Factorial(i)}"); //Добавили вывод от какого числа факториал.
}