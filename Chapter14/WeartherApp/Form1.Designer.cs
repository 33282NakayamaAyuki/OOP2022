
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTodayWeather = new System.Windows.Forms.TextBox();
            this.Office = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTommorowWeather = new System.Windows.Forms.TextBox();
            this.tbDayAfterTommorowWeather = new System.Windows.Forms.TextBox();
            this.registarDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbTommorowWeather = new System.Windows.Forms.PictureBox();
            this.pbDayAfterTommorowWeather = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTommorowWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTommorowWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 2;
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(134, 386);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(590, 137);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "地域";
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
            this.cbPlace.Location = new System.Drawing.Point(134, 19);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(165, 32);
            this.cbPlace.TabIndex = 3;
            this.cbPlace.SelectedIndexChanged += new System.EventHandler(this.cbPlace_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(518, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "記録日：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(518, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "気象局：";
            // 
            // tbTodayWeather
            // 
            this.tbTodayWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTodayWeather.Location = new System.Drawing.Point(129, 148);
            this.tbTodayWeather.Multiline = true;
            this.tbTodayWeather.Name = "tbTodayWeather";
            this.tbTodayWeather.Size = new System.Drawing.Size(170, 64);
            this.tbTodayWeather.TabIndex = 5;
            // 
            // Office
            // 
            this.Office.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Office.Location = new System.Drawing.Point(580, 48);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(171, 23);
            this.Office.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(125, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "今日";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(346, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "１日後";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(557, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "２日後";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "天気概況";
            // 
            // tbTommorowWeather
            // 
            this.tbTommorowWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTommorowWeather.Location = new System.Drawing.Point(350, 148);
            this.tbTommorowWeather.Multiline = true;
            this.tbTommorowWeather.Name = "tbTommorowWeather";
            this.tbTommorowWeather.Size = new System.Drawing.Size(156, 64);
            this.tbTommorowWeather.TabIndex = 5;
            // 
            // tbDayAfterTommorowWeather
            // 
            this.tbDayAfterTommorowWeather.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayAfterTommorowWeather.Location = new System.Drawing.Point(561, 148);
            this.tbDayAfterTommorowWeather.Multiline = true;
            this.tbDayAfterTommorowWeather.Name = "tbDayAfterTommorowWeather";
            this.tbDayAfterTommorowWeather.Size = new System.Drawing.Size(163, 64);
            this.tbDayAfterTommorowWeather.TabIndex = 5;
            // 
            // registarDate
            // 
            this.registarDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registarDate.Location = new System.Drawing.Point(580, 14);
            this.registarDate.Name = "registarDate";
            this.registarDate.Size = new System.Drawing.Size(171, 23);
            this.registarDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(22, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "天気";
            // 
            // pbToday
            // 
            this.pbToday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbToday.Location = new System.Drawing.Point(134, 245);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(165, 90);
            this.pbToday.TabIndex = 6;
            this.pbToday.TabStop = false;
            // 
            // pbTommorowWeather
            // 
            this.pbTommorowWeather.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbTommorowWeather.Location = new System.Drawing.Point(350, 245);
            this.pbTommorowWeather.Name = "pbTommorowWeather";
            this.pbTommorowWeather.Size = new System.Drawing.Size(156, 90);
            this.pbTommorowWeather.TabIndex = 6;
            this.pbTommorowWeather.TabStop = false;
            // 
            // pbDayAfterTommorowWeather
            // 
            this.pbDayAfterTommorowWeather.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbDayAfterTommorowWeather.Location = new System.Drawing.Point(571, 245);
            this.pbDayAfterTommorowWeather.Name = "pbDayAfterTommorowWeather";
            this.pbDayAfterTommorowWeather.Size = new System.Drawing.Size(153, 90);
            this.pbDayAfterTommorowWeather.TabIndex = 6;
            this.pbDayAfterTommorowWeather.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 570);
            this.Controls.Add(this.pbDayAfterTommorowWeather);
            this.Controls.Add(this.pbTommorowWeather);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.registarDate);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.tbDayAfterTommorowWeather);
            this.Controls.Add(this.tbTommorowWeather);
            this.Controls.Add(this.tbTodayWeather);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTommorowWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAfterTommorowWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTodayWeather;
        private System.Windows.Forms.TextBox Office;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTommorowWeather;
        private System.Windows.Forms.TextBox tbDayAfterTommorowWeather;
        private System.Windows.Forms.TextBox registarDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTommorowWeather;
        private System.Windows.Forms.PictureBox pbDayAfterTommorowWeather;
    }
}

