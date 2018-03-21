# NET.S.2018.Kuranets.03
Third day of developing ASP.NET MVC web applications
1.	Реализовать алгоритм FindNthRoot, позволяющий вычислять корень n-ой степени ( n∈N ) из вещественного числа а методом Ньютона с заданной точностью. Разработать модульные тесты (NUnit и (или) MS Unit Test) для тестирования метода. Примерные тест кейсы:
<li>
[TestCase(1, 5, 0.0001,ExpectedResult =1)]
<li>
[TestCase(8, 3, 0.0001,ExpectedResult = 2)]
<li>
[TestCase(0.001, 3, 0.0001,ExpectedResult = 0.1)]
<li>
[TestCase(0.04100625,4 , 0.0001, ExpectedResult =0.45)]
<li>
[TestCase(8, 3, 0.0001, ExpectedResult =2)]
<li>
[TestCase(0.0279936, 7, 0.0001, ExpectedResult =0.6)]
<li>
[TestCase(0.0081, 4, 0.1, ExpectedResult =0.3)]
<li>
[TestCase(-0.008, 3, 0.1, ExpectedResult =-0.2)]
<li>
[TestCase(0.004241979, 9, 0.00000001, ExpectedResult =0.545)]
<li>
[TestCase(8, 15, -7, -5)] <- ArgumentOutOfRangeException
<li>
[TestCase(8, 15, -0.6, -0.1)] <- ArgumentOutOfRangeException
                                 
                                 
Рекомендованный шаблон для тестового метода проверки исключений.
MethodName_Number_Degree_Precision_ArgumentOutOfRangeException(double number, int degree, double precision, double expected) => Assert.Throws(() => ClassName.MethodName(number, degree, precision));
 
 
 
2.	Реализовать метод "пузырьковой" сортировки для целочисленного массива (не использовать методы класса System.Array) таким образом, чтобы была возможность упорядочить строки матрицы
<li>в порядке возрастания(убывания) сумм элементов строк матрицы;
<li>в порядке возрастания(убывания) максимальных элементов строк матрицы;
<li>в порядке возрастания(убывания) минимальных элементов строк матрицы.
