using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Services
{


    public interface ILogger
    {
        void SetLog(string message);
    }
    internal class SMSLogger:ILogger
    {
        public void SetLog(string message) 
        {
            Console.WriteLine("{0} -> {1}" , this.GetType().Name , message);
        }
    }
    internal class MAILLogger : ILogger
    {
        public void SetLog(string message)
        {
            Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
        }
    }
    internal class XMLLogger : ILogger
    {
        public void SetLog(string message)
        {
            Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
        }
    }
    internal class DBLogger : ILogger
    {
        public void SetLog(string message)
        {
            Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
        }
    }
    internal class PushNotification : ILogger
    {
        public void SetLog(string message)
        {
            Console.WriteLine("{0} -> {1}", this.GetType().Name, message);
        }
    }
}
