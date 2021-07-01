
namespace PartyBuildingManagement
{
    partial class Admin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看学生完成状况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("方正姚体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(130, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "欢迎使用学生党员管理系统";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.发布任务ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 35);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            this.学生管理ToolStripMenuItem.Click += new System.EventHandler(this.学生管理ToolStripMenuItem_Click);
            // 
            // 发布任务ToolStripMenuItem
            // 
            this.发布任务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑任务ToolStripMenuItem,
            this.查看学生完成状况ToolStripMenuItem});
            this.发布任务ToolStripMenuItem.Name = "发布任务ToolStripMenuItem";
            this.发布任务ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.发布任务ToolStripMenuItem.Text = "任务管理";
            // 
            // 编辑任务ToolStripMenuItem
            // 
            this.编辑任务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加任务ToolStripMenuItem,
            this.查看任务ToolStripMenuItem});
            this.编辑任务ToolStripMenuItem.Name = "编辑任务ToolStripMenuItem";
            this.编辑任务ToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.编辑任务ToolStripMenuItem.Text = "编辑任务";
            // 
            // 增加任务ToolStripMenuItem
            // 
            this.增加任务ToolStripMenuItem.Name = "增加任务ToolStripMenuItem";
            this.增加任务ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.增加任务ToolStripMenuItem.Text = "增加任务";
            this.增加任务ToolStripMenuItem.Click += new System.EventHandler(this.增加任务ToolStripMenuItem_Click);
            // 
            // 查看任务ToolStripMenuItem
            // 
            this.查看任务ToolStripMenuItem.Name = "查看任务ToolStripMenuItem";
            this.查看任务ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.查看任务ToolStripMenuItem.Text = "查看任务";
            this.查看任务ToolStripMenuItem.Click += new System.EventHandler(this.查看任务ToolStripMenuItem_Click);
            // 
            // 查看学生完成状况ToolStripMenuItem
            // 
            this.查看学生完成状况ToolStripMenuItem.Name = "查看学生完成状况ToolStripMenuItem";
            this.查看学生完成状况ToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.查看学生完成状况ToolStripMenuItem.Text = "查看学生完成状况";
            this.查看学生完成状况ToolStripMenuItem.Click += new System.EventHandler(this.查看学生完成状况ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Admin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin1";
            this.Text = "管理员主界面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看学生完成状况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}