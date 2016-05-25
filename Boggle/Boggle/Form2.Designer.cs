namespace Boggle
{
    partial class Game
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
            this.CurrentMode = new System.Windows.Forms.Label();
            this.ShowScoreInfo = new System.Windows.Forms.Button();
            this.EndEarly = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CurrentMode
            // 
            this.CurrentMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentMode.AutoSize = true;
            this.CurrentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMode.Location = new System.Drawing.Point(222, 9);
            this.CurrentMode.Name = "CurrentMode";
            this.CurrentMode.Size = new System.Drawing.Size(143, 25);
            this.CurrentMode.TabIndex = 0;
            this.CurrentMode.Text = "Current Mode: ";
            this.CurrentMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowScoreInfo
            // 
            this.ShowScoreInfo.Location = new System.Drawing.Point(13, 10);
            this.ShowScoreInfo.Name = "ShowScoreInfo";
            this.ShowScoreInfo.Size = new System.Drawing.Size(75, 23);
            this.ShowScoreInfo.TabIndex = 1;
            this.ShowScoreInfo.Text = "Scoring";
            this.ShowScoreInfo.UseVisualStyleBackColor = true;
            // 
            // EndEarly
            // 
            this.EndEarly.Location = new System.Drawing.Point(497, 10);
            this.EndEarly.Name = "EndEarly";
            this.EndEarly.Size = new System.Drawing.Size(75, 23);
            this.EndEarly.TabIndex = 2;
            this.EndEarly.Text = "End Now";
            this.EndEarly.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 500);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EndEarly);
            this.Controls.Add(this.ShowScoreInfo);
            this.Controls.Add(this.CurrentMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentMode;
        private System.Windows.Forms.Button ShowScoreInfo;
        private System.Windows.Forms.Button EndEarly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer GameTimer;
    }
}