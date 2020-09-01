using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeDoor
{
    public partial class MainWindows : Form
    {
        public GO_TARGET_LIST target_list;

        public MainWindows() {
            InitializeComponent();
            target_list = new GO_TARGET_LIST();//TODO
        }


        //輸入窗Enter事件
        private void ProjectionBox_Enter(object sender, EventArgs e) {
            
        }

        //Send按鈕事件
        private void SendButton_Click(object sender, EventArgs e) {

        }

        //Setting按鈕事件
        private void SettingButton_Click(object sender, EventArgs e) {
            SettingWindows settingwindows = new SettingWindows(target_list);
            settingwindows.ShowDialog();
        }
    }
}
