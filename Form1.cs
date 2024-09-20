namespace QLN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private void btSave_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtHovaTen.Text, dateTimePicker1.Value, txtGioiTinh.Text, Convert.ToInt32(txtmssv.Text), txtNganhHoc.Text, Convert.ToDouble(txtDTB.Text));
            students.Add(student);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }
    }
}
