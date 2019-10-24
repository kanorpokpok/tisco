using System;
using System.Collections.Generic;
using System.Linq;

namespace Tisco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<============ 1. =============>");
            string read = "I read book";
            string reverse = string.Join(' ', read.Split(' ').Select((value, i) => new { i, value }).OrderByDescending(e => e.i).Select(e => e.value).ToList());
            Console.WriteLine($"Originals: {read}");
            Console.WriteLine($"New: {reverse}");
            Console.WriteLine("<============ End 1. =============>\n");

            Console.WriteLine("<============ 2. =============>");
            List<string> st1 = new List<string> { "a", "a", "a", "a", "a" };
            List<string> st2 = new List<string> { "b", "b", "b", "b", "b", "b" };

            var cs = st1.Zip(st2, (a, b) => a + b).ToList();
            Console.WriteLine($"List 1: {string.Join(',', st1)}");
            Console.WriteLine($"List 2: {string.Join(',',st2)}");
            Console.WriteLine(string.Join(string.Empty, cs));
            Console.WriteLine("<============ End 2. =============>\n");

            Console.WriteLine("<============ 3. =============>");
            int leg = 18; // bird=2,dog=4
            int head = 7;

            int count_bird_head = (leg / 2); // หาหัวทั้งหมดถ้าเป็นนก
            int dog = count_bird_head - head; // ถ้าไม่ตรงแสดงว่ามีหมาที่เป็นเศาทางลบ

            int cut_out_leg_dog = leg - (dog * 4); // ขาทั้งหมดลบขาของหมา
            int bird = cut_out_leg_dog / 2; //ขาที่เหลือคือขานก

            //int bird = count_bird_head - (dog*4);
            Console.WriteLine($"Dog: {dog}, Bird: {bird}");
            Console.WriteLine("<============ End 3. =============>\n");

            Console.WriteLine("<============ 4. =============>");
            string[] num = { "+1", "-1", "+3", "5" };
            int total = num.Sum(e => int.Parse(e));

            Console.WriteLine($"{total}");
            Console.WriteLine("<============ End 4. =============>\n");
            Console.ReadLine();
        }
    }
}
