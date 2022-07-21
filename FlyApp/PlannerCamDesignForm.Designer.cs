
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MotionButton = new System.Windows.Forms.Button();
            this.ImageButton = new System.Windows.Forms.Button();
            this.DataButton1 = new System.Windows.Forms.Button();
            this.alpha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alpha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.MotionButton);
            this.MainPanel.Controls.Add(this.ImageButton);
            this.MainPanel.Controls.Add(this.DataButton1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1093, 850);
            this.MainPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alpha1,
            this.alpha2,
            this.S,
            this.V});
            this.dataGridView1.Location = new System.Drawing.Point(276, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(768, 621);
            this.dataGridView1.TabIndex = 8;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(41, 563);
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
            this.MotionButton.Location = new System.Drawing.Point(41, 391);
            this.MotionButton.Name = "MotionButton";
            this.MotionButton.Size = new System.Drawing.Size(171, 59);
            this.MotionButton.TabIndex = 6;
            this.MotionButton.Text = "运动仿真";
            this.MotionButton.UseVisualStyleBackColor = true;
            // 
            // ImageButton
            // 
            this.ImageButton.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ImageButton.Location = new System.Drawing.Point(41, 229);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(171, 59);
            this.ImageButton.TabIndex = 5;
            this.ImageButton.Text = "图形输出";
            this.ImageButton.UseVisualStyleBackColor = true;
            // 
            // DataButton1
            // 
            this.DataButton1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataButton1.Location = new System.Drawing.Point(41, 78);
            this.DataButton1.Name = "DataButton1";
            this.DataButton1.Size = new System.Drawing.Size(171, 59);
            this.DataButton1.TabIndex = 2;
            this.DataButton1.Text = "数据输出";
            this.DataButton1.UseVisualStyleBackColor = true;
            this.DataButton1.Click += new System.EventHandler(this.DataButton1_Click);
            // 
            // alpha1
            // 
            this.alpha1.HeaderText = "alpha1";
            this.alpha1.MinimumWidth = 8;
            this.alpha1.Name = "alpha1";
            this.alpha1.Width = 130;
            // 
            // alpha2
            // 
            this.alpha2.HeaderText = "alpha2";
            this.alpha2.MinimumWidth = 8;
            this.alpha2.Name = "alpha2";
            this.alpha2.Width = 130;
            // 
            // S
            // 
            this.S.HeaderText = "Pressure1";
            this.S.MinimumWidth = 8;
            this.S.Name = "S";
            this.S.Width = 130;
            // 
            // V
            // 
            this.V.HeaderText = "pressure2";
            this.V.MinimumWidth = 8;
            this.V.Name = "V";
            this.V.Width = 130;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MotionButton;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.Button DataButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alpha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alpha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
    }
}