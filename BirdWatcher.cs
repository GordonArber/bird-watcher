using System;

class BirdCount
{
    readonly int[] _birdsPerDay;
    int _addBird;

    public BirdCount(int[] birdsPerDay)
    {
        _birdsPerDay = birdsPerDay;
        _addBird = 0;
    }

    public static int[] LastWeek()
    {
        return new [] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return _birdsPerDay[^1] + _addBird;
    }

    public void IncrementTodaysCount()
    {
        _addBird++;
        Today();
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var birdCount  in _birdsPerDay)
        {
            if (birdCount == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var total = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            total += _birdsPerDay[i];
        }

        return total;
    }

    public int BusyDays()
    {
        var busyDayCount = 0;
        foreach (var birdCount in _birdsPerDay)
        {
            if (birdCount >= 5)
            {
                busyDayCount++;
            }
        }

        return busyDayCount;
    }
}
