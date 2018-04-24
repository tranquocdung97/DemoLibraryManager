using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class FormMain : Form
    {
        SqlConnection connec = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=LibraryManager;Integrated Security=True");
        String BookID = "";
        public FormMain()
        {
            InitializeComponent();
            connec.Open();
            DataReload();
            labelDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void DataReload()
        {
            String sqlSelect = "SELECT * FROM Books";
            SqlCommand com = new SqlCommand(sqlSelect, connec);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }catch(Exception)
            {
                MessageBox.Show("Failed to connect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connec.Close();
        }
        private void Reload()
        {
            try
            {
                DataReload();
                MessageBox.Show("Refresh Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {

            }
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxPage.Text = "";
            textBoxTopic.Text = "";
            textBoxCode.Text = "";
        }
        private void Add()
        {        
            if(textBoxTitle.Text=="")
            {
                MessageBox.Show("You need set the title of the book!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataReload();
            }
            else
            {
                connec.Open();
                String sqlAdd = "INSERT INTO Books (Title,Author,Page_Count,Topic,Code) VALUES('" + textBoxTitle.Text.Trim() + "','" + textBoxAuthor.Text.Trim() + "','" + textBoxPage.Text.Trim() + "','" + textBoxTopic.Text.Trim() + "','" + textBoxCode.Text.Trim() + "')";
                SqlCommand com = new SqlCommand(sqlAdd, connec);
                try
                {
                    com.ExecuteNonQuery();
                    DialogResult dlr = MessageBox.Show("Add Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                        DataReload();
                }catch(Exception)
                {
                    MessageBox.Show("Incorrect data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connec.Close();
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPage.Text = "";
                textBoxTopic.Text = "";
                textBoxCode.Text = "";                
            }
        }
        private void Delete()
        {
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("You need set the title of the book!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataReload();
            }
            else
            {
                connec.Open();
                String sqlDelete = "DELETE FROM Books where Title='" + textBoxTitle.Text.Trim() + "'";
                if (textBoxAuthor.Text != "")
                {
                    sqlDelete += "AND Author='" + textBoxAuthor.Text.Trim() + "'";
                }
                if (textBoxPage.Text != "")
                {
                    sqlDelete += "AND Page_Count='" + textBoxPage.Text.Trim() + "'";
                }
                if (textBoxTopic.Text != "")
                {
                    sqlDelete += "AND Topic='" + textBoxTopic.Text.Trim() + "'";
                }
                if (textBoxCode.Text != "")
                {
                    sqlDelete += "AND Code='" + textBoxCode.Text.Trim() + "'";
                }
                SqlCommand com = new SqlCommand(sqlDelete, connec);
                try
                {
                    com.ExecuteNonQuery();
                    DialogResult dlr = MessageBox.Show("Delete Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                        DataReload();                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connec.Close();
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPage.Text = "";
                textBoxTopic.Text = "";
                textBoxCode.Text = "";
            }      
        }
        private void Search()
        {
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("You need set the title of the book!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataReload();
            }
            else
            {
                connec.Open();
                String sqlSelect = "SELECT Title,Author,Page_Count,Topic,Code FROM Books where Title='" + textBoxTitle.Text.Trim() + "'";
                if (textBoxAuthor.Text != "")
                {
                    sqlSelect += "AND Author='" + textBoxAuthor.Text.Trim() + "'";
                }
                if (textBoxPage.Text != "")
                {
                    sqlSelect += "AND Page_Count='" + textBoxPage.Text.Trim() + "'";
                }
                if (textBoxTopic.Text != "")
                {
                    sqlSelect += "AND Topic='" + textBoxTopic.Text.Trim() + "'";
                }
                if (textBoxCode.Text != "")
                {
                    sqlSelect += "AND Code='" + textBoxCode.Text.Trim() + "'";
                }
                SqlCommand com = new SqlCommand(sqlSelect, connec);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }catch(Exception)
                {
                    MessageBox.Show("Incorrect data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connec.Close();
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPage.Text = "";
                textBoxTopic.Text = "";
                textBoxCode.Text = "";
            }      
        }
        private void Modify()
        {
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("You need set the title of the book!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataReload();
            }
            else
            {
                connec.Open();
                String sqlUpdate = "UPDATE Books SET Title='"+textBoxTitle.Text+"', Author='" + textBoxAuthor.Text.Trim() + "', Page_Count='" + textBoxPage.Text.Trim() + "', Topic='" + textBoxTopic.Text.Trim() + "', Code='" + textBoxCode.Text.Trim() + "'FROM Books where BookID='" + BookID + "'";
                SqlCommand com = new SqlCommand(sqlUpdate, connec);
                try
                {
                    com.ExecuteNonQuery();
                    DialogResult dlr = MessageBox.Show("Update Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                        DataReload();                   
                }
                catch(Exception)
                {
                    MessageBox.Show("Incorrect data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connec.Close();
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPage.Text = "";
                textBoxTopic.Text = "";
                textBoxCode.Text = "";
                
            }
        }
        private void Exit()
        {
            DialogResult dlr = MessageBox.Show("Do you want to sign out?", "Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dlr==DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void toolStrip1_ItemClick(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text.ToString())
            {
                case "Reload":
                    Reload();
                    break;
                case "Add":
                    Add();
                    break;
                case "Delete":
                    Delete();
                    break;
                case "Search":
                    Search();
                    break;
                case "Modify":
                    Modify();
                    break;
                case "Exit":
                    Exit();
                    break;
                default: 
                    break;

            }
        }

        private void menuItemExit(object sender, EventArgs e)
        {
            Exit();
        }

        private void menuItemReload(object sender, EventArgs e)
        {
            Reload();
        }

        private void menuItemAdd(object sender, EventArgs e)
        {
            Add();
        }

        private void menuItemDelete(object sender, EventArgs e)
        {
            Delete();
        }

        private void menuItemSearch(object sender, EventArgs e)
        {
            Search();
        }
        private void menuItemModify(object sender, EventArgs e)
        {
            Modify();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dataGridView1.CurrentCell.RowIndex;
            BookID = dataGridView1.Rows[d].Cells[0].Value.ToString();
            textBoxTitle.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            textBoxAuthor.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            textBoxPage.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            textBoxTopic.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
            textBoxCode.Text = dataGridView1.Rows[d].Cells[5].Value.ToString();
        }


    }
}
