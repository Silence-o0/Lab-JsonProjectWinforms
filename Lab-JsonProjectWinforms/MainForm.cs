using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Windows.Forms;
using static Lab_JsonProjectWinforms.Data;
using static Lab_JsonProjectWinforms.MainForm;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace Lab_JsonProjectWinforms
{

    public partial class MainForm : Form
    {
        private List<Schedule> currentListOnTable;              //поточний список, який відображається в DataGridView
        public string Path { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            try
            {
                CreateTableColumns(Data.table);
                DataGridView.DataSource = Data.table;
            }
            catch 
            {
                Data.ErrorMessage = "Помилка генерування таблиці. Перезапустить програму.";
                WarningForm warningForm = new();
                warningForm.Show();
            }

            
        }

        private void CreateTableColumns(DataTable table)
        {
            table.Columns.Add("ПІБ викладача", typeof(string));
            table.Columns.Add("Факультет", typeof(string));
            table.Columns.Add("Кафедра", typeof(string));
            table.Columns.Add("Аудиторія", typeof(string));
            table.Columns.Add("Дисципліна", typeof(string));
            table.Columns.Add("Група", typeof(string));
        }

        private void DeserializeFile()
        {
            try
            {
                var jsonContent = File.ReadAllText(Path);

                Data.lessonsList = JsonSerializer.Deserialize<List<Schedule>>(jsonContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                Data.table.Clear();            //Очистка таблиці від попередніх даних

                if (Data.lessonsList != null)
                {
                    AddToTable(lessonsList, ref table);
                }
                else
                {
                    Data.ErrorMessage = "Файл порожній.";
                    WarningForm warningForm = new WarningForm();
                    warningForm.Show();
                }

                currentListOnTable = Data.lessonsList;
            }
            catch (Exception)
            {
                Data.ErrorMessage = "Помилка десеріалізації файлу.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
        }

        private void AddToTable(List<Schedule> templist, ref DataTable table)
        {
            try
            {
                foreach (Data.Schedule element in templist)
                {
                    table.Rows.Add(element.Name, element.Faculty, element.Cathedra, element.Auditory, element.Subject, element.StudentGroup);
                }
            }
            catch
            {
                Data.ErrorMessage = "Неможливо оновити табличку.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Buttons.EditData(this);
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenAsButton_Click(object sender, EventArgs e)
        {
            Buttons.OpenAs(this);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Buttons.InfoOpen(this);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Buttons.AddData(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Buttons.DeleteData(this);
        }

        private void OkSearchButton_Click(object sender, EventArgs e)
        {
            Buttons.SearchInList(this);
        }

        private void ReturnSearchButton_Click(object sender, EventArgs e)
        {
            Buttons.ReturnToMainList(this);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Buttons.Save(this);
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            Buttons.SaveAs();
        }

        static class Buttons
         {
            internal static void SaveAs()
            {
                try
                {
                    SaveFileDialog saveFile = new()
                    {
                        Filter = "Json-file|*.json",
                        Title = "Save as"
                    };

                    saveFile.ShowDialog();

                    try
                    {
                        var options = new JsonSerializerOptions
                        {
                            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                            WriteIndented = true
                        };

                        string serializedFile = JsonSerializer.Serialize(Data.lessonsList, options);
                        File.WriteAllText(saveFile.FileName, serializedFile);
                    }
                    catch
                    {
                        Data.ErrorMessage = "Помилка серіалізації файлу.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                        return;
                    }
                }
                catch
                {
                    Data.ErrorMessage = "Не вдається зберегти файл.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            internal static void Save(dynamic form)
            {
                try
                {
                    var options = new JsonSerializerOptions
                    {
                        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                        WriteIndented = true
                    };

                    string serializedFile = JsonSerializer.Serialize(Data.lessonsList, options);
                    File.WriteAllText(form.Path, serializedFile);
                }
                catch
                {
                    Data.ErrorMessage = "Не вдається зберегти файл.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            internal static void OpenAs(dynamic form)
            {
                try
                {
                    OpenFileDialog openFile = new()
                    {
                        Filter = "Json-file|*.json",
                        Title = "Open as"
                    };

                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        form.Path = openFile.FileName;
                        form.DeserializeFile();
                    }
                    else
                    {
                        Data.ErrorMessage = "Файл не було обрано.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }
                }
                catch
                {
                    Data.ErrorMessage = "Помилка відкриття файлу.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            internal static void InfoOpen(dynamic form)
            {
                InfoForm infoForm = new();
                infoForm.Show();
            }

            internal static void EditData(dynamic form)
            {
                Data.AddNewElement = false;     //змінна, яка каже що користувач хоче редагувати рядок
                if (form.DataGridView.SelectedRows.Count == 1)
                {
                    Data.EditRowIndex = form.DataGridView.SelectedRows[0].Index;    //індекс рядка, який користувач хоче редагувати

                    AddEditForm addEditForm = new();
                    addEditForm.Show();
                }
                else if (form.DataGridView.SelectedRows.Count == 0)     // Якщо рядок не обраний
                {
                    Data.ErrorMessage = "Оберіть рядок, який хочете редагувати, натиснувши на відповідну " +
                      "клітинку у першому стовпчику та виділивши бажаний рядок.";
                    WarningForm warningForm = new();
                    warningForm.Show();

                }
                else       //обрано більше 1 рядка
                {
                    Data.ErrorMessage = "Ви можете обрати лише один рядок.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
                ReturnToMainList(form);
            }

            internal static void AddData(dynamic form)
            {
                Data.AddNewElement = true;       //змінна, яка каже, що користувач хоче додати рядок
                AddEditForm addEditForm = new();
                addEditForm.Show();
                ReturnToMainList(form);
            }

            internal static void DeleteData(dynamic form)
            {
                try
                {
                    if (form.DataGridView.SelectedRows.Count > 0 && form.DataGridView.SelectedRows.Count <= form.DataGridView.Rows.Count)
                    {
                        DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити?", "Видалення", MessageBoxButtons.YesNo);

                        switch (result)
                        {
                            case DialogResult.Yes:
                                {

                                    foreach (DataGridViewRow row in form.DataGridView.SelectedRows)
                                    {
                                        int i = 0;
                                        foreach (Data.Schedule element in Data.lessonsList)
                                        {
                                            if (element.Name == row.Cells[0].Value.ToString() &&
                                                element.Faculty == row.Cells[1].Value.ToString() &&
                                                element.Cathedra == row.Cells[2].Value.ToString() &&
                                                element.Auditory == row.Cells[3].Value.ToString() &&
                                                element.Subject == row.Cells[4].Value.ToString() &&
                                                element.StudentGroup == row.Cells[5].Value.ToString())
                                            {
                                                break;
                                            }
                                            i++;
                                        }
                                        if (form.DataGridView.Rows.Count != Data.lessonsList.Count)
                                        {
                                            DataRow rr = Data.table.Rows[i];
                                            rr.Delete();
                                        }
                                        Data.lessonsList.RemoveAt(i);

                                        form.DataGridView.Rows.RemoveAt(row.Index);
                                    }
                                }
                                break;

                            case DialogResult.No:
                                break;
                        }
                    }
                    else if (form.DataGridView.SelectedRows.Count == 0)     // Якщо рядок не обраний
                    {
                        Data.ErrorMessage = "Оберіть рядок, який хочете видалити, натиснувши на відповідну " +
                           "клітинку у першому стовпчику та виділивши бажаний рядок.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }
                }
                catch
                {
                    Data.ErrorMessage = "Невдалось видалити. Спробуйте ще раз.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            internal static void ReturnToMainList(dynamic form)
            {
                try
                {
                    form.currentListOnTable = Data.lessonsList;
                    form.DataGridView.DataSource = Data.table;
                }
                catch
                {
                    Data.ErrorMessage = "Неможливо повернутися до початкової таблиці. Будь ласка, відкрийте файл знову.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            internal static void SearchInList(dynamic form)
            {
                try
                {
                    if (form.ComboBoxTypeSearch.Text == "ПІБ:")
                    {
                        SearchNameFunction(form.currentListOnTable, form);
                    }
                    else if (form.ComboBoxTypeSearch.Text == "Дисципліна:")
                    {
                        SearchSubjectFunction(form.currentListOnTable, form);
                    }
                    else if (form.ComboBoxTypeSearch.Text == "Група:")
                    {
                        SearchGroupFunction(form.currentListOnTable, form);
                    }
                    else
                    {
                        Data.ErrorMessage = "Оберіть критерій за яким хочете здійснити пошук.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }
                }
                catch
                {
                    Data.ErrorMessage = "Неможливо здійснити пошук.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            private static void SearchNameFunction(List<Data.Schedule> list, dynamic form)
            {
                try
                {
                    DataTable resultTable = new();
                    form.CreateTableColumns(resultTable);

                    var templist = from temp in list
                                   where temp.Name.ToLower().Contains(form.textBoxDataSearch.Text.ToLower())
                                   select temp;

                    form.AddToTable(list, ref resultTable);

                    form.currentListOnTable = templist.ToList();
                    form.DataGridView.DataSource = resultTable;
                }
                catch
                {
                    Data.ErrorMessage = "Неможливо здійснити пошук.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            private static void SearchSubjectFunction(List<Data.Schedule> list, dynamic form)
            {
                try { 
                    DataTable resultTable = new();
                    form.CreateTableColumns(resultTable);

                    var templist = from temp in list
                                   where temp.Subject.ToLower() == form.textBoxDataSearch.Text.ToLower()
                                   select temp;

                    form.AddToTable(list, ref resultTable);

                    form.currentListOnTable = templist.ToList();
                    form.DataGridView.DataSource = resultTable;
                }
                catch
                {
                    Data.ErrorMessage = "Неможливо здійснити пошук.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            private static void SearchGroupFunction(List<Data.Schedule> list, dynamic form)
            {
                try { 
                    DataTable resultTable = new();
                    form.CreateTableColumns(resultTable);

                    var templist = from temp in list
                                   where temp.StudentGroup.ToLower().Contains(form.textBoxDataSearch.Text.ToLower())
                                   select temp;

                    form.AddToTable(list, ref resultTable);

                    form.currentListOnTable = templist.ToList();
                    form.DataGridView.DataSource = resultTable;
                }
                catch
                {
                    Data.ErrorMessage = "Неможливо здійснити пошук.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }
        }
    }
}