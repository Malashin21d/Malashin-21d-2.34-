int a1, a2, b,res1, res2,res3,res;
Console.WriteLine("Введите превую цифру из двухзанчнго ");
a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую цифру из двухзанчнго ");
a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите цифру однозачнаю ");
b = int.Parse(Console.ReadLine());
res = a2 + a1 + b;
res1 = res / 10;
    res2 = res % 10;
Console.WriteLine("Ответ {0},{1}",res1,res2);

