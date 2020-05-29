using System;

namespace MyLibrary
{
    public class lib1
    {
        static public string stpow(string a, int b)
        {
            string a1 = a;
            for (int i = 0; i < b - 1; i++)
            {
                a = a + a1;
            }
            return (a);
        }
        static public string rev(string a)
        {
            string v = "";
            for (int i = a.Length - 1; i > -1; i--) 
            {
                v = v + a[i] + "";
            }
            return (v);
        }
        static public string remov(string ds, string s)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                ds = ds.Replace(s, "");
            }
            return (ds);
        }
        static public int leng(string ds)
        {
            int a = ds.Length;
            return (a);
        }
    }
}

