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
    public partial class SettingWindows : Form
    {
        private GO_TARGET_LIST target_list;
        private GO_TARGET_LIST proto_list;
        private int list_index = -1;

        public SettingWindows(GO_TARGET_LIST _target_list) {
            InitializeComponent();
            proto_list = _target_list;
            target_list = _target_list.GoClone();
            UpdateList();
        }

        //OK按鈕事件
        private void OkButton_Click(object sender, EventArgs e) {
            proto_list.GoSetList(target_list);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //【>>】按鈕事件
        private void AddButton_Click(object sender, EventArgs e) {
            if (IpTextBox.Text == "" || PortTextBox.Text == "")
                return;

            target_list.GoAdd(IpTextBox.Text, PortTextBox.Text);
            UpdateList();
        }

        //【<<】按鈕事件
        private void TakeButton_Click(object sender, EventArgs e) {
            list_index = IpPortListBox.SelectedIndex;
            if (list_index == -1)
                return;

            IpTextBox.Text = target_list[list_index].ip;
            PortTextBox.Text = target_list[list_index].port;

            target_list.GoRemove(list_index);

            IpTextBox.Refresh();
            PortTextBox.Refresh();
            UpdateList();

        }

        //更新IpPortListBox
        private void UpdateList() {
            IpPortListBox.Items.Clear();
            IpPortListBox.Items.AddRange(target_list.GoGetStringArray());
            IpPortListBox.Refresh();
        }
    }

}
