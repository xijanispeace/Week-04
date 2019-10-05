using System;

namespace LaB01
{
    class Program
    {
        private static object name;

        static void Main(string[] args)
        {
            long mercury   = 57910000;
            long venus     = 108200000;
            long earth     = 149600000;
            long mars      = 227940000;
            long jupiter   = 778330000;
            long uranus    = 2873550000;
            long neptune   = 4501000000;
            long pluto     = 5945900000;

            double AU = 6.684587123e-9;
            double lm = 8.317;

            Console.Write("Mercury");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", mercury);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * mercury);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * mercury) * lm));

            Console.Write("venus");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", venus);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * venus);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * venus) * lm));

            Console.Write("earth ");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", earth);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * earth);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * earth) * lm));

            Console.Write("mars ");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", mars);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * mars);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * mars) * lm));

            Console.Write("jupiter ");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", jupiter);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * jupiter);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * jupiter) * lm));

            Console.Write("uranus ");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", uranus);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * uranus);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * uranus) * lm));

            Console.Write("neptune  ");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", neptune);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * neptune);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * neptune) * lm));

            Console.Write("pluto");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", pluto);
            Console.WriteLine("Distance of A.U       : {0, 0:n10} AU", AU * pluto);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * pluto) * lm));







        }
    }
}
