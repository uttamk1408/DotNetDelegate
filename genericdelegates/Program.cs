
// Func Generic Delegate
int AddNumber(int i, int j)
{
    return i + j;
}

// Action Generic Delegate
void MultiplyNumber(int i, int j)
{
    Console.WriteLine(i * j);
}

// Predicate Generic Delegate
bool isGreaterThanFive(int i)
{
    if(i > 5)
        return true;

    return false;
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Func<int, int, int> objAdd = AddNumber;
int addResult = objAdd.Invoke(5, 10);
Console.WriteLine(addResult); 

Action<int, int> objMul = MultiplyNumber;
objMul.Invoke(10, 5);

Predicate<int> objChk = isGreaterThanFive;
bool result = objChk.Invoke(4);

Console.WriteLine(result);

result = objChk.Invoke(6);

Console.WriteLine(result);