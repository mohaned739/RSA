using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RSA_Project
{
    class Program
    {

        static void Main(string[] args)
        {

            FileStream file = new FileStream("C:\\Users\\Dell\\Desktop\\RSA_Project\\RSA_Project\\bin\\Debug\\SampleRSA.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            FileStream file2 = new FileStream("C:\\Users\\Dell\\Desktop\\RSA_Project\\RSA_Project\\bin\\Debug\\SampleRSAOutput.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file2);
            Big_int n, e, msg;
            int fun;
            string line1 = "";
            string line2 = "";
            string line3 = "";
            string line4 = "";
            int filelen = int.Parse(sr.ReadLine());

            for (int j = 0; j < filelen; j++)
            {
                int caseNo = j + 1;
                line1 = sr.ReadLine();
                line2 = sr.ReadLine();
                line3 = sr.ReadLine();
                line4 = sr.ReadLine();
                n = new Big_int(line1);
                e = new Big_int(line2);
                msg = new Big_int(line3);
                fun = int.Parse(line4);
                if (fun == 0)
                {
                    float start_time = System.Environment.TickCount;
                    Big_int res = Big_int.encr(n, e, msg);
                    float end_time = System.Environment.TickCount;
                    float sec = (end_time - start_time) / 1000;
                    Console.WriteLine("Case " + caseNo + " : ");
                    Console.WriteLine("Seconds : " + sec + "sec");
                    float ms = (end_time - start_time);
                    Console.WriteLine("Milliseconds : " + ms + " ms");
                    foreach (int i in res.arr)
                    {
                        sw.Write(i);
                    }
                    sw.WriteLine();
                }
                else
                {
                    float start_time = System.Environment.TickCount;
                    Big_int res = Big_int.dec(n, e, msg);
                    float end_time = System.Environment.TickCount;
                    float sec = (end_time - start_time) / 1000;
                    Console.WriteLine("Case " + caseNo + " : ");
                    Console.WriteLine("Seconds : " + sec + "sec");
                    float ms = (end_time - start_time);
                    Console.WriteLine("Milliseconds : " + ms + " ms");
                    foreach (int i in res.arr)
                    {
                        sw.Write(i);
                    }
                    sw.WriteLine();
                }



            }
                sw.Close();
                sr.Close();



                Console.WriteLine("########################### COMPLETE TEST CASES ############################");

                file = new FileStream("C:\\Users\\Dell\\Desktop\\RSA_Project\\RSA_Project\\bin\\Debug\\TestRSA.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                file2 = new FileStream("C:\\Users\\Dell\\Desktop\\RSA_Project\\RSA_Project\\bin\\Debug\\TestRSAOutput.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(file2);

               filelen = int.Parse(sr.ReadLine());

                for (int j = 0; j < filelen; j++)
                {
                    int caseNo = j + 1;
                    line1 = sr.ReadLine();
                    line2 = sr.ReadLine();
                    line3 = sr.ReadLine();
                    line4 = sr.ReadLine();
                    n = new Big_int(line1);
                    e = new Big_int(line2);
                    msg = new Big_int(line3);
                    fun = int.Parse(line4);
                    if (fun == 0)
                    {
                        float start_time = System.Environment.TickCount;
                        Big_int res = Big_int.encr(n, e, msg);
                        float end_time = System.Environment.TickCount;
                        float sec = (end_time - start_time) / 1000;
                        Console.WriteLine("Case " + caseNo + " : ");
                        Console.WriteLine("Seconds : " + sec + "sec");
                        float ms = (end_time - start_time);
                        Console.WriteLine("Milliseconds : " + ms + " ms");
                        foreach (int i in res.arr)
                        {
                            sw.Write(i);
                        }
                        sw.WriteLine();
                    }
                    else
                    {
                        float start_time = System.Environment.TickCount;
                        Big_int res = Big_int.dec(n, e, msg);
                        float end_time = System.Environment.TickCount;
                        float sec = (end_time - start_time) / 1000;
                        Console.WriteLine("Case " + caseNo + " : ");
                        Console.WriteLine("Seconds : " + sec + "sec");
                        float ms = (end_time - start_time);
                        Console.WriteLine("Milliseconds : " + ms + " ms");
                        foreach (int i in res.arr)
                        {
                            sw.Write(i);
                        }
                        sw.WriteLine();
                    }



                }
                sw.Close();
                sr.Close();
        }
    }
}