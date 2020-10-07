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
        public static string reset_lockout_count_result = "";
        public static string force_logoff_result = "";
        public static string admin_account_result = "";
        public static string audit_system_events_result = "";
        public static string audit_logon_events_result = "";
        public static string audit_object_access_result = "";
        public static string audit_policy_change_result = "";
        public static string audit_account_logon_result = "";
        public static string audit_privilege_use_result = "";
        public static string audit_account_manage_result = "";
        public static string audit_process_track_result = "";
        public static string lockout_duration_result = "";
        public static string name_lookup_result = "";

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
                        
                        if (x == 0)
                        {
                            enable_guest_account_result = "p";
                        }
                        else
                        {
                            enable_guest_account_result = "f";
                        }
                    }
                    if (line.StartsWith("ResetLockoutCount"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        
                        if (x >= 15)
                        {
                            reset_lockout_count_result = "p";
                        }
                        else
                        {
                            reset_lockout_count_result = "f";
                        }
                    }
                    if (line.StartsWith("ForceLogoffWhenHourExpire"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }
                        
                        if (x == 1)
                        {
                            force_logoff_result = "p";
                        }
                        else
                        {
                            force_logoff_result = "f";
                        }
                    }
                    if (line.StartsWith("EnableAdminAccount"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            force_logoff_result = "p";
                        }
                        else
                        {
                            force_logoff_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditSystemEvents"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_system_events_result = "p";
                        }
                        else
                        {
                            audit_system_events_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditLogonEvents"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_logon_events_result = "p";
                        }
                        else
                        {
                            audit_logon_events_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditObjectAccess"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_object_access_result = "p";
                        }
                        else
                        {
                            audit_object_access_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditPolicyChange"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_policy_change_result = "p";
                        }
                        else
                        {
                            audit_policy_change_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditAccountLogon"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_account_logon_result = "p";
                        }
                        else
                        {
                            audit_account_logon_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditPrivilegeUse"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_privilege_use_result = "p";
                        }
                        else
                        {
                            audit_privilege_use_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditAccountManage"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_account_manage_result = "p";
                        }
                        else
                        {
                            audit_account_manage_result = "f";
                        }
                    }
                    if (line.StartsWith("AuditProcessTracking"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            audit_process_track_result = "p";
                        }
                        else
                        {
                            audit_process_track_result = "f";
                        }
                    }
                    if (line.StartsWith("LockoutDuration"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x >= 15)
                        {
                            lockout_duration_result = "p";
                        }
                        else
                        {
                            lockout_duration_result = "f";
                        }
                    }
                    if (line.StartsWith("LSAAnonymousNameLookup"))
                    {
                        string[] fullName = line.Split('=');
                        deviceName = fullName[1];
                        if (int.TryParse(deviceName, out int x)) { }

                        if (x == 1)
                        {
                            name_lookup_result = "p";
                        }
                        else
                        {
                            name_lookup_result = "f";
                        }
                    }

                }
            }
           
            string[] result = new string[21];
            
            result[0] = min_pass_age_result;
            result[1] = max_pass_age_result;
            result[2] = pass_his_size_result;
            result[3] = min_pass_len_result;
            result[4] = pass_complexity_result;
            result[5] = lockout_bad_count_result;
            result[6] = logon_to_change_pass_result;
            result[7] = enable_guest_account_result;
            result[8] = reset_lockout_count_result;
            result[9] = force_logoff_result;
            result[10] = admin_account_result;
            result[11] = audit_system_events_result;
            result[12] = audit_logon_events_result;
            result[13] = audit_object_access_result;
            result[14] = audit_policy_change_result;
            result[15] = audit_account_logon_result;
            result[16] = audit_privilege_use_result;
            result[17] = audit_account_manage_result;
            result[18] = audit_process_track_result;
            result[19] = lockout_duration_result;
            result[20] = name_lookup_result;

            return result;

        }
       
    }
}
