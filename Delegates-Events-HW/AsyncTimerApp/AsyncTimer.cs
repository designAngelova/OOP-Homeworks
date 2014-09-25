using System;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTimerApp
{
    public class AsyncTimer
    {
        private Thread thread;
        private Action<int> action;
        private int ticks;
        private int interval;

        public AsyncTimer(Action<int> action, int ticks, int interval)
        {
            this.action = action;
            this.ticks = ticks;
            this.interval = interval;
        }

        public Action<int> Action
        {
            get { return this.action; }
            set
            {
                this.action = value;
            }
        }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ticks count cannot be negative");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval value cannot be negative");
                }
                this.interval = value;
            }
        }

        private void Clock()
        {
            int timer = 0;

            while (timer <= this.ticks)
            {
                this.Action(timer);

                try
                {
                    Thread.Sleep(this.interval);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.ToString());
                }
                catch (ThreadInterruptedException tie)
                {
                    Console.WriteLine(tie.ToString());
                }
                catch (SecurityException se)
                {
                    Console.WriteLine(se.ToString());
                }
                
                timer++;
            }
        }

        public void StartCounter()
        {
            this.thread = new Thread(new ThreadStart(this.Clock));
            this.thread.Name = "Clock";
            try
            {
                this.thread.Start();
            }
            catch (ThreadStateException te)
            {
                Console.WriteLine(te.ToString());
            }       
        }

        public void StopCounter()
        {
            try
            {
                this.thread.Abort();
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae);
            }           
        }

        public void SetToBackground()
        {
            this.thread.IsBackground = true;
        }

        public void Join(TimeSpan ts)
        {
            this.thread.Join(ts);
        }
    }

    public class AsyncTimerTester
    {
        public static void Main()
        {
            Action<int> MyCrazyFunction = (i) => Console.WriteLine(i);

            AsyncTimer myTimer = new AsyncTimer(MyCrazyFunction, 110, 500);

            myTimer.StartCounter();

            // Uncomment the line below to stop the 'myTimer thread with the main thread i.e end of program exec
            myTimer.SetToBackground();

            AsyncTimer mySecondTimer = new AsyncTimer(MyCrazyFunction, 11, 1000);

            mySecondTimer.StartCounter();

            // Executes parallely with the counter
            Thread.CurrentThread.Name = "Main thread";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} says -> Hello", Thread.CurrentThread.Name);
            }

            Thread.Sleep(3000);

            Console.WriteLine("{0} says -> Hello again. I will stop 'mySecondTimer'", Thread.CurrentThread.Name);
            mySecondTimer.StopCounter();
            Console.WriteLine("Only 'myTimer' continues and 'Main thread just sits there'");

            myTimer.Join(new TimeSpan(0, 0, 10));

            // The main method will wait 10 seconds so that myTimer can work some more
            Console.WriteLine("End of Main");
        }
    }
}
