namespace Laba
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetLoc = new System.Windows.Forms.Button();
            this.buttonSetTepl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeLoc = new System.Windows.Forms.PictureBox();
            this.buttonTakeLoc = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(761, 543);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetLoc
            // 
            this.buttonSetLoc.Location = new System.Drawing.Point(762, 177);
            this.buttonSetLoc.Name = "buttonSetLoc";
            this.buttonSetLoc.Size = new System.Drawing.Size(218, 56);
            this.buttonSetLoc.TabIndex = 1;
            this.buttonSetLoc.Text = "Припарковать локомотив";
            this.buttonSetLoc.UseVisualStyleBackColor = true;
            this.buttonSetLoc.Click += new System.EventHandler(this.buttonSetLoc_Click);
            // 
            // buttonSetTepl
            // 
            this.buttonSetTepl.Location = new System.Drawing.Point(762, 239);
            this.buttonSetTepl.Name = "buttonSetTepl";
            this.buttonSetTepl.Size = new System.Drawing.Size(218, 49);
            this.buttonSetTepl.TabIndex = 2;
            this.buttonSetTepl.Text = "Припарковать тепловоз";
            this.buttonSetTepl.UseVisualStyleBackColor = true;
            this.buttonSetTepl.Click += new System.EventHandler(this.buttonSetTepl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxTakeLoc);
            this.groupBox2.Controls.Add(this.buttonTakeLoc);
            this.groupBox2.Controls.Add(this.maskedTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(762, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Забрать локомотив";
            // 
            // pictureBoxTakeLoc
            // 
            this.pictureBoxTakeLoc.Location = new System.Drawing.Point(1, 81);
            this.pictureBoxTakeLoc.Name = "pictureBoxTakeLoc";
            this.pictureBoxTakeLoc.Size = new System.Drawing.Size(222, 165);
            this.pictureBoxTakeLoc.TabIndex = 3;
            this.pictureBoxTakeLoc.TabStop = false;
            // 
            // buttonTakeLoc
            // 
            this.buttonTakeLoc.Location = new System.Drawing.Point(54, 49);
            this.buttonTakeLoc.Name = "buttonTakeLoc";
            this.buttonTakeLoc.Size = new System.Drawing.Size(110, 30);
            this.buttonTakeLoc.TabIndex = 2;
            this.buttonTakeLoc.Text = "Забрать";
            this.buttonTakeLoc.UseVisualStyleBackColor = true;
            this.buttonTakeLoc.Click += new System.EventHandler(this.buttonTakeLoc_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(88, 21);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(117, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Место";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ульяновское ДЕПО";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(762, 18);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(218, 148);
            this.listBoxLevels.TabIndex = 5;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormParking
            // 
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSetTepl);
            this.Controls.Add(this.buttonSetLoc);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetLoc;
        private System.Windows.Forms.Button buttonSetTepl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxTakeLoc;
        private System.Windows.Forms.Button buttonTakeLoc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}