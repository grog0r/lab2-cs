using lab2_siu;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ЗАДАНИЕ 1");
        // Создаем три точки с разными координатами
        Point point1 = new Point(1.5, 2.7);
        Point point2 = new Point(2.1, -1.7);
        Point point3 = new Point(-4.3, -1.1);

        // Вывод на экран текстовое представление точек
        Console.WriteLine($"Точка 1: {point1}");
        Console.WriteLine($"Точка 2: {point2}");
        Console.WriteLine($"Точка 3: {point3}");

        Console.WriteLine("ЗАДАНИЕ 2"); 
        // Создаем линию 1
        Point linestart1 = new Point(1, 3);
        Point lineend1 = new Point(23, 8);
        Line line1 = new Line(linestart1, lineend1);
        Console.WriteLine($"Линия 1: {line1}");

        // Создаем линию 2
        Point linestart2 = new Point(5, 10);
        Point lineend2 = new Point(25, 10);
        Line line2 = new Line(linestart2, lineend2);
        Console.WriteLine($"Линия 2: {line2}");

        // Создаем линию 3
        Line line3 = new Line(line1.Start, line2.End);
        Console.WriteLine($"Линия 3: {line3}");

        // Меняем координаты первой и второй линии
        line1.Start.X = 10;
        line1.Start.Y = 20;
        line1.End.X = 25;
        line1.End.Y = 30;

        line2.Start.X = 5;
        line2.Start.Y = 7;
        line2.End.X = 15;
        line2.End.Y = 7;

        Console.WriteLine($"Измененная линия 1: {line1}");
        Console.WriteLine($"Измененная линия 2: {line2}");
        Console.WriteLine($"Измененная линия 3: {line3}");

        // Изменение координат первой линии так, чтобы изменения не повлияли на линию 3
        line1.Start = new Point(25, 25);
        line1.End = new Point(-25, -25);
        Console.WriteLine($"Измененная линия 1: {line1}");
        Console.WriteLine($"Линия 2: {line2}");
        Console.WriteLine($"Линия 3: {line3}");

        Console.WriteLine("ЗАДАНИЕ 3");
        // Создаем студента Васю с оценками: 3, 4, 5
        int[] vGrades = { 3, 4, 5 };
        Student vasya = new Student("Вася", vGrades);
        Console.WriteLine(vasya);

        // Создаем студента Петю и копируем оценки Васи
        Student petya = new Student("Петя", vasya.Grades);
        Console.WriteLine(petya);

        // Меняем первую оценку Пети на число 5
        petya.Grades[0] = 5;
        Console.WriteLine("Оценки Пети и Васи после изменения оценки Пети: ");
        Console.WriteLine(vasya);
        Console.WriteLine(petya);
        // Оба объекта используют один и тот же массив, поэтому оценка меняется у обоих сразу

        // Создаем студента Андрея и копируем ему оценки Васи так, чтобы изменение оценок Васи не влияло на Андрея
        int[] aGrades = new int[vasya.Grades.Length];
        Array.Copy(vasya.Grades, aGrades, vasya.Grades.Length);
        Student andrey = new Student("Андрей", aGrades);
        // Меняем оценки Васи и смотрим результат
        vasya.Grades[0] = 2;
        Console.WriteLine(vasya);
        Console.WriteLine(andrey);
        // Андрей имеет отдельный массив скопированных оценок Васи в памяти, поэтому изменение оценок одного не влияет на другого

        Console.WriteLine("ЗАДАНИЕ 4");
        // Создаем точки с координатами (3;5), (25;6), (7;8), задавая координаты конструктором
        PointNew pointnew1 = new PointNew(3, 5);
        PointNew pointnew2 = new PointNew(25, 6);
        PointNew pointnew3 = new PointNew(7, 8);

        Console.WriteLine($"Точка 1: {pointnew1}");
        Console.WriteLine($"Точка 2:  {pointnew2}");
        Console.WriteLine($"Точка 3:  {pointnew3}");

        Console.WriteLine("ЗАДАНИЕ 5");
        // Создаем студента Васю с оценками 3, 4, 5
        StudentNew vasya2 = new StudentNew("Вася", new int[] { 3, 4, 5 });
        Console.WriteLine(vasya2);
        // Создаем студента Максима без оценок
        StudentNew maxim = new StudentNew("Максим");
        Console.WriteLine(maxim);
    }
}