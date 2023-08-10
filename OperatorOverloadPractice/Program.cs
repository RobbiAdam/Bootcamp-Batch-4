using System;

class Program
{
    static void Main(string[] args)
    {
        Box box1 = new Box(5,6,5);
        Box box2 = new Box(3,4,5);
        decimal _result = box1.GetVolume();
        decimal _result2 = box2.GetVolume();
        Console.WriteLine("Box Volume is " + _result);
        Console.WriteLine("Box 2 Volume is " + _result2);

        Box box3 = box1 + box2;
        decimal _result3 = box3.GetVolume();
        Console.WriteLine("Box 3 Volume is " + _result3);

    }
}

class Box
{
    private decimal _width { get; set; }
    private decimal _length { get; set; }
    private decimal _height { get; set; }

    public Box(decimal width, decimal length, decimal height)
    {
        _width = width;
        _length = length;
        _height = height;
    }

    public decimal GetVolume()
    {
        return _width * _height * _length;
    }

    public static Box operator +(Box b1, Box b2)
    {
        return new Box(b1._width + b2._width, b1._height + b2._height, b1._length + b2._length);
    }
}