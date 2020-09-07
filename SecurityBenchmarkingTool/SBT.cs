using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

using System.Xml;
using System.Xml.Linq;

namespace SecurityBenchmarkingTool
{
    public partial class SBT : Form
    {
        public SBT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            this.openFileDialog1.Filter = "audit files (*.audit)|*.audit";

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
                listBox1.Items.Add(file);
               // Console.WriteLine(size); // <-- Shows file size in debugging mode.
                //Console.WriteLine(result);
                //Console.WriteLine(file);


            }
                       
        }

        private void BrowseMultipleButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            
            this.openFileDialog1.Filter = "audit files (*.audit)|*.audit";
            this.openFileDialog1.Multiselect = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();
            
            if (dr == DialogResult.OK)
            {
                listBox1.Text = openFileDialog1.FileName;
                Application.DoEvents();

                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        if ((myStream = this.openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                listBox1.Items.Add(file);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: could not read file from disk. Original error: " + ex.Message);
                    }
                }
                //foreach (String file in openFileDialog1.FileNames)
                //{
                  //MessageBox.Show(file);
                //}
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.GetDirectoryName((string)listBox1.SelectedItem);
            string fileName = System.IO.Path.GetFileName((string)listBox1.SelectedItem);

            //string[] lines;
            var list = new List<string>();
            var fileStream = new FileStream(filePath+"\\"+fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null )
                {
                    
                    list.Add(line);
                }
            }
            //lines = list.ToArray();
           // Console.WriteLine(list[50]);
            for(int m=0; m<list.Count; m++)
            {
                /*if (list[m].StartsWith("<check_type"))
                {
                    list[m] = list[m].Replace("<check_type", "<check_type type");
                    break;
                }
                if (list[m].StartsWith("<group_policy"))
                {
                    list[m] = list[m].Replace("<group_policy", "<group_policy group");
                } */
                if (list[m].Contains("<blank>"))
                {
                    list[m] = list[m].Replace("<blank>", "blank");

                    //Console.WriteLine(list[m]);
                }
                if (list[m].Contains("<none>"))
                {
                    list[m] = list[m].Replace("<none>", "none");

                    //Console.WriteLine(list[m]);
                }

                if (list[m].StartsWith("#"))
                {
                    list[m] = list[m].Remove(0, list[m].Length);
                    //Console.WriteLine(list[m]);
                }
                if (list[m].Contains("&"))
                {
                    list[m] = list[m].Replace("&", "AND");

                    //Console.WriteLine(list[m]);
                }
                
                else if (list[m].Contains(":"))
                {
                    list[m] = list[m].Replace(":", "=");
                    //Console.WriteLine(list[m]);
                }
                
                if (list[m].Contains(" type   ")) 
                {
                    list[m] = list[m].Replace("type", "<type>");
                    list[m] = list[m].Insert(list[m].Length , "</type>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                }
                 else if (list[m].Contains("description"))
                {
                    list[m] = list[m].Replace("description", "<description>");
                    list[m] = list[m].Insert(list[m].Length, "</description>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace( '"', ' ') ; 
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("value_type"))
                {
                    list[m] = list[m].Replace("value_type", "<value_type>");
                    list[m] = list[m].Insert(list[m].Length, "</value_type>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("value_data"))
                {
                    list[m] = list[m].Replace("value_data", "<value_data>");
                    list[m] = list[m].Insert(list[m].Length, "</value_data>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    list[m] = list[m].Replace('&', ' ');
                    // Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("reg_key"))
                {
                    list[m] = list[m].Replace("reg_key", "<reg_key>");
                    list[m] = list[m].Insert(list[m].Length, "</reg_key>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                   // Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("reg_item"))
                {
                    list[m] = list[m].Replace("reg_item", "<reg_item>");
                    list[m] = list[m].Insert(list[m].Length, "</reg_item>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("check_type  "))
                {
                    list[m] = list[m].Replace("check_type", "<check_type>");
                    list[m] = list[m].Insert(list[m].Length, "</check_type>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                }
                else if(list[m].Contains("info    "))
                {
                    list[m] = list[m].Replace("info   ", "<info>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                    while (!list[m].Contains("solution  ") && !list[m].Contains("see_also  "))
                    {  
                        m++;
                        if (list[m].Contains("<driveletter>"))
                        {
                            list[m] = list[m].Replace("<driveletter>", "driveletter");

                            //Console.WriteLine(list[m]);
                        }
                        if (list[m].Contains("<blank>"))
                        {
                            list[m] = list[m].Replace("<blank>", "blank");

                            //Console.WriteLine(list[m]);
                        }
                        if (list[m].Contains("&"))
                        {
                            list[m] = list[m].Replace("&", "AND");

                            //Console.WriteLine(list[m]);
                        }
                    }
                    m = m -1 ;
                    list[m] = list[m].Insert(list[m].Length , "</info>");                   
                    // Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("solution  "))
                {
                    list[m] = list[m].Replace("solution", "<solution>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                    while (!list[m].Contains("reference  "))
                    {

                        m++;
                        if (list[m].Contains("&"))
                        {
                            list[m] = list[m].Replace("&", "AND");

                            //Console.WriteLine(list[m]);
                        }

                    }
                    m = m - 1;
                    list[m] = list[m].Insert(list[m].Length, "</solution>");
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("password_policy"))
                {
                    list[m] = list[m].Replace("password_policy", "<password_policy>");
                    list[m] = list[m].Insert(list[m].Length, "</password_policy>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("right_type"))
                {
                    list[m] = list[m].Replace("right_type", "<right_type>");
                    list[m] = list[m].Insert(list[m].Length, "</right_type>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("account_type"))
                {
                    list[m] = list[m].Replace("account_type", "<account_type>");
                    list[m] = list[m].Insert(list[m].Length, "</account_type>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("reg_option"))
                {
                    list[m] = list[m].Replace("reg_option", "<reg_option>");
                    list[m] = list[m].Insert(list[m].Length, "</reg_option>");
                    list[m] = list[m].Replace("=", "");
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("audit_policy_subcategory"))
                {
                    list[m] = list[m].Replace("audit_policy_subcategory", "<audit_policy_subcategory>");
                    list[m] = list[m].Insert(list[m].Length, "</audit_policy_subcategory>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("reg_ignore_hku_users"))
                {
                    list[m] = list[m].Replace("reg_ignore_hku_users", "<reg_ignore_hku_users>");
                    list[m] = list[m].Insert(list[m].Length, "</reg_ignore_hku_users>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("reference"))
                {
                    list[m] = list[m].Replace("reference", "<reference>");
                    list[m] = list[m].Insert(list[m].Length, "</reference>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("see_also"))
                {
                    list[m] = list[m].Replace("see_also", "<see_also>");
                    list[m] = list[m].Insert(list[m].Length, "</see_also>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("lockout_policy"))
                {
                    list[m] = list[m].Replace("lockout_policy", "<lockout_policy>");
                    list[m] = list[m].Insert(list[m].Length, "</lockout_policy>");
                    list[m] = list[m].Replace("=", "");
                    //list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("powershell_args"))
                {
                    list[m] = list[m].Replace("powershell_args", "<powershell_args>");
                    list[m] = list[m].Insert(list[m].Length, "</powershell_args>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                else if (list[m].Contains("key_item"))
                {
                    list[m] = list[m].Replace("key_item", "<key_item>");
                    list[m] = list[m].Insert(list[m].Length, "</key_item>");
                    list[m] = list[m].Replace("=", "");
                    list[m] = list[m].Replace('"', ' ');
                    //Console.WriteLine(list[m]);
                }
                

            }
            /*foreach(string line in list)
            {
                Console.WriteLine(line);
            }*/
            using (TextWriter tw = new StreamWriter(@"C:\Users\User\Desktop\XML.xml"))
            {
                foreach (String line in list)
                    tw.WriteLine(line);
                //Console.WriteLine("file was created");
            }
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\XML.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("custom_item");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                
            }
            MessageBox.Show("File parsing completed successfully");


        }
        public string conString = "Data Source=WIN-AGBLDGI4OBP;Initial Catalog=SecurityBenchmarkingTool;Integrated Security=True";

        private void SaveButton_Click(object sender, EventArgs e)
        {
           using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                foreach (string item in listBox1.Items)
                {
                    string fileName = System.IO.Path.GetFileName(item);
                    // string filePath = System.IO.Path.GetDirectoryName(item);

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Audit_Files (Audit_File_Name) VALUES (@fileName)", connection))
                    {
                        cmd.Parameters.AddWithValue("@fileName", fileName);
                        // cmd.Parameters.AddWithValue("@filePath", filePath);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            string type = "";
            string description = "";
            string value_type = "";
            string value_data = "";
            string reg_key = "";
            string reg_item = "";
            string check_type = "";
            string info = "";
            string solution = "";
            string password_policy = "";
            string right_type = "";
            string account_type = "";
            string reg_option = "";
            string audit_policy_subcategory = "";
            string reg_ignore_hku_users = "";
            string reference = "";
            string see_also = "";
            string lockout_policy = "";
            string powershell_args = "";
            string key_item = "";


            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=WIN-AGBLDGI4OBP;Initial Catalog=SecurityBenchmarkingTool;Integrated Security=True";
                conn.Open();
                using (XmlTextReader reader = new XmlTextReader(@"C:\Users\User\Desktop\XML.xml"))
                {
                    while (reader.Read())
                    {
                        SqlCommand insertCommand = new SqlCommand("InsertProcedure", conn);
                        if (reader.IsStartElement("custom_item"))
                        {
                            type = "";
                            description = "";
                            value_type = "";
                            value_data = "";
                            reg_key = "";
                            reg_item = "";
                            check_type = "";
                            info = "";
                            solution = "";
                            password_policy = "";
                            right_type = "";
                            account_type = "";
                            reg_option = "";
                            audit_policy_subcategory = "";
                            reg_ignore_hku_users = "";
                            reference = "";
                            see_also = "";
                            lockout_policy = "";
                            powershell_args = "";
                            key_item = "";

                            while(reader.Read() && reader.IsStartElement())
                            {
                                switch (reader.Name)
                                {
                                    case "type":
                                        type = reader.ReadString();
                                        break;
                                    case "description":
                                        description = reader.ReadString();
                                        break;
                                    case "value_type":
                                        value_type = reader.ReadString();
                                        break;
                                    case "value_data":
                                        value_data = reader.ReadString();
                                        break;
                                    case "reg_key":
                                        reg_key = reader.ReadString();
                                        break;
                                    case "reg_item":
                                        reg_item = reader.ReadString();
                                        break;
                                    case "check_type":
                                        check_type = reader.ReadString();
                                        break;
                                    case "info":
                                        info = reader.ReadString();
                                        break;
                                    case "solution":
                                        solution = reader.ReadString();
                                        break;
                                    case "password_policy":
                                        password_policy = reader.ReadString();
                                        break;
                                    case "right_type":
                                        right_type = reader.ReadString();
                                        break;
                                    case "account_type":
                                        account_type = reader.ReadString();
                                        break;
                                    case "reg_option":
                                        reg_option = reader.ReadString();
                                        break;
                                    case "audit_policy_subcategory":
                                        audit_policy_subcategory = reader.ReadString();
                                        break;
                                    case "reg_ignore_hku_users":
                                        reg_ignore_hku_users = reader.ReadString();
                                        break;
                                    case "reference":
                                        reference = reader.ReadString();
                                        break;
                                    case "see_also":
                                        see_also = reader.ReadString();
                                        break;
                                    case "lockout_policy":
                                        lockout_policy = reader.ReadString();
                                        break;
                                    case "powershell_args":
                                        powershell_args = reader.ReadString();
                                        break;
                                    case "key_item":
                                        key_item = reader.ReadString();
                                        break;

                                    default :
                                        throw new InvalidExpressionException("Unexpected tag");


                                }
                                reader.ReadEndElement();
                            }
                        }
                        insertCommand.CommandType = CommandType.StoredProcedure;
                        insertCommand.Parameters.AddWithValue("type", type);
                        insertCommand.Parameters.AddWithValue("description", description);
                        insertCommand.Parameters.AddWithValue("value_type", value_type );
                        insertCommand.Parameters.AddWithValue("value_data", value_data );
                        insertCommand.Parameters.AddWithValue("reg_key",reg_key );
                        insertCommand.Parameters.AddWithValue("reg_item", reg_item );
                        insertCommand.Parameters.AddWithValue("check_type", check_type );
                        insertCommand.Parameters.AddWithValue("info", info );
                        insertCommand.Parameters.AddWithValue("solution", solution );
                        insertCommand.Parameters.AddWithValue("password_policy", password_policy );
                        insertCommand.Parameters.AddWithValue("right_type", right_type);
                        insertCommand.Parameters.AddWithValue("account_type", account_type );
                        insertCommand.Parameters.AddWithValue("reg_option", reg_option);
                        insertCommand.Parameters.AddWithValue("audit_policy_subcategory", audit_policy_subcategory );
                        insertCommand.Parameters.AddWithValue("reg_ignore_hku_users", reg_ignore_hku_users );
                        insertCommand.Parameters.AddWithValue("reference", reference );
                        insertCommand.Parameters.AddWithValue("see_also", see_also);
                        insertCommand.Parameters.AddWithValue("lockout_policy", lockout_policy);
                        insertCommand.Parameters.AddWithValue("powershell_args", powershell_args);
                        insertCommand.Parameters.AddWithValue("key_item", key_item );

                        if(!(type==" " && description==" " && value_type == " " && value_data == " " && reg_key == " " && reg_item == " "
                            && check_type == " " && info == " " && solution == " " && password_policy == " " && right_type == " "
                            && account_type == " " && reg_option == " " && audit_policy_subcategory == " " && reg_ignore_hku_users == " "
                            && reference == " " && see_also == " " && lockout_policy == " " && powershell_args == " " && key_item == ""))
                        {
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
              MessageBox.Show("Data was transfered to database successfully");
        }
    }
}
