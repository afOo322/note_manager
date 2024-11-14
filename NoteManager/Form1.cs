using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NoteManager
{
    public partial class Form1 : Form
    {
        private List<Note> notes = new List<Note>();

        public Form1()
        {
            InitializeComponent();
            lstNotes.SelectedIndexChanged += LstNotes_SelectedIndexChanged;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Сохранение новой заметки
            var note = new Note
            {
                Title = txtTitle.Text,
                Content = txtContent.Text,
                Category = txtCategory.Text
            };

            notes.Add(note);
            UpdateNoteList();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Удаление выбранной заметки
            if (lstNotes.SelectedItem is Note selectedNote)
            {
                notes.Remove(selectedNote);
                UpdateNoteList();
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Поиск заметок по ключевым словам
            string searchTerm = txtSearch.Text.ToLower();
            var filteredNotes = notes.Where(n =>
                n.Title.ToLower().Contains(searchTerm) ||
                n.Content.ToLower().Contains(searchTerm) ||
                n.Category.ToLower().Contains(searchTerm)).ToList();

            lstNotes.DataSource = filteredNotes;
            lstNotes.DisplayMember = "Title"; // показываем только заголовок
        }

        private void LstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Показать содержимое выбранной заметки
            if (lstNotes.SelectedItem is Note selectedNote)
            {
                txtTitle.Text = selectedNote.Title;
                txtContent.Text = selectedNote.Content;
                txtCategory.Text = selectedNote.Category;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Очищаем поля ввода для создания новой заметки
            ClearFields();
        }

        private void UpdateNoteList()
        {
            // Обновление списка заметок
            lstNotes.DataSource = null;
            lstNotes.DataSource = notes;
            lstNotes.DisplayMember = "Title"; // показываем только заголовок
        }

        private void ClearFields()
        {
            // Очистка полей ввода
            txtTitle.Clear();
            txtContent.Clear();
            txtCategory.Clear();
            lstNotes.ClearSelected();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Обновление содержимого выбранной заметки
            if (lstNotes.SelectedItem is Note selectedNote)
            {
                selectedNote.Title = txtTitle.Text;
                selectedNote.Content = txtContent.Text;
                selectedNote.Category = txtCategory.Text;
                UpdateNoteList();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Очистка полей ввода
            ClearFields();
        }

    }

    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return Title; // Отображаем только заголовок заметки в списке
        }
    }
}
