namespace youyou_CreatDBModelTool
{
    partial class UserControl_A_H
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_A_H));
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.buttons_A1 = new youyou_CreatDBModelTool.Buttons.Buttons_A();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.Encoding = ((System.Text.Encoding)(resources.GetObject("textEditorControl1.Encoding")));
            this.textEditorControl1.IsIconBarVisible = false;
            this.textEditorControl1.Location = new System.Drawing.Point(0, 36);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.ShowEOLMarkers = true;
            this.textEditorControl1.ShowInvalidLines = false;
            this.textEditorControl1.ShowSpaces = true;
            this.textEditorControl1.ShowTabs = true;
            this.textEditorControl1.ShowVRuler = true;
            this.textEditorControl1.Size = new System.Drawing.Size(689, 519);
            this.textEditorControl1.TabIndex = 1;
            this.textEditorControl1.VRulerRow = 300;
            // 
            // buttons_A1
            // 
            this.buttons_A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons_A1.Location = new System.Drawing.Point(617, 7);
            this.buttons_A1.Name = "buttons_A1";
            this.buttons_A1.PicFirst = global::youyou_CreatDBModelTool.Properties.Resources.Button_Create_1;
            this.buttons_A1.PicSecond = global::youyou_CreatDBModelTool.Properties.Resources.Button_Create_2;
            this.buttons_A1.PicThird = global::youyou_CreatDBModelTool.Properties.Resources.Button_Create_3;
            this.buttons_A1.Size = new System.Drawing.Size(59, 22);
            this.buttons_A1.TabIndex = 0;
            this.buttons_A1.ButtonClick += new youyou_CreatDBModelTool.Buttons.ButtonClickHandler(this.buttons_A1_ButtonClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "aspx";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(56, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "aspx.cs";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // UserControl_A_H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textEditorControl1);
            this.Controls.Add(this.buttons_A1);
            this.Name = "UserControl_A_H";
            this.Size = new System.Drawing.Size(689, 555);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl_A_A_Paint);
            this.SizeChanged += new System.EventHandler(this.UserControl_A_A_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private youyou_CreatDBModelTool.Buttons.Buttons_A buttons_A1;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}