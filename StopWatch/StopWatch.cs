using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class StopWatch
    {
        private DateTime _startTime { get; set; }
        private DateTime _endTime { get; set; }
        public TimeSpan duration { get; set; }
        public bool _isStartOrStop { get; set; }
        
        public void Start()
        {
            _startTime = DateTime.Now;
            _isStartOrStop = true;
        }

        public void Stop()
        {
            _endTime = DateTime.Now;
            duration = _endTime - _startTime;
            _isStartOrStop = false;
        }
    }
}