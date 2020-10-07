using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;
using SecurityBenchmarkingTool;


namespace SecurityBenchmarkingTool
{
    class PolicySettings
    {
        private static int x;
        internal static void changeSettings(string path)
        {
            string deviceName = String.Empty;
            List<string> list = new List<string>();
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {

                    list.Add(line);
                }
            }
             for(int m = 0; m < list.Count; m++)
             {
                if (list[m].StartsWith("MaximumPasswordAge"))
                {
                    list[m] = list[m].Replace("-1", "6");
                    //Console.WriteLine(list[m]);
                }
                if (list[m].StartsWith("PasswordHistorySize"))
                {
                    list[m] = list[m].Replace("0", "25");
                }
                if (list[m].StartsWith("MinimumPasswordLength"))
                {
                    list[m] = list[m].Replace("1", "15");
                }
                if (list[m].StartsWith("PasswordComplexity"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("RequireLogonToChangePassword"))
                {
                    list[m] = list[m].Replace("0", "10");
                }
                if (list[m].StartsWith("LockoutBadCount"))
                {
                    list[m] = list[m].Replace("0", "16");
                }
                if (list[m].StartsWith("EnableAdminAccount"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("ForceLogoffWhenHourExpire"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditSystemEvents"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditLogonEvents"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditObjectAccess"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditPolicyChange"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditAccountLogon"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditPrivilegeUse"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditAccountManage"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("AuditProcessTracking"))
                {
                    list[m] = list[m].Replace("0", "1");
                }
                if (list[m].StartsWith("LSAAnonymousNameLookup"))
                {
                    list[m] = list[m].Replace("0", "1");
                }

            }
            using (TextWriter tw = new StreamWriter(@"D:\\University\\Sem V\\CyberSecurity\\extracted_pol2.inf"))
            {
                foreach (String line in list)
                    tw.WriteLine(line);
                //Console.WriteLine("file was created");
            }

        }

    }
}
