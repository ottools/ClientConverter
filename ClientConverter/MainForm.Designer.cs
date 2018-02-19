namespace ClientConverter
{
    partial class MainForm
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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.loadProgressBar = new System.Windows.Forms.ProgressBar();
            this.loadButton = new System.Windows.Forms.Button();
            this.inputFrameGroupsCheckBox = new System.Windows.Forms.CheckBox();
            this.inputFrameDurationsCheckBox = new System.Windows.Forms.CheckBox();
            this.inputVersionComboBox = new System.Windows.Forms.ComboBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.compileProgressBar = new System.Windows.Forms.ProgressBar();
            this.compileButton = new System.Windows.Forms.Button();
            this.outputFrameGroupsCheckBox = new System.Windows.Forms.CheckBox();
            this.outputFrameDurationsCheckBox = new System.Windows.Forms.CheckBox();
            this.outputVersionComboBox = new System.Windows.Forms.ComboBox();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.loadProgressBar);
            this.inputGroupBox.Controls.Add(this.loadButton);
            this.inputGroupBox.Controls.Add(this.inputFrameGroupsCheckBox);
            this.inputGroupBox.Controls.Add(this.inputFrameDurationsCheckBox);
            this.inputGroupBox.Controls.Add(this.inputVersionComboBox);
            this.inputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(200, 179);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // loadProgressBar
            // 
            this.loadProgressBar.Location = new System.Drawing.Point(7, 113);
            this.loadProgressBar.Name = "loadProgressBar";
            this.loadProgressBar.Size = new System.Drawing.Size(187, 23);
            this.loadProgressBar.TabIndex = 4;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(7, 142);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(187, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // inputFrameGroupsCheckBox
            // 
            this.inputFrameGroupsCheckBox.AutoSize = true;
            this.inputFrameGroupsCheckBox.Enabled = false;
            this.inputFrameGroupsCheckBox.Location = new System.Drawing.Point(7, 78);
            this.inputFrameGroupsCheckBox.Name = "inputFrameGroupsCheckBox";
            this.inputFrameGroupsCheckBox.Size = new System.Drawing.Size(92, 17);
            this.inputFrameGroupsCheckBox.TabIndex = 2;
            this.inputFrameGroupsCheckBox.Text = "Frame Groups";
            this.inputFrameGroupsCheckBox.UseVisualStyleBackColor = true;
            // 
            // inputFrameDurationsCheckBox
            // 
            this.inputFrameDurationsCheckBox.AutoSize = true;
            this.inputFrameDurationsCheckBox.Enabled = false;
            this.inputFrameDurationsCheckBox.Location = new System.Drawing.Point(7, 55);
            this.inputFrameDurationsCheckBox.Name = "inputFrameDurationsCheckBox";
            this.inputFrameDurationsCheckBox.Size = new System.Drawing.Size(103, 17);
            this.inputFrameDurationsCheckBox.TabIndex = 1;
            this.inputFrameDurationsCheckBox.Text = "Frame Durations";
            this.inputFrameDurationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // inputVersionComboBox
            // 
            this.inputVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputVersionComboBox.FormattingEnabled = true;
            this.inputVersionComboBox.Location = new System.Drawing.Point(7, 20);
            this.inputVersionComboBox.Name = "inputVersionComboBox";
            this.inputVersionComboBox.Size = new System.Drawing.Size(187, 21);
            this.inputVersionComboBox.TabIndex = 0;
            this.inputVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.InputVersionComboBox_SelectedIndexChanged);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.compileProgressBar);
            this.outputGroupBox.Controls.Add(this.compileButton);
            this.outputGroupBox.Controls.Add(this.outputFrameGroupsCheckBox);
            this.outputGroupBox.Controls.Add(this.outputFrameDurationsCheckBox);
            this.outputGroupBox.Controls.Add(this.outputVersionComboBox);
            this.outputGroupBox.Location = new System.Drawing.Point(219, 13);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(200, 179);
            this.outputGroupBox.TabIndex = 1;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // compileProgressBar
            // 
            this.compileProgressBar.Location = new System.Drawing.Point(7, 113);
            this.compileProgressBar.Name = "compileProgressBar";
            this.compileProgressBar.Size = new System.Drawing.Size(187, 23);
            this.compileProgressBar.TabIndex = 5;
            // 
            // compileButton
            // 
            this.compileButton.Enabled = false;
            this.compileButton.Location = new System.Drawing.Point(7, 142);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(187, 23);
            this.compileButton.TabIndex = 4;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // outputFrameGroupsCheckBox
            // 
            this.outputFrameGroupsCheckBox.AutoSize = true;
            this.outputFrameGroupsCheckBox.Location = new System.Drawing.Point(6, 78);
            this.outputFrameGroupsCheckBox.Name = "outputFrameGroupsCheckBox";
            this.outputFrameGroupsCheckBox.Size = new System.Drawing.Size(92, 17);
            this.outputFrameGroupsCheckBox.TabIndex = 3;
            this.outputFrameGroupsCheckBox.Text = "Frame Groups";
            this.outputFrameGroupsCheckBox.UseVisualStyleBackColor = true;
            // 
            // outputFrameDurationsCheckBox
            // 
            this.outputFrameDurationsCheckBox.AutoSize = true;
            this.outputFrameDurationsCheckBox.Location = new System.Drawing.Point(6, 55);
            this.outputFrameDurationsCheckBox.Name = "outputFrameDurationsCheckBox";
            this.outputFrameDurationsCheckBox.Size = new System.Drawing.Size(103, 17);
            this.outputFrameDurationsCheckBox.TabIndex = 2;
            this.outputFrameDurationsCheckBox.Text = "Frame Durations";
            this.outputFrameDurationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // outputVersionComboBox
            // 
            this.outputVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputVersionComboBox.FormattingEnabled = true;
            this.outputVersionComboBox.Location = new System.Drawing.Point(6, 20);
            this.outputVersionComboBox.Name = "outputVersionComboBox";
            this.outputVersionComboBox.Size = new System.Drawing.Size(187, 21);
            this.outputVersionComboBox.TabIndex = 1;
            this.outputVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputVersionComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 207);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientConverter";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.ComboBox inputVersionComboBox;
        private System.Windows.Forms.ComboBox outputVersionComboBox;
        private System.Windows.Forms.CheckBox inputFrameDurationsCheckBox;
        private System.Windows.Forms.CheckBox outputFrameDurationsCheckBox;
        private System.Windows.Forms.CheckBox inputFrameGroupsCheckBox;
        private System.Windows.Forms.CheckBox outputFrameGroupsCheckBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.ProgressBar loadProgressBar;
        private System.Windows.Forms.ProgressBar compileProgressBar;
    }
}

