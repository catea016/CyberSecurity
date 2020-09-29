using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Collections;
using System.Windows.Forms;
using SecurityBenchmarkingTool;
using System.Net.NetworkInformation;

namespace SecurityBenchmarkingTool
{
    class MyScanner
    {
        public static string min_pass_age_result = "";
        public static string max_pass_age_result = "";
        public static string pass_his_size_result = "";
        public static string min_pass_len_result = "";
        public static string pass_complexity_result = "";
        public static string lockout_bad_count_result = "";
        public static string logon_to_change_pass_result = "";
        public static string enable_guest_account_result = "";
        
        private static int x;

        internal static string[] Read(string path)
        {
            string line;
            string deviceName = String.Empty;
           
            // Read the file and display it line by line.
            StreamReader file = new System.IO.StreamReader(path);
            {
                while ((line = file.ReadLine()) != null)
                {
                    


                    if (line.StartsWith("MinimumPasswordAge"))
                    {
                            string[] fullName = line.Split('=');
                            deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x >= 1)
                        {
                             min_pass_age_result = "p";
                        }
                        else
                        {
                            min_pass_age_result = "f";
                        }
                    } 
                    if (line.StartsWith("MaximumPasswordAge"))
                    {
                         string[] fullName = line.Split('=');
                         deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x >= 1 && x <= 60)
                         {
                             max_pass_age_result = "p";
                         }
                         else
                         {

                            max_pass_age_result = "f";
                         }
                    }
                    if (line.StartsWith("PasswordHistorySize"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x >= 24)
                        {
                            pass_his_size_result = "p";
                        }
                        else
                        {
                            pass_his_size_result = "f";
                        }
                    }

                    if (line.StartsWith("MinimumPasswordLength"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x >= 14)
                        {
                            min_pass_len_result = "p";
                        }
                        else
                        {
                            min_pass_len_result = "f";
                        }
                    }

                    if (line.StartsWith("PasswordComplexity"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x == 1)
                        {
                            pass_complexity_result = "p";
                        }
                        else
                        {
                            pass_complexity_result = "f";
                        }
                    }

                    if (line.StartsWith("LockoutBadCount"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x >= 15)
                        {
                            lockout_bad_count_result = "p";
                        }
                        else
                        {
                            lockout_bad_count_result = "f";
                        }
                    }

                    if (line.StartsWith("RequireLogonToChangePassword"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x >= 5 && x <= 14)
                        {
                            logon_to_change_pass_result = "p";
                        }
                        else
                        {
                            logon_to_change_pass_result = "f";
                        }
                    }
                    if (line.StartsWith("EnableGuestAccount"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        //Console.WriteLine(x);
                        if (x == 0)
                        {
                            enable_guest_account_result = "p";
                        }
                        else
                        {
                            enable_guest_account_result = "f";
                        }
                    }

                }
            }
           
            string[] result = new string[10];
            
            result[0] = min_pass_age_result;
            result[1] = max_pass_age_result;
            result[2] = pass_his_size_result;
            result[3] = min_pass_len_result;
            result[4] = pass_complexity_result;
            result[5] = lockout_bad_count_result;
            result[6] = logon_to_change_pass_result;
            result[7] = enable_guest_account_result;
            return result;

        }
        public string MinPassAge { get; } = min_pass_age_result;

        public string MaxPassAge { get; } = max_pass_age_result;

        public string PassHisSize { get; } = pass_his_size_result;


    }
}
