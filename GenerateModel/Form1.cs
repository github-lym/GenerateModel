using IniFiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GenerateModel
{
    public partial class Form1 : Form
    {
        static string exePath = string.Empty;
        IniFile ini = new IniFile("settings.ini");

        public Form1()
        {
            InitializeComponent();
            exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CB_ConnectionStrings.Items.Add("無");
            CB_ConnectionStrings.SelectedItem = "無";
            //取得已有情境
            string ini_opt = ini.ReadString("Option", "Value");
            string[] opts = ini_opt.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (opts.Length > 0)
                foreach (var item in opts)
                    CB_ConnectionStrings.Items.Add(item);
            //string conn = iniManager.ReadIniFile("ConnectionStrings", "Value", string.Empty);
            //this.TBX_ConnectionStrings.Text = conn;
        }

        private void CB_ConnectionStrings_Change(object sender, EventArgs e)
        {
            string opt_string = CB_ConnectionStrings.Text;
            if (string.IsNullOrWhiteSpace(opt_string) || "無".Equals(opt_string))
                TBX_ConnectionString.Text = string.Empty;
            else
            {
                string conn = ini.ReadString(opt_string, "ConnectionString");
                if (!string.IsNullOrWhiteSpace(conn))
                    TBX_ConnectionString.Text = conn.Trim();
                else
                    TBX_ConnectionString.Text = string.Empty;
            }
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                string queryStr = string.Empty;
                if (this.TypeA.Checked)
                {
                    queryStr = this.TBX_Query.Text;

                    if (string.Empty.Equals(queryStr))
                    {
                        MessageBox.Show("連線字串或查詢字串為空");
                        return;
                    }

                    DataTable schemaTable = new DataTable();
                    try
                    {
                        using (SqlConnection sqlConn = new SqlConnection(TBX_ConnectionString.Text.Trim()))
                        {
                            using (SqlCommand cmd = sqlConn.CreateCommand())
                            {
                                cmd.CommandText = queryStr;
                                sqlConn.Open();
                                SqlDataReader sqlReader = cmd.ExecuteReader();
                                schemaTable = sqlReader.GetSchemaTable();
                                sqlConn.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"資料庫或查詢指令有問題:{ex}");
                        return;
                    }

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("public partial class YOURMODELNAME");
                    sb.AppendLine("{");
                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        sb.Append("  public ");
                        string type = schemaTable.Rows[i]["DataTypeName"].ToString();
                        switch (type)
                        {
                            case "bigint":
                                sb.Append("long");
                                break;
                            case "binary":
                                sb.Append("byte[]");
                                break;
                            case "bit":
                                sb.Append("bool");
                                break;
                            case "char":
                                sb.Append("string");
                                break;
                            case "date":
                                sb.Append("DateTime");
                                break;
                            case "datetime":
                                sb.Append("DateTime");
                                break;
                            case "datetime2":
                                sb.Append("DateTime");
                                break;
                            case "datetimeoffset":
                                sb.Append("DateTimeOffset");
                                break;
                            case "decimal":
                                sb.Append("decimal");
                                break;
                            case "float":
                                sb.Append("double");
                                break;
                            case "image":
                                sb.Append("byte[]");
                                break;
                            case "int":
                                sb.Append("int");
                                break;
                            case "money":
                                sb.Append("decimal");
                                break;
                            case "nchar":
                                sb.Append("string");
                                break;
                            case "ntext":
                                sb.Append("string");
                                break;
                            case "numeric":
                                sb.Append("decimal");
                                break;
                            case "nvarchar":
                                sb.Append("string");
                                break;
                            case "real":
                                sb.Append("float");
                                break;
                            case "smalldatetime":
                                sb.Append("DateTime");
                                break;
                            case "smallint":
                                sb.Append("short");
                                break;
                            case "smallmoney":
                                sb.Append("decimal");
                                break;
                            case "text":
                                sb.Append("string");
                                break;
                            case "time":
                                sb.Append("TimeSpan");
                                break;
                            case "timestamp":
                                sb.Append("long");
                                break;
                            case "tinyint":
                                sb.Append("byte");
                                break;
                            case "uniqueidentifier":
                                sb.Append("Guid");
                                break;
                            case "varbinary":
                                sb.Append("byte[]");
                                break;
                            case "varchar":
                                sb.Append("string");
                                break;
                            default:
                                sb.Append("UNKNOWN");
                                break;
                        }
                        if ("TRUE".Equals(schemaTable.Rows[i]["AllowDBNull"].ToString().ToUpper()))
                            if (!"binary".Equals(type) && !"varbinary".Equals(type) && !"image".Equals(type) && !"text".Equals(type) && !"ntext".Equals(type) && !"varchar".Equals(type) && !"nvarchar".Equals(type) && !"char".Equals(type) && !"nchar".Equals(type))
                            {
                                sb.Append("?");
                            }
                        if (this.RB_CASE1.Checked)
                            sb.Append(" " + schemaTable.Rows[i]["BaseColumnName"].ToString());
                        else if (this.RB_CASE2.Checked)
                        {
                            sb.Append(" " + ChangeCase(schemaTable.Rows[i]["BaseColumnName"].ToString(), "2"));
                        }
                        else if (this.RB_CASE3.Checked)
                        {
                            sb.Append(" " + ChangeCase(schemaTable.Rows[i]["BaseColumnName"].ToString(), "3"));
                        }
                        sb.AppendLine(" " + "{ get; set; }");
                    }
                    sb.AppendLine("}");

                    this.TBX_Result.Text = sb.ToString();
                }
                else if (this.TypeB.Checked)    //目前用不到
                {
                    Regex pattern = new Regex(@"<input\s.*name=""(?<v>.+?)""", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    MatchCollection matches = pattern.Matches(this.TBX_Query.Text);
                    if (matches.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("public partial class YOURMODELNAME");
                        sb.AppendLine("{");
                        for (int i = 0; i < matches.Count; i++)
                        {
                            sb.Append("  public string ");
                            if (this.RB_CASE1.Checked)
                                sb.Append(" " + matches[i].Groups["v"].ToString());
                            else if (this.RB_CASE2.Checked)
                            {
                                sb.Append(" " + ChangeCase(matches[i].Groups["v"].ToString(), "2"));
                            }
                            else if (this.RB_CASE3.Checked)
                            {
                                sb.Append(" " + ChangeCase(matches[i].Groups["v"].ToString(), "3"));
                            }
                            sb.AppendLine(" " + "{ get; set; }");
                        }
                        sb.AppendLine("}");
                        this.TBX_Result.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        private string ChangeCase(string str, string _case)
        {
            if ("2".Equals(_case))
                str = str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
            if ("3".Equals(_case))
                str = str.ToUpper();
            return str;
        }

        private void BTN_COPY_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.TBX_Result.Text);
        }
    }
}
