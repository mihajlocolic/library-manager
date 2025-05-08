using System.Text.Json;
using LibraryManager.Models;

namespace LibraryManager.Forms
{
    public partial class MemberAddForm : Form
    {

        MainForm mainForm;
        List<Member> members = new List<Member>();

        public MemberAddForm(MainForm mf)
        {
            InitializeComponent();

            this.mainForm = mf;

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
                UpdateGridView();

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

        private void UpdateGridView()
        {

            BindingSource source = new BindingSource();

            foreach (Member m in members)
            {
                source.Add(m);
            }
            mainForm.dataGridView2.DataSource = source;


        }


    }
}
