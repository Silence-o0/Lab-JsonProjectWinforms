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
                Data.ErrorMessage = "������� ����������� �������. ������������� ��������.";
                WarningForm warningForm = new();
                warningForm.Show();
            }

            
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
            EditData();
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenAsButton_Click(object sender, EventArgs e)
        {
            OpenAs();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoOpen();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void OkSearchButton_Click(object sender, EventArgs e)
        {
            SearchInList();
        }

        private void ReturnSearchButton_Click(object sender, EventArgs e)
        {
            ReturnToMainList();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
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

        private void Save()
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };

                string serializedFile = JsonSerializer.Serialize(Data.lessonsList, options);
                File.WriteAllText(Path, serializedFile);
            }
            catch
            {
                Data.ErrorMessage = "�� ������� �������� ����.";
                WarningForm warningForm = new();
                warningForm.Show();
            }

        }
        private void OpenAs()
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
                    Path = openFile.FileName;
                    DeserializeFile();
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

        private void InfoOpen()
        {
            InfoForm infoForm = new();
            infoForm.Show();
        }

        private void EditData()
        {
            Data.AddNewElement = false;     //�����, ��� ���� �� ���������� ���� ���������� �����
            if (DataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DataGridView.SelectedRows[0];

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

                Data.EditRowIndex = i;     //������ �����, ���� ���������� ���� ����������

                AddEditForm addEditForm = new();
                addEditForm.Show();
            }
            else if (DataGridView.SelectedRows.Count == 0)     // ���� ����� �� �������
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
            ReturnToMainList();
        }

        private void AddData()
        {
            Data.AddNewElement = true;       //�����, ��� ����, �� ���������� ���� ������ �����
            AddEditForm addEditForm = new();
            addEditForm.Show();
            ReturnToMainList();
        }

        private void DeleteData()
        {
            try
            {
                if (DataGridView.SelectedRows.Count > 0 && DataGridView.SelectedRows.Count <= DataGridView.Rows.Count)
                {
                    DialogResult result = MessageBox.Show("�� �������, �� ������ ��������?", "���������", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            {

                                foreach (DataGridViewRow row in DataGridView.SelectedRows)
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
                                    if (DataGridView.Rows.Count != Data.lessonsList.Count)
                                    {
                                        DataRow rr = Data.table.Rows[i];
                                        rr.Delete();
                                    }
                                    Data.lessonsList.RemoveAt(i);

                                    DataGridView.Rows.RemoveAt(row.Index);
                                }
                            }
                            break;

                        case DialogResult.No:
                            break;
                    }
                }
                else if (DataGridView.SelectedRows.Count == 0)     // ���� ����� �� �������
                {
                    Data.ErrorMessage = "������ �����, ���� ������ ��������, ���������� �� �������� " +
                       "������� � ������� ��������� �� �������� ������� �����.";
                    WarningForm warningForm = new();
                    warningForm.Show();
                }
            }
            catch
            {
                Data.ErrorMessage = "��������� ��������. ��������� �� ���.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
        }

        private void ReturnToMainList()
        {
            try
            {
                currentListOnTable = Data.lessonsList;
                DataGridView.DataSource = Data.table;
            }
            catch
            {
                Data.ErrorMessage = "��������� ����������� �� ��������� �������. ���� �����, �������� ���� �����.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
        }
        private void SearchInList()
        {
            try
            {
                if (ComboBoxTypeSearch.Text == "ϲ�:")
                {
                    SearchNameFunction(currentListOnTable);
                }
                else if (ComboBoxTypeSearch.Text == "���������:")
                {
                    SearchSubjectFunction(currentListOnTable);
                }
                else if (ComboBoxTypeSearch.Text == "�����:")
                {
                    SearchGroupFunction(currentListOnTable);
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
        private void SearchNameFunction(List<Data.Schedule> list)
        {
            try
            {
                DataTable resultTable = new();
                CreateTableColumns(resultTable);

                var templist = from temp in list
                               where temp.Name.ToLower().Contains(textBoxDataSearch.Text.ToLower())
                               select temp;

                AddToTable(list, ref resultTable);

                currentListOnTable = templist.ToList();
                DataGridView.DataSource = resultTable;
            }
            catch
            {
                Data.ErrorMessage = "��������� �������� �����.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
            finally
            {
                textBoxDataSearch.Text = String.Empty;
            }
        }
        private void SearchSubjectFunction(List<Data.Schedule> list)
        {
            try
            {
                DataTable resultTable = new();
                CreateTableColumns(resultTable);

                var templist = from temp in list
                               where temp.Subject.ToLower() == textBoxDataSearch.Text.ToLower()
                               select temp;

                AddToTable(list, ref resultTable);

                currentListOnTable = templist.ToList();
                DataGridView.DataSource = resultTable;
            }
            catch
            {
                Data.ErrorMessage = "��������� �������� �����.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
            finally
            {
                textBoxDataSearch.Text = String.Empty;
            }
        }
        private void SearchGroupFunction(List<Data.Schedule> list)
        {
            try
            {
                DataTable resultTable = new();
                CreateTableColumns(resultTable);

                var templist = from temp in list
                               where temp.StudentGroup.ToLower().Contains(textBoxDataSearch.Text.ToLower())
                               select temp;

                AddToTable(list, ref resultTable);

                currentListOnTable = templist.ToList();
                DataGridView.DataSource = resultTable;
            }
            catch
            {
                Data.ErrorMessage = "��������� �������� �����.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
            finally
            {
                textBoxDataSearch.Text = String.Empty;
            }
        }
    }
}