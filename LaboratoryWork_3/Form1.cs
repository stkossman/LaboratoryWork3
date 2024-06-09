namespace LaboratoryWork_3
{
    public partial class Form1 : Form
    {
        private Dormitory dormitory;
        public Form1()
        {
            InitializeComponent();
            dormitory = new Dormitory(400);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeListView();
            dormitory.Load();
            UpdateStdList();
            UpdateDormList();
        }

        private void InitializeListView()
        {
            studentsListView.View = View.Details;
            studentsListView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            studentsListView.Columns.Add("Name", -2, HorizontalAlignment.Left);
            studentsListView.Columns.Add("Contact Info", -2, HorizontalAlignment.Left);
            studentsListView.Columns.Add("Priority", -2, HorizontalAlignment.Left);

            settledStudentsListView.View = View.Details;
            settledStudentsListView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            settledStudentsListView.Columns.Add("Name", -2, HorizontalAlignment.Left);
            settledStudentsListView.Columns.Add("Contact Info", -2, HorizontalAlignment.Left);
        }

        public void UpdateStdList()
        {
            var students = dormitory.Get();
            studentsListView.Items.Clear();
            foreach (var student in students)
            {
                var listItem = new ListViewItem(student.Id.ToString());
                listItem.SubItems.Add(student.Name);
                listItem.SubItems.Add(student.Contact);
                listItem.SubItems.Add(student.Priority.ToString());
                studentsListView.Items.Add(listItem);
            }

            var settledStudents = dormitory.GetSettledStudents();
            settledStudentsListView.Items.Clear();
            foreach (var student in settledStudents)
            {
                var listItem = new ListViewItem(student.Id.ToString());
                listItem.SubItems.Add(student.Name);
                listItem.SubItems.Add(student.Contact);
                settledStudentsListView.Items.Add(listItem);
            }
        }

        public void UpdateDormList()
        {
            availablePlaces.Text = "Available places in dormitory: " + dormitory.GetAvailable();
            occupiedPlaces.Text = "Occupied places in dormitory: " + dormitory.OccupiedPlaces;
        }

        private void addStd_Click(object sender, EventArgs e)
        {
            var AddingNewStudent = new AddStdFormcs(dormitory);
            AddingNewStudent.ShowDialog();
            UpdateStdList();
        }

        private void editStd_Click(object sender, EventArgs e)
        {
            if (studentsListView.SelectedItems.Count > 0)
            {
                var stdId = int.Parse(studentsListView.SelectedItems[0].Text);
                var EditingStudent = new EditStdForm(dormitory, stdId);
                EditingStudent.ShowDialog();
            }
            else if (settledStudentsListView.SelectedItems.Count > 0)
            {
                var stdId = int.Parse(settledStudentsListView.SelectedItems[0].Text);
                var EditingStudent = new EditStdForm(dormitory, stdId);
                EditingStudent.ShowDialog();
            }
            UpdateStdList();
        }

        private void deleteStd_Click(object sender, EventArgs e)
        {
            if (studentsListView.SelectedItems.Count > 0)
            {
                var stdId = int.Parse(studentsListView.SelectedItems[0].Text);
                dormitory.Delete(stdId);
            }
            else if (settledStudentsListView.SelectedItems.Count > 0)
            {
                var stdId = int.Parse(settledStudentsListView.SelectedItems[0].Text);
                dormitory.DeleteSettled(stdId);
            }

            UpdateStdList();
            UpdateDormList();
        }

        private void settleStd_Click(object sender, EventArgs e)
        {
            var stdId = int.Parse(studentsListView.SelectedItems[0].Text);
            if (dormitory.Settle(stdId) == true)
                MessageBox.Show("Student settled");
            else
                MessageBox.Show("No available places");

            UpdateStdList();
            UpdateDormList();
        }
    }
}
