using FormCRUD.Models;

namespace FormCRUD
{
    public partial class Form1 : Form
    {
        DatabaseConnection dbCon = new DatabaseConnection();
        UserRepository userRep = new UserRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            string name = nametextBox.Text;
            string email = emailtextBox.Text;
            if (Name=="" || email == "")
            {
                MessageBox.Show("Erreur");
            }
            else
            {
                Users user = new Users(name, email);
                try
                {
                    userRep.AddUser(user);
                    MessageBox.Show("Enregistrement reussi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
