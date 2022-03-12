using IniFiles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetModifiedFiles
{
    class Program
    {
        static IniFile ini = new IniFile("settings.ini");
        static void Main(string[] args)
        {
            try
            {
                //取得來源目的資料夾
                string fromPath = ini.ReadString("Path", "source");
                string toPath = ini.ReadString("Path", "destination");
                if (fromPath.Equals(toPath))
                {
                    Console.WriteLine("Err:來源目標路徑不得相同");
                    Console.ReadKey();
                    return;
                }

                //取得排除資料夾
                string exDir = ini.ReadString("Folder", "exclude");
                string[] exDirArray;
                if (!string.IsNullOrWhiteSpace(exDir))
                    exDirArray = exDir.ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                else
                    exDirArray = new string[1] { "jdfdA44ajsdifjao" };

                //取得排除副檔名
                string exFiles = ini.ReadString("Files", "exclude");
                string[] exFilesArray;
                if (!string.IsNullOrWhiteSpace(exFiles))
                    exFilesArray = exFiles.ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                else
                    exFilesArray = new string[1] { "jdfdAa44jsdifjao" };

                //取得檔案存取的時間
                string mDt = ini.ReadString("DateTime", "modified");
                DateTime mDate;
                if (!string.IsNullOrWhiteSpace(mDt))
                    mDate = DateTime.ParseExact(mDt, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                else
                    mDate = DateTime.ParseExact("1900-01-01 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                //目標資料夾不存在就產生
                if (!Directory.Exists(toPath))
                    Directory.CreateDirectory(toPath);

                //開始找底下包含子目錄所有檔案
                foreach (string file in Directory.EnumerateFiles(fromPath, "*.*", SearchOption.AllDirectories))
                {
                    bool ex = false;
                    string _file = file.ToLower();

                    //排除的副檔名
                    foreach (var item in exFilesArray)
                    {
                        if (_file.EndsWith(item))
                        {
                            ex = true;
                            break;
                        }
                    }
                    if (ex)
                        continue;

                    //存取時間
                    if (File.GetLastWriteTime(file) < mDate)
                        continue;

                    //檢查路徑上所有資料夾  若有排除的資料夾就跳出
                    string fromSubPath = Path.GetDirectoryName(file).Replace(fromPath, "").ToLower();
                    if (!string.IsNullOrWhiteSpace(fromSubPath))
                    {
                        string[] splitFromSubPath = fromSubPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                        if (splitFromSubPath.Length > 0)
                            foreach (var item in splitFromSubPath)
                            {
                                if (exDirArray.Contains(item))
                                {
                                    ex = true;
                                    break;
                                }
                            }
                    }
                    if (ex)
                        continue;

                    //在目的資料夾要架構相同
                    string toFullPath = file.Replace(fromPath, toPath);
                    string subFolder = Path.GetDirectoryName(toFullPath);
                    //DirectoryInfo info = )
                    //if (exDirArray.Contains(new DirectoryInfo(subFolder).Name.ToLower()))
                    //    continue;

                    //目標資料夾不存在就產生
                    if (!Directory.Exists(subFolder))
                        Directory.CreateDirectory(subFolder);

                    //copy overwrite
                    File.Copy(file, toFullPath, true);
                }

                Console.WriteLine("完成！按任意鍵繼續...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("按任意鍵繼續...");
                Console.ReadKey();
            }

        }
    }
}
