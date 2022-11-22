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


namespace Lab_JsonProjectWinforms
{

    public partial class MainForm : Form
    {
        public string Path { get; set; } = "./schedule.json";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Data.table.Columns.Add("ПІБ викладача", typeof(string));
            Data.table.Columns.Add("Факультет", typeof(string));
            Data.table.Columns.Add("Кафедра", typeof(string));
            Data.table.Columns.Add("Аудиторія", typeof(string));
            Data.table.Columns.Add("Дисципліна", typeof(string));
            Data.table.Columns.Add("Група", typeof(string));

            DeserializeFile();

            DataGridView.DataSource = Data.table;
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            Buttons buttons = new Buttons();
            buttons.EditData(this);

        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            Buttons buttons = new Buttons();
            buttons.SaveAs(this);
        }

        private void OpenAsButton_Click(object sender, EventArgs e)
        {
            Buttons buttons = new Buttons();
            buttons.OpenAs(this);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Buttons buttons = new Buttons();
            buttons.InfoOpen(this);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Buttons buttons = new Buttons();
            buttons.AddData(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Buttons buttons = new Buttons();
            buttons.DeleteData(this);
        }


        private void DeserializeFile()
        {
            var jsonContent = File.ReadAllText(Path);

            Data.lessonsList = new List<Schedule>();
            Data.lessonsList = JsonSerializer.Deserialize<List<Data.Schedule>>(jsonContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            Data.table.Clear();   //Очистка таблиці від попередніх даних


            if (Data.lessonsList != null)
            {
                foreach (var lesson in Data.lessonsList)
                {
                    Data.table.Rows.Add(lesson.Name, lesson.Faculty, lesson.Cathedra, lesson.Auditory, lesson.Subject, lesson.StudentGroup);
                }
            }
            else
            {

            }
        }

        class Buttons
        {
            internal void SaveAs(dynamic form)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Json-file|*.json";
                saveFile.Title = "Save as";
                saveFile.ShowDialog();

                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                string objectser = JsonSerializer.Serialize(Data.lessonsList, options);
                File.WriteAllText(saveFile.FileName, objectser);
            }
            internal void OpenAs(dynamic form)
            {
                try
                {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "Json-file|*.json";
                    openFile.Title = "Open as";

                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        form.Path = openFile.FileName;
                        form.DeserializeFile();
                    }
                    else
                    {
                        MessageBox.Show("Файл не був обраний.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Помилка відкриття файлу.");
                }

            }
            internal void InfoOpen(dynamic form)
            {
                InfoForm infoForm= new InfoForm();
                infoForm.Show();
            }
            internal void EditData(dynamic form)
            {
                Data.AddNewElement = false;
                if (form.DataGridView.SelectedRows.Count == 1)
                {
                    Data.EditRowIndex = form.DataGridView.SelectedRows[0].Index;

                    AddEditForm addEditForm = new AddEditForm();
                    addEditForm.Show();
                }
                else if (form.DataGridView.SelectedRows.Count == 0)     // Якщо рядок не обраний
                {
                    Data.ErrorMessage = "Оберіть рядок, який хочете редагувати, натиснувши на відповідну " +
                      "клітинку у першому стовпчику та виділивши бажаний рядок.";
                    WarningForm warningForm = new WarningForm();
                    warningForm.Show();

                }
                else
                {
                    Data.ErrorMessage = "Ви можете обрати лише один рядок.";
                    WarningForm warningForm = new WarningForm();
                    warningForm.Show();
                }
            }
            internal void AddData(dynamic form)
            {
                Data.AddNewElement = true;
                AddEditForm addEditForm = new AddEditForm();
                addEditForm.Show();
            }
            internal void DeleteData(dynamic form)
            {
                if (form.DataGridView.SelectedRows.Count > 0 && form.DataGridView.SelectedRows.Count < form.DataGridView.Rows.Count)
                {
                    DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити?", "Видалення", MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            {

                                foreach (DataGridViewRow row in form.DataGridView.SelectedRows)
                                {
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
                    WarningForm warningForm = new WarningForm();
                    warningForm.Show();
  
                }
            }
        }

        private void OkSearchButton_Click(object sender, EventArgs e)
        {
            if(ComboBoxTypeSearch.Text == "ПІБ:")
            {
                List<Schedule> templist = new List<Schedule>();
                templist = from comp
                               in Data.lessonsList
                           where comp.Name.Contains(textBoxDataSearch.Text)
                           select comp;

                Data.table.Clear();
                foreach (Schedule temp in templist)
                {
                    Data.table.Rows.Add(temp.Name, temp.Faculty, temp.Cathedra, temp.Auditory,
                        temp.Subject, temp.StudentGroup);

                }
            }
        }
    }
   

}