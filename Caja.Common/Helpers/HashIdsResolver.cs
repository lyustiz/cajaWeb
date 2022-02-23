using System.Linq;
using HashidsNet;

namespace System
{
    public static class HashIdsResolver
    {
        private static readonly Hashids mHashids = new Hashids("This is 42345 a super SALT0515981", 5);

        public static string Encode(params int[] numbers) => mHashids.Encode(numbers);
        public static string Encode(params long[] numbers) => mHashids.EncodeLong(numbers);

        public static string Encode(int? number) => number.HasValue ? Encode(number.Value) : "";
        public static string Encode(long? number) => number.HasValue ? Encode(number.Value) : "";

        public static string EncodeNullable(int? number) => number == null ? "" : mHashids.Encode(number.Value);


        public static int[] Decode(string hash) => mHashids.Decode(hash);


        public static long[] DecodeLong(string hash) => mHashids.DecodeLong(hash);


        public static int DecodeOne(string hash) => mHashids.Decode(hash)[0];

        //public static int? DecodeOne(string hash) => hash == null ? null : mHashids.Decode(hash)[0];

        public static int? DecodeOneNullable(string hash) => hash.IsNullOrEmpty() ? null : (int?)mHashids.Decode(hash)[0];


        public static long DecodeOneLong(string hash) => mHashids.DecodeLong(hash)[0];

        public static string Encode(string[] numbers)
        {
            int[] arrNumber = numbers.Select(int.Parse).ToArray();
            for (int i = 0; i < arrNumber.Length; i++)
            {
                numbers[i] = Encode(arrNumber[i]);
            }
            return string.Join(",", numbers);
        }

        public static int[] Decode(string[] numbers)
        {
            int[] arrNumber = new int[numbers.Length]; //numbers.Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                arrNumber[i] = DecodeOne(numbers[i]);
            }
            return arrNumber;
        }

    }
}