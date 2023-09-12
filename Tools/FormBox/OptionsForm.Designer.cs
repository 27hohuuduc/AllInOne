
namespace Tools
{
    partial class OptionsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panHotKey = new System.Windows.Forms.Panel();
            this.butHotKey = new System.Windows.Forms.Button();
            this.txtHotKey = new System.Windows.Forms.TextBox();
            this.chkHotKey = new System.Windows.Forms.CheckBox();
            this.numLimit = new System.Windows.Forms.NumericUpDown();
            this.chkWindowsAtEnd = new System.Windows.Forms.CheckBox();
            this.chkTruncateTitle = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUpdates = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panHotKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(383, 249);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(113, 31);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(261, 249);
            this.butSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(113, 31);
            this.butSubmit.TabIndex = 1;
            this.butSubmit.Text = "OK";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panHotKey);
            this.groupBox1.Controls.Add(this.chkHotKey);
            this.groupBox1.Controls.Add(this.numLimit);
            this.groupBox1.Controls.Add(this.chkWindowsAtEnd);
            this.groupBox1.Controls.Add(this.chkTruncateTitle);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(480, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // panHotKey
            // 
            this.panHotKey.Controls.Add(this.butHotKey);
            this.panHotKey.Controls.Add(this.txtHotKey);
            this.panHotKey.Location = new System.Drawing.Point(201, 55);
            this.panHotKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panHotKey.Name = "panHotKey";
            this.panHotKey.Size = new System.Drawing.Size(271, 31);
            this.panHotKey.TabIndex = 5;
            // 
            // butHotKey
            // 
            this.butHotKey.Location = new System.Drawing.Point(171, 1);
            this.butHotKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butHotKey.Name = "butHotKey";
            this.butHotKey.Size = new System.Drawing.Size(100, 28);
            this.butHotKey.TabIndex = 4;
            this.butHotKey.Text = "Change";
            this.butHotKey.UseVisualStyleBackColor = true;
            this.butHotKey.Click += new System.EventHandler(this.butHotKey_Click);
            // 
            // txtHotKey
            // 
            this.txtHotKey.Location = new System.Drawing.Point(0, 4);
            this.txtHotKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHotKey.Name = "txtHotKey";
            this.txtHotKey.ReadOnly = true;
            this.txtHotKey.Size = new System.Drawing.Size(161, 22);
            this.txtHotKey.TabIndex = 2;
            // 
            // chkHotKey
            // 
            this.chkHotKey.AutoSize = true;
            this.chkHotKey.Location = new System.Drawing.Point(8, 62);
            this.chkHotKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHotKey.Name = "chkHotKey";
            this.chkHotKey.Size = new System.Drawing.Size(159, 21);
            this.chkHotKey.TabIndex = 3;
            this.chkHotKey.Text = "Use a global hot key";
            this.chkHotKey.UseVisualStyleBackColor = true;
            this.chkHotKey.CheckedChanged += new System.EventHandler(this.chkHotKey_CheckedChanged);
            // 
            // numLimit
            // 
            this.numLimit.Location = new System.Drawing.Point(201, 23);
            this.numLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numLimit.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(120, 22);
            this.numLimit.TabIndex = 1;
            this.numLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chkWindowsAtEnd
            // 
            this.chkWindowsAtEnd.AutoSize = true;
            this.chkWindowsAtEnd.Location = new System.Drawing.Point(8, 98);
            this.chkWindowsAtEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkWindowsAtEnd.Name = "chkWindowsAtEnd";
            this.chkWindowsAtEnd.Size = new System.Drawing.Size(209, 21);
            this.chkWindowsAtEnd.TabIndex = 0;
            this.chkWindowsAtEnd.Text = "Show windows list at the end";
            this.chkWindowsAtEnd.UseVisualStyleBackColor = true;
            this.chkWindowsAtEnd.CheckedChanged += new System.EventHandler(this.chkTruncateTitle_CheckedChanged);
            // 
            // chkTruncateTitle
            // 
            this.chkTruncateTitle.AutoSize = true;
            this.chkTruncateTitle.Location = new System.Drawing.Point(8, 25);
            this.chkTruncateTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTruncateTitle.Name = "chkTruncateTitle";
            this.chkTruncateTitle.Size = new System.Drawing.Size(169, 21);
            this.chkTruncateTitle.TabIndex = 0;
            this.chkTruncateTitle.Text = "Truncate window titles";
            this.chkTruncateTitle.UseVisualStyleBackColor = true;
            this.chkTruncateTitle.CheckedChanged += new System.EventHandler(this.chkTruncateTitle_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUpdates);
            this.groupBox2.Location = new System.Drawing.Point(16, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(480, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application";
            // 
            // chkUpdates
            // 
            this.chkUpdates.AutoSize = true;
            this.chkUpdates.Location = new System.Drawing.Point(8, 23);
            this.chkUpdates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUpdates.Name = "chkUpdates";
            this.chkUpdates.Size = new System.Drawing.Size(254, 21);
            this.chkUpdates.TabIndex = 1;
            this.chkUpdates.Text = "Always check for updates at startup";
            this.chkUpdates.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.butSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(512, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.butCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinWin - Options";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panHotKey.ResumeLayout(false);
            this.panHotKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTruncateTitle;
        private System.Windows.Forms.Panel panHotKey;
        private System.Windows.Forms.Button butHotKey;
        private System.Windows.Forms.TextBox txtHotKey;
        private System.Windows.Forms.CheckBox chkHotKey;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.CheckBox chkUpdates;
        private System.Windows.Forms.CheckBox chkWindowsAtEnd;
    }
}