using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using GlobalHotKey;
using System.Runtime.InteropServices;

namespace Win_R
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        public Form1()
        {
            InitializeComponent();


            int UniqueHotkeyId = 1;
        
    
            int HotKeyCode = (int)Keys.F10;


            Boolean F10Registered = RegisterHotKey(
                this.Handle, UniqueHotkeyId, 0x0000, HotKeyCode
            );

      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
           
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
               

                if (id == 1)
                {
                    if (this.Visible)
                    {
                        this.Visible = false;
                    }
                    else
                    {
                        this.Visible = true;
                    }

                }
            }

            base.WndProc(ref m);
        }
    

        

        private void OkButton_Click(object sender, EventArgs e)
        {
            process1.StartInfo = new ProcessStartInfo(textBox.Text);
            process1.Start();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            process1.StartInfo = new ProcessStartInfo("explorer.exe");
            process1.Start();
        }
    }
}
