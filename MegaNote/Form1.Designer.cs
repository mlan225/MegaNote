namespace MegaNote
{
    partial class megaNote
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
            this.noteTitle = new System.Windows.Forms.Label();
            this.noteMessage = new System.Windows.Forms.Label();
            this.noteTitleInput = new System.Windows.Forms.TextBox();
            this.noteMessageInput = new System.Windows.Forms.TextBox();
            this.notesDataGrid = new System.Windows.Forms.DataGridView();
            this.clearNote = new System.Windows.Forms.Button();
            this.saveNote = new System.Windows.Forms.Button();
            this.deleteNote = new System.Windows.Forms.Button();
            this.clearSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // noteTitle
            // 
            this.noteTitle.AutoSize = true;
            this.noteTitle.Location = new System.Drawing.Point(44, 55);
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.Size = new System.Drawing.Size(65, 13);
            this.noteTitle.TabIndex = 0;
            this.noteTitle.Text = "Title of Note";
            // 
            // noteMessage
            // 
            this.noteMessage.AutoSize = true;
            this.noteMessage.Location = new System.Drawing.Point(45, 111);
            this.noteMessage.Name = "noteMessage";
            this.noteMessage.Size = new System.Drawing.Size(76, 13);
            this.noteMessage.TabIndex = 1;
            this.noteMessage.Text = "Note Message";
            // 
            // noteTitleInput
            // 
            this.noteTitleInput.Location = new System.Drawing.Point(166, 52);
            this.noteTitleInput.Name = "noteTitleInput";
            this.noteTitleInput.Size = new System.Drawing.Size(144, 20);
            this.noteTitleInput.TabIndex = 2;
            // 
            // noteMessageInput
            // 
            this.noteMessageInput.Location = new System.Drawing.Point(166, 111);
            this.noteMessageInput.Multiline = true;
            this.noteMessageInput.Name = "noteMessageInput";
            this.noteMessageInput.Size = new System.Drawing.Size(317, 239);
            this.noteMessageInput.TabIndex = 3;
            // 
            // notesDataGrid
            // 
            this.notesDataGrid.AllowUserToAddRows = false;
            this.notesDataGrid.AllowUserToDeleteRows = false;
            this.notesDataGrid.AllowUserToResizeColumns = false;
            this.notesDataGrid.AllowUserToResizeRows = false;
            this.notesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesDataGrid.Location = new System.Drawing.Point(514, 55);
            this.notesDataGrid.Name = "notesDataGrid";
            this.notesDataGrid.ReadOnly = true;
            this.notesDataGrid.RowHeadersVisible = false;
            this.notesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.notesDataGrid.Size = new System.Drawing.Size(253, 295);
            this.notesDataGrid.TabIndex = 4;
            this.notesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesDataGrid_CellClick);
            // 
            // clearNote
            // 
            this.clearNote.Location = new System.Drawing.Point(371, 52);
            this.clearNote.Name = "clearNote";
            this.clearNote.Size = new System.Drawing.Size(75, 23);
            this.clearNote.TabIndex = 5;
            this.clearNote.Text = "Clear Text";
            this.clearNote.UseVisualStyleBackColor = true;
            this.clearNote.Click += new System.EventHandler(this.clearNote_Click);
            // 
            // saveNote
            // 
            this.saveNote.Location = new System.Drawing.Point(301, 375);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(75, 23);
            this.saveNote.TabIndex = 6;
            this.saveNote.Text = "Save";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.saveNote_Click);
            // 
            // deleteNote
            // 
            this.deleteNote.Location = new System.Drawing.Point(528, 375);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(75, 23);
            this.deleteNote.TabIndex = 8;
            this.deleteNote.Text = "Delete";
            this.deleteNote.UseVisualStyleBackColor = true;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // clearSelection
            // 
            this.clearSelection.Location = new System.Drawing.Point(642, 375);
            this.clearSelection.Name = "clearSelection";
            this.clearSelection.Size = new System.Drawing.Size(115, 23);
            this.clearSelection.TabIndex = 9;
            this.clearSelection.Text = "Clear Selection";
            this.clearSelection.UseVisualStyleBackColor = true;
            this.clearSelection.Click += new System.EventHandler(this.clearSelection_Click);
            // 
            // megaNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearSelection);
            this.Controls.Add(this.deleteNote);
            this.Controls.Add(this.saveNote);
            this.Controls.Add(this.clearNote);
            this.Controls.Add(this.notesDataGrid);
            this.Controls.Add(this.noteMessageInput);
            this.Controls.Add(this.noteTitleInput);
            this.Controls.Add(this.noteMessage);
            this.Controls.Add(this.noteTitle);
            this.Name = "megaNote";
            this.Text = "MegaNote";
            this.Load += new System.EventHandler(this.MegaNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteTitle;
        private System.Windows.Forms.Label noteMessage;
        private System.Windows.Forms.TextBox noteTitleInput;
        private System.Windows.Forms.TextBox noteMessageInput;
        private System.Windows.Forms.DataGridView notesDataGrid;
        private System.Windows.Forms.Button clearNote;
        private System.Windows.Forms.Button saveNote;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.Button clearSelection;
    }
}

