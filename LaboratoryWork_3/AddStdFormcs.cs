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
    public partial class AddStdFormcs : Form
    {
        private Dormitory dormitory;

        public AddStdFormcs(Dormitory dormitory)
        {
            InitializeComponent();
            this.dormitory = dormitory;
        }

        //private void AddStdFormcs_Load(object sender, EventArgs e)
        //{

//        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Name = nameBox.Text,
                Contact = contactBox.Text,
                Priority = int.Parse(priorityBox.Text),
            };
            dormitory.Add(student);
            this.Close();
        }
    }
}
