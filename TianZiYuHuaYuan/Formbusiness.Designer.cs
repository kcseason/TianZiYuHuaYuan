namespace TianZiYuHuaYuan
{
    partial class FormBusiness
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
            this.btn_save = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnMoney = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReturnFood = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReturnSoldier = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RemoveFood = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Persons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelSum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAdd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodAdd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldierAdd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelSum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAdd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodAdd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldierAdd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelSum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAdd3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodAdd3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldierAdd3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelSum4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAdd4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodAdd4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldierAdd4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAdd5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodAdd5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldierAdd5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Size = new System.Drawing.Size(884, 561);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BusinessName,
            this.BaseAdd,
            this.AddTime,
            this.BaseSub,
            this.SubTime,
            this.ReturnMoney,
            this.ReturnFood,
            this.ReturnSoldier,
            this.RemoveFood,
            this.Persons,
            this.LevelSum1,
            this.MoneyAdd1,
            this.FoodAdd1,
            this.SoldierAdd1,
            this.LevelSum2,
            this.MoneyAdd2,
            this.FoodAdd2,
            this.SoldierAdd2,
            this.LevelSum3,
            this.MoneyAdd3,
            this.FoodAdd3,
            this.SoldierAdd3,
            this.LevelSum4,
            this.MoneyAdd4,
            this.FoodAdd4,
            this.SoldierAdd4,
            this.Star,
            this.StarSum,
            this.MoneyAdd5,
            this.FoodAdd5,
            this.SoldierAdd5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(884, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(26, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // BusinessName
            // 
            this.BusinessName.DataPropertyName = "BusinessName";
            this.BusinessName.HeaderText = "经营名称";
            this.BusinessName.Name = "BusinessName";
            this.BusinessName.Width = 80;
            // 
            // BaseAdd
            // 
            this.BaseAdd.DataPropertyName = "BaseAdd";
            this.BaseAdd.HeaderText = "生产1";
            this.BaseAdd.Name = "BaseAdd";
            this.BaseAdd.Width = 60;
            // 
            // AddTime
            // 
            this.AddTime.DataPropertyName = "AddTime";
            this.AddTime.HeaderText = "时间1";
            this.AddTime.Name = "AddTime";
            this.AddTime.Width = 60;
            // 
            // BaseSub
            // 
            this.BaseSub.DataPropertyName = "BaseSub";
            this.BaseSub.HeaderText = "生产2";
            this.BaseSub.Name = "BaseSub";
            this.BaseSub.Width = 60;
            // 
            // SubTime
            // 
            this.SubTime.DataPropertyName = "SubTime";
            this.SubTime.HeaderText = "时间2";
            this.SubTime.Name = "SubTime";
            this.SubTime.Width = 60;
            // 
            // ReturnMoney
            // 
            this.ReturnMoney.DataPropertyName = "ReturnMoney";
            this.ReturnMoney.HeaderText = "银两";
            this.ReturnMoney.Name = "ReturnMoney";
            this.ReturnMoney.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnMoney.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReturnMoney.Width = 52;
            // 
            // ReturnFood
            // 
            this.ReturnFood.DataPropertyName = "ReturnFood";
            this.ReturnFood.HeaderText = "粮草";
            this.ReturnFood.Name = "ReturnFood";
            this.ReturnFood.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnFood.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReturnFood.Width = 52;
            // 
            // ReturnSoldier
            // 
            this.ReturnSoldier.DataPropertyName = "ReturnSoldier";
            this.ReturnSoldier.HeaderText = "征兵";
            this.ReturnSoldier.Name = "ReturnSoldier";
            this.ReturnSoldier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnSoldier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReturnSoldier.Width = 52;
            // 
            // RemoveFood
            // 
            this.RemoveFood.DataPropertyName = "RemoveFood";
            this.RemoveFood.HeaderText = "扣粮";
            this.RemoveFood.Name = "RemoveFood";
            this.RemoveFood.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveFood.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RemoveFood.Width = 52;
            // 
            // Persons
            // 
            this.Persons.DataPropertyName = "Persons";
            this.Persons.HeaderText = "驻扎要求";
            this.Persons.Name = "Persons";
            this.Persons.Width = 150;
            // 
            // LevelSum1
            // 
            this.LevelSum1.DataPropertyName = "LevelSum1";
            this.LevelSum1.HeaderText = "条件1";
            this.LevelSum1.Name = "LevelSum1";
            this.LevelSum1.Width = 58;
            // 
            // MoneyAdd1
            // 
            this.MoneyAdd1.DataPropertyName = "MoneyAdd1";
            this.MoneyAdd1.HeaderText = "银";
            this.MoneyAdd1.Name = "MoneyAdd1";
            this.MoneyAdd1.Width = 30;
            // 
            // FoodAdd1
            // 
            this.FoodAdd1.DataPropertyName = "FoodAdd1";
            this.FoodAdd1.HeaderText = "粮";
            this.FoodAdd1.Name = "FoodAdd1";
            this.FoodAdd1.Width = 30;
            // 
            // SoldierAdd1
            // 
            this.SoldierAdd1.DataPropertyName = "SoldierAdd1";
            this.SoldierAdd1.HeaderText = "兵";
            this.SoldierAdd1.Name = "SoldierAdd1";
            this.SoldierAdd1.Width = 30;
            // 
            // LevelSum2
            // 
            this.LevelSum2.DataPropertyName = "LevelSum2";
            this.LevelSum2.HeaderText = "条件2";
            this.LevelSum2.Name = "LevelSum2";
            this.LevelSum2.Width = 58;
            // 
            // MoneyAdd2
            // 
            this.MoneyAdd2.DataPropertyName = "MoneyAdd2";
            this.MoneyAdd2.HeaderText = "银";
            this.MoneyAdd2.Name = "MoneyAdd2";
            this.MoneyAdd2.Width = 30;
            // 
            // FoodAdd2
            // 
            this.FoodAdd2.DataPropertyName = "FoodAdd2";
            this.FoodAdd2.HeaderText = "粮";
            this.FoodAdd2.Name = "FoodAdd2";
            this.FoodAdd2.Width = 30;
            // 
            // SoldierAdd2
            // 
            this.SoldierAdd2.DataPropertyName = "SoldierAdd2";
            this.SoldierAdd2.HeaderText = "兵";
            this.SoldierAdd2.Name = "SoldierAdd2";
            this.SoldierAdd2.Width = 30;
            // 
            // LevelSum3
            // 
            this.LevelSum3.DataPropertyName = "LevelSum3";
            this.LevelSum3.HeaderText = "条件3";
            this.LevelSum3.Name = "LevelSum3";
            this.LevelSum3.Width = 58;
            // 
            // MoneyAdd3
            // 
            this.MoneyAdd3.DataPropertyName = "MoneyAdd3";
            this.MoneyAdd3.HeaderText = "银";
            this.MoneyAdd3.Name = "MoneyAdd3";
            this.MoneyAdd3.Width = 30;
            // 
            // FoodAdd3
            // 
            this.FoodAdd3.DataPropertyName = "FoodAdd3";
            this.FoodAdd3.HeaderText = "粮";
            this.FoodAdd3.Name = "FoodAdd3";
            this.FoodAdd3.Width = 30;
            // 
            // SoldierAdd3
            // 
            this.SoldierAdd3.DataPropertyName = "SoldierAdd3";
            this.SoldierAdd3.HeaderText = "兵";
            this.SoldierAdd3.Name = "SoldierAdd3";
            this.SoldierAdd3.Width = 30;
            // 
            // LevelSum4
            // 
            this.LevelSum4.DataPropertyName = "LevelSum4";
            this.LevelSum4.HeaderText = "条件4";
            this.LevelSum4.Name = "LevelSum4";
            this.LevelSum4.Width = 58;
            // 
            // MoneyAdd4
            // 
            this.MoneyAdd4.DataPropertyName = "MoneyAdd4";
            this.MoneyAdd4.HeaderText = "银";
            this.MoneyAdd4.Name = "MoneyAdd4";
            this.MoneyAdd4.Width = 30;
            // 
            // FoodAdd4
            // 
            this.FoodAdd4.DataPropertyName = "FoodAdd4";
            this.FoodAdd4.HeaderText = "粮";
            this.FoodAdd4.Name = "FoodAdd4";
            this.FoodAdd4.Width = 30;
            // 
            // SoldierAdd4
            // 
            this.SoldierAdd4.DataPropertyName = "SoldierAdd4";
            this.SoldierAdd4.HeaderText = "兵";
            this.SoldierAdd4.Name = "SoldierAdd4";
            this.SoldierAdd4.Width = 30;
            // 
            // Star
            // 
            this.Star.DataPropertyName = "Star";
            this.Star.HeaderText = "星级";
            this.Star.Name = "Star";
            this.Star.Width = 52;
            // 
            // StarSum
            // 
            this.StarSum.DataPropertyName = "StarSum";
            this.StarSum.HeaderText = "数量";
            this.StarSum.Name = "StarSum";
            this.StarSum.Width = 52;
            // 
            // MoneyAdd5
            // 
            this.MoneyAdd5.DataPropertyName = "MoneyAdd5";
            this.MoneyAdd5.HeaderText = "银";
            this.MoneyAdd5.Name = "MoneyAdd5";
            this.MoneyAdd5.Width = 30;
            // 
            // FoodAdd5
            // 
            this.FoodAdd5.DataPropertyName = "FoodAdd5";
            this.FoodAdd5.HeaderText = "粮";
            this.FoodAdd5.Name = "FoodAdd5";
            this.FoodAdd5.Width = 30;
            // 
            // SoldierAdd5
            // 
            this.SoldierAdd5.DataPropertyName = "SoldierAdd5";
            this.SoldierAdd5.HeaderText = "兵";
            this.SoldierAdd5.Name = "SoldierAdd5";
            this.SoldierAdd5.Width = 30;
            // 
            // FormBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormBusiness";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formbusiness";
            this.Load += new System.EventHandler(this.FormBusiness_Load);
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
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReturnMoney;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReturnFood;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReturnSoldier;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RemoveFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persons;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelSum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAdd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodAdd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldierAdd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelSum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAdd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodAdd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldierAdd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelSum3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAdd3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodAdd3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldierAdd3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelSum4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAdd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodAdd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldierAdd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Star;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAdd5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodAdd5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldierAdd5;
    }
}