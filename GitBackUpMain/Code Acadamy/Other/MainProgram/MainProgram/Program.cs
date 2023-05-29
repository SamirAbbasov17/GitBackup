namespace MainProgram
{
    using Services;
    using Models;


    //public delegate void LowLevelLoggerDelegate(string message);
    //public delegate void MediumLevelLoggerDelegate(string message);
    //public delegate void HighLevelLoggerDelegate(string message);
    internal class Program
    {
        //public delegate void Toplama(double a, double b);
        //public delegate void Cixma(double a, double b);
        //public delegate void Vurma(double a, double b);
        //public delegate void Bolme(double a, double b);

        public delegate TResult Calculator<in Tin , out TResult>(Tin a , Tin b);

        static void Main(string[] args)
        {

            ////string errorMessage = "Exception sinifi icerisinden gelen hata mesaji";
            //ILogger smsLogger = new SMSLogger();
            ////smsLogger.SetLog(errorMessage);

            //ILogger mailLogger = new MAILLogger();
            ////mailLogger.SetLog(errorMessage);

            //ILogger pushNotification = new PushNotification();
            ////pushNotification.SetLog(errorMessage);

            //ILogger xmlLogger = new XMLLogger();
            ////xmlLogger.SetLog(errorMessage);

            //ILogger dbLogger = new DBLogger();
            ////dbLogger.SetLog(errorMessage);

            //Exception ex = new Exception("Alinan hata bilgisi");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Low Level Logs");
            //LowLevelLoggerDelegate lowLevel = new LowLevelLoggerDelegate(xmlLogger.SetLog);
            //lowLevel += mailLogger.SetLog;
            //lowLevel.Invoke(ex.Message);
            //Console.ResetColor();

            //Console.WriteLine("\n" + new string('_',50) + "\n");

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Medium Level Logs");
            //MediumLevelLoggerDelegate mediumDelegate = new MediumLevelLoggerDelegate(mailLogger.SetLog);
            //mediumDelegate += xmlLogger.SetLog;
            //mediumDelegate += dbLogger.SetLog;
            //mediumDelegate.Invoke(ex.Message);
            //Console.ResetColor();



            //Console.WriteLine("\n" + new string('_', 50) + "\n");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("High Level Logs");
            //HighLevelLoggerDelegate highDelegate = new HighLevelLoggerDelegate(mailLogger.SetLog);
            //highDelegate += xmlLogger.SetLog;
            //highDelegate += dbLogger.SetLog;
            //highDelegate += smsLogger.SetLog;
            //highDelegate += pushNotification.SetLog;
            //highDelegate.Invoke(ex.Message);
            //Console.ResetColor();




            //Hesblama hesabla = new Hesblama();




            //Toplama toplama = new(hesabla.Toplama);
            //toplama.Invoke()
            Calculator<double, double> sum = (a,b)=>
            {
                return a + b;
            };
            Calculator<double, double> difference = (a, b) =>
            {
                return a - b;
            };
            Calculator<double, double> vur = (a, b) =>
            {
                return a * b;
            };
            Calculator<double, double> bol = (a, b) =>
            {
                return a / b;
            };
        }
    }
}