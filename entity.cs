using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace lab2_siu;

internal class Point
{
    //поля (по умолчанию поля приватные (НЕЛЬЗЯ ДЕЛАТЬ ПУБЛИЧНЫЕ))
    double x;
    double y;

    // свойства
    public double X { get; set; }
    public double Y { get; set; }

    //конструкторы 
    //по умолчанию

    //с параметрами
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    //копирование
    //public Student(Student student)
    //{
    // this.name = student.Name;
    // this.age = student.Age;
    //  this.avg = student.Avg;
    //  this.gender = student.Gender;
    //}

    //методы
    public string GetTextAnswer()
    {
        return $"[{X};{Y}]";
    }

    public override string ToString()
    {
        return GetTextAnswer();
    }
}

internal class Line
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }
    public string GetTextAnswer()
    {
        return $"Линия от {Start} до {End}";
    }

    public override string ToString()
    {
        return GetTextAnswer();
    }
}

internal class Student
{
    public string Name { get; set; }
    public int[] Grades { get; set; }
    public Student(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public string GetTextAnswer()
    {
        return $"{Name}: [{string.Join(", ", Grades)}]";
    }
    public override string ToString()
    {
        return GetTextAnswer();
    }
}

internal class PointNew
{
    public double X { get; } // Только чтение
    public double Y { get; } // Только чтение

    public PointNew(double x, double y) // Теперь задать координаты можно только с помощью конструктора
    {
        X = x;
        Y = y;
    }
    public string GetTextAnswer()
    {
        return $"[{X};{Y}]";
    }

    public override string ToString()
    {
        return GetTextAnswer();
    }
}

internal class StudentNew
{
    public string Name { get; set; }
    public int[] Grades { get; set; }
    public StudentNew(string name, int[] grades = null)
    {
        Name = name;
        
        if (grades == null)
        {
            Grades = new int[0]; // Пустой массив если null
        }
        else
        {
            Grades = grades;
        }
    }
    public string GetTextAnswer()
    {
        if (Grades == null || Grades.Length == 0)
        {
            return $"{Name}: []";
        }
        return $"{Name}: [{string.Join(", ", Grades)}]";
    }
    public override string ToString()
    {
        return GetTextAnswer();
    }
}