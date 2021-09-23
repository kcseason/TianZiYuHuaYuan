namespace TianZiYuHuaYuan
{
    partial class FormPerson
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qulification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Force = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intelligence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Politics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiveStar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SixStar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SevenStar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EightStar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Size = new System.Drawing.Size(884, 561);
            this.splitContainer1.SplitterDistance = 498;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PersonName,
            this.PersonType,
            this.PositionType,
            this.Level,
            this.Qulification,
            this.Properties,
            this.Force,
            this.Intelligence,
            this.Politics,
            this.Command,
            this.FiveStar,
            this.SixStar,
            this.SevenStar,
            this.EightStar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(884, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 25;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "门客";
            this.PersonName.Name = "PersonName";
            this.PersonName.Width = 60;
            // 
            // PersonType
            // 
            this.PersonType.DataPropertyName = "PersonType";
            this.PersonType.HeaderText = "类型";
            this.PersonType.Name = "PersonType";
            this.PersonType.Width = 55;
            // 
            // PositionType
            // 
            this.PositionType.DataPropertyName = "PositionType";
            this.PositionType.HeaderText = "职别";
            this.PositionType.Name = "PositionType";
            this.PositionType.Width = 55;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "等级";
            this.Level.Name = "Level";
            this.Level.Width = 55;
            // 
            // Qulification
            // 
            this.Qulification.DataPropertyName = "Qulification";
            this.Qulification.HeaderText = "资质";
            this.Qulification.Name = "Qulification";
            this.Qulification.Width = 60;
            // 
            // Properties
            // 
            this.Properties.DataPropertyName = "Properties";
            this.Properties.HeaderText = "属性";
            this.Properties.Name = "Properties";
            this.Properties.Width = 60;
            // 
            // Force
            // 
            this.Force.DataPropertyName = "Force";
            this.Force.HeaderText = "武力";
            this.Force.Name = "Force";
            this.Force.Width = 70;
            // 
            // Intelligence
            // 
            this.Intelligence.DataPropertyName = "Intelligence";
            this.Intelligence.HeaderText = "智力";
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Width = 70;
            // 
            // Politics
            // 
            this.Politics.DataPropertyName = "Politics";
            this.Politics.HeaderText = "政治";
            this.Politics.Name = "Politics";
            this.Politics.Width = 70;
            // 
            // Command
            // 
            this.Command.DataPropertyName = "Command";
            this.Command.HeaderText = "统率";
            this.Command.Name = "Command";
            this.Command.Width = 70;
            // 
            // FiveStar
            // 
            this.FiveStar.DataPropertyName = "FiveStar";
            this.FiveStar.HeaderText = "5星";
            this.FiveStar.Name = "FiveStar";
            this.FiveStar.Width = 50;
            // 
            // SixStar
            // 
            this.SixStar.DataPropertyName = "SixStar";
            this.SixStar.HeaderText = "6星";
            this.SixStar.Name = "SixStar";
            this.SixStar.Width = 50;
            // 
            // SevenStar
            // 
            this.SevenStar.DataPropertyName = "SevenStar";
            this.SevenStar.HeaderText = "7星";
            this.SevenStar.Name = "SevenStar";
            this.SevenStar.Width = 50;
            // 
            // EightStar
            // 
            this.EightStar.DataPropertyName = "EightStar";
            this.EightStar.HeaderText = "8星";
            this.EightStar.Name = "EightStar";
            this.EightStar.Width = 50;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(26, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPerson";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPerson";
            this.Load += new System.EventHandler(this.FormPerson_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qulification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Properties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Force;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intelligence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Politics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiveStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SixStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SevenStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EightStar;
        private System.Windows.Forms.Button btn_save;
    }
}