namespace Boggle
{
    partial class StartPage
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
            this.Title = new System.Windows.Forms.Label();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.Start4by4 = new System.Windows.Forms.Button();
            this.Start5by5 = new System.Windows.Forms.Button();
            this.StartWildCard = new System.Windows.Forms.Button();
            this.StartSpeedBoggle = new System.Windows.Forms.Button();
            this.Custom = new System.Windows.Forms.Button();
            this.TimeSelector = new System.Windows.Forms.NumericUpDown();
            this.TimeInfo = new System.Windows.Forms.Label();
            this.StartCustom = new System.Windows.Forms.Button();
            this.RowColumnInfo = new System.Windows.Forms.Label();
            this.RowColumnSelector = new System.Windows.Forms.NumericUpDown();
            this.ButtonTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowColumnSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Bodoni MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(484, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "KESSON\'S BOGGLE";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonTable
            // 
            this.ButtonTable.ColumnCount = 1;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTable.Controls.Add(this.Start4by4, 0, 0);
            this.ButtonTable.Controls.Add(this.Start5by5, 0, 1);
            this.ButtonTable.Controls.Add(this.StartWildCard, 0, 2);
            this.ButtonTable.Controls.Add(this.StartSpeedBoggle, 0, 3);
            this.ButtonTable.Controls.Add(this.Custom, 0, 4);
            this.ButtonTable.Location = new System.Drawing.Point(0, 33);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 5;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTable.Size = new System.Drawing.Size(484, 431);
            this.ButtonTable.TabIndex = 1;
            // 
            // Start4by4
            // 
            this.Start4by4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start4by4.Location = new System.Drawing.Point(3, 3);
            this.Start4by4.Name = "Start4by4";
            this.Start4by4.Size = new System.Drawing.Size(478, 80);
            this.Start4by4.TabIndex = 0;
            this.Start4by4.Text = "4x4";
            this.Start4by4.UseVisualStyleBackColor = true;
            // 
            // Start5by5
            // 
            this.Start5by5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start5by5.Location = new System.Drawing.Point(3, 89);
            this.Start5by5.Name = "Start5by5";
            this.Start5by5.Size = new System.Drawing.Size(478, 80);
            this.Start5by5.TabIndex = 1;
            this.Start5by5.Text = "5x5";
            this.Start5by5.UseVisualStyleBackColor = true;
            // 
            // StartWildCard
            // 
            this.StartWildCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartWildCard.Location = new System.Drawing.Point(3, 175);
            this.StartWildCard.Name = "StartWildCard";
            this.StartWildCard.Size = new System.Drawing.Size(478, 80);
            this.StartWildCard.TabIndex = 2;
            this.StartWildCard.Text = "Wild Card";
            this.StartWildCard.UseVisualStyleBackColor = true;
            // 
            // StartSpeedBoggle
            // 
            this.StartSpeedBoggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartSpeedBoggle.Location = new System.Drawing.Point(3, 261);
            this.StartSpeedBoggle.Name = "StartSpeedBoggle";
            this.StartSpeedBoggle.Size = new System.Drawing.Size(478, 80);
            this.StartSpeedBoggle.TabIndex = 3;
            this.StartSpeedBoggle.Text = "Speed Boggle";
            this.StartSpeedBoggle.UseVisualStyleBackColor = true;
            // 
            // Custom
            // 
            this.Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custom.Location = new System.Drawing.Point(3, 347);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(478, 81);
            this.Custom.TabIndex = 4;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            // 
            // TimeSelector
            // 
            this.TimeSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeSelector.Enabled = false;
            this.TimeSelector.Location = new System.Drawing.Point(115, 478);
            this.TimeSelector.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.TimeSelector.Name = "TimeSelector";
            this.TimeSelector.Size = new System.Drawing.Size(64, 20);
            this.TimeSelector.TabIndex = 2;
            // 
            // TimeInfo
            // 
            this.TimeInfo.AutoSize = true;
            this.TimeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInfo.Location = new System.Drawing.Point(-1, 478);
            this.TimeInfo.Name = "TimeInfo";
            this.TimeInfo.Size = new System.Drawing.Size(110, 17);
            this.TimeInfo.TabIndex = 3;
            this.TimeInfo.Text = "Time (seconds):";
            // 
            // StartCustom
            // 
            this.StartCustom.Enabled = false;
            this.StartCustom.Location = new System.Drawing.Point(380, 475);
            this.StartCustom.Name = "StartCustom";
            this.StartCustom.Size = new System.Drawing.Size(75, 23);
            this.StartCustom.TabIndex = 4;
            this.StartCustom.Text = "Start Custom";
            this.StartCustom.UseVisualStyleBackColor = true;
            // 
            // RowColumnInfo
            // 
            this.RowColumnInfo.AutoSize = true;
            this.RowColumnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowColumnInfo.Location = new System.Drawing.Point(199, 478);
            this.RowColumnInfo.Name = "RowColumnInfo";
            this.RowColumnInfo.Size = new System.Drawing.Size(104, 17);
            this.RowColumnInfo.TabIndex = 5;
            this.RowColumnInfo.Text = "Rows/Columns:";
            // 
            // RowColumnSelector
            // 
            this.RowColumnSelector.Enabled = false;
            this.RowColumnSelector.Location = new System.Drawing.Point(309, 478);
            this.RowColumnSelector.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.RowColumnSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowColumnSelector.Name = "RowColumnSelector";
            this.RowColumnSelector.Size = new System.Drawing.Size(34, 20);
            this.RowColumnSelector.TabIndex = 6;
            this.RowColumnSelector.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 504);
            this.Controls.Add(this.RowColumnSelector);
            this.Controls.Add(this.RowColumnInfo);
            this.Controls.Add(this.StartCustom);
            this.Controls.Add(this.TimeInfo);
            this.Controls.Add(this.TimeSelector);
            this.Controls.Add(this.ButtonTable);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartPage";
            this.Text = "Boggle";
            this.ButtonTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowColumnSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        private System.Windows.Forms.NumericUpDown TimeSelector;
        private System.Windows.Forms.Label TimeInfo;
        private System.Windows.Forms.Button StartCustom;
        private System.Windows.Forms.Button Start4by4;
        private System.Windows.Forms.Button Start5by5;
        private System.Windows.Forms.Button StartWildCard;
        private System.Windows.Forms.Button StartSpeedBoggle;
        private System.Windows.Forms.Button Custom;
        private System.Windows.Forms.Label RowColumnInfo;
        private System.Windows.Forms.NumericUpDown RowColumnSelector;
    }
}

