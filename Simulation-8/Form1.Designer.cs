
namespace Simulation_8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labBall = new System.Windows.Forms.Label();
            this.questBox = new System.Windows.Forms.TextBox();
            this.ansButton = new System.Windows.Forms.Button();
            this.labMode = new System.Windows.Forms.Label();
            this.checkMode = new System.Windows.Forms.CheckBox();
            this.labAns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulation_8.Properties.Resources.magiya1;
            this.pictureBox1.Location = new System.Drawing.Point(-120, -137);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 835);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labBall
            // 
            this.labBall.AutoSize = true;
            this.labBall.BackColor = System.Drawing.Color.NavajoWhite;
            this.labBall.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labBall.Location = new System.Drawing.Point(316, 48);
            this.labBall.Name = "labBall";
            this.labBall.Padding = new System.Windows.Forms.Padding(5);
            this.labBall.Size = new System.Drawing.Size(164, 47);
            this.labBall.TabIndex = 1;
            this.labBall.Text = "Magic Ball";
            // 
            // questBox
            // 
            this.questBox.BackColor = System.Drawing.Color.White;
            this.questBox.Location = new System.Drawing.Point(245, 152);
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(303, 27);
            this.questBox.TabIndex = 2;
            // 
            // ansButton
            // 
            this.ansButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ansButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ansButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.ansButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.ansButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ansButton.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ansButton.Location = new System.Drawing.Point(304, 213);
            this.ansButton.Name = "ansButton";
            this.ansButton.Size = new System.Drawing.Size(189, 54);
            this.ansButton.TabIndex = 3;
            this.ansButton.Text = "Get an answer";
            this.ansButton.UseVisualStyleBackColor = false;
            this.ansButton.Click += new System.EventHandler(this.ansButton_Click);
            // 
            // labMode
            // 
            this.labMode.AutoSize = true;
            this.labMode.BackColor = System.Drawing.Color.NavajoWhite;
            this.labMode.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labMode.Location = new System.Drawing.Point(287, 469);
            this.labMode.Name = "labMode";
            this.labMode.Padding = new System.Windows.Forms.Padding(5);
            this.labMode.Size = new System.Drawing.Size(175, 39);
            this.labMode.TabIndex = 4;
            this.labMode.Text = "YES/NO mode";
            // 
            // checkMode
            // 
            this.checkMode.AutoSize = true;
            this.checkMode.BackColor = System.Drawing.Color.NavajoWhite;
            this.checkMode.Location = new System.Drawing.Point(459, 469);
            this.checkMode.Name = "checkMode";
            this.checkMode.Padding = new System.Windows.Forms.Padding(11);
            this.checkMode.Size = new System.Drawing.Size(40, 39);
            this.checkMode.TabIndex = 5;
            this.checkMode.UseVisualStyleBackColor = false;
            this.checkMode.CheckedChanged += new System.EventHandler(this.checkMode_CheckedChanged);
            // 
            // labAns
            // 
            this.labAns.AutoSize = true;
            this.labAns.BackColor = System.Drawing.Color.NavajoWhite;
            this.labAns.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labAns.Location = new System.Drawing.Point(287, 309);
            this.labAns.Name = "labAns";
            this.labAns.Padding = new System.Windows.Forms.Padding(5);
            this.labAns.Size = new System.Drawing.Size(10, 43);
            this.labAns.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 555);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.checkMode);
            this.Controls.Add(this.labMode);
            this.Controls.Add(this.ansButton);
            this.Controls.Add(this.questBox);
            this.Controls.Add(this.labBall);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "MAGIC BALL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labBall;
        private System.Windows.Forms.TextBox questBox;
        private System.Windows.Forms.Button ansButton;
        private System.Windows.Forms.Label labMode;
        private System.Windows.Forms.CheckBox checkMode;
        private System.Windows.Forms.Label labAns;
    }
}

