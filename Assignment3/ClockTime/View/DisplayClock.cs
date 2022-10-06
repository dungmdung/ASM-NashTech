namespace Assignment3
{
    public class DisplayClock
    {
        public void Subcribe(Clock clock)
        {
            clock.clocktick += new Clock.clockTickHandler(ShowClock);
        }
        public void ShowClock(object clock, ClockEventArgs clockEventArgs)
        {
            Console.WriteLine($" {clockEventArgs.hour} : {clockEventArgs.minute} : {clockEventArgs.second}");
        }
    }
}