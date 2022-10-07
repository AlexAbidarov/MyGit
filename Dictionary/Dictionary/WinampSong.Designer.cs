namespace Dictionary {
    partial class WinampSong {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbEdit = new DevExpress.XtraEditors.SimpleButton();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.meTranslation = new DevExpress.XtraEditors.MemoEdit();
            this.meText = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.keyGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xpcSongs = new DevExpress.Xpo.XPCollection();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meTranslation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbEdit);
            this.layoutControl1.Controls.Add(this.sbAdd);
            this.layoutControl1.Controls.Add(this.meTranslation);
            this.layoutControl1.Controls.Add(this.meText);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(994, 479);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbEdit
            // 
            this.sbEdit.Location = new System.Drawing.Point(105, 30);
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(96, 22);
            this.sbEdit.StyleController = this.layoutControl1;
            this.sbEdit.TabIndex = 7;
            this.sbEdit.Text = "Edit";
            this.sbEdit.Click += new System.EventHandler(this.sbEdit_Click);
            // 
            // sbAdd
            // 
            this.sbAdd.Location = new System.Drawing.Point(12, 30);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(89, 22);
            this.sbAdd.StyleController = this.layoutControl1;
            this.sbAdd.TabIndex = 6;
            this.sbAdd.Text = "Add";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // meTranslation
            // 
            this.meTranslation.Location = new System.Drawing.Point(352, 105);
            this.meTranslation.Name = "meTranslation";
            this.meTranslation.Properties.ReadOnly = true;
            this.meTranslation.Size = new System.Drawing.Size(617, 349);
            this.meTranslation.StyleController = this.layoutControl1;
            this.meTranslation.TabIndex = 5;
            // 
            // meText
            // 
            this.meText.Location = new System.Drawing.Point(25, 105);
            this.meText.Name = "meText";
            this.meText.Properties.ReadOnly = true;
            this.meText.Size = new System.Drawing.Size(317, 349);
            this.meText.StyleController = this.layoutControl1;
            this.meText.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.keyGroup,
            this.lcAdd,
            this.lcEdit,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(994, 479);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.CustomizationFormText = "Song";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(974, 18);
            this.simpleLabelItem1.Text = "Song";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(57, 14);
            // 
            // keyGroup
            // 
            this.keyGroup.CustomizationFormText = "Key";
            this.keyGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.keyGroup.Location = new System.Drawing.Point(0, 44);
            this.keyGroup.Name = "keyGroup";
            this.keyGroup.Size = new System.Drawing.Size(974, 415);
            this.keyGroup.Text = "Key";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.meText;
            this.layoutControlItem1.CustomizationFormText = "Text:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(61, 36);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(321, 369);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Text:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.meTranslation;
            this.layoutControlItem2.CustomizationFormText = "Translation:";
            this.layoutControlItem2.Location = new System.Drawing.Point(327, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(61, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(621, 369);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Translation:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(321, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.ResizeMode = DevExpress.XtraLayout.SplitterItemResizeMode.AllSiblings;
            this.splitterItem1.Size = new System.Drawing.Size(6, 369);
            // 
            // lcAdd
            // 
            this.lcAdd.Control = this.sbAdd;
            this.lcAdd.CustomizationFormText = "lcAdd";
            this.lcAdd.Location = new System.Drawing.Point(0, 18);
            this.lcAdd.Name = "lcAdd";
            this.lcAdd.Size = new System.Drawing.Size(93, 26);
            this.lcAdd.Text = "lcAdd";
            this.lcAdd.TextSize = new System.Drawing.Size(0, 0);
            this.lcAdd.TextToControlDistance = 0;
            this.lcAdd.TextVisible = false;
            // 
            // lcEdit
            // 
            this.lcEdit.Control = this.sbEdit;
            this.lcEdit.CustomizationFormText = "lcEdit";
            this.lcEdit.Location = new System.Drawing.Point(93, 18);
            this.lcEdit.Name = "lcEdit";
            this.lcEdit.Size = new System.Drawing.Size(100, 26);
            this.lcEdit.Text = "lcEdit";
            this.lcEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lcEdit.TextToControlDistance = 0;
            this.lcEdit.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(193, 18);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(781, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xpcSongs
            // 
            this.xpcSongs.ObjectType = typeof(Dictionary.Song);
            // 
            // WinampSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "WinampSong";
            this.Size = new System.Drawing.Size(994, 479);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meTranslation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlGroup keyGroup;
        private DevExpress.XtraEditors.MemoEdit meTranslation;
        private DevExpress.XtraEditors.MemoEdit meText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton sbEdit;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraLayout.LayoutControlItem lcAdd;
        private DevExpress.XtraLayout.LayoutControlItem lcEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.Xpo.XPCollection xpcSongs;
    }
}
