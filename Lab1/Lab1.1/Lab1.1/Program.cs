Console.Write("Input the values\nx:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Radius:");
int R = Convert.ToInt32(Console.ReadLine());
string result = checkCoords(x, y, R);
Console.WriteLine(result);

static string checkCoords(int x, int y, int R)
{
    if (y >= 0 && (Math.Abs(x) + y) <= R)
    {
        if ((Math.Abs(x) + y) == R)
        {
            return "On the edge.";
        }
        else
        {
            return "Inside of the Circle";
        }
    }

    if (Math.Abs(y) < Math.Abs(x) && Math.Abs(y) + Math.Abs(x) <= R)
    {
        if (Math.Abs(y) + Math.Abs(x) == R)
        {
            return "On the edge of the Triangle";
        }
        else
        {
            return "Inside of the Triangle";
        }
    }
    else return "Out of the Range";
}




