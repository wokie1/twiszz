﻿namespace crossword
{
    partial class MainWindow
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
            this.UI_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UI_MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veryLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxhorizontal = new System.Windows.Forms.ListBox();
            this.listBoxvertical = new System.Windows.Forms.ListBox();
            this.UI_TablePanel.SuspendLayout();
            this.UI_MainMenuStrip.SuspendLayout();
            this.Hint.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_TablePanel
            // 
            this.UI_TablePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UI_TablePanel.AutoSize = true;
            this.UI_TablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UI_TablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.UI_TablePanel.ColumnCount = 2;
            this.UI_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.UI_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1170F));
            this.UI_TablePanel.Controls.Add(this.textBox1, 0, 0);
            this.UI_TablePanel.Location = new System.Drawing.Point(0, 3);
            this.UI_TablePanel.Name = "UI_TablePanel";
            this.UI_TablePanel.RowCount = 2;
            this.UI_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.UI_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.UI_TablePanel.Size = new System.Drawing.Size(1208, 88);
            this.UI_TablePanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(38, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_MainMenuStrip
            // 
            this.UI_MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.UI_MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.UI_MainMenuStrip.Name = "UI_MainMenuStrip";
            this.UI_MainMenuStrip.Size = new System.Drawing.Size(1200, 24);
            this.UI_MainMenuStrip.TabIndex = 1;
            this.UI_MainMenuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.nextStageToolStripMenuItem,
            this.changeWordListToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.veryLargeToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // veryLargeToolStripMenuItem
            // 
            this.veryLargeToolStripMenuItem.Name = "veryLargeToolStripMenuItem";
            this.veryLargeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.veryLargeToolStripMenuItem.Text = "Very Large";
            this.veryLargeToolStripMenuItem.Click += new System.EventHandler(this.veryLargeToolStripMenuItem_Click);
            // 
            // nextStageToolStripMenuItem
            // 
            this.nextStageToolStripMenuItem.Name = "nextStageToolStripMenuItem";
            this.nextStageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nextStageToolStripMenuItem.Text = "Next Stage";
            this.nextStageToolStripMenuItem.Click += new System.EventHandler(this.nextStageToolStripMenuItem_Click);
            // 
            // changeWordListToolStripMenuItem
            // 
            this.changeWordListToolStripMenuItem.Name = "changeWordListToolStripMenuItem";
            this.changeWordListToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changeWordListToolStripMenuItem.Text = "Change Word List";
            this.changeWordListToolStripMenuItem.Click += new System.EventHandler(this.changeWordListToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Hint
            // 
            this.Hint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintToolStripMenuItem});
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(98, 26);
            // 
            // hintToolStripMenuItem
            // 
            this.hintToolStripMenuItem.Name = "hintToolStripMenuItem";
            this.hintToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.hintToolStripMenuItem.Text = "Hint";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listBoxhorizontal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxvertical, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(608, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 662);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.41667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.58333F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 668);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.UI_TablePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 662);
            this.panel1.TabIndex = 6;
            // 
            // listBoxhorizontal
            // 
            this.listBoxhorizontal.ContextMenuStrip = this.Hint;
            this.listBoxhorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxhorizontal.FormattingEnabled = true;
            this.listBoxhorizontal.HorizontalScrollbar = true;
            this.listBoxhorizontal.ItemHeight = 20;
            this.listBoxhorizontal.Location = new System.Drawing.Point(3, 293);
            this.listBoxhorizontal.Name = "listBoxhorizontal";
            this.listBoxhorizontal.Size = new System.Drawing.Size(583, 144);
            this.listBoxhorizontal.Sorted = true;
            this.listBoxhorizontal.TabIndex = 3;
            this.listBoxhorizontal.SelectedIndexChanged += new System.EventHandler(this.listBoxhorizontal_SelectedIndexChanged);
            // 
            // listBoxvertical
            // 
            this.listBoxvertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxvertical.ContextMenuStrip = this.Hint;
            this.listBoxvertical.FormattingEnabled = true;
            this.listBoxvertical.HorizontalScrollbar = true;
            this.listBoxvertical.ItemHeight = 20;
            this.listBoxvertical.Location = new System.Drawing.Point(3, 3);
            this.listBoxvertical.Name = "listBoxvertical";
            this.listBoxvertical.Size = new System.Drawing.Size(583, 284);
            this.listBoxvertical.Sorted = true;
            this.listBoxvertical.TabIndex = 5;
            this.listBoxvertical.SelectedIndexChanged += new System.EventHandler(this.listBoxvertical_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.UI_MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.UI_MainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "laba4";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.UI_TablePanel.ResumeLayout(false);
            this.UI_TablePanel.PerformLayout();
            this.UI_MainMenuStrip.ResumeLayout(false);
            this.UI_MainMenuStrip.PerformLayout();
            this.Hint.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UI_TablePanel;
        private System.Windows.Forms.MenuStrip UI_MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip Hint;
        private System.Windows.Forms.ToolStripMenuItem hintToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veryLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextStageToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxhorizontal;
        private System.Windows.Forms.ListBox listBoxvertical;
    }
}

