using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace Radix
{
    public partial class overlay : Form
    {
        string selected = "";
        string selected2 = "";
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);
        
        public overlay()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            encrypt_radio.Checked = true;

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            {
                if (encrypt_radio.Checked == true)
                {
                    if (password_1.Text == password_2.Text)
                    {
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.Multiselect = true;
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            selected = ofd.FileName;

                            selected2 = selected;
                            DialogResult dialogResult = MessageBox.Show("Do you want to proceed?", "Radix", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                foreach (string fileName in ofd.FileNames)
                                {
                                    string password = password_1.Text;
                                    GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
                                    EncryptClass.FileEncrypt(fileName, password);
                                    ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                                    gch.Free();
                                    Console.WriteLine("The given password is surely nothing: " + password);
                                    File.Delete(@fileName);
                                }
                                MessageBox.Show("All done!");
                            }
                            else if (dialogResult == DialogResult.No)
                            {

                            }
                        }
                    }
                    else if (password_1.Text != password_2.Text)
                    {
                        MessageBox.Show("Please check your password!");
                    }
                }
                else if (decrypt_radio.Checked == true)
                {
                    if (password_1.Text == password_2.Text)
                    {
                        OpenFileDialog ofd2 = new OpenFileDialog();
                        ofd2.Multiselect = true;
                        ofd2.Filter = "Radix Files (*.crypt)|*.crypt|All files (*.*)|*.*";
                        ofd2.FilterIndex = 1;
                        if (ofd2.ShowDialog() == DialogResult.OK)
                        {
                        }
                        int bruh = 0;
                        DialogResult dialogResult = MessageBox.Show("Do you want to proceed?", "Radix", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            bruh = 1;
                            foreach (string fileName in ofd2.FileNames)
                            {
                                string password = "";
                                password = password_1.Text;
                                GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
                                selected2 = fileName;
                                selected2 = selected2.Replace(".crypt", "");
                                DecryptClass.FileDecrypt(fileName, @selected2, password);
                                ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                                gch.Free();
                                Console.WriteLine("The given password is surely nothing: " + password);
                                password = "";
                                long vIn = new FileInfo(selected2).Length;
                                string strLong = vIn.ToString();
                                if (strLong == "0")
                                {
                                    if (bruh == 1)
                                    {
                                        MessageBox.Show("Try again, or use a different password!");
                                        bruh = 0;
                                    }
                                    File.Delete(selected2);
                                }
                                else
                                {
                                    File.Delete(@fileName);
                                    selected2 = "";
                                }
                            }
                            MessageBox.Show("All done!");
                            
                        }
                    }
                    else if (password_1.Text != password_2.Text)
                    {
                        MessageBox.Show("Please check your password!");
                    }
                }
                    else if (password_1.Text != password_2.Text)
                    {
                        MessageBox.Show("Please check your password!");
                    }
                }
            }
        
        int checkmalab = 0;
        private void encrypt_radio_CheckedChanged(object sender, System.EventArgs e)
        {
            button1.Text = "Encrypt";
            checkmalab = 0;
        }

        private void decrypt_radio_CheckedChanged(object sender, System.EventArgs e)
        {
            button1.Text = "Decrypt";
            checkmalab = 1;
        }

    }
}
