
namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbReporter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.dtpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDataGridView = new System.Windows.Forms.DataGridView();
            this.btOpenArticle = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btOpenPicture = new System.Windows.Forms.Button();
            this.btDeletePicture = new System.Windows.Forms.Button();
            this.btAddArticle = new System.Windows.Forms.Button();
            this.btReviseArticle = new System.Windows.Forms.Button();
            this.btDeleteArticle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btFinish = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbOutsideCar = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.sfdSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.設定ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColorDialog = new System.Windows.Forms.ColorDialog();
            this.btChangeLarge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbReporter
            // 
            this.cbReporter.FormattingEnabled = true;
            this.cbReporter.Location = new System.Drawing.Point(132, 62);
            this.cbReporter.Name = "cbReporter";
            this.cbReporter.Size = new System.Drawing.Size(215, 20);
            this.cbReporter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "車名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "メーカー：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "記録者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "日付：";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(132, 124);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(215, 20);
            this.cbCarName.TabIndex = 0;
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPicture.Location = new System.Drawing.Point(565, 62);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(187, 151);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPicture.TabIndex = 2;
            this.pbPicture.TabStop = false;
            // 
            // dtpDateTimePicker
            // 
            this.dtpDateTimePicker.Location = new System.Drawing.Point(132, 34);
            this.dtpDateTimePicker.Name = "dtpDateTimePicker";
            this.dtpDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dtpDateTimePicker.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "記事一覧：";
            // 
            // dgvDataGridView
            // 
            this.dgvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGridView.Location = new System.Drawing.Point(132, 268);
            this.dgvDataGridView.Name = "dgvDataGridView";
            this.dgvDataGridView.RowTemplate.Height = 21;
            this.dgvDataGridView.Size = new System.Drawing.Size(634, 150);
            this.dgvDataGridView.TabIndex = 5;
            // 
            // btOpenArticle
            // 
            this.btOpenArticle.Location = new System.Drawing.Point(32, 315);
            this.btOpenArticle.Name = "btOpenArticle";
            this.btOpenArticle.Size = new System.Drawing.Size(75, 23);
            this.btOpenArticle.TabIndex = 6;
            this.btOpenArticle.Text = "開く...";
            this.btOpenArticle.UseVisualStyleBackColor = true;
            this.btOpenArticle.Click += new System.EventHandler(this.btOpenArticle_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(32, 362);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "画像：";
            // 
            // btOpenPicture
            // 
            this.btOpenPicture.Location = new System.Drawing.Point(604, 27);
            this.btOpenPicture.Name = "btOpenPicture";
            this.btOpenPicture.Size = new System.Drawing.Size(59, 23);
            this.btOpenPicture.TabIndex = 6;
            this.btOpenPicture.Text = "開く...";
            this.btOpenPicture.UseVisualStyleBackColor = true;
            this.btOpenPicture.Click += new System.EventHandler(this.btOpenPicture_Click);
            // 
            // btDeletePicture
            // 
            this.btDeletePicture.Location = new System.Drawing.Point(669, 27);
            this.btDeletePicture.Name = "btDeletePicture";
            this.btDeletePicture.Size = new System.Drawing.Size(59, 23);
            this.btDeletePicture.TabIndex = 6;
            this.btDeletePicture.Text = "削除";
            this.btDeletePicture.UseVisualStyleBackColor = true;
            this.btDeletePicture.Click += new System.EventHandler(this.btDeletePicture_Click);
            // 
            // btAddArticle
            // 
            this.btAddArticle.Location = new System.Drawing.Point(546, 227);
            this.btAddArticle.Name = "btAddArticle";
            this.btAddArticle.Size = new System.Drawing.Size(59, 23);
            this.btAddArticle.TabIndex = 6;
            this.btAddArticle.Text = "追加";
            this.btAddArticle.UseVisualStyleBackColor = true;
            this.btAddArticle.Click += new System.EventHandler(this.btAddArticle_Click);
            // 
            // btReviseArticle
            // 
            this.btReviseArticle.Enabled = false;
            this.btReviseArticle.Location = new System.Drawing.Point(617, 227);
            this.btReviseArticle.Name = "btReviseArticle";
            this.btReviseArticle.Size = new System.Drawing.Size(59, 23);
            this.btReviseArticle.TabIndex = 6;
            this.btReviseArticle.Text = "修正";
            this.btReviseArticle.UseVisualStyleBackColor = true;
            this.btReviseArticle.Click += new System.EventHandler(this.btReviseArticle_Click);
            // 
            // btDeleteArticle
            // 
            this.btDeleteArticle.Enabled = false;
            this.btDeleteArticle.Location = new System.Drawing.Point(693, 227);
            this.btDeleteArticle.Name = "btDeleteArticle";
            this.btDeleteArticle.Size = new System.Drawing.Size(59, 23);
            this.btDeleteArticle.TabIndex = 6;
            this.btDeleteArticle.Text = "削除";
            this.btDeleteArticle.UseVisualStyleBackColor = true;
            this.btDeleteArticle.Click += new System.EventHandler(this.btDeleteArticle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "レポート：";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(130, 163);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(397, 87);
            this.tbAddress.TabIndex = 7;
            // 
            // btFinish
            // 
            this.btFinish.Location = new System.Drawing.Point(669, 424);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(97, 23);
            this.btFinish.TabIndex = 6;
            this.btFinish.Text = "終了";
            this.btFinish.UseVisualStyleBackColor = true;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(132, 95);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 8;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(185, 95);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 8;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(238, 95);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 8;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(291, 95);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 8;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbOutsideCar
            // 
            this.rbOutsideCar.AutoSize = true;
            this.rbOutsideCar.Location = new System.Drawing.Point(344, 95);
            this.rbOutsideCar.Name = "rbOutsideCar";
            this.rbOutsideCar.Size = new System.Drawing.Size(59, 16);
            this.rbOutsideCar.TabIndex = 8;
            this.rbOutsideCar.TabStop = true;
            this.rbOutsideCar.Text = "外国車";
            this.rbOutsideCar.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(407, 95);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 8;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator2,
            this.設定ToolStripMenuItem1,
            this.toolStripSeparator1,
            this.終了ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.設定ToolStripMenuItem.Text = "ファイル";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.開くToolStripMenuItem.Text = "開く...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.btOpenArticle_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.保存ToolStripMenuItem.Text = "保存...";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.btSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(107, 6);
            // 
            // 設定ToolStripMenuItem1
            // 
            this.設定ToolStripMenuItem1.Name = "設定ToolStripMenuItem1";
            this.設定ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.設定ToolStripMenuItem1.Text = "色設定";
            this.設定ToolStripMenuItem1.Click += new System.EventHandler(this.設定ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // btChangeLarge
            // 
            this.btChangeLarge.Location = new System.Drawing.Point(734, 27);
            this.btChangeLarge.Name = "btChangeLarge";
            this.btChangeLarge.Size = new System.Drawing.Size(32, 24);
            this.btChangeLarge.TabIndex = 10;
            this.btChangeLarge.Text = "★";
            this.btChangeLarge.UseVisualStyleBackColor = true;
            this.btChangeLarge.Click += new System.EventHandler(this.btChangeLarge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChangeLarge);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbOutsideCar);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToyota);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDeletePicture);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.btDeleteArticle);
            this.Controls.Add(this.btReviseArticle);
            this.Controls.Add(this.btAddArticle);
            this.Controls.Add(this.btOpenPicture);
            this.Controls.Add(this.btOpenArticle);
            this.Controls.Add(this.dgvDataGridView);
            this.Controls.Add(this.dtpDateTimePicker);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbReporter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "車一覧";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbReporter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.DateTimePicker dtpDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDataGridView;
        private System.Windows.Forms.Button btOpenArticle;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOpenPicture;
        private System.Windows.Forms.Button btDeletePicture;
        private System.Windows.Forms.Button btAddArticle;
        private System.Windows.Forms.Button btReviseArticle;
        private System.Windows.Forms.Button btDeleteArticle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbOutsideCar;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.SaveFileDialog sfdSaveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog cdColorDialog;
        private System.Windows.Forms.Button btChangeLarge;
    }
}

