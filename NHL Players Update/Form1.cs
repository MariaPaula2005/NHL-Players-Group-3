using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NHL_Players_Update;
using System.Globalization;
using static System.Net.WebRequestMethods;


namespace NHL_Players
{
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();
        private Parser parser = new Parser();
        private Sorting sorting = new Sorting();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            btn_ApplyFilter.FlatStyle = FlatStyle.Flat;
            btn_ApplyFilter.FlatAppearance.BorderSize = 0;
            btn_ApplySorting.FlatStyle = FlatStyle.Flat;
            btn_ApplySorting.FlatAppearance.BorderSize = 0;
            btnLoadCSV.FlatStyle = FlatStyle.Flat;
            btnLoadCSV.FlatAppearance.BorderSize = 0;
        }

        public void InitializeDataGridView()
        {
            dataGridViewPlayers.Columns.Clear();
            dataGridViewPlayers.Columns.Add("Name", "Name");
            dataGridViewPlayers.Columns.Add("Team", "Team");
            dataGridViewPlayers.Columns.Add("Pos", "Pos");
            dataGridViewPlayers.Columns.Add("GP", "GP");
            dataGridViewPlayers.Columns.Add("G", "G");
            dataGridViewPlayers.Columns.Add("A", "A");
            dataGridViewPlayers.Columns.Add("P", "P");
            dataGridViewPlayers.Columns.Add("PlusMinus", "+/-");
            dataGridViewPlayers.Columns.Add("PIM", "PIM");
            dataGridViewPlayers.Columns.Add("PGP", "PGP");
            dataGridViewPlayers.Columns.Add("PPG", "PPG");
            dataGridViewPlayers.Columns.Add("PPP", "PPP");
            dataGridViewPlayers.Columns.Add("SHG", "SHG");
            dataGridViewPlayers.Columns.Add("SHP", "SHP");
            dataGridViewPlayers.Columns.Add("GWG", "GWG");
            dataGridViewPlayers.Columns.Add("OTG", "OTG");
            dataGridViewPlayers.Columns.Add("S", "S");
            dataGridViewPlayers.Columns.Add("SPercentage", "SPercentage");
            dataGridViewPlayers.Columns.Add("TOIGP", "TOIGP");
            dataGridViewPlayers.Columns.Add("ShiftsGP", "ShiftsGP");
            dataGridViewPlayers.Columns.Add("FOWPercentage", "FOWPercentage");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

        }


        private void btnLoadCSV_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    players = parser.ParseCSVFile(openFileDialog.FileName);
                    DisplayPlayersInDataGridView(players);
                }
            }
        }


        private void btn_ApplyFilter_Click(object sender, EventArgs e)
        {
            var filteredPlayers = Filter.ApplyFilter(players, textBoxFilter.Text);
            DisplayPlayersInDataGridView(filteredPlayers);
        }

        private void btn_ApplySorting_Click(object sender, EventArgs e)
        {
            bool ascending = comboBoxSortingOrder.SelectedItem.ToString() == "Ascending";
            var sortedPlayers = sorting.Sort(players, comboBoxSorting.SelectedItem.ToString(), ascending);
            DisplayPlayersInDataGridView(sortedPlayers);
        }
        private void DisplayPlayersInDataGridView(List<Player> playersToDisplay)
        {
            dataGridViewPlayers.Rows.Clear();
            foreach (var player in playersToDisplay)
            {
                dataGridViewPlayers.Rows.Add(
                    player.Name, player.Team, player.Pos, player.GP, player.G, player.A, player.P,
                    player.PlusMinus, player.PIM, player.PGP, player.PPG, player.PPP, player.SHG,
                    player.SHP, player.GWG, player.OTG, player.S, player.SPercentage, player.TOIGP,
                    player.ShiftsGP, player.FOWPercentage
                );
            }

        }
    }
}
