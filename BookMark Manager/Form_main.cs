using System;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMark_Manager
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            this.Text = "BookMark Manager";
        }

        SQLiteConnection sqlite_conn;

        private void Form_main_Load(object sender, EventArgs e)
        {
            bool isNew;
            // Check if database is found
            if (!File.Exists("database.sqlite"))
            {
                sqlite_conn = new SQLiteConnection("Data Source = database.sqlite; Version = 3; New = True; Compress = True; ");
                isNew = true;
            }
            else
            {
                sqlite_conn = new SQLiteConnection("Data Source = database.sqlite; Version = 3; New = False; Compress = True; ");
                isNew = false;
            }

            // Open connection
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Is database is new, create tables
            if (isNew)
            {
                Task _w = Task.Factory.StartNew(() => WriteBasicTables());
                Task.WaitAll(_w);
            }

            // Load all lists from SQLite
            FillAll();
        }
        /////////////////////////// METHODS ////////////////////////////
        // Write initial DB file
        private void WriteBasicTables()
        {
            string _q1 = "CREATE TABLE Links(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, link VARCHAR(1000), description VARCHAR(50), category INTEGER)";
            string _q2 = "CREATE TABLE Category(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name VARCHAR(50))";
            string _q3 = "INSERT INTO Category (name) VALUES ('Catégorie par défaut')";
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = _q1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = _q2;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = _q3;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.Dispose();
        }

        //Fill lists
        private void FillAll()
        {
            ReloadCategories();
            ReloadLinks();
        }

        private void ReloadCategories()
        {
            dataGridView_category.Rows.Clear();
            string _q1 = "SELECT id, name FROM Category";
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = _q1;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            //DataGridViewRow newRow = new DataGridViewRow(); // Add default category in first
            //newRow.CreateCells(dataGridView_category);
            //newRow.Cells[0].Value = 0;
            //newRow.Cells[1].Value = "Aucune catégorie";
            //dataGridView_category.Rows.Add(newRow);
            while (sqlite_datareader.Read())
            {
                DataGridViewRow newRow1 = new DataGridViewRow();
                newRow1.CreateCells(dataGridView_category);
                newRow1.Cells[0].Value = sqlite_datareader.GetInt32(0);
                newRow1.Cells[1].Value = sqlite_datareader.GetString(1);
                dataGridView_category.Rows.Add(newRow1);
            }
            sqlite_datareader.Close();
        }
        private void ReloadLinks()
        {
            string _q1 = "SELECT Links.id, Links.link, Links.description, Category.name FROM Links INNER JOIN Category ON Links.category = Category.id";
            dataGridView_links.Rows.Clear();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = _q1;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView_links);
                newRow.Cells[0].Value = sqlite_datareader.GetInt32(0);
                newRow.Cells[1].Value = sqlite_datareader.GetString(1);
                newRow.Cells[2].Value = sqlite_datareader.GetString(2);
                newRow.Cells[3].Value = sqlite_datareader.GetString(3);
                dataGridView_links.Rows.Add(newRow);
            }
            sqlite_datareader.Close();
        }

        /////////////////////////// BUTTONS ////////////////////////////
        // Add category
        private void Button_add_cat_Click(object sender, EventArgs e)
        {
            if (textBox_cat_add.Text != "")
            {
                string _q1 = "INSERT INTO Category (name) VALUES ('" + textBox_cat_add.Text + "')";
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = _q1;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.Dispose();
                textBox_cat_add.Clear();
                ReloadCategories();
            }
            else
            {
                MessageBox.Show("Le champ ne doit pas être vide ! ", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Del category
        private void Button_del_cat_Click(object sender, EventArgs e)
        {
            if (dataGridView_category.SelectedCells.Count > 0)
            {
                if (dataGridView_category.CurrentRow.Cells["col_cat_id"].Value.ToString() != "1")
                {
                    string _q1 = "DELETE FROM Category WHERE id = '" + dataGridView_category.CurrentRow.Cells["col_cat_id"].Value.ToString() + "'";
                    string _q2 = "UPDATE Links SET category='" + 1 + "' WHERE category='" + dataGridView_category.CurrentRow.Cells["col_cat_id"].Value.ToString() + "'";
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = _q1;
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_cmd.CommandText = _q2;
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_cmd.Dispose();
                    FillAll();
                }
                else
                {
                    MessageBox.Show("Impossible de supprimer la catégorie par défaut !", "Action non autorisée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show("Pas de ligne sélectionnée !", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Delete link
        private void Button_del_link_Click(object sender, EventArgs e)
        {
            if (dataGridView_links.SelectedCells.Count > 0)
            {
                string _q1 = "DELETE FROM Links WHERE id = '" + dataGridView_links.CurrentRow.Cells["col_link_id"].Value.ToString() + "'";
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = _q1;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.Dispose();
                ReloadLinks();
            }
            else
            {
                MessageBox.Show("Pas de ligne sélectionnée !", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Add link
        private void Button_addlink_Click(object sender, EventArgs e)
        {
            if (dataGridView_category.SelectedCells.Count > 0)
            {
                if ((textBox_add_link.Text != "") && (textBox_add_desc.Text != ""))
                {

                    string _q1 = "INSERT INTO Links (link, description, category) VALUES ('" + textBox_add_link.Text + "','" + textBox_add_desc.Text + "','" + dataGridView_category.CurrentRow.Cells["col_cat_id"].Value.ToString() + "')";
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = _q1;
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_cmd.Dispose();
                    ReloadLinks();
                    textBox_add_link.Clear();
                    textBox_add_desc.Clear();
                }
                else
                {
                    MessageBox.Show("Les champs ne doit pas être vides ! ", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Pas de catégorie sélectionnée !", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Reload list
        private void Button_reinitlist_Click(object sender, EventArgs e)
        {
            ReloadLinks();
        }

        // Search link
        private void Button_search_Click(object sender, EventArgs e)
        {
            int _m = 0;
            string _q;
            if ((!checkBox_link.Checked == false) || (!checkBox_desc.Checked == false))
            {
                if (textBox_search.Text.Length >= 3)
                {
                    if ((checkBox_link.Checked == true) && (checkBox_desc.Checked == false))
                    {
                        _m = 1;
                    }
                    else if ((checkBox_desc.Checked == true) && (checkBox_link.Checked == false))
                    {
                        _m = 2;
                    }
                    else if ((checkBox_link.Checked == true) && (checkBox_desc.Checked == true))
                    {
                        _m = 3;
                    }

                    switch (_m)
                    {
                        case 1:
                            _q = "SELECT Links.id, Links.link, Links.description, Category.name FROM Links INNER JOIN Category ON Links.category = Category.id WHERE Links.link LIKE '%" + textBox_search.Text + "%'";
                            break;
                        case 2:
                            _q = "SELECT Links.id, Links.link, Links.description, Category.name FROM Links INNER JOIN Category ON Links.category = Category.id WHERE Links.description LIKE '%" + textBox_search.Text + "%'";
                            break;
                        case 3:
                            _q = "SELECT Links.id, Links.link, Links.description, Category.name FROM Links INNER JOIN Category ON Links.category = Category.id WHERE Links.link LIKE '%" + textBox_search.Text + "%' OR Links.description LIKE '%" + textBox_search.Text + "%'";
                            break;
                        default:
                            _q = "SELECT Links.id, Links.link, Links.description, Category.name FROM Links INNER JOIN Category ON Links.category = Category.id";
                            break;
                    }

                    dataGridView_links.Rows.Clear();
                    SQLiteDataReader sqlite_datareader;
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = _q;
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    while (sqlite_datareader.Read())
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView_links);
                        newRow.Cells[0].Value = sqlite_datareader.GetInt32(0);
                        newRow.Cells[1].Value = sqlite_datareader.GetString(1);
                        newRow.Cells[2].Value = sqlite_datareader.GetString(2);
                        newRow.Cells[3].Value = sqlite_datareader.GetString(3);
                        dataGridView_links.Rows.Add(newRow);
                    }
                    sqlite_datareader.Close();
                }
                else
                {
                    MessageBox.Show("Trois caractères au minimun sont requis pour la recherche !", "Critère de recherche trop court", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Pas de mode de recherche sélectionné !", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Assign category
        private void Button_assign_cat_Click(object sender, EventArgs e)
        {
            if ((dataGridView_category.SelectedCells.Count > 0) || (dataGridView_links.SelectedCells.Count > 0))
            {
                string _q1 = "UPDATE Links SET category='" + dataGridView_category.CurrentRow.Cells["col_cat_id"].Value.ToString() + "' WHERE Links.id = '" + dataGridView_links.CurrentRow.Cells["col_link_id"].Value.ToString() + "'";
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = _q1;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.Dispose();
                textBox_cat_add.Clear();
                ReloadLinks();
            }
            else
            {
                MessageBox.Show("Il faut séléctionner à la fois un lien et \nune catégorie pour cette action !", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Show links regarding category
        private void Button_show_links_Click(object sender, EventArgs e)
        {
            string _q1 = "SELECT Links.id, Links.link, Links.description, Category.name FROM Links INNER JOIN Category ON Links.category = Category.id WHERE Category.id ='" + dataGridView_category.CurrentRow.Cells["col_cat_id"].Value.ToString() + "'";
            dataGridView_links.Rows.Clear();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = _q1;
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView_links);
                newRow.Cells[0].Value = sqlite_datareader.GetInt32(0);
                newRow.Cells[1].Value = sqlite_datareader.GetString(1);
                newRow.Cells[2].Value = sqlite_datareader.GetString(2);
                newRow.Cells[3].Value = sqlite_datareader.GetString(3);
                dataGridView_links.Rows.Add(newRow);
            }
            sqlite_datareader.Close();

        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        private void DataGridView_links_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (Uri.IsWellFormedUriString(dataGridView_links.Rows[e.RowIndex].Cells[1].Value.ToString(), UriKind.Absolute))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(dataGridView_links.Rows[e.RowIndex].Cells[1].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }
                else if (IsValidEmail(dataGridView_links.Rows[e.RowIndex].Cells[1].Value.ToString()))
                {
                    try
                    {
                        System.Diagnostics.Process.Start("mailto:" + dataGridView_links.Rows[e.RowIndex].Cells[1].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }
            }
        }
    }
}
