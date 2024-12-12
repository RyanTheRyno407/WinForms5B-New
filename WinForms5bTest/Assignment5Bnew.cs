using Microsoft.EntityFrameworkCore;

namespace WinForms5Bnew
{
    public partial class Assignment5Bnew : Form
    {

        private readonly IPersonDataSource _datasource;
        public Assignment5Bnew(IPersonDataSource ds)
        {
            InitializeComponent();
            _datasource = ds;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _datasource.SaveChanges();
            PersonGrid.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personBindingSource.DataSource = _datasource.GetPeople();
        }
    }
}
