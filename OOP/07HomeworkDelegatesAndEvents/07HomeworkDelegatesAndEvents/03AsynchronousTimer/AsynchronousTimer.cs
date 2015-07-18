namespace _03AsynchronousTimer
{
    #region

    using System;
    using System.Threading;
    using System.Threading.Tasks;

    #endregion

    public class AsynchronousTimer
    {
        public AsynchronousTimer(Action action, int interval, int ticks)
        {
            this.Action = action;
            this.Interval = interval;
            this.Ticks = ticks;
        }

        public Action Action { get; set; }

        public int Interval { get; set; }

        public int Ticks { get; set; }

        public async void Start()
        {
            await Task.Run(() =>
                    {
                        for (int i = 0; i < this.Ticks; i++)
                        {
                            this.Action();
                            Thread.Sleep(this.Interval);
                        }
                    }); 

            Console.WriteLine("Done!");
        }
    }
}