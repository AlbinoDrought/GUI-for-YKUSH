using GhettoYkushGui.YKUSH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhettoYkushGui
{
    public partial class ControlForm : Form
    {
        YKushWrapper wrapper;
        YKushState state;
        bool editMode = false;

        public ControlForm()
        {
            InitializeComponent();
            this.wrapper = new YKushWrapper
            {
                ExecutablePath = "./ykushcmd/bin/ykushcmd.exe"
            };
            this.state = new YKushState()
            {
                Wrapper = wrapper,
                NameFile = "./names.txt",
            };

            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
        }

        private void bindForm()
        {
            this.chkPortOne.Checked = this.state.PortState[1].Enabled;
            this.chkPortOne.Text = this.state.PortState[1].Name;

            this.txtPortOne.Text = this.state.PortState[1].Name;

            this.chkPortTwo.Checked = this.state.PortState[2].Enabled;
            this.chkPortTwo.Text = this.state.PortState[2].Name;

            this.txtPortTwo.Text = this.state.PortState[2].Name;

            this.chkPortThree.Checked = this.state.PortState[3].Enabled;
            this.chkPortThree.Text = this.state.PortState[3].Name;

            this.txtPortThree.Text = this.state.PortState[3].Name;
            
            this.notifyIcon.ContextMenuStrip.Items.Clear();

            foreach (var port in state.PortState.Values)
            {
                var text = port.Name + ": " + (port.Enabled ? "On" : "Off");

                this.notifyIcon.ContextMenuStrip.Items.Add(text, null, (s, e) => changePortState(port.Port, !port.Enabled));
            }

            this.notifyIcon.ContextMenuStrip.Items.Add("-");
            this.notifyIcon.ContextMenuStrip.Items.Add("Show", null, (s, e) => showSelf());
            this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, (s, e) => Environment.Exit(0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.state.LoadNames();
            this.state.Refresh();
            this.bindForm();
            this.Enabled = true;
        }

        private void showSelf()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void changePortState(int port, bool newState)
        {
            this.Enabled = false;

            if (newState)
            {
                state.Up(port);
            }
            else
            {
                state.Down(port);
            }

            this.bindForm();

            this.Enabled = true;
        }

        private void chkPortOne_CheckedChanged(object sender, EventArgs e)
        {
            changePortState(1, this.chkPortOne.Checked);
        }

        private void chkPortTwo_CheckedChanged(object sender, EventArgs e)
        {
            changePortState(2, this.chkPortTwo.Checked);
        }

        private void chkPortThree_CheckedChanged(object sender, EventArgs e)
        {
            changePortState(3, this.chkPortThree.Checked);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode = !editMode;

            if (!editMode)
            {
                state.PortState[1].Name = txtPortOne.Text;
                state.PortState[2].Name = txtPortTwo.Text;
                state.PortState[3].Name = txtPortThree.Text;

                state.SaveNames();
                this.bindForm();
            }

            this.btnEdit.Text = editMode
                ? "Save"
                : "Edit";

            txtPortOne.Visible = editMode;
            txtPortTwo.Visible = editMode;
            txtPortThree.Visible = editMode;

            chkPortOne.Visible = !editMode;
            chkPortTwo.Visible = !editMode;
            chkPortThree.Visible = !editMode;
        }

        private void ControlForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                this.ShowInTaskbar = false;
            }
        }
    }
}
