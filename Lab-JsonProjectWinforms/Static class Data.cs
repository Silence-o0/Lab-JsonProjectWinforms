using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Lab_JsonProjectWinforms
{
    static partial class Data
    {
        public static DataTable table = new DataTable();
        public static List<Schedule> lessonsList = new List<Schedule>();
        public static string? ErrorMessage;
        public static bool AddNewElement;      
        public static int EditRowIndex;        //індекс рядку, який користувач хоче змінити
        public class Schedule
        {
            public string? Name { get; set; }
            public string? Faculty { get; set; }

            public string? Cathedra { get; set; }

            public string? Auditory { get; set; }

            public string? Subject { get; set; }

            public string? StudentGroup { get; set; }
            public Schedule() { }
            public Schedule (string name, string faculty, string cathedra, string auditory, string subject, string group)
            {
                this.Name = name;
                this.Faculty = faculty;
                this.Cathedra = cathedra;
                this.Auditory= auditory;
                this.Subject = subject;
                this.StudentGroup = group;

            }
        }

    }

}
