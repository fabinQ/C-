using System;
public struct Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public int X { get; set; }
    public int Y { get; set; }
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
                if (house[i][j] == 'X')
                {
                    potus = new Point(i, j);
                }
            }
        }
        var scannedPoints = new List<Point>();

        var isNotAlone = Scan(potus, house, scannedPoints);
        return !isNotAlone;
    }
    public static bool Scan(Point point, char[][] house, List<Point> scannedPoints)
    {
        if (scannedPoints.Contains(point))
        {
            return false;
        }
        scannedPoints.Add(point);

        if (house[point.X][point.Y] == 'o')
        {
            return true;
        }

        if (house[point.X][point.Y] == '#')
        {
            return false;
        }
        Point pointUp = new Point(point.X, point.Y + 1);
        Point pointDown = new Point(point.X, point.Y - 1);
        Point pointLeft = new Point(point.X - 1, point.Y);
        Point pointRight = new Point(point.X + 1, point.Y);

        List<Point> points = new List<Point>
        {
            pointUp, pointDown, pointLeft, pointRight
        };
        foreach (Point pointDemention in points)
        {
            if (Scan(pointDemention, house, scannedPoints))
            { return true; }
        }
        return false;
    }
}