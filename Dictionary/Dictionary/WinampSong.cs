using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Dictionary {
    public partial class WinampSong : XtraUserControl {
        public WinampSong() {
            InitializeComponent();
        }
        string title = "-1";
        string TitleString {
            get {
                if(title == null) return "No winamp song";
                if(title == string.Empty) return "Empty title";
                return title; 
            }
            set {
                if(title == value) return;
                title = value;
                UpdateData();
            }
        }
        string KeyTitle {
            get { 
                int start = TitleString.IndexOf("- ");
                if(start > -1 && start < 5)
                    return TitleString.Substring(start + 2, TitleString.Length - start - 2);
                return TitleString;
            }
        }
        Song GetCurrentSong(string title) {
                foreach(Song song in xpcSongs) {
                    if(song.Key.ToLower() == title.ToLower()) return song;
                }
                return null;
        }

        void UpdateData() {
            simpleLabelItem1.Text = TitleString;
            if(KeyTitle == null) {
                lcAdd.Visibility = lcEdit.Visibility =
                    keyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else {
                keyGroup.Text = KeyTitle;
                Song song = GetCurrentSong(keyGroup.Text);
                if(song == null) {
                    lcAdd.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcEdit.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    keyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                else {
                    lcAdd.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcEdit.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    keyGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    meText.Text = song.Text;
                    meTranslation.Text = song.Translation;
                }
            }
        }
        public void SetSong(string winampTitle) {
            TitleString = winampTitle;
        }

        private void sbAdd_Click(object sender, EventArgs e) {
            if(GetCurrentSong(KeyTitle) != null) return;
            if(XtraMessageBox.Show(string.Format("Are you sure to add {0}?", KeyTitle), "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Song song = new Song();
            song.Key = KeyTitle;
            xpcSongs.Add(song);
            song.Save();
            UpdateData();
        }

        private void sbEdit_Click(object sender, EventArgs e) {
            Song song = GetCurrentSong(KeyTitle);
            if(song == null) return;
            frmEditSong frm = new frmEditSong(song);
            if(frm.ShowDialog() == DialogResult.Cancel) return;
            song.Text = frm.TextSong;
            song.Translation = frm.TranslationSong;
            song.Save();
            UpdateData();
        }
    }
}
