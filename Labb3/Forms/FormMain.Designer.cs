namespace Labb3.winforms.Forms
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetActiveWordList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmRemovingWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmExitingProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMode = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStripMain.Size = new System.Drawing.Size(1140, 37);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewListToolStripMenuItem,
            this.ToolStripMenuItemSetActiveWordList,
            this.toolStripMenuItemExit});
            this.ToolStripMenuItemFile.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(46, 29);
            this.ToolStripMenuItemFile.Text = "File";
            // 
            // createNewListToolStripMenuItem
            // 
            this.createNewListToolStripMenuItem.Name = "createNewListToolStripMenuItem";
            this.createNewListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.createNewListToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.createNewListToolStripMenuItem.Text = "Create new word list";
            // 
            // ToolStripMenuItemSetActiveWordList
            // 
            this.ToolStripMenuItemSetActiveWordList.Name = "ToolStripMenuItemSetActiveWordList";
            this.ToolStripMenuItemSetActiveWordList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSetActiveWordList.Size = new System.Drawing.Size(274, 26);
            this.ToolStripMenuItemSetActiveWordList.Text = "Set active word list";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(274, 26);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmRemovingWordsToolStripMenuItem,
            this.confirmExitingProgramToolStripMenuItem});
            this.settingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // confirmRemovingWordsToolStripMenuItem
            // 
            this.confirmRemovingWordsToolStripMenuItem.Checked = true;
            this.confirmRemovingWordsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.confirmRemovingWordsToolStripMenuItem.Name = "confirmRemovingWordsToolStripMenuItem";
            this.confirmRemovingWordsToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.confirmRemovingWordsToolStripMenuItem.Text = "Confirm removing words";
            // 
            // confirmExitingProgramToolStripMenuItem
            // 
            this.confirmExitingProgramToolStripMenuItem.Checked = true;
            this.confirmExitingProgramToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.confirmExitingProgramToolStripMenuItem.Name = "confirmExitingProgramToolStripMenuItem";
            this.confirmExitingProgramToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.confirmExitingProgramToolStripMenuItem.Text = "Confirm exiting program";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 45);
            this.panelData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(896, 473);
            this.panelData.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 518);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(896, 62);
            this.panelButtons.TabIndex = 2;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.BackColor = System.Drawing.Color.White;
            this.comboBoxMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Edit",
            "Practice"});
            this.comboBoxMode.Location = new System.Drawing.Point(723, 5);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(160, 28);
            this.comboBoxMode.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelMode);
            this.panelTop.Controls.Add(this.comboBoxMode);
            this.panelTop.Controls.Add(this.menuStripMain);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 5, 13, 0);
            this.panelTop.Size = new System.Drawing.Size(896, 45);
            this.panelTop.TabIndex = 0;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMode.Location = new System.Drawing.Point(672, 5);
            this.labelMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelMode.Size = new System.Drawing.Size(51, 26);
            this.labelMode.TabIndex = 3;
            this.labelMode.Text = "Mode:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 597);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelButtons);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(449, 462);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glosor v1.0";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetActiveWordList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        public System.Windows.Forms.Panel panelButtons;
        public System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.ToolStripMenuItem createNewListToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelMode;
        public System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmRemovingWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmExitingProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}