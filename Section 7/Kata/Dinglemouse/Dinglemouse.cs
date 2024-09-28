using System;
public struct Point
{
    public Point( int x, int y)
    {
        X = x;
        Y = y;
    }
    public int X {get;set;}
    public int Y {get;set;}
}
public class Dinglemouse
{

    public static bool AllAlone(char[][] house)
    {
        Point potus = default;
        for (int i = 0; i < house.GetLength(0); i++)
        {
            for (int j = 0; j < house[i].Length; j++)
            {
                if (house[i][j] =='X')
                {
                    potus = new Point(i,j);
                }
            }
        }
        return false;
    }
}