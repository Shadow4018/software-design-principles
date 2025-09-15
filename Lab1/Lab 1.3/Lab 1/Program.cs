
using System.Diagnostics;
using System.Xml.Serialization;

static bool isValid(int x, int y)
{
    if (x >= 1 && x <= 8 && y >= 1 && y <= 8)
    {
        return true;
    }
    else return false;
}

static bool KingAttacks(int kx, int ky, int x, int y)
{
    return Math.Abs(kx - x) <= 1 && Math.Abs(ky - y) <= 1;
}

static bool FerzAttacks(int qx, int qy, int x, int y)
{
    return Math.Abs(qx - x) == Math.Abs(qy - y);
}

static bool PawnAttacks(int px, int py, int x, int y)
{
    return (x == px - 1 || x == px + 1) && y == py - 1;
}

static void king(ref int kx, ref int ky)
{
    Console.WriteLine($"You've chosen the White King. Current coords: ({kx}, {ky})");
    int oldX = kx;
    int oldY = ky;

    for (; ; )
    {
        Console.WriteLine("Input new coords: ");
        kx = Convert.ToInt32(Console.ReadLine());
        ky = Convert.ToInt32(Console.ReadLine());

        if (!isValid(kx, ky))
        {
            Console.WriteLine("Invalid coords! Try again.");
            continue;
        }

        if (Math.Abs(kx - oldX) <= 1 && Math.Abs(ky - oldY) <= 1)
        {
            Console.WriteLine($"King moved to ({kx}, {ky})");
            return;
        }
        else
        {
            Console.WriteLine("Wrong move! King moves only 1 square. Try again.");
        }
    }
}


//static void ShowBoard(int x1, int y1, int x2, int y2, int x3, int y3)
//{
//    Console.WriteLine("\n--- Поточні координати фігур ---");
//    Console.WriteLine($"Білий король: ({x1},{y1})");
//    Console.WriteLine($"Чорний кінь:  ({x2},{y2})");
//    Console.WriteLine($"Чорний слон:  ({x3},{y3})");
//    Console.WriteLine("--------------------------------\n");
//}

static void ferz(ref int fx, ref int fy)
{
    Console.WriteLine($"You've chosen the White Ferz. Current coords: ({fx}, {fy})");
    int oldX = fx;
    int oldY = fy;

    for (; ; )
    {
        Console.WriteLine("Input new coords: ");
        fx = Convert.ToInt32(Console.ReadLine());
        fy = Convert.ToInt32(Console.ReadLine());

        if (!isValid(fx, fy))
        {
            Console.WriteLine("Invalid coords! Try again.");
            continue;
        }

        // умова діагонального руху
        if (Math.Abs(fx - oldX) == Math.Abs(fy - oldY))
        {
            Console.WriteLine($"Ferz moved diagonally to ({fx}, {fy})");
            return;
        }
        else
        {
            Console.WriteLine("Wrong move! Ferz can move only diagonally. Try again.");
        }
    }
}

static void pawn(ref int px, ref int py)
{
    Console.WriteLine($"You've chosen the Dark Pawn. Current coords: ({px}, {py})");
    Console.WriteLine("", px, py);
    int oldX = px;
    int oldY = py;
    for (; ; )
    {
        Console.WriteLine("Input new coords: ");
        px = Convert.ToInt32(Console.ReadLine());
        py = Convert.ToInt32(Console.ReadLine());

        if (!isValid(px, py))
        {
            Console.WriteLine("Invalid coords! Try again.");
            continue;
        }

        if (py == oldY-1 && px == oldX)
        {
            Console.WriteLine($"Pawn moved to ({px}, {py})");
            return;
        }
        else
        {
            Console.WriteLine("Wrong move! Pawn can move only forward. Try again.");
        }
    }
}

static void mainMenu(ref int kx, ref int ky, ref int fx, ref int fy, ref int px, ref int py)
{
    Console.WriteLine("Choose a pawn:\n 1. White King\n2. White Ferz\n3.Dark Pawn\n0. Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    for (; ; )
    {
        switch (option)
        {
            case 1: // King
                king(ref kx, ref ky);
                if (KingAttacks(kx, ky, px, py))
                    Console.WriteLine("King is on ATTACK!");
                else if (PawnAttacks(px, py, fx, fy) && KingAttacks(kx, ky, fx, fy))
                    Console.WriteLine("King is on PROTECT!");
                else
                    Console.WriteLine("Just a silly move ^_^");
                break;

            case 2: // Ferz
                ferz(ref fx, ref fy);
                if (FerzAttacks(fx, fy, px, py))
                    Console.WriteLine("Ferz is on ATTACK!");
                else if (PawnAttacks(px, py, kx, ky) && FerzAttacks(fx, fy, kx, ky))
                    Console.WriteLine("Ferz is on PROTECT!");
                else
                    Console.WriteLine("Just a silly move ^_^");
                break;

            case 3: // Pawn
                pawn(ref px, ref py);
                if (PawnAttacks(px, py, kx, ky))
                    Console.WriteLine("Pawn is on ATTACK!");
                else if (PawnAttacks(px, py, fx, fy))
                    Console.WriteLine("Pawn is on ATTACK!");
                else
                    Console.WriteLine("Just a silly move ^_^");
                break;
            case 0:
                return;
            default:
                Console.WriteLine("Невірний вибір!");
                break;
        }
    }
}

Console.WriteLine("Input coords of the King pawn: ");
int kx = Convert.ToInt32(Console.ReadLine());
int ky = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coords of the Ferz Pawn: ");
int fx = Convert.ToInt32(Console.ReadLine());
int fy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coords of the Ferz Pawn: ");
int px = Convert.ToInt32(Console.ReadLine());
int py = Convert.ToInt32(Console.ReadLine());
if (!isValid(kx, ky) || !isValid(fx, fy) || !isValid(px, py))
{
    Console.WriteLine("Invalid coordinates!");
    return;
}

mainMenu(ref kx, ref ky, ref fx, ref fy, ref px, ref py);