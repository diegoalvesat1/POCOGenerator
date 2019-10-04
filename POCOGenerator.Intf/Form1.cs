using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace POCOGenerator.Intf
{
    public partial class Form1 : Form
    {
        private const string NoTables = "TableFilterInclude = new Regex(\"^$\");";
        private const string AllTables = "TableFilterInclude = null;";

        private int countAllTablesFromConnectionBase { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void connectToDatabase_Click(object sender, EventArgs e)
        {
            tables.Items.Clear();

            var dcd = new DataConnectionDialog();

            var sqlDataSource = DataSource.SqlDataSource;
            dcd.DataSources.Add(sqlDataSource);
            dcd.DataSources.Add(DataSource.SqlFileDataSource);
            dcd.SelectedDataSource = sqlDataSource;
            var result = DataConnectionDialog.Show(dcd);

            if (result != DialogResult.OK)
                return;

            connectionString.Text = dcd.ConnectionString;

            // Load tables
            using (var connection = new SqlConnection(dcd.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(
                    "SELECT t.name, s.name from sys.tables t INNER JOIN sys.schemas s ON t.schema_id = s.schema_id ORDER BY t.name",
                    connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Items.Add(new TableSchema(reader.GetString(0), reader.GetString(1)));
                    }
                }

                countAllTablesFromConnectionBase = tables.Items.Count;
            }
        }

        private void tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRegex();
        }

        private void UpdateRegex()
        {
            if (tables.CheckedItems.Count == 0)
            {
                regex.Text = NoTables;
                return;
            }

            var sb = new StringBuilder();
            sb.Append("TableFilterInclude = new Regex(\"");

            if (tables.CheckedItems.Count == countAllTablesFromConnectionBase)
            {
                regex.Text = AllTables;
                Clipboard.SetText(AllTables);
                return;
            }
            else
            {
                bool first = true;
                foreach (var item in tables.CheckedItems)
                {
                    if (!first)
                        sb.Append("|");
                    else
                        first = false;

                    var tableSchema = item as TableSchema;
                    if (tableSchema != null) sb.AppendFormat("^{0}$", tableSchema.TableName);
                }
            }

            sb.Append("\");");
            Clipboard.SetText(sb.ToString());
            regex.Text = sb.ToString();
        }

        private void selectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (var n = 0; n < tables.Items.Count; n++)
            {
                tables.SetItemCheckState(n, CheckState.Checked);
            }
            //regex.Text = AllTables;
            //Clipboard.SetText(AllTables);

            UpdateRegex();
        }

        private void selectNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (var n = 0; n < tables.Items.Count; n++)
            {
                tables.SetItemCheckState(n, CheckState.Unchecked);
            }
            regex.Text = NoTables;
            Clipboard.SetText(NoTables);
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString.Text))
                return;

            tables.Items.Clear();

            // Load tables
            using (var connection = new SqlConnection(connectionString.Text))
            {
                connection.Open();

                string query = "SELECT t.name, s.name from sys.tables t INNER JOIN sys.schemas s ON t.schema_id = s.schema_id ";

                if (!string.IsNullOrEmpty(sistema.Text))
                {
                    query += " WHERE t.name like '" + sistema.Text.ToUpper() + "%' ";
                }

                if (!string.IsNullOrEmpty(Tabela.Text))
                {
                    if (!string.IsNullOrEmpty(sistema.Text))
                        query += " OR t.name like '%" + Tabela.Text.ToUpper() + "%' ";
                    else
                        query += " WHERE t.name like '%" + Tabela.Text.ToUpper() + "%' ";
                }

                var cmd = new SqlCommand( query, connection);
                ;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Items.Add(new TableSchema(reader.GetString(0), reader.GetString(1)));
                    }
                }
            }
        }
    }
}
