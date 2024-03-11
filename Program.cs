using System;

class Program
{
    static void Main(string[] args)
    {
        var rect = new Rectangle(3, 4);
        //(float width, float height) = rect; //деконструирование
        //rect.Deconstruct(out var width, out var height);
        //var (width, height) = rect;
        var (width, height) = rect; // _ - символ отбрасывания
        Console.WriteLine(width + " " + height);

        Sentence s = new Sentence();//индексаторы
        Console.WriteLine(s[^1]); //последняя с конца
        string[] firstTwoWords = s [..2];
        
        //s[3] = "kangoroo";
        Console.WriteLine(s[3]);
    }
}
public class Panda
{
    string name;
    public Panda(string n) //конструктор
    {
        name = n;
    }
    //public Panda (string n ) => name = n; конструктор содержащий единственный оператор
}
public class Wine
{
    public decimal Price;
    public int Year;
    public Wine(decimal price) { Price = price; }
    public Wine(decimal price, int year) : this(price) { Year = year; } //ключевое слово this перегружает конструктор что бы вызвать другой
}
class Rectangle 
{
    public readonly float Width, Height;
    public Rectangle(float width, float height) //конструктор
    {
        Width = width;
        Height = height;
    }
    public void Deconstruct(out float width, out float height) //деконструктор
    {//присвает значение полей набору переменных "out"
        width = Width;
        height = Height;
    }
}
class Sentence
{
    string[] words = "The quick brown fox".Split();
    public string this[Index index] => words[index];
    public string[] this[Range range] => words[range];
    public string this[int wordNum] // индексатор . Определяем св-во по имени this
    {
        get { return words[wordNum]; }
        set { words[wordNum] = value;}
    }
}
