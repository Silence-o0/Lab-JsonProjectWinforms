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
            if (Data.AddNewElement == true)
            {
                acceptButton.Text = "Add";
                this.Text = "Adding";
            }
            else
            {
                acceptButton.Text = "Edit";
                this.Text = "Editing";
                textBoxName.Text = Data.table.Rows[Data.EditRowIndex].Field<string>("ПІБ викладача");
                textBoxFaculty.Text = Data.table.Rows[Data.EditRowIndex].Field<string>("Факультет");
                textBoxCathedra.Text = Data.table.Rows[Data.EditRowIndex].Field<string>("Кафедра");
                textBoxAuditory.Text = Data.table.Rows[Data.EditRowIndex].Field<string>("Аудиторія");
                textBoxSubject.Text = Data.table.Rows[Data.EditRowIndex].Field<string>("Дисципліна");
                textBoxGroup.Text = Data.table.Rows[Data.EditRowIndex].Field<string>("Група");
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            AcceptAction();

        }
        private void AcceptAction()
        {
            if (Data.AddNewElement == true)
            {
                Data.lessonsList.Add(new Data.Schedule(textBoxName.Text, textBoxFaculty.Text, textBoxCathedra.Text, textBoxAuditory.Text,
                    textBoxSubject.Text, textBoxGroup.Text));

                int index = Data.lessonsList.Count() - 1;
                Data.table.Rows.Add(Data.lessonsList[index].Name, Data.lessonsList[index].Faculty, Data.lessonsList[index].Cathedra,
                    Data.lessonsList[index].Auditory, Data.lessonsList[index].Subject, Data.lessonsList[index].StudentGroup);

            }
            else
            {
                Data.table.Rows[Data.EditRowIndex][0] = textBoxName.Text;
                Data.table.Rows[Data.EditRowIndex][1] = textBoxFaculty.Text;
                Data.table.Rows[Data.EditRowIndex][2] = textBoxCathedra.Text;
                Data.table.Rows[Data.EditRowIndex][3] = textBoxAuditory.Text;
                Data.table.Rows[Data.EditRowIndex][4] = textBoxSubject.Text;
                Data.table.Rows[Data.EditRowIndex][5] = textBoxGroup.Text;
            }
            this.Close();
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
