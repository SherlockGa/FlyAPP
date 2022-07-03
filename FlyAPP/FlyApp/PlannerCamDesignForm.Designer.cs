
namespace FlyApp
{
    partial class PlannerCamDesignForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MotionButton = new System.Windows.Forms.Button();
            this.ImageButton = new System.Windows.Forms.Button();
            this.DataButton3 = new System.Windows.Forms.Button();
            this.DataButton2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataButton1 = new System.Windows.Forms.Button();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.MotionButton);
            this.MainPanel.Controls.Add(this.ImageButton);
            this.MainPanel.Controls.Add(this.DataButton3);
            this.MainPanel.Controls.Add(this.DataButton2);
            this.MainPanel.Controls.Add(this.listView1);
            this.MainPanel.Controls.Add(this.DataButton1);
            this.MainPanel.Controls.Add(this.ChooseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1093, 850);
            this.MainPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(57, 734);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 59);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "退    出";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MotionButton
            // 
            this.MotionButton.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MotionButton.Location = new System.Drawing.Point(57, 609);
            this.MotionButton.Name = "MotionButton";
            this.MotionButton.Size = new System.Drawing.Size(171, 59);
            this.MotionButton.TabIndex = 6;
            this.MotionButton.Text = "运动仿真";
            this.MotionButton.UseVisualStyleBackColor = true;
            // 
            // ImageButton
            // 
            this.ImageButton.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ImageButton.Location = new System.Drawing.Point(57, 489);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(171, 59);
            this.ImageButton.TabIndex = 5;
            this.ImageButton.Text = "图形输出";
            this.ImageButton.UseVisualStyleBackColor = true;
            // 
            // DataButton3
            // 
            this.DataButton3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataButton3.Location = new System.Drawing.Point(57, 373);
            this.DataButton3.Name = "DataButton3";
            this.DataButton3.Size = new System.Drawing.Size(171, 59);
            this.DataButton3.TabIndex = 4;
            this.DataButton3.Text = "数据输出三";
            this.DataButton3.UseVisualStyleBackColor = true;
            // 
            // DataButton2
            // 
            this.DataButton2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataButton2.Location = new System.Drawing.Point(57, 263);
            this.DataButton2.Name = "DataButton2";
            this.DataButton2.Size = new System.Drawing.Size(171, 59);
            this.DataButton2.TabIndex = 3;
            this.DataButton2.Text = "数据输出二";
            this.DataButton2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(297, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 734);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ang";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rc";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ac";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Xc";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yc";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Alf";
            this.columnHeader6.Width = 120;
            // 
            // DataButton1
            // 
            this.DataButton1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataButton1.Location = new System.Drawing.Point(57, 155);
            this.DataButton1.Name = "DataButton1";
            this.DataButton1.Size = new System.Drawing.Size(171, 59);
            this.DataButton1.TabIndex = 2;
            this.DataButton1.Text = "数据输出一";
            this.DataButton1.UseVisualStyleBackColor = true;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChooseButton.Location = new System.Drawing.Point(57, 40);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(171, 59);
            this.ChooseButton.TabIndex = 1;
            this.ChooseButton.Text = "选    定";
            this.ChooseButton.UseVisualStyleBackColor = true;
            // 
            // PlannerCamDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 850);
            this.Controls.Add(this.MainPanel);
            this.Name = "PlannerCamDesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "平面凸轮机构设计";
            this.Load += new System.EventHandler(this.PlannerCamDesignForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MotionButton;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.Button DataButton3;
        private System.Windows.Forms.Button DataButton2;
        private System.Windows.Forms.Button DataButton1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}