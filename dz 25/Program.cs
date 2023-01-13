//напишите цикл, который принимает на вход два числа а и b  и возводит число
// a в натуральную степень б

// Console.WriteLine ("Введите число A: ");
// int a = int.Parse (Console.ReadLine () ?? "");
// Console.WriteLine ("Введите число B: ");
// int b = int.Parse (Console.ReadLine ()?? "");
// int c = Convert.ToInt32 (Math.Pow (a,b));
// Console.WriteLine ($"{a},{b} -> {c}");

Console.Clear ();
int num = GetNumberFromUser ("Введите число А: ", "Ошибка Ввода!");
int num1 =GetNumberFromUser ("Введите число B: ", "Ошибка Ввода!");

int cubeNumbers = CubeNumbers (num, num1);

Console.WriteLine ($"{num}, {num1} -> {cubeNumbers}");

int GetNumberFromUser (string message, string errorMessage)
{
   while (true)
   {
       Console.Write (message);
       bool isCorrect = int.TryParse (Console.ReadLine (), out int userNumber);
       if (isCorrect)
           return userNumber;
       Console.WriteLine (errorMessage);
   }
}

int CubeNumbers (int num, int num1)
{
   int result = num;
   for (int i=0 ; i<num1-1; i++)
   {
       result *= num;
   }
   return result;
}
