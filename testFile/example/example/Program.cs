using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            //func();
            //handleStr("adsddfsfgdgdg","a");
            //pop();
            //handleList();
            //replaceSpace("we are student");
            //getC("Have you ever gone shopping and");
            //getTimes("Have you ever gone shopping and",'e');
            //duplicate();
            revert();

        }

        public static void func()
        {
            Console.WriteLine("helloWorld！");
            Console.ReadKey();
        }

        public static void handleStr(string s, string c)
        {
            string str = s.Replace(c, "");
            Console.WriteLine(str);
            Console.ReadKey();
        }

        //冒泡
        public static void pop()
        {
            int[] array = new int[] { 7, 6, 4, 9, 12, 5, 3 };
            int temp = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[j] < array[i])
                    {

                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;

                    }

                }

            }

            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + "  ");
            }

            Console.ReadKey();
        }

        //List
        public static void handleList()
        {

            String[] a = { "asdsfdgfdg", "eweeewr", "fwerwrwe" };
            List<string> list = new List<string>(a);
            String[] b = { "one", "twe", "three" };
            List<string> list1 = new List<string>(b);
            list.AddRange(list1);
            list.Add("four");
            list.Remove("one");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            //string s = "abcdef";
            //char[] c = s.ToCharArray();
            //Array.Reverse(c);
            //Console.WriteLine(c);
            //Console.ReadKey();
        }

        public static void replaceSpace(string str)
        {
            //string s1 = "we are student";
            //string s2 = "we%20are%20student";
            string s = str.Replace(" ", "20%");
            Console.WriteLine(s);
            Console.ReadKey();

        }

        //给定一个英文字符串,请写一段代码找出这个字符串中首先出现三次的那个英文字符(需要区分大小写)。
        public static void getC(string str)
        {
            char[] c1 = str.ToCharArray();
            char[] c = new char[52];
            for (int n = 0; n < c.Length; n++)
            {
                c[n] = (char)('a' + n);
                if (c[n] == 'z')
                {
                    for (int m = n + 1; m < c.Length; m++)
                    {
                        c[m] = (char)('A' + m - n - 1);
                        if (c[m] == 'Z')
                        {
                            for (int j = 0; j < c1.Length; j++)
                            {
                                if (c.Contains(c1[j]))
                                {
                                    int count = str.Length - c1.ToString().Replace(c1[j].ToString(), "").Length;
                                    if (count == 3)
                                    {
                                        Console.WriteLine(c1[j]);
                                        Console.ReadKey();
                                        break;
                                    }
                                }

                                //c[c1[j]]++;
                            }
                        }
                    }
                }
            }
        }

        //统计某个字符在字符串中出现的次数
        public static void getTimes(string str, char c)
        {
            //adnndnfdndf  d
            char[] newChar = str.ToCharArray();
            int num = 0;
            for (int i = 0; i < newChar.Length; i++)
            {
                if (newChar[i] == c)
                {
                    num++;
                }
            }

            Console.WriteLine(num);
            Console.ReadKey();
        }
  
        //字符串翻转
        //abcdef  fedcba
        public static void revert()
        {
            string s = "abcdef";
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            string s1 = new string(c);
            Console.WriteLine(s1);
            Console.ReadKey();

        }

        public static void duplicate()
        {
            int[] arr = { 1, 2, 4, 4, 3, 3, 1, 5, 3 };
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        list.Add(arr[i]);
                        break;
                    }
                }
            }

            //HashSet<int> hs = new HashSet<int>(list);
            //int[] a = hs.ToArray();
            list.Sort();   //排序
            int[] a1 = list.ToArray();
            HashSet<int> hs1 = new HashSet<int>(a1);  //去重
            int[] a2 = hs1.ToArray();
            foreach (int n in a2)   //遍历
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
        
    }


}

