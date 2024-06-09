using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork_3
{
    public partial class EditStdForm : Form
    {
        private Dormitory dormitory;
        private int stdId;
        private bool isSettled;

        public EditStdForm(Dormitory dormitory, int stdId, bool isSettled = false)
        {
            InitializeComponent();
            this.dormitory = dormitory;
            this.stdId = stdId;
            this.isSettled = isSettled;

            Student student;
            if (isSettled)
            {
                student = dormitory.GetSettledStudents().FirstOrDefault(std => std.Id == stdId);
            }
            else
            {
                student = dormitory.Get().FirstOrDefault(std => std.Id == stdId);
            }

            if (student != null)
            {
                nameBox.Text = student.Name;
                contactBox.Text = student.Contact;
                priorityBox.Text = student.Priority.ToString();
            }
        }

        private void EditStdForm_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = stdId,
                Name = nameBox.Text,
                Contact = contactBox.Text,
                Priority = int.Parse(priorityBox.Text),
            };
            dormitory.Edit(student, isSettled);
            this.Close();
        }
    }
}
