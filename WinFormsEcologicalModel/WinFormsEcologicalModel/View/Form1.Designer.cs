
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
            this.label1 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.predatorCountLabel = new System.Windows.Forms.Label();
            this.predatorCountTextBox = new System.Windows.Forms.TextBox();
            this.preyCountLabel = new System.Windows.Forms.Label();
            this.preyCountTextBox = new System.Windows.Forms.TextBox();
            this.obstacleCountLabel = new System.Windows.Forms.Label();
            this.obstacleCountTextBox = new System.Windows.Forms.TextBox();
            this.iteretionsCountLabel = new System.Windows.Forms.Label();
            this.iteretionsCountTextBox = new System.Windows.Forms.TextBox();
            this.startSimulationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(185, 93);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(125, 27);
            this.widthTextBox.TabIndex = 1;
            this.widthTextBox.Text = "25";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthLabel.Location = new System.Drawing.Point(185, 66);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(60, 23);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heightLabel.Location = new System.Drawing.Point(185, 182);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(65, 23);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(185, 208);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(125, 27);
            this.heightTextBox.TabIndex = 4;
            this.heightTextBox.Text = "70";
            // 
            // predatorCountLabel
            // 
            this.predatorCountLabel.AutoSize = true;
            this.predatorCountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.predatorCountLabel.Location = new System.Drawing.Point(625, 182);
            this.predatorCountLabel.Name = "predatorCountLabel";
            this.predatorCountLabel.Size = new System.Drawing.Size(129, 23);
            this.predatorCountLabel.TabIndex = 5;
            this.predatorCountLabel.Text = "Predator count:";
            // 
            // predatorCountTextBox
            // 
            this.predatorCountTextBox.Location = new System.Drawing.Point(630, 208);
            this.predatorCountTextBox.Name = "predatorCountTextBox";
            this.predatorCountTextBox.Size = new System.Drawing.Size(124, 27);
            this.predatorCountTextBox.TabIndex = 6;
            this.predatorCountTextBox.Text = "20";
            // 
            // preyCountLabel
            // 
            this.preyCountLabel.AutoSize = true;
            this.preyCountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preyCountLabel.Location = new System.Drawing.Point(630, 66);
            this.preyCountLabel.Name = "preyCountLabel";
            this.preyCountLabel.Size = new System.Drawing.Size(96, 23);
            this.preyCountLabel.TabIndex = 7;
            this.preyCountLabel.Text = "Prey count:";
            // 
            // preyCountTextBox
            // 
            this.preyCountTextBox.Location = new System.Drawing.Point(629, 92);
            this.preyCountTextBox.Name = "preyCountTextBox";
            this.preyCountTextBox.Size = new System.Drawing.Size(125, 27);
            this.preyCountTextBox.TabIndex = 8;
            this.preyCountTextBox.Text = "150";
            // 
            // obstacleCountLabel
            // 
            this.obstacleCountLabel.AutoSize = true;
            this.obstacleCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.obstacleCountLabel.Location = new System.Drawing.Point(630, 303);
            this.obstacleCountLabel.Name = "obstacleCountLabel";
            this.obstacleCountLabel.Size = new System.Drawing.Size(129, 23);
            this.obstacleCountLabel.TabIndex = 9;
            this.obstacleCountLabel.Text = "Obstacle count:";
            // 
            // obstacleCountTextBox
            // 
            this.obstacleCountTextBox.Location = new System.Drawing.Point(631, 329);
            this.obstacleCountTextBox.Name = "obstacleCountTextBox";
            this.obstacleCountTextBox.Size = new System.Drawing.Size(128, 27);
            this.obstacleCountTextBox.TabIndex = 10;
            this.obstacleCountTextBox.Text = "75";
            // 
            // iteretionsCountLabel
            // 
            this.iteretionsCountLabel.AutoSize = true;
            this.iteretionsCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iteretionsCountLabel.Location = new System.Drawing.Point(185, 303);
            this.iteretionsCountLabel.Name = "iteretionsCountLabel";
            this.iteretionsCountLabel.Size = new System.Drawing.Size(131, 23);
            this.iteretionsCountLabel.TabIndex = 11;
            this.iteretionsCountLabel.Text = "Iteretions count";
            // 
            // iteretionsCountTextBox
            // 
            this.iteretionsCountTextBox.Location = new System.Drawing.Point(185, 329);
            this.iteretionsCountTextBox.Name = "iteretionsCountTextBox";
            this.iteretionsCountTextBox.Size = new System.Drawing.Size(125, 27);
            this.iteretionsCountTextBox.TabIndex = 12;
            this.iteretionsCountTextBox.Text = "1000";
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startSimulationButton.Location = new System.Drawing.Point(291, 418);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(395, 83);
            this.startSimulationButton.TabIndex = 13;
            this.startSimulationButton.Text = "Start simulation";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 578);
            this.Controls.Add(this.startSimulationButton);
            this.Controls.Add(this.iteretionsCountTextBox);
            this.Controls.Add(this.iteretionsCountLabel);
            this.Controls.Add(this.obstacleCountTextBox);
            this.Controls.Add(this.obstacleCountLabel);
            this.Controls.Add(this.preyCountTextBox);
            this.Controls.Add(this.preyCountLabel);
            this.Controls.Add(this.predatorCountTextBox);
            this.Controls.Add(this.predatorCountLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label predatorCountLabel;
        private System.Windows.Forms.TextBox predatorCountTextBox;
        private System.Windows.Forms.Label preyCountLabel;
        private System.Windows.Forms.TextBox preyCountTextBox;
        private System.Windows.Forms.Label obstacleCountLabel;
        private System.Windows.Forms.TextBox obstacleCountTextBox;
        private System.Windows.Forms.Label iteretionsCountLabel;
        private System.Windows.Forms.TextBox iteretionsCountTextBox;
        private System.Windows.Forms.Button startSimulationButton;
    }
}

