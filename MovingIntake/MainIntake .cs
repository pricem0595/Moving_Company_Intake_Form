using System;
using System.Data;
using System.Windows.Forms;

namespace MovingIntake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserInfo userInfo = new UserInfo();

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
        //CREATE ENUMS OR COLLECTION TO CLEAN UP CODE AND MAYBE TRANSFER FUCTIONS TO TEXTBOXLOGIC
        public void EnterAllFields()
        {
            TextBoxLogic.EnterTextBox(textBoxFirstName, "First Name");
            TextBoxLogic.EnterTextBox(textBoxLastName, "Last Name");
            TextBoxLogic.EnterTextBox(textBoxEmail, "xxxx@xxxxx.com");
            TextBoxLogic.EnterTextBox(textBoxPhoneNumber, "xxx-xxx-xxxx");
            TextBoxLogic.EnterTextBox(textBoxFromStreet, "Street");
            TextBoxLogic.EnterTextBox(textBoxFromCity, "City");
            TextBoxLogic.EnterTextBox(textBoxFromState, "ST");
            TextBoxLogic.EnterTextBox(textBoxFromZipCode, "Zip Code");
            TextBoxLogic.EnterTextBox(textBoxToStreet, "Street");
            TextBoxLogic.EnterTextBox(textBoxToCity, "City");
            TextBoxLogic.EnterTextBox(textBoxToState, "ST");
            TextBoxLogic.EnterTextBox(textBoxToZipCode, "Zip Code");
            TextBoxLogic.EnterTextBox(textBoxRoomCount, "xx");
            TextBoxLogic.EnterTextBox(textBoxNotes, "Additional Information");
        }
        public void ResetTextBoxes()
        {
            userInfo.CustomerID = 0;
            TextBoxLogic.ResetTextBox(textBoxFirstName, "First Name");
            TextBoxLogic.ResetTextBox(textBoxLastName, "Last Name");
            TextBoxLogic.ResetTextBox(textBoxEmail, "xxxx@xxxxx.com");
            TextBoxLogic.ResetTextBox(textBoxPhoneNumber, "xxx-xxx-xxxx");
            TextBoxLogic.ResetTextBox(textBoxFromStreet, "Street");
            TextBoxLogic.ResetTextBox(textBoxFromCity, "City");
            TextBoxLogic.ResetTextBox(textBoxFromState, "ST");
            TextBoxLogic.ResetTextBox(textBoxFromZipCode, "Zip Code");
            TextBoxLogic.ResetTextBox(textBoxToStreet, "Street");
            TextBoxLogic.ResetTextBox(textBoxToCity, "City");
            TextBoxLogic.ResetTextBox(textBoxToState, "ST");
            TextBoxLogic.ResetTextBox(textBoxToZipCode, "Zip Code");
            TextBoxLogic.ResetTextBox(textBoxRoomCount, "xx");
            TextBoxLogic.ResetTextBox(textBoxNotes, "Additional Information");
            TextBoxLogic.ResetTextBox(textBoxSearch, "Name, Email, or Phone Number");
            RefreshTable();
        }
        public void RefreshTable()
        {
            DataTable tableView = userInfo.Select();
            dgvTableView.DataSource = tableView;
        }
        public bool ValidationCheck()
        {
            int a = int.TryParse(textBoxFromZipCode.Text, out a) ? a : 0;
            int b = int.TryParse(textBoxToZipCode.Text, out b) ? b : 0;
            int c = int.TryParse(textBoxRoomCount.Text, out c) ? c : 0;
            if (a != 0 && b != 0 && c != 0)
                return true;

            else
            {
                MessageBox.Show("The zip codes and rooms fields require numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //READ OBJECT TEXT AND USE THAT BEFORE WIPING SO YOU DONT HAVE TO STATE THE DEFAULT TEXT BELOW //THEN USE EXPRESSION BODY FOR ALL
        private void TextBoxFirstName_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "First Name");
        }
        private void TextBoxFirstName_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "First Name");
        }
        private void TextBoxLastName_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "Last Name");
        }
        private void TextBoxLastName_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "Last Name");
        }
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "xxxx@xxxxx.com");
        }
        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "xxxx@xxxxx.com");
        }
        private void TextBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "xxx-xxx-xxxx");
        }
        private void TextBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "xxx-xxx-xxxx");
        }
        private void TextBoxFromStreet_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "Street");
        }
        private void TextBoxFromStreet_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "Street");
        }
        private void TextBoxToStreet_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "Street");
        }
        private void TextBoxToStreet_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "Street");
        }
        private void TextBoxFromCity_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "City");
        }
        private void TextBoxFromCity_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "City");
        }
        private void TextBoxToCity_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "City");
        }
        private void TextBoxToCity_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "City");
        }
        private void TextBoxFromState_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "ST");
        }
        private void TextBoxFromState_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "ST");
        }
        private void TextBoxToState_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "ST");
        }
        private void TextBoxToState_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "ST");
        }
        private void TextBoxFromZipCode_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "Zip Code");
        }
        private void TextBoxFromZipCode_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "Zip Code");
        }
        private void TextBoxToZipCode_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "Zip Code");
        }
        private void TextBoxToZipCode_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "Zip Code");
        }
        private void TextBoxNotes_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "Additional Information");
        }
        private void TextBoxNotes_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "Additional Information");
        }
        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "Name, Email, or Phone Number");
        }
        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "Name, Email, or Phone Number");
            TextBox passedBox = (TextBox)sender;
            if(passedBox.Text == "Name, Email, or Phone Number")
            {
                RefreshTable();
            }
        }
        private void TextBoxRoomCount_Enter(object sender, EventArgs e)
        {
            TextBoxLogic.EnterTextBox(sender, "xx");
        }
        private void TextBoxRoomCount_Leave(object sender, EventArgs e)
        {
            TextBoxLogic.LeaveTextBox(sender, "xx");
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool check = ValidationCheck();
            if (check)
            {
                userInfo.FirstName = textBoxFirstName.Text;
                userInfo.LastName = textBoxLastName.Text;
                userInfo.Email = textBoxEmail.Text;
                userInfo.PhoneNumber = textBoxPhoneNumber.Text;
                userInfo.MoveDate = dateTimeMoveDate.Value;
                userInfo.FromStreet = textBoxFromStreet.Text;
                userInfo.FromCity = textBoxFromCity.Text;
                userInfo.FromState = textBoxFromState.Text;
                userInfo.FromZipCode = Convert.ToInt32(textBoxFromZipCode.Text);
                userInfo.ToStreet = textBoxToStreet.Text;
                userInfo.ToCity = textBoxToCity.Text;
                userInfo.ToState = textBoxToState.Text;
                userInfo.ToZipCode = Convert.ToInt32(textBoxToZipCode.Text);
                userInfo.Rooms = Convert.ToInt32(textBoxRoomCount.Text);
                userInfo.Notes = textBoxNotes.Text;

                bool success = userInfo.Submit(userInfo);
                if (success)
                {
                    MessageBox.Show("User Added Successfully", "New User");
                    RefreshTable();
                    ResetTextBoxes();
                }
            }
        }
        private void DgvTableView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            EnterAllFields();
            userInfo.CustomerID = (Int32)dgvTableView.Rows[rowIndex].Cells[0].Value;
            textBoxFirstName.Text = dgvTableView.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvTableView.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxEmail.Text = dgvTableView.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxPhoneNumber.Text = dgvTableView.Rows[rowIndex].Cells[4].Value.ToString();
            dateTimeMoveDate.Value = (DateTime)dgvTableView.Rows[rowIndex].Cells[5].Value;
            textBoxFromStreet.Text = dgvTableView.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxFromCity.Text = dgvTableView.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxFromState.Text = dgvTableView.Rows[rowIndex].Cells[8].Value.ToString();
            textBoxFromZipCode.Text = dgvTableView.Rows[rowIndex].Cells[9].Value.ToString();
            textBoxToStreet.Text = dgvTableView.Rows[rowIndex].Cells[10].Value.ToString();
            textBoxToCity.Text = dgvTableView.Rows[rowIndex].Cells[11].Value.ToString();
            textBoxToState.Text = dgvTableView.Rows[rowIndex].Cells[12].Value.ToString();
            textBoxToZipCode.Text = dgvTableView.Rows[rowIndex].Cells[13].Value.ToString();
            textBoxRoomCount.Text = dgvTableView.Rows[rowIndex].Cells[14].Value.ToString();
            textBoxNotes.Text = dgvTableView.Rows[rowIndex].Cells[15].Value.ToString();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (userInfo.CustomerID == 0)
                MessageBox.Show("You Must Select a Customer Row Before Updating Fields", "Customer Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                bool check = ValidationCheck();

                if (check)
                {
                    userInfo.FirstName = textBoxFirstName.Text;
                    userInfo.LastName = textBoxLastName.Text;
                    userInfo.Email = textBoxEmail.Text;
                    userInfo.PhoneNumber = textBoxPhoneNumber.Text;
                    userInfo.MoveDate = dateTimeMoveDate.Value;
                    userInfo.FromStreet = textBoxFromStreet.Text;
                    userInfo.FromCity = textBoxFromCity.Text;
                    userInfo.FromState = textBoxFromState.Text;
                    userInfo.FromZipCode = Convert.ToInt32(textBoxFromZipCode.Text);
                    userInfo.ToStreet = textBoxToStreet.Text;
                    userInfo.ToCity = textBoxToCity.Text;
                    userInfo.ToState = textBoxToState.Text;
                    userInfo.ToZipCode = Convert.ToInt32(textBoxToZipCode.Text);
                    userInfo.Rooms = Convert.ToInt32(textBoxRoomCount.Text);
                    userInfo.Notes = textBoxNotes.Text;
                    bool success = userInfo.Update(userInfo);

                    if (success)
                    {
                        MessageBox.Show("User Update Successful", "Update User");
                        RefreshTable();
                        ResetTextBoxes();
                    }
                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear all fields?", "Clear All Fields", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                ResetTextBoxes();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (userInfo.CustomerID == 0)
                MessageBox.Show("You Must Select a Customer Row Before Deleting It", "Customer Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                var input = MessageBox.Show("Are You Sure You Want To Delete Selected User?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (input == DialogResult.Yes)
                {
                    userInfo.Delete(userInfo);
                    RefreshTable();
                    ResetTextBoxes();
                }
            }
        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
                DataTable dt = userInfo.Search(sender);
                dgvTableView.DataSource = dt;
        }
    }
}
