using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManager.Forms
{
    public partial class MemberAddForm : Form
    {

        List<Member> members = new List<Member>();

        public MemberAddForm()
        {
            InitializeComponent();

            FileInfo membersFile = new FileInfo("members.json");
            if (membersFile.Length > 0)
            {
                using (StreamReader reader = new StreamReader("members.json"))
                {
                    string tmp = reader.ReadToEnd();
                    members = JsonSerializer.Deserialize<List<Member>>(tmp);
                }
            }
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            if (memberFirstName.Text.Length > 0 && memberLastName.Text.Length > 0 && memberPhoneNumber.Text.Length > 0)
            {

                if (members.Count > 0)
                {
                    Member tmp = new(members.Last().id + 1, memberFirstName.Text, memberLastName.Text, memberPhoneNumber.Text);
                    members.Add(tmp);
                }
                else
                {
                    Member tmp = new(1, memberFirstName.Text, memberLastName.Text, memberPhoneNumber.Text);
                    members.Add(tmp);
                }

                SaveMembers();

            }
            else
            {
                memberAddErrorLabel.Text = "All fields must be populated!";
            }
        }

        private void SaveMembers()
        {
            if (File.Exists("members.json"))
            {
                using (StreamWriter sw = new StreamWriter("members.json"))
                {
                    string json = JsonSerializer.Serialize(members);
                    sw.WriteLine(json);

                }
                Close(); // Closing the form once the book is added and saved.
            }
            else
            {
                Console.WriteLine("Error: JSON file missing. Cannot save.");
            }
        }


    }
}
