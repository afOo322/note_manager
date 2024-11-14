namespace NoteManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate; // Добавлено
        private System.Windows.Forms.Button btnClear; // Добавлено

        private void InitializeComponent()
        {
            lstNotes = new ListBox();
            txtTitle = new TextBox();
            txtContent = new TextBox();
            txtCategory = new TextBox();
            txtSearch = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnBack = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lstNotes
            // 
            lstNotes.FormattingEnabled = true;
            lstNotes.ItemHeight = 15;
            lstNotes.Location = new Point(12, 12);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(260, 184);
            lstNotes.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(278, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Заголовок";
            txtTitle.Size = new Size(210, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(278, 41);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.PlaceholderText = "Содержимое";
            txtContent.Size = new Size(210, 120);
            txtContent.TabIndex = 2;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(278, 167);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Категория";
            txtCategory.Size = new Size(210, 23);
            txtCategory.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 204);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск";
            txtSearch.Size = new Size(260, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(278, 204);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Добавить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(359, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(440, 204);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(278, 233);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(359, 233);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(440, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(540, 270);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(txtCategory);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(lstNotes);
            Name = "Form1";
            Text = "Менеджер Заметок";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
