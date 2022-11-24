
namespace WeartherApp {
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
            this.label104 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbTommorowWeather = new System.Windows.Forms.PictureBox();
            this.pbDayAfterTommorowWeather = new System.Windows.Forms.PictureBox();
            this.label106 = new System.Windows.Forms.Label();
            this.weatherInfo = new System.Windows.Forms.Label();
            this.registarDate = new System.Windows.Forms.Label();
            this.office = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbTodayMax = new System.Windows.Forms.Label();
            this.lbTodayMin = new System.Windows.Forms.Label();
            this.lbTomorrowMax = new System.Windows.Forms.Label();
            this.lbTomorrowMin = new System.Windows.Forms.Label();
            this.lbDayAfterTomorrowMax = new System.Windows.Forms.Label();
            this.lbDayAfterTomorrowMin = new System.Windows.Forms.Label();
            this.lbTodayWeather = new System.Windows.Forms.Label();
            this.lbTommorowWeather = new System.Windows.Forms.Label();
            this.lbDayAfterTommorowWeather = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTommorowWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTommorowWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.BackColor = System.Drawing.Color.Transparent;
            this.label104.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label104.ForeColor = System.Drawing.Color.Yellow;
            this.label104.Location = new System.Drawing.Point(39, 159);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(0, 24);
            this.label104.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(107, -186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "天気概況";
            // 
            // cbPlace
            // 
            this.cbPlace.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "網走・北見・紋別地方",
            "十勝地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "三重県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "山口県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "奄美地方",
            "鹿児島県（奄美地方除く）",
            "沖縄本島地方",
            "大東島地方",
            "宮古島地方",
            "八重山地方"});
            this.cbPlace.Location = new System.Drawing.Point(129, 35);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(282, 32);
            this.cbPlace.TabIndex = 3;
            this.cbPlace.SelectedIndexChanged += new System.EventHandler(this.cbPlace_SelectedIndexChanged);
            // 
            // label101
            // 
            this.label101.BackColor = System.Drawing.Color.Transparent;
            this.label101.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label101.ForeColor = System.Drawing.Color.Yellow;
            this.label101.Location = new System.Drawing.Point(125, 115);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(58, 24);
            this.label101.TabIndex = 2;
            // 
            // label102
            // 
            this.label102.BackColor = System.Drawing.Color.Transparent;
            this.label102.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label102.ForeColor = System.Drawing.Color.Yellow;
            this.label102.Location = new System.Drawing.Point(355, 115);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(74, 24);
            this.label102.TabIndex = 2;
            // 
            // label103
            // 
            this.label103.BackColor = System.Drawing.Color.Transparent;
            this.label103.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label103.ForeColor = System.Drawing.Color.Yellow;
            this.label103.Location = new System.Drawing.Point(557, 115);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(74, 24);
            this.label103.TabIndex = 2;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.BackColor = System.Drawing.Color.Transparent;
            this.label105.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label105.ForeColor = System.Drawing.Color.Red;
            this.label105.Location = new System.Drawing.Point(12, 389);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(0, 24);
            this.label105.TabIndex = 2;
            // 
            // pbToday
            // 
            this.pbToday.BackColor = System.Drawing.Color.Transparent;
            this.pbToday.Location = new System.Drawing.Point(129, 245);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(153, 90);
            this.pbToday.TabIndex = 6;
            this.pbToday.TabStop = false;
            // 
            // pbTommorowWeather
            // 
            this.pbTommorowWeather.BackColor = System.Drawing.Color.Transparent;
            this.pbTommorowWeather.Location = new System.Drawing.Point(359, 245);
            this.pbTommorowWeather.Name = "pbTommorowWeather";
            this.pbTommorowWeather.Size = new System.Drawing.Size(156, 90);
            this.pbTommorowWeather.TabIndex = 6;
            this.pbTommorowWeather.TabStop = false;
            // 
            // pbDayAfterTommorowWeather
            // 
            this.pbDayAfterTommorowWeather.BackColor = System.Drawing.Color.Transparent;
            this.pbDayAfterTommorowWeather.Location = new System.Drawing.Point(571, 245);
            this.pbDayAfterTommorowWeather.Name = "pbDayAfterTommorowWeather";
            this.pbDayAfterTommorowWeather.Size = new System.Drawing.Size(153, 90);
            this.pbDayAfterTommorowWeather.TabIndex = 6;
            this.pbDayAfterTommorowWeather.TabStop = false;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.BackColor = System.Drawing.Color.Transparent;
            this.label106.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label106.ForeColor = System.Drawing.Color.Blue;
            this.label106.Location = new System.Drawing.Point(12, 441);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(0, 24);
            this.label106.TabIndex = 2;
            // 
            // weatherInfo
            // 
            this.weatherInfo.BackColor = System.Drawing.Color.Transparent;
            this.weatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weatherInfo.Location = new System.Drawing.Point(744, 87);
            this.weatherInfo.Name = "weatherInfo";
            this.weatherInfo.Size = new System.Drawing.Size(420, 390);
            this.weatherInfo.TabIndex = 7;
            // 
            // registarDate
            // 
            this.registarDate.BackColor = System.Drawing.Color.Transparent;
            this.registarDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registarDate.Location = new System.Drawing.Point(808, 38);
            this.registarDate.Name = "registarDate";
            this.registarDate.Size = new System.Drawing.Size(356, 32);
            this.registarDate.TabIndex = 8;
            // 
            // office
            // 
            this.office.BackColor = System.Drawing.Color.Transparent;
            this.office.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.office.Location = new System.Drawing.Point(502, 38);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(257, 32);
            this.office.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(39, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 24);
            this.label.TabIndex = 2;
            this.label.Text = "地域";
            // 
            // lbTodayMax
            // 
            this.lbTodayMax.BackColor = System.Drawing.Color.Transparent;
            this.lbTodayMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayMax.ForeColor = System.Drawing.Color.Red;
            this.lbTodayMax.Location = new System.Drawing.Point(246, 390);
            this.lbTodayMax.Name = "lbTodayMax";
            this.lbTodayMax.Size = new System.Drawing.Size(65, 23);
            this.lbTodayMax.TabIndex = 10;
            // 
            // lbTodayMin
            // 
            this.lbTodayMin.BackColor = System.Drawing.Color.Transparent;
            this.lbTodayMin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayMin.ForeColor = System.Drawing.Color.Blue;
            this.lbTodayMin.Location = new System.Drawing.Point(250, 442);
            this.lbTodayMin.Name = "lbTodayMin";
            this.lbTodayMin.Size = new System.Drawing.Size(61, 23);
            this.lbTodayMin.TabIndex = 10;
            // 
            // lbTomorrowMax
            // 
            this.lbTomorrowMax.BackColor = System.Drawing.Color.Transparent;
            this.lbTomorrowMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrowMax.ForeColor = System.Drawing.Color.Red;
            this.lbTomorrowMax.Location = new System.Drawing.Point(451, 390);
            this.lbTomorrowMax.Name = "lbTomorrowMax";
            this.lbTomorrowMax.Size = new System.Drawing.Size(72, 23);
            this.lbTomorrowMax.TabIndex = 10;
            // 
            // lbTomorrowMin
            // 
            this.lbTomorrowMin.BackColor = System.Drawing.Color.Transparent;
            this.lbTomorrowMin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTomorrowMin.ForeColor = System.Drawing.Color.Blue;
            this.lbTomorrowMin.Location = new System.Drawing.Point(455, 441);
            this.lbTomorrowMin.Name = "lbTomorrowMin";
            this.lbTomorrowMin.Size = new System.Drawing.Size(68, 23);
            this.lbTomorrowMin.TabIndex = 10;
            // 
            // lbDayAfterTomorrowMax
            // 
            this.lbDayAfterTomorrowMax.BackColor = System.Drawing.Color.Transparent;
            this.lbDayAfterTomorrowMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayAfterTomorrowMax.ForeColor = System.Drawing.Color.Red;
            this.lbDayAfterTomorrowMax.Location = new System.Drawing.Point(662, 390);
            this.lbDayAfterTomorrowMax.Name = "lbDayAfterTomorrowMax";
            this.lbDayAfterTomorrowMax.Size = new System.Drawing.Size(76, 23);
            this.lbDayAfterTomorrowMax.TabIndex = 10;
            // 
            // lbDayAfterTomorrowMin
            // 
            this.lbDayAfterTomorrowMin.BackColor = System.Drawing.Color.Transparent;
            this.lbDayAfterTomorrowMin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayAfterTomorrowMin.ForeColor = System.Drawing.Color.Blue;
            this.lbDayAfterTomorrowMin.Location = new System.Drawing.Point(666, 441);
            this.lbDayAfterTomorrowMin.Name = "lbDayAfterTomorrowMin";
            this.lbDayAfterTomorrowMin.Size = new System.Drawing.Size(72, 23);
            this.lbDayAfterTomorrowMin.TabIndex = 10;
            // 
            // lbTodayWeather
            // 
            this.lbTodayWeather.BackColor = System.Drawing.Color.Transparent;
            this.lbTodayWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTodayWeather.Location = new System.Drawing.Point(125, 159);
            this.lbTodayWeather.Name = "lbTodayWeather";
            this.lbTodayWeather.Size = new System.Drawing.Size(155, 64);
            this.lbTodayWeather.TabIndex = 11;
            // 
            // lbTommorowWeather
            // 
            this.lbTommorowWeather.BackColor = System.Drawing.Color.Transparent;
            this.lbTommorowWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTommorowWeather.Location = new System.Drawing.Point(365, 159);
            this.lbTommorowWeather.Name = "lbTommorowWeather";
            this.lbTommorowWeather.Size = new System.Drawing.Size(158, 64);
            this.lbTommorowWeather.TabIndex = 11;
            // 
            // lbDayAfterTommorowWeather
            // 
            this.lbDayAfterTommorowWeather.BackColor = System.Drawing.Color.Transparent;
            this.lbDayAfterTommorowWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayAfterTommorowWeather.Location = new System.Drawing.Point(569, 164);
            this.lbDayAfterTommorowWeather.Name = "lbDayAfterTommorowWeather";
            this.lbDayAfterTommorowWeather.Size = new System.Drawing.Size(155, 64);
            this.lbDayAfterTommorowWeather.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeartherApp.Properties.Resources.tennki;
            this.ClientSize = new System.Drawing.Size(1176, 486);
            this.Controls.Add(this.lbDayAfterTommorowWeather);
            this.Controls.Add(this.lbTommorowWeather);
            this.Controls.Add(this.lbTodayWeather);
            this.Controls.Add(this.lbTodayMin);
            this.Controls.Add(this.lbTomorrowMin);
            this.Controls.Add(this.lbDayAfterTomorrowMin);
            this.Controls.Add(this.lbDayAfterTomorrowMax);
            this.Controls.Add(this.lbTomorrowMax);
            this.Controls.Add(this.lbTodayMax);
            this.Controls.Add(this.office);
            this.Controls.Add(this.registarDate);
            this.Controls.Add(this.weatherInfo);
            this.Controls.Add(this.pbDayAfterTommorowWeather);
            this.Controls.Add(this.pbTommorowWeather);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.label105);
            this.Controls.Add(this.label101);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTommorowWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTommorowWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTommorowWeather;
        private System.Windows.Forms.PictureBox pbDayAfterTommorowWeather;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label weatherInfo;
        private System.Windows.Forms.Label registarDate;
        private System.Windows.Forms.Label office;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbTodayMax;
        private System.Windows.Forms.Label lbTodayMin;
        private System.Windows.Forms.Label lbTomorrowMax;
        private System.Windows.Forms.Label lbTomorrowMin;
        private System.Windows.Forms.Label lbDayAfterTomorrowMax;
        private System.Windows.Forms.Label lbDayAfterTomorrowMin;
        private System.Windows.Forms.Label lbTodayWeather;
        private System.Windows.Forms.Label lbTommorowWeather;
        private System.Windows.Forms.Label lbDayAfterTommorowWeather;
    }
}

