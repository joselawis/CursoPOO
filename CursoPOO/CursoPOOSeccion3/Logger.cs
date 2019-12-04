using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOOSeccion3
{
    abstract class LoggerBase : ILogger
    {
        protected string MiPropiedad { get; set; }
        public abstract void Log(string mensaje);
        public virtual void LogException(Exception ex) => Log(ex.Message);

        public static void ProbarLogger(LoggerBase logger)
        {
            logger.Log("Probando el logger");
            try
            {
                throw new NotImplementedException("Prueba de exception");
            }
            catch(NotImplementedException ex)
            {
                logger.LogException(ex);
            }
        }
    }

    interface ILogger
    {
        void Log(string mensaje);
        void LogException(Exception ex);
    }

    class LoggerConsola : LoggerBase
    {
        public override void Log(string mensaje) => Console.WriteLine(mensaje);
        public override void LogException(Exception ex)
        {
            Log($"{ex.Message}: {ex.StackTrace}");
        }
    }

    class LoggerArchivo: LoggerBase
    {
        public override void Log(string mensaje)
        {
            using (StreamWriter writetext = new StreamWriter($@"{Directory.GetCurrentDirectory()}\log.txt", append: true))
            {
                writetext.WriteLine($"{DateTime.Now}: {mensaje}");
            }
        }
    }


}
