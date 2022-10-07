using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Dictionary {
    public partial class frmEditSong : XtraForm {
        public frmEditSong(Song song) {
            InitializeComponent();
            Text = string.Format("Edit: {0}", song.Key);
            memoEdit1.Text = song.Text;
            memoEdit2.Text = song.Translation;
        }
        public string TextSong { get { return memoEdit1.Text; } }
        public string TranslationSong { get { return memoEdit2.Text; } }
    }
}
