namespace TianZiYuHuaYuan
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuBaseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.银两优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.征兵优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粮食优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平衡优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.载入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tl_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_money = new System.Windows.Forms.TabPage();
            this.dv_money = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_soldier = new System.Windows.Forms.TabPage();
            this.dv_soldier = new System.Windows.Forms.DataGridView();
            this.businessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_food = new System.Windows.Forms.TabPage();
            this.tab_average = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lb_soldier = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_food = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_money.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_money)).BeginInit();
            this.tab_soldier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_soldier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBaseInfo,
            this.计算ToolStripMenuItem,
            this.数据ToolStripMenuItem,
            this.tl_cancel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuBaseInfo
            // 
            this.MenuBaseInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPerson,
            this.MenuBusiness});
            this.MenuBaseInfo.Name = "MenuBaseInfo";
            this.MenuBaseInfo.Size = new System.Drawing.Size(68, 21);
            this.MenuBaseInfo.Text = "基础信息";
            // 
            // MenuPerson
            // 
            this.MenuPerson.Name = "MenuPerson";
            this.MenuPerson.Size = new System.Drawing.Size(100, 22);
            this.MenuPerson.Text = "门客";
            this.MenuPerson.Click += new System.EventHandler(this.MenuPerson_Click);
            // 
            // MenuBusiness
            // 
            this.MenuBusiness.Name = "MenuBusiness";
            this.MenuBusiness.Size = new System.Drawing.Size(100, 22);
            this.MenuBusiness.Text = "经营";
            this.MenuBusiness.Click += new System.EventHandler(this.MenuBusiness_Click);
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.银两优先ToolStripMenuItem,
            this.征兵优先ToolStripMenuItem,
            this.粮食优先ToolStripMenuItem,
            this.平衡优先ToolStripMenuItem});
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.计算ToolStripMenuItem.Text = "计算结果";
            // 
            // 银两优先ToolStripMenuItem
            // 
            this.银两优先ToolStripMenuItem.Name = "银两优先ToolStripMenuItem";
            this.银两优先ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.银两优先ToolStripMenuItem.Text = "银两优先";
            // 
            // 征兵优先ToolStripMenuItem
            // 
            this.征兵优先ToolStripMenuItem.Name = "征兵优先ToolStripMenuItem";
            this.征兵优先ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.征兵优先ToolStripMenuItem.Text = "征兵优先";
            // 
            // 粮食优先ToolStripMenuItem
            // 
            this.粮食优先ToolStripMenuItem.Name = "粮食优先ToolStripMenuItem";
            this.粮食优先ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.粮食优先ToolStripMenuItem.Text = "粮食优先";
            // 
            // 平衡优先ToolStripMenuItem
            // 
            this.平衡优先ToolStripMenuItem.Name = "平衡优先ToolStripMenuItem";
            this.平衡优先ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.平衡优先ToolStripMenuItem.Text = "平衡优先";
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.载入ToolStripMenuItem,
            this.备份ToolStripMenuItem});
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据ToolStripMenuItem.Text = "数据更新";
            // 
            // 载入ToolStripMenuItem
            // 
            this.载入ToolStripMenuItem.Name = "载入ToolStripMenuItem";
            this.载入ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.载入ToolStripMenuItem.Text = "门客";
            // 
            // 备份ToolStripMenuItem
            // 
            this.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem";
            this.备份ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.备份ToolStripMenuItem.Text = "经营";
            // 
            // tl_cancel
            // 
            this.tl_cancel.Name = "tl_cancel";
            this.tl_cancel.Size = new System.Drawing.Size(44, 21);
            this.tl_cancel.Text = "退出";
            this.tl_cancel.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_money);
            this.tabControl1.Controls.Add(this.tab_soldier);
            this.tabControl1.Controls.Add(this.tab_food);
            this.tabControl1.Controls.Add(this.tab_average);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_money
            // 
            this.tab_money.Controls.Add(this.dv_money);
            this.tab_money.Location = new System.Drawing.Point(4, 22);
            this.tab_money.Name = "tab_money";
            this.tab_money.Padding = new System.Windows.Forms.Padding(3);
            this.tab_money.Size = new System.Drawing.Size(796, 428);
            this.tab_money.TabIndex = 0;
            this.tab_money.Text = "银两优先";
            this.tab_money.UseVisualStyleBackColor = true;
            // 
            // dv_money
            // 
            this.dv_money.AllowUserToAddRows = false;
            this.dv_money.AllowUserToDeleteRows = false;
            this.dv_money.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_money.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dv_money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dv_money.Location = new System.Drawing.Point(3, 3);
            this.dv_money.Name = "dv_money";
            this.dv_money.ReadOnly = true;
            this.dv_money.RowTemplate.Height = 23;
            this.dv_money.Size = new System.Drawing.Size(790, 422);
            this.dv_money.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "经营名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "门客安排";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // tab_soldier
            // 
            this.tab_soldier.Controls.Add(this.dv_soldier);
            this.tab_soldier.Location = new System.Drawing.Point(4, 22);
            this.tab_soldier.Name = "tab_soldier";
            this.tab_soldier.Padding = new System.Windows.Forms.Padding(3);
            this.tab_soldier.Size = new System.Drawing.Size(796, 428);
            this.tab_soldier.TabIndex = 1;
            this.tab_soldier.Text = "征兵优先";
            this.tab_soldier.UseVisualStyleBackColor = true;
            // 
            // dv_soldier
            // 
            this.dv_soldier.AllowUserToAddRows = false;
            this.dv_soldier.AllowUserToDeleteRows = false;
            this.dv_soldier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_soldier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.businessName,
            this.personSet});
            this.dv_soldier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dv_soldier.Location = new System.Drawing.Point(3, 3);
            this.dv_soldier.Name = "dv_soldier";
            this.dv_soldier.ReadOnly = true;
            this.dv_soldier.RowTemplate.Height = 23;
            this.dv_soldier.Size = new System.Drawing.Size(790, 422);
            this.dv_soldier.TabIndex = 1;
            // 
            // businessName
            // 
            this.businessName.HeaderText = "经营名称";
            this.businessName.Name = "businessName";
            this.businessName.ReadOnly = true;
            this.businessName.Width = 150;
            // 
            // personSet
            // 
            this.personSet.HeaderText = "门客安排";
            this.personSet.Name = "personSet";
            this.personSet.ReadOnly = true;
            this.personSet.Width = 300;
            // 
            // tab_food
            // 
            this.tab_food.Location = new System.Drawing.Point(4, 22);
            this.tab_food.Name = "tab_food";
            this.tab_food.Size = new System.Drawing.Size(796, 428);
            this.tab_food.TabIndex = 2;
            this.tab_food.Text = "粮食优先";
            this.tab_food.UseVisualStyleBackColor = true;
            // 
            // tab_average
            // 
            this.tab_average.Location = new System.Drawing.Point(4, 22);
            this.tab_average.Name = "tab_average";
            this.tab_average.Size = new System.Drawing.Size(796, 428);
            this.tab_average.TabIndex = 3;
            this.tab_average.Text = "平衡优先";
            this.tab_average.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_soldier);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.lb_food);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lb_money);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cal);
            this.splitContainer1.Size = new System.Drawing.Size(804, 536);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.TabIndex = 1;
            // 
            // lb_soldier
            // 
            this.lb_soldier.AutoSize = true;
            this.lb_soldier.Location = new System.Drawing.Point(422, 23);
            this.lb_soldier.Name = "lb_soldier";
            this.lb_soldier.Size = new System.Drawing.Size(65, 12);
            this.lb_soldier.TabIndex = 6;
            this.lb_soldier.Text = "lb_soldier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "增加士兵：";
            // 
            // lb_food
            // 
            this.lb_food.AutoSize = true;
            this.lb_food.Location = new System.Drawing.Point(264, 23);
            this.lb_food.Name = "lb_food";
            this.lb_food.Size = new System.Drawing.Size(47, 12);
            this.lb_food.TabIndex = 4;
            this.lb_food.Text = "lb_food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "增加粮食：";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Location = new System.Drawing.Point(94, 23);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(53, 12);
            this.lb_money.TabIndex = 2;
            this.lb_money.Text = "lb_money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "增加银两：";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(694, 18);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 0;
            this.btn_cal.Text = "计算";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_money.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_money)).EndInit();
            this.tab_soldier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_soldier)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuBaseInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuPerson;
        private System.Windows.Forms.ToolStripMenuItem MenuBusiness;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 银两优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 征兵优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粮食优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平衡优先ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_money;
        private System.Windows.Forms.TabPage tab_soldier;
        private System.Windows.Forms.TabPage tab_food;
        private System.Windows.Forms.TabPage tab_average;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_food;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.Label lb_soldier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 载入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tl_cancel;
        private System.Windows.Forms.DataGridView dv_soldier;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personSet;
        private System.Windows.Forms.DataGridView dv_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

