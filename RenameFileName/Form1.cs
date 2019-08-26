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

namespace RenameFileName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;

            tbSoucePath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnSelectTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;

            tbTargetPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (tbSoucePath.Text == null || "".Equals(tbSoucePath.Text)
                || tbTargetPath.Text == null || "".Equals(tbTargetPath.Text))
                return;

            if (!Directory.Exists(tbSoucePath.Text))
            {
                MessageBox.Show("源文件夹不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(!Directory.Exists(tbTargetPath.Text))
            {
                MessageBox.Show("目标文件夹不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(tbSoucePath.Text);

            int count = directoryInfo.GetFiles().Length;

            if(count == 0)
            {
                MessageBox.Show("源文件夹中没有文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listProgress.Items.Clear();
            int index = 1;
            string targetFileName;
            string targetFilePath;
            string temp;

            foreach(FileInfo fileInfo in directoryInfo.GetFiles())
            {
                targetFileName = GetTargetFileName(fileInfo.Name);

                temp = "正在重命名（" + index + "/" + count + "）：" + fileInfo.Name + "  ->  " + targetFileName;

                listProgress.Items.Insert(0, DateTime.Now.ToString("[HH:mm:ss]") + temp);

                targetFilePath = Path.Combine(tbTargetPath.Text, targetFileName);

                fileInfo.CopyTo(targetFilePath, true);

                index++;
            }

            MessageBox.Show("重命名完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 将文件名转化成用户需要的名字
        /// </summary>
        /// <param name="name">被更改的文件名</param>
        /// <returns>修改后的文件名</returns>
        private string GetTargetFileName(string name)
        {
            return RemoveZero(name);
        }

        /// <summary>
        /// 移除文件名中多余的0，比如0001.txt -> 1.txt;
        /// </summary>
        /// <param name="name">被修改的文件名</param>
        /// <returns>修改后的文件名</returns>
        private string RemoveZero(string name)
        {
            while (name[0].Equals('0'))
            {
                name = name.Substring(1, name.Length - 1);
            }

            return name;
        }
    }
}
