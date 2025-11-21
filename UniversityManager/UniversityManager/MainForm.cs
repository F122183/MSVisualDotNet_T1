// Mario Nikolov
// F122183
// This is the main form for the University Manager application,
// handling user interactions for adding, removing, and displaying people in the system.
// It manages a list of Person objects, allowing users to add Students and Professors,
// and provides filtering options to view all, only students, or only professors.
// It also updates the status label to inform users about actions taken.

using UniversityManager.Models;

namespace UniversityManager
{
    public partial class MainForm : Form
    {
        List<Person> people = new List<Person>();

        public MainForm()
        {
            InitializeComponent();
            roleComboBox.Text = "Select Role";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            allSortButton.Checked = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            if (roleComboBox.SelectedItem.ToString() == "Student")
            {
                double grade;
                if (!double.TryParse(extraInfoTxt.Text, out grade))
                {
                    MessageBox.Show("Please enter a valid grade.");
                    return;
                }
                var student = new Student
                {
                    Name = txtName.Text,
                    Role = roleComboBox.SelectedItem.ToString(),
                    Id = txtId.Text,
                    Grade = grade
                };
                people.Add(student);
            }
            else if (roleComboBox.SelectedItem.ToString() == "Faculty Staff")
            {
                var professor = new Professor
                {
                    Name = txtName.Text,
                    Role = roleComboBox.SelectedItem.ToString(),
                    Department = extraInfoTxt.Text
                };
                people.Add(professor);
            }
            RefreshList();
            ClearForm();
            UpdateStatus("Added new " + roleComboBox.SelectedItem.ToString());
        }

        private void ClearForm()
        {
            txtName.Text = string.Empty;
            roleComboBox.Text = "Select Role";
            txtId.Text = string.Empty;
            extraInfoTxt.Text = string.Empty;
            idLabel.Text = string.Empty;
            extraInfoLabel.Text = string.Empty;
            idLabel.Visible = false;
            txtId.Visible = false;
            extraInfoLabel.Visible = false;
            extraInfoTxt.Visible = false;
        }

        private void RefreshList()
        {
            lstPeople.Items.Clear();
            var sortingFilter = allSortButton.Checked ? "All" :
                                studentsSortButton.Checked ? "Student" :
                                professorsSortButton.Checked ? "Faculty Staff" : "All";

            if(sortingFilter == "All")
            {
                lstPeople.Items.AddRange(people.Select(p => p.GetDetails()).ToArray());
                return;
            }

            lstPeople.Items.AddRange(people.Where(p => p.Role == sortingFilter).Select(p => p.GetDetails()).ToArray());

        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
            RevertDefaultStatusLabel();
        }

        private void rmvButton_Click(object sender, EventArgs e)
        {
            var selectedItem = lstPeople.SelectedItem;

            if (selectedItem != null)
            {
                people = people.Where(p => p.GetDetails() != selectedItem.ToString()).ToList();
            }
            else
            {
                MessageBox.Show("Please select a person to remove.");
                return;
            }

            ClearForm();
            RefreshList();
            UpdateStatus("Removed selected person");
        }

        private void roleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedItem.ToString() == "Student")
            {
                idLabel.Text = "Faculty Number:";
                extraInfoLabel.Text = "Grade:";
                idLabel.Visible = true;
                txtId.Visible = true;
                extraInfoLabel.Visible = true;
                extraInfoTxt.Visible = true;
            }
            else if (roleComboBox.SelectedItem.ToString() == "Faculty Staff")
            {
                idLabel.Text = "Staff ID:";
                extraInfoLabel.Text = "Department:";
                idLabel.Visible = true;
                txtId.Visible = true;
                extraInfoLabel.Visible = true;
                extraInfoTxt.Visible = true;
            }
            else
            {
                idLabel.Visible = false;
                txtId.Visible = false;
                extraInfoLabel.Visible = false;
                extraInfoTxt.Visible = false;
            }
        }

        private void allSortButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allSortButton.Checked)
            {
                lstPeople.Items.Clear();
                lstPeople.Items.AddRange(people.Select(p => p.GetDetails()).ToArray());
                studentsSortButton.Checked = false;
                professorsSortButton.Checked = false;
            }
        }

        private void studentsSortButton_CheckedChanged(object sender, EventArgs e)
        {
            if (studentsSortButton.Checked)
            {
                lstPeople.Items.Clear();
                lstPeople.Items.AddRange(people
                    .Where(p => p.Role == "Student")
                    .Select(p => p.GetDetails())
                    .ToArray());
                allSortButton.Checked = false;
                professorsSortButton.Checked = false;
            }
        }

        private void professorsSortButton_CheckedChanged(object sender, EventArgs e)
        {
            if (professorsSortButton.Checked)
            {
                lstPeople.Items.Clear();
                lstPeople.Items.AddRange(people
                    .Where(p => p.Role == "Faculty Staff")
                    .Select(p => p.GetDetails())
                    .ToArray());
                allSortButton.Checked = false;
                studentsSortButton.Checked = false;
            }
        }

        private void RevertDefaultStatusLabel()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds
            timer.Tick += (s, e) =>
            {
                lblStatus.Text = string.Empty;
            };
            timer.Stop();
            timer.Start();
        }
    }
}
