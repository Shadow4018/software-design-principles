
using System.Diagnostics;
using System.Xml.Serialization;

static bool isValid(int x, int y) // CHECK
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

// MAIN
Console.WriteLine("Input coords of the King pawn: ");
int kx = Convert.ToInt32(Console.ReadLine());
int ky = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coords of the Ferz Pawn: ");
int fx = Convert.ToInt32(Console.ReadLine());
int fy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coords of the Ferz Pawn: ");
int px = Convert.ToInt32(Console.ReadLine());
int py = Convert.ToInt32(Console.ReadLine());

// if coords are beyond 8X8
if (!isValid(kx, ky) || !isValid(fx, fy) || !isValid(px, py))
{
    Console.WriteLine("Invalid coordinates!");
    return;
}

// if two figures are on the same spot
if ((kx == fx && ky == fy) || (kx == px && ky == py) || (fx == px && fy == py))
{
    Console.WriteLine("Error: Two figures in one place!");
    return;
}

//Kings move
if (KingAttacks(kx, ky, px, py))
    Console.WriteLine("King is on ATTACK!");
else if (PawnAttacks(px, py, fx, fy) && KingAttacks(kx, ky, fx, fy))
    Console.WriteLine("King is on PROTECT!");
else
    Console.WriteLine("Just a silly move ^_^");

//Ferz move
if (FerzAttacks(fx, fy, px, py))
    Console.WriteLine("Ferz is on ATTACK!");
else if (PawnAttacks(px, py, kx, ky) && FerzAttacks(fx, fy, kx, ky))
    Console.WriteLine("Ferz is on PROTECT!");
else
    Console.WriteLine("Just a silly move ^_^");

//Pawn move
if (PawnAttacks(px, py, kx, ky))
    Console.WriteLine("Pawn is on ATTACK!");
else if (PawnAttacks(px, py, fx, fy))
    Console.WriteLine("Pawn is on ATTACK!");
else
    Console.WriteLine("Just a silly move ^_^");