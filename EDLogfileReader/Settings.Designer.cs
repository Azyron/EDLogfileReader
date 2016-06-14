namespace EDLogfileReader
{
    partial class SettingsForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logDirectoryButton = new System.Windows.Forms.Button();
            this.logDirectoryTextBox = new System.Windows.Forms.Label();
            this.DistanceTraveledBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EnableDistanceToSol = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputFileBox = new System.Windows.Forms.TextBox();
            this.outputFileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ShowTraveledSoFarBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowDestinationBox = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(554, 20);
            this.textBox1.TabIndex = 0;
            // 
            // logDirectoryButton
            // 
            this.logDirectoryButton.Location = new System.Drawing.Point(572, 25);
            this.logDirectoryButton.Name = "logDirectoryButton";
            this.logDirectoryButton.Size = new System.Drawing.Size(114, 20);
            this.logDirectoryButton.TabIndex = 1;
            this.logDirectoryButton.Text = "Select …";
            this.logDirectoryButton.UseVisualStyleBackColor = true;
            this.logDirectoryButton.Click += new System.EventHandler(this.onSelectLogPathClick);
            // 
            // logDirectoryTextBox
            // 
            this.logDirectoryTextBox.AutoSize = true;
            this.logDirectoryTextBox.Location = new System.Drawing.Point(9, 9);
            this.logDirectoryTextBox.Name = "logDirectoryTextBox";
            this.logDirectoryTextBox.Size = new System.Drawing.Size(70, 13);
            this.logDirectoryTextBox.TabIndex = 2;
            this.logDirectoryTextBox.Text = "Log Directory";
            this.logDirectoryTextBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // DistanceTraveledBox
            // 
            this.DistanceTraveledBox.Location = new System.Drawing.Point(355, 163);
            this.DistanceTraveledBox.Name = "DistanceTraveledBox";
            this.DistanceTraveledBox.Size = new System.Drawing.Size(156, 20);
            this.DistanceTraveledBox.TabIndex = 3;
            this.DistanceTraveledBox.TextChanged += new System.EventHandler(this.DistanceTraveledBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Distance traveled so far";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(598, 346);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.onSaveClick);
            // 
            // CancelButton2
            // 
            this.CancelButton2.Location = new System.Drawing.Point(504, 346);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(88, 23);
            this.CancelButton2.TabIndex = 6;
            this.CancelButton2.Text = "Cancel";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.onCancel);
            // 
            // DestinationBox
            // 
            this.DestinationBox.Enabled = false;
            this.DestinationBox.Location = new System.Drawing.Point(348, 9);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(261, 20);
            this.DestinationBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(253, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(224, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination coordinates";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(348, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 10;
            // 
            // EnableDistanceToSol
            // 
            this.EnableDistanceToSol.AutoSize = true;
            this.EnableDistanceToSol.Location = new System.Drawing.Point(12, 125);
            this.EnableDistanceToSol.Name = "EnableDistanceToSol";
            this.EnableDistanceToSol.Size = new System.Drawing.Size(126, 17);
            this.EnableDistanceToSol.TabIndex = 13;
            this.EnableDistanceToSol.Text = "Show distance to Sol";
            this.EnableDistanceToSol.UseVisualStyleBackColor = true;
            this.EnableDistanceToSol.CheckStateChanged += new System.EventHandler(this.onEnableDistanceToSolChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "light years";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // outputFileBox
            // 
            this.outputFileBox.Location = new System.Drawing.Point(12, 77);
            this.outputFileBox.Name = "outputFileBox";
            this.outputFileBox.Size = new System.Drawing.Size(554, 20);
            this.outputFileBox.TabIndex = 15;
            // 
            // outputFileName
            // 
            this.outputFileName.AutoSize = true;
            this.outputFileName.Location = new System.Drawing.Point(9, 61);
            this.outputFileName.Name = "outputFileName";
            this.outputFileName.Size = new System.Drawing.Size(94, 13);
            this.outputFileName.TabIndex = 16;
            this.outputFileName.Text = "Textbox output file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "Select …";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onOutputFileButtonClick);
            // 
            // ShowTraveledSoFarBox
            // 
            this.ShowTraveledSoFarBox.AutoSize = true;
            this.ShowTraveledSoFarBox.Location = new System.Drawing.Point(12, 166);
            this.ShowTraveledSoFarBox.Name = "ShowTraveledSoFarBox";
            this.ShowTraveledSoFarBox.Size = new System.Drawing.Size(166, 17);
            this.ShowTraveledSoFarBox.TabIndex = 18;
            this.ShowTraveledSoFarBox.Text = "Show distance traveled so far";
            this.ShowTraveledSoFarBox.UseVisualStyleBackColor = true;
            this.ShowTraveledSoFarBox.CheckedChanged += new System.EventHandler(this.onShowTraveledSoFarBoxChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 34);
            this.panel1.TabIndex = 19;
            // 
            // ShowDestinationBox
            // 
            this.ShowDestinationBox.AutoSize = true;
            this.ShowDestinationBox.Enabled = false;
            this.ShowDestinationBox.Location = new System.Drawing.Point(4, 11);
            this.ShowDestinationBox.Name = "ShowDestinationBox";
            this.ShowDestinationBox.Size = new System.Drawing.Size(150, 17);
            this.ShowDestinationBox.TabIndex = 20;
            this.ShowDestinationBox.Text = "Show destination distance";
            this.ShowDestinationBox.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(437, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(526, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 20);
            this.textBox4.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.ShowDestinationBox);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DestinationBox);
            this.panel2.Location = new System.Drawing.Point(7, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 71);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(7, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 33);
            this.panel3.TabIndex = 24;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show distance to Sol";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.onEnableDistanceToSolChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ShowTraveledSoFarBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputFileName);
            this.Controls.Add(this.outputFileBox);
            this.Controls.Add(this.EnableDistanceToSol);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DistanceTraveledBox);
            this.Controls.Add(this.logDirectoryTextBox);
            this.Controls.Add(this.logDirectoryButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button logDirectoryButton;
        private System.Windows.Forms.Label logDirectoryTextBox;
        private System.Windows.Forms.TextBox DistanceTraveledBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton2;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox EnableDistanceToSol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputFileBox;
        private System.Windows.Forms.Label outputFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox ShowTraveledSoFarBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ShowDestinationBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}