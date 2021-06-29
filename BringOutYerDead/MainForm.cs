using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BringOutYerDead
{
    public partial class BringOutYerDead : Form
    {
        private Character CharacterManagement;

        public BringOutYerDead()
        {
            InitializeComponent();
            CharacterManagement = new Character();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Characters_List.Items.Add(Name_textbox.Text + " " + Sex_combobox.Text + " " + Age_textbox.Text);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {

        }

        private void Remove_button_Click(object sender, EventArgs e)
        {

        }

        private void Death_button_Click(object sender, EventArgs e)
        {

        }

        private void Birth_button_Click(object sender, EventArgs e)
        {

        }
    }
}
