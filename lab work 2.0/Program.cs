namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool boo = 1;
            //char ch = 100;
            //byte b = 250,7;
            //sbyte sb = 150;
            //short sh = 10000;
            //ushort ush = -25;     before
            //int i = -233; 
            //uint ui = 300;
            //long l = 100000,6;
            //ulong ul = 8;
            //decimal de = 33,1;
            //float fl;
            //double d0;
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // somewhere yes, somewhere no
            // Fix compilation errors (change values for impossible initialization)
            bool boo = false;
            char ch = 'm';
            byte b = 250;
            sbyte sb = 15;
            short sh = 10000;
            ushort ush = 25;
            int i = -23;
            uint ui = 300;
            long l = 100000;
            ulong ul = 8;
            decimal de = 120;
            float fl = 15;
            double d0 = 11.05;



            //2) declare constants of int and double. Try to change their values.
            const int i1 = 100;
            const double d02 = 20.5;
            //i1 = 20;  error 
            //d02 = 50;



            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            var lol = 20; //int32
            var kek = 20.5; // double

            // Try to reinitialize by 20.5 and 20 (change values). What results are there?
            // types have changed 2;


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?    yes))
            System.Int32 test = -233;
            System.Double test1 = 11.5;



            //if (true)
            //{
            //    // 5) declare variables of int, char, double 
            //    // with names i, ch, do
            //    // is it possible?      imposible
            //    int i;
            //    i = -233;
            //    char ch = 'a';
            //    double d0 = 11.5;
            //    // 6) change values of variables from 1)           broken step


            //}

            // 7)check values of variables from 1). Are they changed? Think, why  broken step


            // 8) use implicit/ explicit conversion to convert variables from 1).  

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char

            // bool -> short

            // double -> long


            long output0 = Convert.ToInt64(d0);
            // float -> char 

            // int to char

            // decimal -> double

            double output1 = Convert.ToDouble(de);
            // byte -> uint
            uint output2 = Convert.ToUInt32(b);
            // ulong -> sbyte
            ulong output3 = Convert.ToUInt32(sb);

            // 9) and reverse conversion with fixing compilation errors.


            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            int? i2 = null;
            //i? = null; unreal

        }
    }
}
