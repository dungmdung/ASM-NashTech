namespace Assignment3
{
    public class Clock
    {
        private int _second;

        public delegate void clockTickHandler(Object clock, ClockEventArgs clockEventArgs);

        public event clockTickHandler? clocktick;

        protected void onTick(Object clock, ClockEventArgs clockEventArgs)
        {
            if (clocktick != null)
            {
                clocktick(clock, clockEventArgs);
            }
        }
        public void Run()
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
                Console.Clear();
                var time = DateTime.Now;

                if (time.Second != this._second)
                {
                    var clockEventArgs = new ClockEventArgs(time.Hour, time.Minute, time.Second);

                    onTick(this, clockEventArgs);
                }
            }
        }
    }
}