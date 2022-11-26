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
        private List<Schedule> currentListOnTable;              //�������� ������, ���� ������������ � DataGridView
        public string Path { get; set; } = "./schedule.json";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateTableColumns(Data.table);

            try
            {
                DeserializeFile();
            }
            catch 
            {
                Data.ErrorMessage = "������� ������������ �����.";
                WarningForm warningForm = new();
                warningForm.Show();
            }

            DataGridView.DataSource = Data.table;
        }

        private void CreateTableColumns(DataTable table)
        {
            table.Columns.Add("ϲ� ���������", typeof(string));
            table.Columns.Add("���������", typeof(string));
            table.Columns.Add("�������", typeof(string));
            table.Columns.Add("��������", typeof(string));
            table.Columns.Add("���������", typeof(string));
            table.Columns.Add("�����", typeof(string));
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

                Data.table.Clear();            //������� ������� �� ��������� �����

                if (Data.lessonsList != null)
                {
                    AddToTable(lessonsList, ref table);
                }
                else
                {
                    Data.ErrorMessage = "���� �������.";
                    WarningForm warningForm = new WarningForm();
                    warningForm.Show();
                }

                currentListOnTable = Data.lessonsList;
            }
            catch (Exception)
            {
                Data.ErrorMessage = "������� ������������ �����.";
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
                Data.ErrorMessage = "��������� ������� ��������.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Buttons.EditData(this);
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            Buttons.SaveAs();
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
                        Data.ErrorMessage = "������� ���������� �����.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                        return;
                    }
                }
                catch
                {
                    Data.ErrorMessage = "�� ������� �������� ����.";
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
                        Data.ErrorMessage = "���� �� ���� ������.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }
                }
                catch
                {
                    Data.ErrorMessage = "������� �������� �����.";
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
                Data.AddNewElement = false;     //�����, ��� ���� �� ���������� ���� ���������� �����
                if (form.DataGridView.SelectedRows.Count == 1)
                {
                    Data.EditRowIndex = form.DataGridView.SelectedRows[0].Index;    //������ �����, ���� ���������� ���� ����������

                    AddEditForm addEditForm = new();
                    addEditForm.Show();
                }
                else if (form.DataGridView.SelectedRows.Count == 0)     // ���� ����� �� �������
                {
                    Data.ErrorMessage = "������ �����, ���� ������ ����������, ���������� �� �������� " +
                      "������� � ������� ��������� �� �������� ������� �����.";
                    WarningForm warningForm = new();
                    warningForm.Show();

                }
                else       //������ ����� 1 �����
                {
                    Data.ErrorMessage = "�� ������ ������ ���� ���� �����.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            internal static void AddData(dynamic form)
            {
                Data.AddNewElement = true;       //�����, ��� ���� �� ���������� ���� ������ �����
                AddEditForm addEditForm = new();
                addEditForm.Show();
            }

            internal static void DeleteData(dynamic form)
            {
                if (form.DataGridView.SelectedRows.Count > 0 && form.DataGridView.SelectedRows.Count < form.DataGridView.Rows.Count)
                {
                    try
                    {
                        Data.ErrorMessage = "�� �������, �� ������ ��������?";
                        YesNoForm yesNoForm = new();
                        yesNoForm.Show();

                        if (Data.YesResultInForm == true)
                        {
                            foreach (DataGridViewRow row in form.DataGridView.SelectedRows)
                            {
                                form.DataGridView.Rows.RemoveAt(row.Index);
                            }

                            form.currentListOnTable = Data.lessonsList;
                        }
                    }
                    catch
                    {
                        Data.ErrorMessage = "������� ���������.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }
                }
                else if (form.DataGridView.SelectedRows.Count == 0)     // ���� ����� �� �������
                {
                    Data.ErrorMessage = "������ �����, ���� ������ ��������, ���������� �� �������� " +
                       "������� � ������� ��������� �� �������� ������� �����.";
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
                    Data.ErrorMessage = "��������� ����������� �� ��������� �������. ���� �����, �������� ���� �����.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }

            internal static void SearchInList(dynamic form)
            {
                try
                {
                    if (form.ComboBoxTypeSearch.Text == "ϲ�:")
                    {
                        SearchNameFunction(form.currentListOnTable, form);
                    }
                    else if (form.ComboBoxTypeSearch.Text == "���������:")
                    {
                        SearchSubjectFunction(form.currentListOnTable, form);
                    }
                    else if (form.ComboBoxTypeSearch.Text == "�����:")
                    {
                        SearchGroupFunction(form.currentListOnTable, form);
                    }
                    else
                    {
                        Data.ErrorMessage = "������ ������� �� ���� ������ �������� �����.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }
                }
                catch
                {
                    Data.ErrorMessage = "��������� �������� �����.";
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
                                   where temp.Name.ToLower() == form.textBoxDataSearch.Text.ToLower()
                                   select temp;

                    form.AddToTable(list, ref resultTable);

                    form.currentListOnTable = templist.ToList();
                    form.DataGridView.DataSource = resultTable;
                }
                catch
                {
                    Data.ErrorMessage = "��������� �������� �����.";
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
                    Data.ErrorMessage = "��������� �������� �����.";
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
                                   where temp.StudentGroup.ToLower() == form.textBoxDataSearch.Text.ToLower()
                                   select temp;

                    form.AddToTable(list, ref resultTable);

                    form.currentListOnTable = templist.ToList();
                    form.DataGridView.DataSource = resultTable;
                }
                catch
                {
                    Data.ErrorMessage = "��������� �������� �����.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }
        }
    }
}