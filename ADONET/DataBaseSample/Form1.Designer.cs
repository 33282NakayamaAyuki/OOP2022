﻿
namespace DataBaseSample {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infosys202225DataSet = new DataBaseSample.infosys202225DataSet();
            this.社員BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.社員TableAdapter = new DataBaseSample.infosys202225DataSetTableAdapters.社員TableAdapter();
            this.tableAdapterManager = new DataBaseSample.infosys202225DataSetTableAdapters.TableAdapterManager();
            this.社員BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.社員BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.社員DataGridView = new System.Windows.Forms.DataGridView();
            this.社員番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名前DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入社年月日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.給与DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConnect = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExecute = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202225DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingNavigator)).BeginInit();
            this.社員BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.社員DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infosys202225DataSet
            // 
            this.infosys202225DataSet.DataSetName = "infosys202225DataSet";
            this.infosys202225DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 社員BindingSource
            // 
            this.社員BindingSource.DataMember = "社員";
            this.社員BindingSource.DataSource = this.infosys202225DataSet;
            // 
            // 社員TableAdapter
            // 
            this.社員TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DataBaseSample.infosys202225DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.社員TableAdapter = this.社員TableAdapter;
            // 
            // 社員BindingNavigator
            // 
            this.社員BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.社員BindingNavigator.BindingSource = this.社員BindingSource;
            this.社員BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.社員BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.社員BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.社員BindingNavigatorSaveItem});
            this.社員BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.社員BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.社員BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.社員BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.社員BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.社員BindingNavigator.Name = "社員BindingNavigator";
            this.社員BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.社員BindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.社員BindingNavigator.TabIndex = 0;
            this.社員BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // 社員BindingNavigatorSaveItem
            // 
            this.社員BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.社員BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("社員BindingNavigatorSaveItem.Image")));
            this.社員BindingNavigatorSaveItem.Name = "社員BindingNavigatorSaveItem";
            this.社員BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.社員BindingNavigatorSaveItem.Text = "データの保存";
            this.社員BindingNavigatorSaveItem.Click += new System.EventHandler(this.社員BindingNavigatorSaveItem_Click);
            // 
            // 社員DataGridView
            // 
            this.社員DataGridView.AutoGenerateColumns = false;
            this.社員DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.社員DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.社員番号DataGridViewTextBoxColumn,
            this.名前DataGridViewTextBoxColumn,
            this.入社年月日DataGridViewTextBoxColumn,
            this.給与DataGridViewTextBoxColumn});
            this.社員DataGridView.DataSource = this.社員BindingSource;
            this.社員DataGridView.Location = new System.Drawing.Point(9, 28);
            this.社員DataGridView.Name = "社員DataGridView";
            this.社員DataGridView.RowTemplate.Height = 21;
            this.社員DataGridView.Size = new System.Drawing.Size(779, 331);
            this.社員DataGridView.TabIndex = 1;
            // 
            // 社員番号DataGridViewTextBoxColumn
            // 
            this.社員番号DataGridViewTextBoxColumn.DataPropertyName = "社員番号";
            this.社員番号DataGridViewTextBoxColumn.HeaderText = "社員番号";
            this.社員番号DataGridViewTextBoxColumn.Name = "社員番号DataGridViewTextBoxColumn";
            // 
            // 名前DataGridViewTextBoxColumn
            // 
            this.名前DataGridViewTextBoxColumn.DataPropertyName = "名前";
            this.名前DataGridViewTextBoxColumn.HeaderText = "名前";
            this.名前DataGridViewTextBoxColumn.Name = "名前DataGridViewTextBoxColumn";
            // 
            // 入社年月日DataGridViewTextBoxColumn
            // 
            this.入社年月日DataGridViewTextBoxColumn.DataPropertyName = "入社年月日";
            this.入社年月日DataGridViewTextBoxColumn.HeaderText = "入社年月日";
            this.入社年月日DataGridViewTextBoxColumn.Name = "入社年月日DataGridViewTextBoxColumn";
            // 
            // 給与DataGridViewTextBoxColumn
            // 
            this.給与DataGridViewTextBoxColumn.DataPropertyName = "給与";
            this.給与DataGridViewTextBoxColumn.HeaderText = "給与";
            this.給与DataGridViewTextBoxColumn.Name = "給与DataGridViewTextBoxColumn";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(24, 406);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(122, 71);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(175, 406);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(122, 71);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(357, 428);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(89, 37);
            this.btExecute.TabIndex = 3;
            this.btExecute.Text = "実行";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(486, 437);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 19);
            this.tbValue.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 509);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.社員DataGridView);
            this.Controls.Add(this.社員BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202225DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingNavigator)).EndInit();
            this.社員BindingNavigator.ResumeLayout(false);
            this.社員BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.社員DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202225DataSet infosys202225DataSet;
        private System.Windows.Forms.BindingSource 社員BindingSource;
        private infosys202225DataSetTableAdapters.社員TableAdapter 社員TableAdapter;
        private infosys202225DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 社員BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 社員BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView 社員DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社員番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入社年月日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 給与DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.TextBox tbValue;
    }
}

