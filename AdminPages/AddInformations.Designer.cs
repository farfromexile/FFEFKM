namespace FFEFKM.AdminPages
{
    partial class AddInformations
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_addinformation = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addinfo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deviceStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicestatusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceStatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addinformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 657);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_addinformation);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_addinfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_addinformation
            // 
            this.dgv_addinformation.AutoGenerateColumns = false;
            this.dgv_addinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceIDDataGridViewTextBoxColumn,
            this.deviceNameDataGridViewTextBoxColumn,
            this.deviceLocationDataGridViewTextBoxColumn,
            this.devicestatusidDataGridViewTextBoxColumn,
            this.deviceStatuDataGridViewTextBoxColumn});
            this.dgv_addinformation.DataSource = this.deviceBindingSource;
            this.dgv_addinformation.Location = new System.Drawing.Point(682, 132);
            this.dgv_addinformation.Name = "dgv_addinformation";
            this.dgv_addinformation.Size = new System.Drawing.Size(544, 493);
            this.dgv_addinformation.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_addinfo
            // 
            this.btn_addinfo.Location = new System.Drawing.Point(487, 47);
            this.btn_addinfo.Name = "btn_addinfo";
            this.btn_addinfo.Size = new System.Drawing.Size(75, 23);
            this.btn_addinfo.TabIndex = 1;
            this.btn_addinfo.Text = "Add Device";
            this.btn_addinfo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Controls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deviceStatusBindingSource
            // 
            this.deviceStatusBindingSource.DataSource = typeof(FFEFKM.DeviceStatus);
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(FFEFKM.Device);
            // 
            // deviceIDDataGridViewTextBoxColumn
            // 
            this.deviceIDDataGridViewTextBoxColumn.DataPropertyName = "DeviceID";
            this.deviceIDDataGridViewTextBoxColumn.HeaderText = "DeviceID";
            this.deviceIDDataGridViewTextBoxColumn.Name = "deviceIDDataGridViewTextBoxColumn";
            // 
            // deviceNameDataGridViewTextBoxColumn
            // 
            this.deviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.HeaderText = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.Name = "deviceNameDataGridViewTextBoxColumn";
            // 
            // deviceLocationDataGridViewTextBoxColumn
            // 
            this.deviceLocationDataGridViewTextBoxColumn.DataPropertyName = "DeviceLocation";
            this.deviceLocationDataGridViewTextBoxColumn.HeaderText = "DeviceLocation";
            this.deviceLocationDataGridViewTextBoxColumn.Name = "deviceLocationDataGridViewTextBoxColumn";
            // 
            // devicestatusidDataGridViewTextBoxColumn
            // 
            this.devicestatusidDataGridViewTextBoxColumn.DataPropertyName = "Devicestatusid";
            this.devicestatusidDataGridViewTextBoxColumn.HeaderText = "Devicestatusid";
            this.devicestatusidDataGridViewTextBoxColumn.Name = "devicestatusidDataGridViewTextBoxColumn";
            // 
            // deviceStatuDataGridViewTextBoxColumn
            // 
            this.deviceStatuDataGridViewTextBoxColumn.DataPropertyName = "DeviceStatu";
            this.deviceStatuDataGridViewTextBoxColumn.HeaderText = "DeviceStatu";
            this.deviceStatuDataGridViewTextBoxColumn.Name = "deviceStatuDataGridViewTextBoxColumn";
            // 
            // AddInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddInformations";
            this.Text = "AddInformations";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addinformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_addinfo;
        private System.Windows.Forms.DataGridView dgv_addinformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicestatusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceStatuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.BindingSource deviceStatusBindingSource;
    }
}