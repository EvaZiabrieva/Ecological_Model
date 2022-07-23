
namespace WinFormsEcologicalModel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.lblPredatorCount = new System.Windows.Forms.Label();
            this.txbPredatorCount = new System.Windows.Forms.TextBox();
            this.lblPreyCount = new System.Windows.Forms.Label();
            this.txbPreyCount = new System.Windows.Forms.TextBox();
            this.lblObstacleCount = new System.Windows.Forms.Label();
            this.txbObstacleCount = new System.Windows.Forms.TextBox();
            this.lblIteretionsCount = new System.Windows.Forms.Label();
            this.txbIteretionsCount = new System.Windows.Forms.TextBox();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.dataGridViewMainField = new System.Windows.Forms.DataGridView();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.txbStaticSuperPredator = new System.Windows.Forms.TextBox();
            this.btnChangeMinColor = new System.Windows.Forms.Button();
            this.btnChangeMaxColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainField)).BeginInit();
            this.SuspendLayout();
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(185, 93);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(125, 27);
            this.txbWidth.TabIndex = 1;
            this.txbWidth.Text = "25";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWidth.Location = new System.Drawing.Point(185, 66);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(60, 23);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(185, 182);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(65, 23);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(185, 208);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(125, 27);
            this.txbHeight.TabIndex = 4;
            this.txbHeight.Text = "70";
            // 
            // lblPredatorCount
            // 
            this.lblPredatorCount.AutoSize = true;
            this.lblPredatorCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPredatorCount.Location = new System.Drawing.Point(625, 182);
            this.lblPredatorCount.Name = "lblPredatorCount";
            this.lblPredatorCount.Size = new System.Drawing.Size(129, 23);
            this.lblPredatorCount.TabIndex = 5;
            this.lblPredatorCount.Text = "Predator count:";
            // 
            // txbPredatorCount
            // 
            this.txbPredatorCount.Location = new System.Drawing.Point(630, 208);
            this.txbPredatorCount.Name = "txbPredatorCount";
            this.txbPredatorCount.Size = new System.Drawing.Size(124, 27);
            this.txbPredatorCount.TabIndex = 6;
            this.txbPredatorCount.Text = "20";
            // 
            // lblPreyCount
            // 
            this.lblPreyCount.AutoSize = true;
            this.lblPreyCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreyCount.Location = new System.Drawing.Point(630, 66);
            this.lblPreyCount.Name = "lblPreyCount";
            this.lblPreyCount.Size = new System.Drawing.Size(96, 23);
            this.lblPreyCount.TabIndex = 7;
            this.lblPreyCount.Text = "Prey count:";
            // 
            // txbPreyCount
            // 
            this.txbPreyCount.Location = new System.Drawing.Point(629, 92);
            this.txbPreyCount.Name = "txbPreyCount";
            this.txbPreyCount.Size = new System.Drawing.Size(125, 27);
            this.txbPreyCount.TabIndex = 8;
            this.txbPreyCount.Text = "150";
            // 
            // lblObstacleCount
            // 
            this.lblObstacleCount.AutoSize = true;
            this.lblObstacleCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObstacleCount.Location = new System.Drawing.Point(630, 303);
            this.lblObstacleCount.Name = "lblObstacleCount";
            this.lblObstacleCount.Size = new System.Drawing.Size(129, 23);
            this.lblObstacleCount.TabIndex = 9;
            this.lblObstacleCount.Text = "Obstacle count:";
            // 
            // txbObstacleCount
            // 
            this.txbObstacleCount.Location = new System.Drawing.Point(631, 329);
            this.txbObstacleCount.Name = "txbObstacleCount";
            this.txbObstacleCount.Size = new System.Drawing.Size(128, 27);
            this.txbObstacleCount.TabIndex = 10;
            this.txbObstacleCount.Text = "75";
            // 
            // lblIteretionsCount
            // 
            this.lblIteretionsCount.AutoSize = true;
            this.lblIteretionsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIteretionsCount.Location = new System.Drawing.Point(185, 303);
            this.lblIteretionsCount.Name = "lblIteretionsCount";
            this.lblIteretionsCount.Size = new System.Drawing.Size(131, 23);
            this.lblIteretionsCount.TabIndex = 11;
            this.lblIteretionsCount.Text = "Iteretions count";
            // 
            // txbIteretionsCount
            // 
            this.txbIteretionsCount.Location = new System.Drawing.Point(185, 329);
            this.txbIteretionsCount.Name = "txbIteretionsCount";
            this.txbIteretionsCount.Size = new System.Drawing.Size(125, 27);
            this.txbIteretionsCount.TabIndex = 12;
            this.txbIteretionsCount.Text = "1000";
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartSimulation.Location = new System.Drawing.Point(291, 418);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(395, 83);
            this.btnStartSimulation.TabIndex = 13;
            this.btnStartSimulation.Text = "Start simulation";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // dataGridViewMainField
            // 
            this.dataGridViewMainField.AllowUserToAddRows = false;
            this.dataGridViewMainField.AllowUserToDeleteRows = false;
            this.dataGridViewMainField.AllowUserToResizeColumns = false;
            this.dataGridViewMainField.AllowUserToResizeRows = false;
            this.dataGridViewMainField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMainField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainField.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewMainField.Name = "dataGridViewMainField";
            this.dataGridViewMainField.RowHeadersWidth = 51;
            this.dataGridViewMainField.RowTemplate.Height = 29;
            this.dataGridViewMainField.Size = new System.Drawing.Size(1212, 535);
            this.dataGridViewMainField.TabIndex = 14;
            this.dataGridViewMainField.Visible = false;
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Location = new System.Drawing.Point(79, 18);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(50, 20);
            this.lblStatistic.TabIndex = 15;
            this.lblStatistic.Text = "label1";
            this.lblStatistic.Visible = false;
            // 
            // txbStaticSuperPredator
            // 
            this.txbStaticSuperPredator.Location = new System.Drawing.Point(939, 92);
            this.txbStaticSuperPredator.Name = "txbStaticSuperPredator";
            this.txbStaticSuperPredator.Size = new System.Drawing.Size(134, 27);
            this.txbStaticSuperPredator.TabIndex = 16;
            this.txbStaticSuperPredator.Text = "10";
            // 
            // btnChangeMinColor
            // 
            this.btnChangeMinColor.Location = new System.Drawing.Point(631, 18);
            this.btnChangeMinColor.Name = "btnChangeMinColor";
            this.btnChangeMinColor.Size = new System.Drawing.Size(139, 29);
            this.btnChangeMinColor.TabIndex = 17;
            this.btnChangeMinColor.Text = "Min Color";
            this.btnChangeMinColor.UseVisualStyleBackColor = true;
            this.btnChangeMinColor.Click += new System.EventHandler(this.btnChangeMinColor_Click);
            // 
            // btnChangeMaxColor
            // 
            this.btnChangeMaxColor.Location = new System.Drawing.Point(789, 18);
            this.btnChangeMaxColor.Name = "btnChangeMaxColor";
            this.btnChangeMaxColor.Size = new System.Drawing.Size(139, 29);
            this.btnChangeMaxColor.TabIndex = 18;
            this.btnChangeMaxColor.Text = "Max Color";
            this.btnChangeMaxColor.UseVisualStyleBackColor = true;
            this.btnChangeMaxColor.Click += new System.EventHandler(this.btnChangeMaxColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 682);
            this.Controls.Add(this.btnChangeMaxColor);
            this.Controls.Add(this.btnChangeMinColor);
            this.Controls.Add(this.txbStaticSuperPredator);
            this.Controls.Add(this.lblStatistic);
            this.Controls.Add(this.dataGridViewMainField);
            this.Controls.Add(this.btnStartSimulation);
            this.Controls.Add(this.txbIteretionsCount);
            this.Controls.Add(this.lblIteretionsCount);
            this.Controls.Add(this.txbObstacleCount);
            this.Controls.Add(this.lblObstacleCount);
            this.Controls.Add(this.txbPreyCount);
            this.Controls.Add(this.lblPreyCount);
            this.Controls.Add(this.txbPredatorCount);
            this.Controls.Add(this.lblPredatorCount);
            this.Controls.Add(this.txbHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txbWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.Label lblPredatorCount;
        private System.Windows.Forms.TextBox txbPredatorCount;
        private System.Windows.Forms.Label lblPreyCount;
        private System.Windows.Forms.TextBox txbPreyCount;
        private System.Windows.Forms.Label lblObstacleCount;
        private System.Windows.Forms.TextBox txbObstacleCount;
        private System.Windows.Forms.Label lblIteretionsCount;
        private System.Windows.Forms.TextBox txbIteretionsCount;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.DataGridView dataGridViewMainField;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.TextBox txbStaticSuperPredator;
        private System.Windows.Forms.Button btnChangeMinColor;
        private System.Windows.Forms.Button btnChangeMaxColor;
    }
}

