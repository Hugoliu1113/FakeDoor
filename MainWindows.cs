using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeDoor
{
    public partial class MainWindows : Form
    {
        public GO_TARGET_LIST target_list;
        public GO_TCP go_tcp;

        public MainWindows() {
            InitializeComponent();
            Init();
        }


        //輸入窗Enter事件
        private void ProjectionBox_Enter(object sender, EventArgs e) {
            if (((KeyEventArgs)e).KeyCode != Keys.Enter)
                return;
            SendButton_Click(sender, e);
        }

        //Send按鈕事件
        private void SendButton_Click(object sender, EventArgs e) {
            int i = go_tcp.GoSend(ProjectionBox.Text);
            MessageBox.Show(i.ToString());
        }

        //Setting按鈕事件
        private void SettingButton_Click(object sender, EventArgs e) {
            SettingWindows settingwindows = new SettingWindows(target_list);
            int is_ok = settingwindows.ShowDialog().GetHashCode();
            if(is_ok == 1)
            {
                go_tcp.GoDisConnact();
                go_tcp.GoSetIpPort(target_list.GoGetStringArray());
                go_tcp.GoConnact();
            }
        }

        private void Init() {

            MessageBoard.Clear();   //TODO 取得設定值
            target_list = new GO_TARGET_LIST(); //TODO 取得設定值

            //開啟伺服器聆聽
            go_tcp = new GO_TCP();
            go_tcp.GoOpenServer(11010); //TODO Port參數
            if (target_list.GoCount() > 0)
            {
                go_tcp.GoSetIpPort(target_list.GoGetStringArray());
                go_tcp.GoConnact();
            }
        }

    }
}
