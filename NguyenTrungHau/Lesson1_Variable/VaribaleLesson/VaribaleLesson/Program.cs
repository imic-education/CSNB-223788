using System;

namespace VaribaleLesson
{
    class Program
    {
        





        static void Main(string[] args)
        {
            bool isValue = true;
            sbyte sValue = SByte.MaxValue;

            sbyte value_1 = 2;
            sbyte value_2 = 127;
            sbyte value_3 =(sbyte)(value_1 + value_2);


            byte byteValue = Byte.MaxValue;
            short shValue = short.MaxValue;
            ushort ushValue = ushort.MaxValue;
            int iValue = int.MaxValue;
            long longValue = long.MaxValue;
            ulong ulongValue = ulong.MaxValue;
            char cValue = '1';
            float fValue = float.MaxValue;
            double dValue = double.MaxValue;
            decimal deValue = decimal.MaxValue;
            object oValue = "Object";
            string strValue = "String " + oValue;
            DateTime dtValue = DateTime.Now;
            DateTime dtValue_1 = new DateTime(2020, 02, 11, 10, 11, 11, 999);

            Console.WriteLine("Bool: " + isValue);
            Console.WriteLine("sbyte: " + sValue);
            Console.WriteLine("byte: " + byteValue);
            Console.WriteLine("short: " + shValue);
            Console.WriteLine("ushort: " + ushValue);
            Console.WriteLine("int: " + iValue);
            Console.WriteLine("long: " + longValue);
            Console.WriteLine("ulong: " + ulongValue);
            Console.WriteLine("char: " + cValue);
            Console.WriteLine("float: " + fValue);
            Console.WriteLine("double: " + dValue);
            Console.WriteLine("decimal: " + deValue);
            Console.WriteLine("object: " + oValue);
            Console.WriteLine("string: " + strValue);
            Console.WriteLine("DateTime: " + dtValue);
            // Console.WriteLine("DateTime: " + dtValue_1.ToString("dd/MM/yyyy HH/mm/ss ffff"));
            Console.WriteLine("DateTime: " + dtValue_1.ToString());
            Console.WriteLine(value_3);
            Console.ReadLine();


        }

    }
}
