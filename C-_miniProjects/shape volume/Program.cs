using System;

abstract class shape
{
    int x, y,z;
    public shape() { Console.WriteLine("already in shape default constructor"); }
    public shape(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public void setX(int x) { this.x = x; }
    public void setY(int y) { this.y = y; }
    public void setZ(int z) { this.z = z; }

    public int getX() { return this.x; }
    public int getY() { return this.y; }
    public int getZ() { return this.z; }

    public abstract double calcVolume();

    public static void geoShape(params shape[] shapes)
    {
        foreach (var s in shapes) {Console.WriteLine(s.calcVolume()); }

    }
}

class circle : shape
{
    circle() { Console.WriteLine("already in circle default constructor"); }
    public circle(int r, int l) { base.setX(r); base.setY(l); }

    public override double calcVolume()
    { return Math.PI * Math.Pow(base.getX(),2)*base.getY(); }
}
class cube:shape
{
    public cube(int l):base(l,l,l) { base.setX(l); }

    public override double calcVolume()
    {
        return Math.Pow(base.getX(), 3);
    }
}

class box : shape
{
    public box(int l, int w, int h) : base(l, w, h) { base.setX(l); base.setY(w); base.setZ(h); }

    public override double calcVolume()
    {
        return getX() * getY() * getZ();
    }
}



class program
{
    public static void Main()
    {
        circle c = new circle(3, 4);
        cube cu = new cube(3);
        box b = new box(2, 3, 4);

        shape.geoShape(c, cu, b);
    }
}
