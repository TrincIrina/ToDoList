using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class MyForm : Form
    {
        
        public MyForm()
        {
            InitializeComponent();

            DateTime dateTime = DateTime.Now;
            string dt = Convert.ToString(dateTime);

            todoListBox.Items.Add($"1. Write a to - do list. {dt}");
            todoListBox.Items.Add($"2. Pretend to be very busy with work. {dt}");
            todoListBox.Items.Add($"3. Come up with an interesting point. {dt}");
            todoListBox.Items.Add($"4. Surf the internet. {dt}");
            todoListBox.Items.Add($"5. He said he was very tired. {dt}");
            todoListBox.Items.Add($"6. Post a 'To - do list'. {dt}");            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Выход - использование диалогового окна
            DialogResult result = MessageBox.Show(
                "Do you really want to get out?",
                "EXIT",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string dt = Convert.ToString(dateTime);
            if (todoTextBox.Text == String.Empty ||
                todoTextBox.Text == null)
            {
                MessageBox.Show("Enter a value",
                    "ERROR", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                todoListBox.Items.Add($"{todoListBox.Items.Count + 1}. " +
                    $"{todoTextBox.Text} {dt}");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string dt = Convert.ToString(dateTime);
            if (todoListBox.SelectedIndex != -1)
            {
                todoListBox.Items[todoListBox.SelectedIndex] = $"{todoListBox.SelectedIndex + 1}." +
                    $" {todoTextBox.Text} {dt}";
            }
            else
            {
                MessageBox.Show("The objecthas not been selected for updating",
                    "ERROR", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string dt = Convert.ToString(dateTime);
            if (todoListBox.SelectedIndex != -1)
            {
                string selected = todoListBox.SelectedItem.ToString();
                int l = selected.Length - dt.Length - selected.IndexOf(" ") - 1; 
                todoTextBox.Text = selected.Substring(selected.IndexOf(" ") + 1, l);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedIndex != -1)
            {
                int selected = todoListBox.SelectedIndex;
                todoListBox.Items.RemoveAt(selected);
                for (int i = selected; i < todoListBox.Items.Count; i++)
                {
                    string strItem = todoListBox.Items[i].ToString();
                    todoListBox.Items[i] = $"{i + 1}. {strItem.Substring(strItem.IndexOf(" ") + 1)}";
                }
            }
            else
            {
                MessageBox.Show("Nothing is selected",
                    "ERROR  ",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            DialogResult isOk = MessageBox.Show("Are you sure you want to delete it?",
                "CLEARING", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (isOk == DialogResult.Yes)
            {
                todoListBox.Items.Clear();
            }
        }
    }
}
