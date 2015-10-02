using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.BZip2;
using ICSharpCode.SharpZipLib.Zip; 

namespace ZipAndUnzip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zip_Click(object sender, EventArgs e)
        {
            string srcFile = @"..\..\..\..\text.txt";//准备压缩的文件路径
            string zipFile = @"..\..\..\..\testzip";//压缩后的文件路径
            Console.WriteLine("使用BZIP开始压缩文件……");
            if (BZipFile(srcFile, zipFile + ".bz"))//使用BZIP压缩文件
            {
                MessageBox.Show("文件压缩成功");
                //Console.WriteLine("文件压缩完成");
            }
            else
            {
                Console.WriteLine("文件压缩失败");
            }
        }
        private bool BZipFile(string sourcefilename, string zipfilename)
        {
            bool blResult;//表示压缩是否成功的返回结果
            //为源文件创建文件流实例，作为压缩方法的输入流参数
            FileStream srcFile = File.OpenRead(sourcefilename);
            //为压缩文件创建文件流实例，作为压缩方法的输出流参数
            FileStream zipFile = File.Open(zipfilename, FileMode.Create);
            try
            {
                //以4096字节作为一个块的方式压缩文件
                BZip2.Compress(srcFile, zipFile, 4096);
                blResult=true;
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                blResult=false;
            }
            srcFile.Close();//关闭源文件流
            zipFile.Close();//关闭压缩文件流
            return blResult;
        }
        //文件解压
        public void UnZip(string zipedFile, string strDirectory, string password, bool overWrite)
        {
            if (strDirectory == "")
                strDirectory = Directory.GetCurrentDirectory();

            if (!strDirectory.EndsWith("\\"))
                strDirectory = strDirectory + "\\";

            using (ZipInputStream s = new ZipInputStream(File.OpenRead(zipedFile)))
            {
                s.Password = password;
                ZipEntry theEntry;

                while ((theEntry = s.GetNextEntry()) != null)
                {
                    string directoryName = "";
                    string pathToZip = "";
                    pathToZip = theEntry.Name;

                    if (pathToZip != "")
                        directoryName = Path.GetDirectoryName(pathToZip) + "\\";

                    string fileName = Path.GetFileName(pathToZip);

                    Directory.CreateDirectory(strDirectory + directoryName);
                    if (fileName != "")
                    {
                        if ((File.Exists(strDirectory + directoryName + fileName) && overWrite) || (!File.Exists(strDirectory + directoryName + fileName)))
                        {
                            using (FileStream streamWriter = File.Create(strDirectory + directoryName + fileName))
                            {
                                int size = 2048;
                                byte[] data = new byte[2048];
                                while (true)
                                {
                                    size = s.Read(data, 0, data.Length);
                                    if (size > 0)
                                        streamWriter.Write(data, 0, size);
                                    else
                                        break;
                                }
                                streamWriter.Close();
                            }
                        }
                    }
                }
                s.Close();
            }
        }

        private void Unzip_Click(object sender, EventArgs e)
        {
            UnZip("hksnzt.zip","E:\\","123",true);
        }  
    }
}
