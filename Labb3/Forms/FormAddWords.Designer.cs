namespace Labb3.winforms.Forms
{
    partial class FormAddWords
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
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelWordsAdded = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridViewWords);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(376, 335);
            this.panelData.TabIndex = 0;
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.AllowUserToAddRows = false;
            this.dataGridViewWords.AllowUserToDeleteRows = false;
            this.dataGridViewWords.AllowUserToResizeColumns = false;
            this.dataGridViewWords.AllowUserToResizeRows = false;
            this.dataGridViewWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWords.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWords.ColumnHeadersVisible = false;
            this.dataGridViewWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.RowHeadersVisible = false;
            this.dataGridViewWords.RowHeadersWidth = 51;
            this.dataGridViewWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewWords.Size = new System.Drawing.Size(376, 335);
            this.dataGridViewWords.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 83.68201F;
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 116.318F;
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.labelWordsAdded);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 335);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(376, 71);
            this.panelButtons.TabIndex = 1;
            // 
            // labelWordsAdded
            // 
            this.labelWordsAdded.AutoSize = true;
            this.labelWordsAdded.BackColor = System.Drawing.Color.Transparent;
            this.labelWordsAdded.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWordsAdded.ForeColor = System.Drawing.Color.Green;
            this.labelWordsAdded.Location = new System.Drawing.Point(0, 0);
            this.labelWordsAdded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWordsAdded.Name = "labelWordsAdded";
            this.labelWordsAdded.Size = new System.Drawing.Size(58, 20);
            this.labelWordsAdded.TabIndex = 2;
            this.labelWordsAdded.Text = "Added!";
            this.labelWordsAdded.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(260, 28);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(152, 28);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormAddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 423);
            this.ControlBox = false;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButtons);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddWords";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please enter words for all languages:";
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelButtons;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridView dataGridViewWords;
        public System.Windows.Forms.Label labelWordsAdded;

        public DataGridViewCellEventHandler DataGridViewWords_CellEndEdit { get; private set; }
        public EventHandler DataGridViewWords_SelectionChanged { get; private set; }
        public EventHandler DataGridViewWords_MouseLeave { get; private set; }
        public EventHandler ButtonClose_Click { get; private set; }
        public EventHandler ButtonAdd_Click { get; private set; }
    }
}