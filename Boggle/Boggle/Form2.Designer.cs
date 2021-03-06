﻿namespace Boggle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.CurrentMode = new System.Windows.Forms.Label();
            this.ShowScoreInfo = new System.Windows.Forms.Button();
            this.EndEarly = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLeftTitle = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.ShamelessPlug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentMode
            // 
            this.CurrentMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentMode.AutoSize = true;
            this.CurrentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMode.Location = new System.Drawing.Point(258, 12);
            this.CurrentMode.Name = "CurrentMode";
            this.CurrentMode.Size = new System.Drawing.Size(269, 29);
            this.CurrentMode.TabIndex = 0;
            this.CurrentMode.Text = "Current Mode: Standard";
            this.CurrentMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowScoreInfo
            // 
            this.ShowScoreInfo.Location = new System.Drawing.Point(13, 10);
            this.ShowScoreInfo.Name = "ShowScoreInfo";
            this.ShowScoreInfo.Size = new System.Drawing.Size(123, 41);
            this.ShowScoreInfo.TabIndex = 1;
            this.ShowScoreInfo.Text = "Scoring";
            this.ShowScoreInfo.UseVisualStyleBackColor = true;
            this.ShowScoreInfo.Click += new System.EventHandler(this.ShowScoreInfo_Click);
            // 
            // EndEarly
            // 
            this.EndEarly.Location = new System.Drawing.Point(649, 10);
            this.EndEarly.Name = "EndEarly";
            this.EndEarly.Size = new System.Drawing.Size(123, 41);
            this.EndEarly.TabIndex = 2;
            this.EndEarly.Text = "End Now";
            this.EndEarly.UseVisualStyleBackColor = true;
            this.EndEarly.Click += new System.EventHandler(this.EndEarly_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.GamePanel.ColumnCount = 1;
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GamePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.GamePanel.Location = new System.Drawing.Point(32, 57);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.RowCount = 1;
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GamePanel.Size = new System.Drawing.Size(720, 720);
            this.GamePanel.TabIndex = 3;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // TimeLeftTitle
            // 
            this.TimeLeftTitle.AutoSize = true;
            this.TimeLeftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeLeftTitle.Location = new System.Drawing.Point(28, 820);
            this.TimeLeftTitle.Name = "TimeLeftTitle";
            this.TimeLeftTitle.Size = new System.Drawing.Size(147, 20);
            this.TimeLeftTitle.TabIndex = 4;
            this.TimeLeftTitle.Text = "TIME REMAINING:";
            this.TimeLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Blue;
            this.Time.Location = new System.Drawing.Point(181, 805);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(2, 41);
            this.Time.TabIndex = 5;
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShamelessPlug
            // 
            this.ShamelessPlug.AutoSize = true;
            this.ShamelessPlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShamelessPlug.Location = new System.Drawing.Point(553, 820);
            this.ShamelessPlug.Name = "ShamelessPlug";
            this.ShamelessPlug.Size = new System.Drawing.Size(210, 20);
            this.ShamelessPlug.TabIndex = 6;
            this.ShamelessPlug.Text = "https://www.github.com/Iwuh";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 861);
            this.Controls.Add(this.ShamelessPlug);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.TimeLeftTitle);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.EndEarly);
            this.Controls.Add(this.ShowScoreInfo);
            this.Controls.Add(this.CurrentMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.Shown += new System.EventHandler(this.Game_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentMode;
        private System.Windows.Forms.Button ShowScoreInfo;
        private System.Windows.Forms.Button EndEarly;
        private System.Windows.Forms.TableLayoutPanel GamePanel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label TimeLeftTitle;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label ShamelessPlug;
    }
}