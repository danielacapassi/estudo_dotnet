using System;

namespace tiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Inteiros
            int signedInteger;// -2.147.483.648 a 2.147.483.647
            uint unsignedInteger; // 0 a 4.294.967.295
            byte unsignedByte;  //	0 a 255
            sbyte signedByte; //-128 a 127
            short signedShort; //-32,768 to 32,767
            long signedLong; // -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            ulong unsignedLong; // 0 a 18.446.744.073.709.551.615

            //Atribuições
            signedInteger = -2147483647;
            unsignedInteger = 4999222;
            unsignedByte = 255;
            signedShort= -32768;
            signedLong =  9223372;
            unsignedLong = 18446744073;

            //Pontos flutuantes
            float signedFloat; //~6 a 9 dígitos
            double signedDouble; //~15 a 17 dígitos
            decimal signedDecimal; //28 a 29 dígitos

            //Atribuições
            signedFloat = 13.000f; //3_000.5F;
            signedDouble = 13.000; // 4d;  3.934_001;
            signedDecimal = 400.75M; //3_000.5m;


            //Booleano

            bool boolean1; 
            bool boolean2;

            //Atribuições
            boolean1=true; 
            boolean2=false;
        }
    }
}
