using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;

public class Logging
    {

        private static int LOG_IND = 1;

        public static string LogFile_path = Application.StartupPath+"~\\LOG\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
        private static bool enableUserIdLogging = true;

        public enum Action
        {
            ADD = 1, UPDATE = 2, DELETE = 3, CHANGEPW = 4, EMAIL = 5, CREATEGROUP = 6, MEMBERADD = 7
        }
        public enum Success
        {
            Success = 1, UnSuccess = 2
        }



        public static void writeSpecLog(string ps_text, string ps_path)
        {
            if (LOG_IND == 1)//add by Max on 12-May-2013
            {

                if (!System.IO.Directory.Exists(ps_path.Substring(0, ps_path.LastIndexOf("\\"))))
                {
                    System.IO.Directory.CreateDirectory(ps_path.Substring(0, ps_path.LastIndexOf("\\")));
                }

                System.IO.StreamWriter file = new System.IO.StreamWriter(ps_path, true, System.Text.Encoding.UTF8);
                file.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]" + ps_text);
               
                file.Close();
                file.Dispose(); file = null;
            }
        }
        public static void writeLog(string ps_text)
        {
            writeSpecLog(ps_text, LogFile_path);
        }
        public static void writeLog(Exception ex)
        {
            writeSpecLog(ex.Message, LogFile_path);
            writeSpecLog(ex.StackTrace, LogFile_path);
        }

     
        //public static void writeProgramLog(string ps_staffID, string ps_name, string ps_loginID, string ps_email, Action ps_action, Success ps_success, string ps_remark)
        //{

        //    string ls_successMsg = ps_success.ToString() + ((ps_remark != "") ? "(" + ps_remark + ")" : "");
        //    string ls_logMsg = "{0},{1},{2},{3},{4},{5}";
        //    ls_logMsg = string.Format(ls_logMsg, ps_staffID, ps_name, ps_loginID, ps_email, ps_action.ToString(), ls_successMsg);
        //    writeLog(ls_logMsg);

        //}    
    }
 