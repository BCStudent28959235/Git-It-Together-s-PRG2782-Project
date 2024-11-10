using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_MainProjectFile.LogicLayer;
using WinFormsApp_MainProjectFile.FileHandling;
using System.Windows.Forms;
using WinFormsApp_MainProjectFile.PresentationLayer.UserControls;

namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    public partial class TasksForm : Form
    {
        //UI DESIGN VARIABLES
        int P1W;
        int P2W;
        bool P1Hidden;
        bool P2Hidden;
        public string iconsPath;

        private Settings settings;
        public event Action OnFormClosed;
        IconLibrary iconLibrary;

        // Importing the CreateRoundRectRgn function from Gdi32.dll for creating rounded rectangle regions
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                 int nLeftRect,
                 int nTopRect,
                 int nRightRect,
                 int nBottomRect,
                 int nWidthEllipse,
                 int nHeightEllipse
             );

        List<Student> students = new List<Student>();
        DataTable studentTable = new DataTable();
        BindingSource src = new BindingSource();

        public TasksForm()
        {
            InitializeComponent();
            settings = new Settings();
            SettingsForm ucSettings = new SettingsForm();
            settings.readIni();

            cqpSlidingPanel1.Width = 0;
            cqpSlidingPanel2.Width = 0;

            // Set the form's region to a rounded rectangle
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            P1W = 250;
            P1Hidden = true;

            P2W = 250;
            P2Hidden = true;

            
            iconLibrary = IconLibrary.Instance;

          

            if (settings.theme.ToLower() == "dark")
            {
                // Apply Dark Theme
                ThemeHandler.ApplyDarkMode(this);
                cbtnCloseChildFormTasks.Image = iconLibrary.GetImage("HomeB", "Dark"); // Dark icon
                btnOpenCloseSliderpnl1.Image = iconLibrary.GetImage("Plus", "Dark");
                btnOpenCloseSliderpnl2.Image = iconLibrary.GetImage("Plus", "Dark");

                cqpSlidingPanel2.ColorFour = Color.FromArgb(82, 109, 130);
                cqpSlidingPanel2.ColorOne = Color.FromArgb(39, 55, 77);
                cqpSlidingPanel2.ColorThree = Color.FromArgb(82, 109, 130);
                cqpSlidingPanel2.ColorTwo = Color.FromArgb(39, 55, 77);

                cqpSlidingPanel1.ColorFour = Color.FromArgb(82, 109, 130);
                cqpSlidingPanel1.ColorOne = Color.FromArgb(39, 55, 77);
                cqpSlidingPanel1.ColorThree = Color.FromArgb(82, 109, 130);
                cqpSlidingPanel1.ColorTwo = Color.FromArgb(39, 55, 77);

                btnSearch.Image = iconLibrary.GetImage("Search", "Dark");
                cgpSliderTab1.ColorOne = Color.Black;
                cgpSliderTab1.ColorTwo = Color.FromArgb(39, 55, 77);

                btnSearch.BackColor = Color.Transparent;

                cgpSliderTab2.ColorOne = Color.Black; //
                cgpSliderTab2.ColorTwo = Color.FromArgb(39, 55, 77);//255, 192, 128
                foreach (DataGridViewRow row in dgvStudents.Rows)
                {
                    // Change font color for each cell in the row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ForeColor = Color.White;  // Set font color to black for each cell
                    }
                }

                // Change font color for all column headers
                foreach (DataGridViewColumn column in dgvStudents.Columns)
                {
                    column.HeaderCell.Style.ForeColor = Color.White;  // Set font color to black for each header
                }

                dgvStudents.RowsDefaultCellStyle.ForeColor = Color.White;
                dgvStudents.RowsDefaultCellStyle.BackColor = Color.Black;

            }
            else
            {
                // Apply Light Theme
                ThemeHandler.ApplyLightMode(this);
                cbtnCloseChildFormTasks.Image = iconLibrary.GetImage("Close", "Light"); // Light icon
                btnOpenCloseSliderpnl1.Image = iconLibrary.GetImage("Plus", "Light");
                btnOpenCloseSliderpnl2.Image = iconLibrary.GetImage("Plus", "Light");
                cqpSlidingPanel2.ColorFour = Color.FromArgb(255, 192, 192);
                cqpSlidingPanel2.ColorOne = Color.FromArgb(255, 224, 192);
                cqpSlidingPanel2.ColorThree = Color.FromArgb(255, 192, 192);
                cqpSlidingPanel2.ColorTwo = Color.FromArgb(255, 224, 192);
                cqpSlidingPanel1.ColorFour = Color.FromArgb(255, 192, 192);
                cqpSlidingPanel1.ColorOne = Color.FromArgb(255, 224, 192);
                cqpSlidingPanel1.ColorThree = Color.FromArgb(255, 192, 192);
                cqpSlidingPanel1.ColorTwo = Color.FromArgb(255, 224, 192);
                btnSearch.BackColor = Color.Transparent;
                btnSearch.Image = iconLibrary.GetImage("Search", "Light");

                dgvStudents.BackgroundColor = Color.White;
                dgvStudents.ForeColor = Color.Black;

                foreach (DataGridViewRow row in dgvStudents.Rows)
                {
                    // Change font color for each cell in the row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ForeColor = Color.Black;  // Set font color to black for each cell
                    }
                }

                foreach (DataGridViewColumn column in dgvStudents.Columns)
                {
                    column.HeaderCell.Style.ForeColor = Color.Black;  // Set font color to black for each header
                }

               
                dgvStudents.RowsDefaultCellStyle.ForeColor = Color.Black;
                dgvStudents.RowsDefaultCellStyle.BackColor = Color.White;

                cgpSliderTab1.ColorOne = Color.FromArgb(39, 55, 77);
                cgpSliderTab1.ColorTwo = Color.FromArgb(39, 55, 77);



                cgpSliderTab2.ColorOne = Color.FromArgb(237, 140, 65); //237, 140, 65
                cgpSliderTab2.ColorTwo = Color.FromArgb(255, 192, 128);//
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void addStudent()
        {
            int sID = int.Parse(txtID.Text);
            try
            {
                var student = new Student
                {
                    Name = txtName.Text,
                    Id = int.Parse(txtID.Text),
                    Age = int.Parse(txtAge.Text),
                    Course = txtCourse.Text
                };

                bool stdIdExists = false;

                foreach (Student studentChk in students)
                {
                    if (studentChk.Id == student.Id)
                    {
                        stdIdExists = true;
                        break;
                    }

                }

                if (stdIdExists)
                {
                    MessageBox.Show("Student ID already taken");
                }
                else
                {
                    students.Add(student);
                    studentTable.Rows.Add(student.Id, student.Name, student.Age, student.Course);
                    save();

                    // Clear input fields after adding the student
                    ClearInputFields();

					Save changeLogSave = new Save();
					changeLogSave.ChangeLog(students, sID, "Add");
				}


            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            save();
        }

        private void ClearInputFields()
        {
            txtName.Clear();
            txtID.Clear();
            txtAge.Clear();
            txtCourse.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentTable.Columns.Add("ID", typeof(int));
            studentTable.Columns.Add("Name", typeof(string));
            studentTable.Columns.Add("Age", typeof(int));
            studentTable.Columns.Add("Course", typeof(string));

            populateStudents();

            src.DataSource = studentTable;

            dgvStudents.DataSource = src;
        }

        private void populateStudents()
        {
            Read read = new Read("Students.txt");
            students = read.streamRead();

            foreach (Student pupil in students)
            {
                studentTable.Rows.Add(pupil.Id, pupil.Name, pupil.Age, pupil.Course);
            }

        }

        private void display()
        {
            try
            {
                if (src.Current != null)
                {
                    DataRowView currentRow = (DataRowView)src.Current;
                    txtName.Text = currentRow["Name"].ToString();
                    txtID.Text = currentRow["ID"].ToString();
                    txtAge.Text = currentRow["Age"].ToString();
                    txtCourse.Text = currentRow["Course"].ToString();
                }
                else
                {
                    txtName.Text = "";
                    txtID.Text = "";
                    txtAge.Text = "";
                    txtCourse.Text = "";
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
                MessageBox.Show(error.Message);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            src.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            src.MovePrevious();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (txtName.Text != "" && txtAge.Text != "" && txtCourse.Text != "")
            {
                DataRowView currentRow = (DataRowView)src.Current;
                //should not be able to edit id
                //currentRow["ID"] = int.Parse(txtID.Text);
                currentRow["Name"] = txtName.Text;
                currentRow["Age"] = int.Parse(txtAge.Text);
                currentRow["Course"] = txtCourse.Text;

                currentRow.EndEdit();

                //create a new student object to replace the old one
                Student student = new Student();
                student.Id = int.Parse(currentRow["ID"].ToString());
                student.Name = currentRow["Name"].ToString();
                student.Age = int.Parse(currentRow["Age"].ToString());
                student.Course = currentRow["Course"].ToString();

                id = int.Parse(currentRow["ID"].ToString());

                for (int k = 0; k < students.Count; k++)
                {
                    if (students[k].Id == id)
                    {
                        students.RemoveAt(k);
                        students.Add(student);
                        break;
                    }
                }

				Save changeLogSave = new Save();
				changeLogSave.ChangeLog(students, id, "Update");
			}
            else
            {
                MessageBox.Show("Please complete the requierd information.");
            }


            save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView currentRow = (DataRowView)src.Current;
            int id = int.Parse(currentRow["ID"].ToString());
            currentRow.Delete();
            //delete student from list to save updated list

            Save changeLogSave = new Save();
            changeLogSave.ChangeLog(students, id, "Delete");

            for (int k = 0; k < students.Count; k++)
            {
                if (students[k].Id == id)
                {
                    students.RemoveAt(k);
                    break;
                }
            }


            save();
        }

        private void save()
        {
            Save save = new Save("students.txt");
            save.streamWrite(students);
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            int stdCount = students.Count;
            float avgStdAge = 0, stdAgeTotal = 0;

            for (int i = 0; i < students.Count; i++)
            {
                stdAgeTotal += students[i].Age;
            }

            avgStdAge = stdAgeTotal / students.Count;

            txtTotalStudents.Text = stdCount.ToString();
            txtAvgStdAge.Text = avgStdAge.ToString();

            Save save = new Save();
            save.GenerateSummary(stdCount, avgStdAge);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                int studentID = int.Parse(txtSearch.Text);

                foreach (Student student in students)
                {
                    if (studentID == student.Id)
                    {
                        studentTable.Rows.Clear();

                        studentTable.Rows.Add(student.Id, student.Name, student.Age, student.Course);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter valid id to search");
            }

        }

        private void btnDisplayAllStudents_Click(object sender, EventArgs e)
        {
            studentTable.Rows.Clear();
            populateStudents();
        }

        private void btnCloseTasksForm_Click(object sender, EventArgs e)
        {
            int tasks = 0;
            if (txtID.Text != "")
            {
                tasks++;
            }
            if (txtAge.Text != "")
            {
                tasks++;
            }
            if (txtName.Text != "")
            {
                tasks++;
            }
            if (txtCourse.Text != "")
            {
                tasks++;
            }
            if (tasks == 4)
            {
                this.Close();  //add in check to make sure the user wasnt in the middle of adding in data
            }
            else
            {
                MessageBox.Show("Finish the task please.");
            }
        }






        private void tmerSlidePanelOpen_Tick(object sender, EventArgs e)
        {

            if (P1Hidden)
            {
                cqpSlidingPanel1.Width += 40;

                if (cqpSlidingPanel1.Width >= P1W)
                {
                    tmerSlidePanelOpen.Stop();
                    P1Hidden = false;
                    if (settings.theme.ToLower() == "dark")
                    {
                        // Apply Dark Theme
                        ThemeHandler.ApplyDarkMode(this);
                        btnOpenCloseSliderpnl1.Image = iconLibrary.GetImage("Minus", "Dark");
                    }
                    else
                    {
                        // Apply Light Theme
                        ThemeHandler.ApplyLightMode(this);
                        btnOpenCloseSliderpnl1.Image = iconLibrary.GetImage("Minus", "Light");
                    }

              

                    this.Refresh();
                }
            }
            else
            {
                cqpSlidingPanel1.Width -= 40;

                if (cqpSlidingPanel1.Width <= 0)
                {
                    tmerSlidePanelOpen.Stop();
                    P1Hidden = true;
                    if (settings.theme.ToLower() == "dark")
                    {
                        // Apply Dark Theme
                        ThemeHandler.ApplyDarkMode(this);
                        btnOpenCloseSliderpnl1.Image = iconLibrary.GetImage("Plus", "Dark");
                    }
                    else
                    {
                        // Apply Light Theme
                        ThemeHandler.ApplyLightMode(this);
                        btnOpenCloseSliderpnl1.Image = iconLibrary.GetImage("Plus", "Light");
                    }


                

                    this.Refresh();
                }
            }
        }




        private void btnOpenCloseSliderpnl1_Click(object sender, EventArgs e)
        {
            tmerSlidePanelOpen.Start();
        }


        private void btnOpenCloseSliderpnl2_Click(object sender, EventArgs e)
        {
            tmerSlidePanelOpen2.Start();

        }

        private void tmerSlidePanelOpen2_Tick(object sender, EventArgs e)
        {
            if (P2Hidden)
            {
                cqpSlidingPanel2.Width += 50;

                if (cqpSlidingPanel2.Width >= P2W)
                {
                    tmerSlidePanelOpen2.Stop();
                    P2Hidden = false;
                   
                    if (settings.theme.ToLower() == "dark")
                    {
                        // Apply Dark Theme
                        ThemeHandler.ApplyDarkMode(this);
                        btnOpenCloseSliderpnl2.Image = iconLibrary.GetImage("Minus", "Dark");
                    }
                    else
                    {
                        // Apply Light Theme
                        ThemeHandler.ApplyLightMode(this);
                        btnOpenCloseSliderpnl2.Image = iconLibrary.GetImage("Minus", "Light");
                    }
                    this.Refresh();
                }
            }
            else
            {
                cqpSlidingPanel2.Width -= 50;

                if (cqpSlidingPanel2.Width <= 0)
                {
                    tmerSlidePanelOpen2.Stop();
                    P2Hidden = true;
                    if (settings.theme.ToLower() == "dark")
                    {
                        // Apply Dark Theme
                        ThemeHandler.ApplyDarkMode(this);
                        btnOpenCloseSliderpnl2.Image = iconLibrary.GetImage("Plus", "Dark");
                    }
                    else
                    {
                        // Apply Light Theme
                        ThemeHandler.ApplyLightMode(this);
                        btnOpenCloseSliderpnl2.Image = iconLibrary.GetImage("Plus", "Light");
                    }
             
                    this.Refresh();
                }
            }
        }

        private void dgvStudents_SelectionChanged_1(object sender, EventArgs e)
        {
            display();
        }



        private void cbtnCloseChildFormTasks_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke(); 

            
            this.Close();
        }
    }
}
