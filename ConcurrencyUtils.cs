using System.Threading;

namespace AnalizadorVentasRopa.Utils
{
    public static class ConcurrencyUtils
    {
        public static SemaphoreSlim ReporteSemaphore = new SemaphoreSlim(1, 1);
        public static object LockObj = new object();


    }
}
