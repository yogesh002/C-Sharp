using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        //1. Form loads
        private void UserForm_Load(object sender, EventArgs e)
        {
            //2. TableAdapter fills the DatatTable with recent data
            testTableAdapter.Fill(testDBDataSet.test);

            //3. Create Binding Source to store the data
            testBindingSource.DataSource = testDBDataSet.test;


            testDBDataSet.test.AddtestRow(testDBDataSet.test.NewtestRow());
            testBindingSource.MoveLast();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Panel.Enabled = false;
            testBindingSource.ResetBindings(true);
        }

        //Clicking Save button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            testBindingSource.EndEdit();
            testDBDataSet.AcceptChanges();
            testTableAdapter.Update(this.testDBDataSet.test);
            Panel.Enabled = false;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Panel.Enabled = true;
            FullNameTextBox.Focus();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            try
            {
                Panel.Enabled = true;
                FullNameTextBox.Focus();
                testDBDataSet.test.AddtestRow(testDBDataSet.test.NewtestRow());
                testBindingSource.MoveLast();
                //   testBindingSource.ResetBindings(true);
                //  DataGridView.DataSource = testBindingSource;


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                testBindingSource.ResetBindings(false);
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog openFileDialogue = new OpenFileDialog()
                         {
                             Filter = "*.JPEG|JPG",
                             ValidateNames = true,
                             Multiselect = false
                         })
                {
                    if (openFileDialogue.ShowDialog() == DialogResult.OK)
                    {
                        PictureBox.Image = Image.FromFile(openFileDialogue.FileName);
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                testBindingSource.ResetBindings(false);
            }
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pressed enter key:
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show(SearchTextBox.Text);
                if (string.IsNullOrEmpty(SearchTextBox.Text))
                {
                    DataGridView.DataSource = testBindingSource;
                }
                else
                {
                    var query = from a in testDBDataSet.test
                                where a.name.Contains(SearchTextBox.Text) || a.phone == SearchTextBox.Text
                                || a.email.Contains(SearchTextBox.Text) || a.address.Contains(SearchTextBox.Text)
                                select a;
                    DataGridView.DataSource = query.ToList();


                }
            }
        }
    }
}
