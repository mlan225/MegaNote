using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace MegaNote
{
    public partial class megaNote : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        string string_ID = null;
        int int_ID = -1;

        

        public megaNote()
        {
            InitializeComponent();
        }

        private void MegaNote_Load(object sender, EventArgs e)
        {

            //notesDataGrid properties
            notesDataGrid.ColumnHeadersVisible = false;
            notesDataGrid.ReadOnly = true;
            notesDataGrid.AllowUserToAddRows = false;
            notesDataGrid.AllowUserToResizeRows = false;
            notesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            displayData();
            notesDataGrid.Columns["Title"].Width = 180;
            notesDataGrid.Columns["DateCreated"].Width = 100;
        }

        private void clearNote_Click(object sender, EventArgs e)
        {
            noteTitleInput.Clear();
            noteMessageInput.Clear();
        }

        private void saveNote_Click(object sender, EventArgs e)
        {
            if(string_ID != null)
            {
                cmd = new SqlCommand("update Notes set title=@title,message=@message where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@title", noteTitleInput.Text);
                cmd.Parameters.AddWithValue("@message", noteMessageInput.Text);
                cmd.Parameters.AddWithValue("@id", int_ID);
                cmd.ExecuteNonQuery();
                con.Close();
                displayData();
                clearData();
                clearRowSelection();
            } else
            {
                DateTime current_dateTime = DateTime.Now;
                cmd = new SqlCommand("insert into Notes(title,message,dateCreated) values(@title,@message,@dateCreated)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@title", noteTitleInput.Text);
                cmd.Parameters.AddWithValue("@message", noteMessageInput.Text);
                cmd.Parameters.AddWithValue("@dateCreated", current_dateTime.ToString("d", DateTimeFormatInfo.InvariantInfo));
                cmd.ExecuteNonQuery();
                con.Close();
                displayData();
                clearData();
                clearRowSelection();
            }
        }

        private void displayData()
        {
            con.Open();
            DataTable notes = new DataTable();
            adapt = new SqlDataAdapter("select * from Notes", con);

            adapt.Fill(notes);
            notesDataGrid.DataSource = notes;
            notesDataGrid.Columns["message"].Visible = false;
            notesDataGrid.Columns["id"].Visible = false;
            con.Close();
        }

        private void clearData()
        {
            noteTitleInput.Clear();
            noteMessageInput.Clear();
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            if (string_ID != null)
            {
                cmd = new SqlCommand("delete Notes where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", int_ID);
                cmd.ExecuteNonQuery();
                con.Close();
                displayData();
                clearData();
                clearRowSelection();
            }
        }

        private void notesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (notesDataGrid.CurrentCell.ColumnIndex.Equals(1) || notesDataGrid.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (notesDataGrid.CurrentCell != null && notesDataGrid.CurrentCell.Value != null)
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = notesDataGrid.Rows[index];
                    int_ID = (int) selectedRow.Cells[0].Value;
                    notesDataGrid.Rows[index].Selected = true;

                    string_ID = int_ID.ToString();
                    noteTitleInput.Text = (string) selectedRow.Cells[1].Value;
                    noteMessageInput.Text = (string)selectedRow.Cells[2].Value;
                }
            }
        }

        private void clearSelection_Click(object sender, EventArgs e)
        {
            clearRowSelection();
        }

        private void clearRowSelection()
        {
            notesDataGrid.ClearSelection();
            int_ID = -1;
            string_ID = null;
        }

    }
}
