using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_JsonProjectWinforms
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Data.AddNewElement == true)        //якщо додаємо рядок
                {
                    acceptButton.Text = "Add";
                    this.Text = "Adding";
                }
                else       //якщо редагуємо рядок
                {
                    acceptButton.Text = "Edit";
                    this.Text = "Editing";

                    textBoxName.Text = Data.lessonsList[Data.EditRowIndex].Name;
                    textBoxFaculty.Text = Data.lessonsList[Data.EditRowIndex].Faculty;
                    textBoxCathedra.Text = Data.lessonsList[Data.EditRowIndex].Cathedra;
                    textBoxAuditory.Text = Data.lessonsList[Data.EditRowIndex].Auditory;
                    textBoxSubject.Text = Data.lessonsList[Data.EditRowIndex].Subject;
                    textBoxGroup.Text = Data.lessonsList[Data.EditRowIndex].StudentGroup;
                }
            }
            catch
            {
                Data.ErrorMessage = "Помилка відкриття форми.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            AcceptAction();
        }
        private void AcceptAction()
        {
            if (textBoxName.Text == "" || textBoxSubject.Text == "" || textBoxGroup.Text == "")
            {
                Data.ErrorMessage = "Зверніть увагу, поля 'ПІБ', 'Дисципліна' та 'Група' не можуть бути порожніми.";
                WarningForm warningForm = new();
                warningForm.Show();
            }
            else 
            {
                bool isElementAlreadyExist = false;
                if (Data.AddNewElement == true)
                {
                    isElementAlreadyExist = CheckExisting();
                    if (isElementAlreadyExist == false)
                    {
                        try
                        {
                            Data.lessonsList.Add(new Data.Schedule(textBoxName.Text, textBoxFaculty.Text, textBoxCathedra.Text, textBoxAuditory.Text,
                                textBoxSubject.Text, textBoxGroup.Text));

                            int index = Data.lessonsList.Count() - 1;
                            Data.table.Rows.Add(Data.lessonsList[index].Name, Data.lessonsList[index].Faculty, Data.lessonsList[index].Cathedra,
                                Data.lessonsList[index].Auditory, Data.lessonsList[index].Subject, Data.lessonsList[index].StudentGroup);
                        }
                        catch
                        {
                            Data.ErrorMessage = "Помилка додавання.";
                            WarningForm warningForm = new();
                            warningForm.Show();
                        }
                    }
                    else
                    {
                        Data.ErrorMessage = "Такий рядок вже існує!";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }

                }
                else
                {
                    try
                    {
                        Data.table.Rows[Data.EditRowIndex][0] = textBoxName.Text;
                        Data.table.Rows[Data.EditRowIndex][1] = textBoxFaculty.Text;
                        Data.table.Rows[Data.EditRowIndex][2] = textBoxCathedra.Text;
                        Data.table.Rows[Data.EditRowIndex][3] = textBoxAuditory.Text;
                        Data.table.Rows[Data.EditRowIndex][4] = textBoxSubject.Text;
                        Data.table.Rows[Data.EditRowIndex][5] = textBoxGroup.Text;

                        Data.lessonsList[Data.EditRowIndex].Name = textBoxName.Text;
                        Data.lessonsList[Data.EditRowIndex].Faculty = textBoxFaculty.Text;
                        Data.lessonsList[Data.EditRowIndex].Cathedra = textBoxCathedra.Text;
                        Data.lessonsList[Data.EditRowIndex].Auditory = textBoxAuditory.Text;
                        Data.lessonsList[Data.EditRowIndex].Subject = textBoxSubject.Text;
                        Data.lessonsList[Data.EditRowIndex].StudentGroup = textBoxGroup.Text;

                    }
                    catch
                    {
                        Data.ErrorMessage = "Помилка редагування.";
                        WarningForm warningForm = new();
                        warningForm.Show();
                    }
                }

                this.Close();
            }
        }

        private bool CheckExisting()
        {
            foreach (Data.Schedule element in Data.lessonsList)
            {
                if (textBoxName.Text.ToLower() == element.Name.ToLower() &&
                    textBoxFaculty.Text.ToLower() == element.Faculty.ToLower() &&
                    textBoxCathedra.Text.ToLower() == element.Cathedra.ToLower() &&
                    textBoxAuditory.Text.ToLower() == element.Auditory.ToLower() &&
                    textBoxSubject.Text.ToLower() == element.Subject.ToLower() &&
                    textBoxGroup.Text.ToLower() == element.StudentGroup.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void LabelFaculty_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
