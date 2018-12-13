using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take3GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetInstalledApps();
            GetUsers();
        }

        private void MainTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Programs_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        public void GetInstalledApps()
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            ProgramList.Items.Add(sk.GetValue("DisplayName"));
                        }
                        catch (Exception ex)
                        { }
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPrograms.Items.Clear();
            foreach (Object item in ProgramList.CheckedItems)
            {
                selectedPrograms.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            System.Windows.Forms.OpenFileDialog oDlg = new System.Windows.Forms.OpenFileDialog();
            if (System.Windows.Forms.DialogResult.OK == oDlg.ShowDialog())
            {
                filePath = oDlg.FileName;
                fileBrowser.Items.Add(filePath);
            }
        }

        private void fileBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileRemove_Click(object sender, EventArgs e)
        {
            if (fileBrowser.SelectedIndex == -1)
            {
               
            }
            else
            {
                fileBrowser.Items.RemoveAt(fileBrowser.SelectedIndex);
            }
                
        }

        private void fileClear_Click(object sender, EventArgs e)
        {

            fileBrowser.Items.Clear();
        }

        private void Files_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public void GetUsers()
        {
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                string user;
                user = (string)envVar["Name"];
                if (user == "DefaultAccount") { }
                else if (user == "WDAGUtilityAccount") { }
                else { userList.Items.Add(envVar["Name"].ToString()); }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            checkEXE.Text = String.Empty;
            string filePath = "";
            System.Windows.Forms.OpenFileDialog oDlg = new System.Windows.Forms.OpenFileDialog();
            if (System.Windows.Forms.DialogResult.OK == oDlg.ShowDialog())
            {
                filePath = oDlg.FileName;
                checkEXE.Text += filePath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyVersion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(checkEXE.Text)) { }
            else if (String.IsNullOrEmpty(programVersion.Text)) { }
            else
            {
                string version = programVersion.Text;
                string filePath = checkEXE.Text;
                string output = filePath + "," + version;
                versionBox.Items.Add(output);
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            versionBox.Items.Clear();
        }

        private void versionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void programSubmit_Click(object sender, EventArgs e)
        {
            selectedPrograms.Items.Clear();
            foreach (Object item in ProgramList.CheckedItems)
            {
                selectedPrograms.Items.Add(item);
            }
        }
    }
}
