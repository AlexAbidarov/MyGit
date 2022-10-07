using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Collections;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace Dictionary {
    public partial class MostUsefulWords : XtraUserControl {
        ArrayList arr;
        public const string OpenTextFilterString = "Text Files(*.TXT)|*.TXT|All(*.*)|*.*;";
        const char dash = (char)45;
        int start = System.Environment.TickCount;
        public MostUsefulWords() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignMode) {
                gridControl1.DataSource = xpNotes;
                listBoxControl2.DataSource = xpKnownWords;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            LoadFromData();
        }
        private void simpleButton2_Click(object sender, EventArgs e) {
            LoadTextFile();
        }
        private void simpleButton3_Click(object sender, EventArgs e) {
            LoadFromClipboard();
        }
        string TempFileName { get { return Application.StartupPath + "\\Temp.bak"; } }
        void LoadFromData() {
            start = System.Environment.TickCount;
            using(StreamWriter wr = File.CreateText(TempFileName)) {
                foreach(Note note in xpNotes)
                    wr.WriteLine(note.Text);
                wr.Close();
            }
            SelectText(TempFileName);
            AddToList();
        }
        void LoadTextFile() {
            start = System.Environment.TickCount;
            using(OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.Filter = OpenTextFilterString;
                if(DialogResult.OK == dlg.ShowDialog()) {
                    Cursor.Current = Cursors.WaitCursor;
                    SelectText(dlg.FileName);
                }
            }
            AddToList();
        }
        void LoadFromClipboard() {
            string data = Clipboard.GetText();
            if(data == null || data.Trim() == string.Empty) return;
            start = System.Environment.TickCount;
            using(StreamWriter wr = File.CreateText(TempFileName)) {
                wr.WriteLine(data);
                wr.Close();
            }
            SelectText(TempFileName);
            AddToList();
        }
        void AddToList() {
            Application.DoEvents();
            if(arr == null) return;
            arr.Sort();
            listBoxControl1.DataSource = arr;
            string result = string.Empty;
            foreach(object obj in arr)
                result += obj.ToString() + "\r\n";
            memoEdit1.Text = result;
            simpleLabelItem1.Text = string.Format("Last creation time = {0} sec.({1})", (double)(System.Environment.TickCount - start) / 1000, arr.Count);
        }
        void SelectText(string file_name) {
            arr = new ArrayList();
            using(StreamReader sr = File.OpenText(file_name)) {
                String input;
                while((input = sr.ReadLine()) != null) {
                    FindWords(input);
                }
                sr.Close();
            }
            if(!checkEdit1.Checked) return;
            foreach(KnownWord kword in xpKnownWords) {
                int index = arr.IndexOf(kword.Word);
                if(index != -1) arr.RemoveAt(index);
            }
        }
        void FindWords(string input) {
            string s = string.Empty;
            char prevChar = (char)0;
            for(int i = 0; i < input.Length; i++) {
                char c = input[i];
                if(char.IsLetter(c) || c == dash) {
                    if(!(c == dash && prevChar == dash))
                        s += c;
                }
                else {
                    AddWord(s.ToLower());
                    s = string.Empty;
                }
                prevChar = c;
            }
            AddWord(s.ToLower());
        }
        void AddWord(string s) {
            if(s.Length < 2) return;
            if(arr.IndexOf(s) == -1) {
                WordObject wo = new WordObject(s);
                arr.Add(wo);
            }
            else {
                ((WordObject)arr[arr.IndexOf(s)]).IncNum();
            }
        }

        public class WordObject : IComparable {
            string name;
            int count;
            public WordObject(string name) {
                this.name = name;
                this.count = 1;
            }
            public string Name {
                get { return name; }
            }
            public int Num {
                get { return count; }
            }
            public void IncNum() {
                count++;
            }
            public override string ToString() {
                return string.Format("{0}({1})", Name, Num);
            }

            #region IComparable Members

            public int CompareTo(object obj) {
                WordObject wo = obj as WordObject;
                if(wo == null) return 0;
                return Comparer.Default.Compare(wo.Num, Num);
            }
            public override bool Equals(object obj) {
                return Name == obj.ToString();
            }
            /*public override int GetHashCode() {
                //return base.GetHashCode();
                int hash1 = 5381;
                int hash2 = hash1;

                int i = Start;
                int iEnd = Start + Length;
                while(true) {
                    int c = String[i];
                    hash1 = ((hash1 << 5) + hash1) ^ c;
                    i++;
                    if(i >= iEnd) break;
                    c = String[i];
                    hash2 = ((hash2 << 5) + hash2) ^ c;
                    i++;
                    if(i >= iEnd) break;
                }
                return hash1 + (hash2 * 1566083941);
            }*/
            #endregion
        }

        private void listBoxControl1_DoubleClick(object sender, EventArgs e) {
            AddKnownWord();
        }
        private void listBoxControl1_KeyDown(object sender, KeyEventArgs e) {
            if(e.Control && e.KeyCode == Keys.Enter) AddKnownWord();
        }
        void AddKnownWord() {
            WordObject word = listBoxControl1.SelectedItem as WordObject;
            if(word == null) return;
            KnownWord kword = xpKnownWords.Session.FindObject<KnownWord>(CriteriaOperator.Parse("[Word] = ?", word.Name));
            if(kword != null) return;
            kword = new KnownWord(word.Name);
            xpKnownWords.Add(kword);
            kword.Save();
            int index = arr.IndexOf(word.Name);
            if(index != -1) arr.RemoveAt(index);
            listBoxControl1.Refresh();
        }

        private void listBoxControl2_DoubleClick(object sender, EventArgs e) {
            KnownWord kword = listBoxControl2.SelectedItem as KnownWord;
            if(kword == null) return;
            xpKnownWords.Remove(kword);
            kword.Delete();
            listBoxControl2.Refresh();
        }
    }
}
