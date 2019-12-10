using System;

class ClockAngle
  {
    static void Main()
    {
      Console.WriteLine("Enter the hour:");
      int hour = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the minute:");
      int minute = int.Parse(Console.ReadLine());

      float result = determineDistance(hour, minute);

      Console.WriteLine("The distance in degress between the hour and the minute is " + result + " degrees.");
    }
    static float determineDistance(int hour, int minute)
    {
      float minuteDegrees = minute * 6; // 360/60 = 6
      float hourDegrees = Convert.ToSingle(hour * 30 + .5 * minute); // 360/12 = 30 each hour 30/60 = .5 each min
      float angleDistance = Math.Abs(minuteDegrees - hourDegrees);
      if (angleDistance > 180)
      {
        angleDistance = 360 - angleDistance;
      }
      return angleDistance;
    }
  }
