using System;

namespace ConsoleApp1
{
    public abstract class DBConection
    {
        private string _conectionString { get; }
        private TimeSpan _timeout { get; }
        private DateTime _timeStarted { get; set; }

        public DateTime timeStarted
        {
            get { return _timeStarted; }
        }

        public TimeSpan timeout
        {
            get { return _timeout; }
        }

        public DBConection(string conectionString)
        {
            if (string.IsNullOrWhiteSpace(conectionString))
            {
                Console.WriteLine("Enter a Valid conectionString");
            }
            else
            {
                _conectionString = conectionString;
                _timeout = TimeSpan.FromMinutes(15);
            }
        }

        public DBConection(string conectionString, TimeSpan timeout)
            : this(conectionString)
        {
            if (string.IsNullOrWhiteSpace(timeout.ToString()))
            {
                Console.WriteLine("Enter a Valid TimeSpan");
            }
            else
            {
                _timeout = timeout;
            }
        }


        public abstract void OpenningConectiom();


        public abstract void ClosingConectiom();
    }
}