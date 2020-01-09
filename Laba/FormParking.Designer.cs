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
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeLoc = new System.Windows.Forms.PictureBox();
            this.buttonTakeLoc = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetLoc = new System.Windows.Forms.Button();
            this.menuStripSave = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLoc)).BeginInit();
            this.menuStripSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(761, 515);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Controls.Add(this.pictureBoxTakeLoc);
            this.groupBoxTake.Controls.Add(this.buttonTakeLoc);
            this.groupBoxTake.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTake.Controls.Add(this.labelPlace);
            this.groupBoxTake.Location = new System.Drawing.Point(762, 296);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(223, 246);
            this.groupBoxTake.TabIndex = 3;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Забрать локомотив";
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
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(88, 21);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(117, 22);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(20, 26);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(49, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(356, 464);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(138, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Ульяновское ДЕПО";
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
            // buttonSetLoc
            // 
            this.buttonSetLoc.Location = new System.Drawing.Point(796, 189);
            this.buttonSetLoc.Name = "buttonSetLoc";
            this.buttonSetLoc.Size = new System.Drawing.Size(139, 48);
            this.buttonSetLoc.TabIndex = 6;
            this.buttonSetLoc.Text = "Заказать";
            this.buttonSetLoc.UseVisualStyleBackColor = true;
            this.buttonSetLoc.Click += new System.EventHandler(this.buttonSetLoc_Click);
            // 
            // menuStripSave
            // 
            this.menuStripSave.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripSave.Location = new System.Drawing.Point(0, 0);
            this.menuStripSave.Name = "menuStripSave";
            this.menuStripSave.Size = new System.Drawing.Size(979, 28);
            this.menuStripSave.TabIndex = 7;
            this.menuStripSave.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(796, 255);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(129, 23);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormParking
            // 
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSetLoc);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStripSave);
            this.MainMenuStrip = this.menuStripSave;
            this.Name = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeLoc)).EndInit();
            this.menuStripSave.ResumeLayout(false);
            this.menuStripSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.PictureBox pictureBoxTakeLoc;
        private System.Windows.Forms.Button buttonTakeLoc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonSetLoc;
        private System.Windows.Forms.MenuStrip menuStripSave;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}