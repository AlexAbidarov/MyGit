using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;

namespace Dictionary {
    [OptimisticLocking(false)]
    public class Theme : XPObject {
        public string Name;
    }
    [OptimisticLocking(false)]
    public class Word : XPObject {
        public Word() : base(DevExpress.Xpo.Session.DefaultSession) { }
        public string Name;
        public string Translation;
        public string Translation2;
        public string Translation3;
        public string Transcription;
        [SizeAttribute(SizeAttribute.Unlimited)]
        public string Examples;
        public bool Pass;
        public Theme Theme;

        public string TranscriptionFull {
            get {
                if(Transcription == string.Empty || Transcription == null) return string.Empty;
                return string.Format("[{0}] ", Transcription);
            }
        }
        public string Text {
            get {
                string ret = string.Format("{0}{1}", TranscriptionFull, Translation);
                if(Translation2 != string.Empty && Translation2 != null)
                    ret = string.Format("{0}, {1}", ret, Translation2);
                if(Translation3 != string.Empty && Translation3 != null)
                    ret = string.Format("{0}, {1}", ret, Translation3);
                if(Examples != string.Empty && Examples != null)
                    ret = string.Format("{0}\r\n<i>{1}", ret, Examples);
                return ret;
            }
        }
    }
    public class Song : XPObject {
        public Song() : base(DevExpress.Xpo.Session.DefaultSession) { }
        public string Key;
        [SizeAttribute(SizeAttribute.Unlimited)]
        public string Text;
        [SizeAttribute(SizeAttribute.Unlimited)]
        public string Translation;
    }
    public class Note : XPObject { 
        public Note() : base(DevExpress.Xpo.Session.DefaultSession) {
            OnAdded = DateTime.Now;
        }
        [SizeAttribute(SizeAttribute.Unlimited)]
        public string Text;
        public DateTime OnAdded;
    }
    public class KnownWord : XPObject {
        public KnownWord() : base(DevExpress.Xpo.Session.DefaultSession) { }
        public KnownWord(string name)
            : this() {
            Word = name;
        }
        public string Word;
    }
}
