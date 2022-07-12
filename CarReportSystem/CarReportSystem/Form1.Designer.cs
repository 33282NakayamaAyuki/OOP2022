
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
            this.cbToyota = new System.Windows.Forms.CheckBox();
            this.cbNissan = new System.Windows.Forms.CheckBox();
            this.cbHonda = new System.Windows.Forms.CheckBox();
            this.cbSubaru = new System.Windows.Forms.CheckBox();
            this.cbOutsideCar = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).BeginInit();
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
            this.pbPicture.Location = new System.Drawing.Point(565, 48);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(187, 151);
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
            // cbToyota
            // 
            this.cbToyota.AutoSize = true;
            this.cbToyota.Location = new System.Drawing.Point(132, 95);
            this.cbToyota.Name = "cbToyota";
            this.cbToyota.Size = new System.Drawing.Size(48, 16);
            this.cbToyota.TabIndex = 4;
            this.cbToyota.Text = "トヨタ";
            this.cbToyota.UseVisualStyleBackColor = true;
            // 
            // cbNissan
            // 
            this.cbNissan.AutoSize = true;
            this.cbNissan.Location = new System.Drawing.Point(184, 95);
            this.cbNissan.Name = "cbNissan";
            this.cbNissan.Size = new System.Drawing.Size(48, 16);
            this.cbNissan.TabIndex = 4;
            this.cbNissan.Text = "日産";
            this.cbNissan.UseVisualStyleBackColor = true;
            // 
            // cbHonda
            // 
            this.cbHonda.AutoSize = true;
            this.cbHonda.Location = new System.Drawing.Point(236, 95);
            this.cbHonda.Name = "cbHonda";
            this.cbHonda.Size = new System.Drawing.Size(52, 16);
            this.cbHonda.TabIndex = 4;
            this.cbHonda.Text = "ホンダ";
            this.cbHonda.UseVisualStyleBackColor = true;
            // 
            // cbSubaru
            // 
            this.cbSubaru.AutoSize = true;
            this.cbSubaru.Location = new System.Drawing.Point(292, 95);
            this.cbSubaru.Name = "cbSubaru";
            this.cbSubaru.Size = new System.Drawing.Size(53, 16);
            this.cbSubaru.TabIndex = 4;
            this.cbSubaru.Text = "スバル";
            this.cbSubaru.UseVisualStyleBackColor = true;
            // 
            // cbOutsideCar
            // 
            this.cbOutsideCar.AutoSize = true;
            this.cbOutsideCar.Location = new System.Drawing.Point(349, 95);
            this.cbOutsideCar.Name = "cbOutsideCar";
            this.cbOutsideCar.Size = new System.Drawing.Size(60, 16);
            this.cbOutsideCar.TabIndex = 4;
            this.cbOutsideCar.Text = "外国車";
            this.cbOutsideCar.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(413, 95);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(55, 16);
            this.cbOther.TabIndex = 4;
            this.cbOther.Text = "その他";
            this.cbOther.UseVisualStyleBackColor = true;
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
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(32, 362);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "画像：";
            // 
            // btOpenPicture
            // 
            this.btOpenPicture.Location = new System.Drawing.Point(612, 13);
            this.btOpenPicture.Name = "btOpenPicture";
            this.btOpenPicture.Size = new System.Drawing.Size(59, 23);
            this.btOpenPicture.TabIndex = 6;
            this.btOpenPicture.Text = "開く...";
            this.btOpenPicture.UseVisualStyleBackColor = true;
            this.btOpenPicture.Click += new System.EventHandler(this.btOpenPicture_Click);
            // 
            // btDeletePicture
            // 
            this.btDeletePicture.Location = new System.Drawing.Point(693, 13);
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
            this.btReviseArticle.Location = new System.Drawing.Point(617, 227);
            this.btReviseArticle.Name = "btReviseArticle";
            this.btReviseArticle.Size = new System.Drawing.Size(59, 23);
            this.btReviseArticle.TabIndex = 6;
            this.btReviseArticle.Text = "修正";
            this.btReviseArticle.UseVisualStyleBackColor = true;
            // 
            // btDeleteArticle
            // 
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbOutsideCar);
            this.Controls.Add(this.cbSubaru);
            this.Controls.Add(this.cbHonda);
            this.Controls.Add(this.cbNissan);
            this.Controls.Add(this.cbToyota);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView)).EndInit();
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
        private System.Windows.Forms.CheckBox cbToyota;
        private System.Windows.Forms.CheckBox cbNissan;
        private System.Windows.Forms.CheckBox cbHonda;
        private System.Windows.Forms.CheckBox cbSubaru;
        private System.Windows.Forms.CheckBox cbOutsideCar;
        private System.Windows.Forms.CheckBox cbOther;
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
    }
}

