using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markdown2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://md.mzr.me/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://yangkairuei.github.io/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://markdown.com.cn/");
        
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string localFilePath = saveFileDialog1.FileName.ToString();
            StreamWriter sw = File.CreateText(localFilePath);

            sw.Write(richTextBox1.Text);  //写入文件中
            sw.Flush();//清理缓冲区
            sw.Close();//关闭文件

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string webmarkdown = "<html>\r\n<title>"+textBox1.Text+"</title>\r\n<xmp theme='united\" style=\"display:none;'>\r\n"+ richTextBox1.Text + "\r\n</xmp>\r\n<script src='http://cdn.ztx.io/strapdown/strapdown.min.js'></script>\r\n</html>";
            saveFileDialog2.ShowDialog();
            string localFilePath = saveFileDialog2.FileName.ToString();
            StreamWriter sw = File.CreateText(localFilePath);

            sw.Write(webmarkdown);  //写入文件中
            sw.Flush();//清理缓冲区
            sw.Close();//关闭文件

        }

   
    }
}
