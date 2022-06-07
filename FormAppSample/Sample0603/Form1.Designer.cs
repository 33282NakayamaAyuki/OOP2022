
namespace Sample0603 {
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
            this.btPush = new System.Windows.Forms.Button();
            this.tbSuu1 = new System.Windows.Forms.TextBox();
            this.tbSuu2 = new System.Windows.Forms.TextBox();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox2 = new System.Windows.Forms.Label();
            this.nudSuu1 = new System.Windows.Forms.NumericUpDown();
            this.nudSuu2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAns = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).BeginInit();
            this.SuspendLayout();
            // 
            // btPush
            // 
            this.btPush.BackColor = System.Drawing.Color.Aqua;
            this.btPush.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPush.Location = new System.Drawing.Point(572, 204);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(141, 75);
            this.btPush.TabIndex = 0;
            this.btPush.Text = "計算";
            this.btPush.UseVisualStyleBackColor = false;
            this.btPush.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSuu1
            // 
            this.tbSuu1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSuu1.Location = new System.Drawing.Point(168, 44);
            this.tbSuu1.Name = "tbSuu1";
            this.tbSuu1.Size = new System.Drawing.Size(98, 28);
            this.tbSuu1.TabIndex = 1;
            // 
            // tbSuu2
            // 
            this.tbSuu2.AcceptsReturn = true;
            this.tbSuu2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSuu2.Location = new System.Drawing.Point(340, 44);
            this.tbSuu2.Name = "tbSuu2";
            this.tbSuu2.Size = new System.Drawing.Size(98, 28);
            this.tbSuu2.TabIndex = 1;
            // 
            // tbAns
            // 
            this.tbAns.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAns.Location = new System.Drawing.Point(559, 44);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(98, 28);
            this.tbAns.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(288, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // textbox2
            // 
            this.textbox2.AutoSize = true;
            this.textbox2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textbox2.Location = new System.Drawing.Point(474, 44);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(47, 33);
            this.textbox2.TabIndex = 2;
            this.textbox2.Text = "＝";
            // 
            // nudSuu1
            // 
            this.nudSuu1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSuu1.Location = new System.Drawing.Point(168, 137);
            this.nudSuu1.Name = "nudSuu1";
            this.nudSuu1.Size = new System.Drawing.Size(98, 31);
            this.nudSuu1.TabIndex = 3;
            // 
            // nudSuu2
            // 
            this.nudSuu2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSuu2.Location = new System.Drawing.Point(340, 137);
            this.nudSuu2.Name = "nudSuu2";
            this.nudSuu2.Size = new System.Drawing.Size(98, 31);
            this.nudSuu2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(288, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(474, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "＝";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(559, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 28);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(474, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "＝";
            // 
            // nudAns
            // 
            this.nudAns.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAns.Location = new System.Drawing.Point(559, 140);
            this.nudAns.Name = "nudAns";
            this.nudAns.Size = new System.Drawing.Size(98, 31);
            this.nudAns.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 311);
            this.Controls.Add(this.nudAns);
            this.Controls.Add(this.nudSuu2);
            this.Controls.Add(this.nudSuu1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.tbSuu2);
            this.Controls.Add(this.tbSuu1);
            this.Controls.Add(this.btPush);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.TextBox tbSuu1;
        private System.Windows.Forms.TextBox tbSuu2;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textbox2;
        private System.Windows.Forms.NumericUpDown nudSuu1;
        private System.Windows.Forms.NumericUpDown nudSuu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAns;
    }
}

