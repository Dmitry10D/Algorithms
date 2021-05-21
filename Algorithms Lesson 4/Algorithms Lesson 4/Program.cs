using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_Lesson_4
{
    //public class HashSet_or_Array
    //{
        
    //    public HashSet<string> hashSet;

    //    public override bool Equals(object obj)
    //    {
    //        var user = obj as HashSet_or_Array;
    //        if (user == null) return false;

    //        return hashSet == user.hashSet;
    //    }

    //    public override int GetHashCode()
    //    {
    //        int secondNameHashCode = hashSet?.GetHashCode() ?? 0;
    //        return secondNameHashCode;
    //    }
    //}
    class Program
    {
        

        public class Test
        {
            HashSet<string> hashSet;
        }
        static void Main(string[] args)
        {
            string[] array = ArrayBuilder();

            var hashSet = new HashSet<string>();
            for (var i = 0; i < array.Length; i++)
            {
                hashSet.Add(array[i]);
            }
            
            
            Console.ReadLine();
            
        }

        public bool Comparer ()
        {
            return 
        }
        public static string[] ArrayBuilder ()
        {
            string[] array = new string[10000];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = GenerateRandomAlphanumericString();
            }

            return array;
        }
        public static string GenerateRandomAlphanumericString()
        {
            int length = 10;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
    }
}
