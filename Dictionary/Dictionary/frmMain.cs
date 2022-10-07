using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace Dictionary {
    public partial class frmMain : XtraForm {
        public frmMain() {
            InitializeComponent();

        }
        XPCollection words, themes;
        Timer alertTimer = new Timer();
        Timer winampTimer = new Timer();
        Random rnd = new Random();
        private void frmMain_Load(object sender, EventArgs e) {
            words = new XPCollection(DevExpress.Xpo.Session.DefaultSession, typeof(Word));
            themes = new XPCollection(DevExpress.Xpo.Session.DefaultSession, typeof(Theme));
            gridControl1.DataSource = words;
            gridControl2.DataSource = themes;
            repositoryItemLookUpEdit1.DataSource = themes;
            alertTimer.Interval = 10000;
            alertTimer.Tick += new EventHandler(alertTimer_Tick);
            winampTimer.Interval = 1000;
            winampTimer.Start();
            winampTimer.Tick+=new EventHandler(winampTimer_Tick);
        }

        Word GetNewWord() {
            for(int i = 0; i < words.Count * 10; i++) {
                Word w = (Word)words[rnd.Next(words.Count)];
                if(!w.Pass) return w;
            }
            return null;
        }

        void ShowSimple(AlertInfo info) {
            alertControl1.Buttons[0].Visible = true;
            alertControl1.Buttons[1].Visible = false;
            alertControl1.Buttons[0].Down = ((Word)info.Tag).Pass;
            alertControl1.Show(this, info);
        }
        void ShowText(AlertInfo info) {
            alertControl1.Buttons[0].Visible = false;
            alertControl1.Buttons[1].Visible = true;
            alertControl1.Show(this, info);
        }

        AlertInfo GetAlertInfo() {
            Word word = GetNewWord();
            if(word == null) return null;
            AlertInfo info = new AlertInfo(string.Format("<b><size=11>{0}", word.Name), word.Text, string.Format("<u><color=Blue>{0}", word.Text));
            info.Tag = word;
            return info;
        }

        void alertTimer_Tick(object sender, EventArgs e) {
            AlertInfo info = GetAlertInfo();
            if(info == null) return;
            ShowText(info);
        }

        private void barButtonItem1_DownChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            alertTimer.Enabled = barButtonItem1.Down;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            foreach(Word word in words) {
                word.Pass = false;
                word.Save();
            }
        }

        private void alertControl1_ButtonDownChanged(object sender, AlertButtonDownChangedEventArgs e) {
            Word w = (Word)e.Info.Tag;
            w.Pass = e.Down;
            w.Save();
        }

        private void alertControl1_BeforeFormShow(object sender, AlertFormEventArgs e) {
            TextEdit edit = new TextEdit();
            edit.Width = e.AlertForm.Width - 6;
            edit.Location = new Point(3, 40);
            edit.Properties.AutoHeight = false;
            //edit.Height = 34;
            edit.Parent = e.AlertForm;
            edit.TextChanged += new EventHandler(edit_TextChanged);
        }

        private void alertControl1_FormLoad(object sender, AlertFormLoadEventArgs e) {
            e.AlertForm.Controls[0].Height = 34 + (e.AlertForm.Height - 100);
        }

        void edit_TextChanged(object sender, EventArgs e) {
            TextEdit edit = sender as TextEdit;
            AlertForm frm = edit.Parent as AlertForm;
            Word word = frm.Info.Tag as Word;
            if(frm == null) return;
            if(edit.Text.Trim() != string.Empty && (
                edit.Text == word.Translation || edit.Text == word.Translation2 || edit.Text == word.Translation3)) {
                word.Pass = true;
                word.Save();
                frm.Close();
            }
        }

        private void alertControl1_ButtonClick(object sender, AlertButtonClickEventArgs e) {
            if(e.ButtonName == "alertButton2") {
                if(e.AlertForm.Controls[0] != null)
                    e.AlertForm.Controls[0].Visible = false;
            }
        }

        private void alertControl1_MouseFormLeave(object sender, AlertFormEventArgs e) {
            bool ret = false;
            Control ctrl = e.AlertForm.Controls[0];
            if(ctrl == null || !ctrl.Visible) return;
            foreach(Control c in ctrl.Controls)
                if(c.Focused) ret = true;
            e.Cancel = ret;
        }

        private void winampTimer_Tick(object sender, EventArgs e) {
            ShowWinampPlaying();
        }

        string GetWinampPlaying() {
            foreach(Process proc in Process.GetProcesses())
                if("AIMP".Equals(proc.ProcessName))
                    return proc.MainWindowTitle;
            return null;
        }

        void ShowWinampPlaying() {
            winampSong1.SetSong(GetWinampPlaying());
        }
    }
}