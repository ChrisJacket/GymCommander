using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace GymCommander
{
    public partial class MainForm : Form
    {
        public static string currentVersion = "0.0.2";
        public MainForm()
        {
            InitializeComponent();
        }

        List<Customer> FullMemberList = new List<Customer>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Gym Commander v{currentVersion}";

            TestingInitializer();

            ListViewInit();
            LoadDataIntoListView();
            
        }

        private void TestingInitializer()
        {
            Customer client1 = new Customer("123", "Ion Palasca", MembershipTypes.Full_Fitness, DateOnly.Parse("22/03/2026", new CultureInfo("ro-RO")));
            Customer client2 = new Customer("346", "Gicu Piticu", MembershipTypes.Cardio_Only, DateOnly.Parse("04/04/2025", new CultureInfo("ro-RO")));
            Customer client3 = new Customer("7357", "Gigi Dumbrava", MembershipTypes.Weights_Only, DateOnly.Parse("09/08/2027", new CultureInfo("ro-RO")));
            FullMemberList.AddRange(new List<Customer> { client1, client2, client3 });

        }
        
        private void LoadDataIntoListView()
        {
            foreach (Customer client in FullMemberList)
            {
                // the second array member will become a button
                // that opens a dialog box with the person's photo

                string[] RowToAdd = { client.MemberID, "//", client.Name, client.MembershipType, client.MembershipExpiration.ToString() };

                if (client.MembershipExpiration.AddDays(-10) < DateOnly.FromDateTime(DateTime.UtcNow))
                {
                    // the TimeOnly is set to 23:59:59 so that membership is still valid on the day it expires
                    int DaysUntilExpiration = (client.MembershipExpiration.ToDateTime(new TimeOnly(23,59,59)) - DateTime.UtcNow).Days;
                    RowToAdd[4] += " (" + DaysUntilExpiration + " days left)";
                }
                MainListView.Items.Add(new ListViewItem(RowToAdd));
            }
        }

        private void ListViewInit()
        {
            MainListView.Clear();
            MainListView.View = View.Details;
            MainListView.GridLines = true;

            ColumnHeader IdColumn = new ColumnHeader();
            MainListView.Columns.Add(IdColumn);
            MainListView.Columns[0].Text = "ID";

            ColumnHeader PhotoColumn = new ColumnHeader();
            MainListView.Columns.Add(PhotoColumn);
            MainListView.Columns[1].Text = "Photo";
            MainListView.Columns[1].TextAlign = HorizontalAlignment.Left;

            ColumnHeader NameColumn = new ColumnHeader();
            MainListView.Columns.Add(NameColumn);
            MainListView.Columns[2].Text = "Name";
            MainListView.Columns[2].TextAlign = HorizontalAlignment.Left;
            MainListView.Columns[2].Width = 250;

            ColumnHeader MembershipTypeColumn = new ColumnHeader();
            MainListView.Columns.Add(MembershipTypeColumn);
            MainListView.Columns[3].Text = "Membership Type";
            MainListView.Columns[3].TextAlign = HorizontalAlignment.Left;
            MainListView.Columns[3].Width = 250;

            ColumnHeader MembershipExpirationColumn = new ColumnHeader();
            MainListView.Columns.Add(MembershipExpirationColumn);
            MainListView.Columns[4].Text = "Expiration Date";
            MainListView.Columns[4].TextAlign = HorizontalAlignment.Left;
            MainListView.Columns[4].Width = 299;
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == " Cautare...")
            {
                SearchTextBox.Text = string.Empty;
                SearchTextBox.Font = new Font(SearchTextBox.Font, FontStyle.Regular);
            }
        }
    }

    class Customer
    {
        // all nullables are for testing
        // placeholders should be used when possible, and nullable disabled

        public string MemberID { get; private set; }
        public string? PathToPhoto { get; private set; }
        public string Name { get; private set; }
        public string MembershipType { get; private set; }
        public DateOnly MembershipExpiration { get; private set; }

        // for statistical use
        public DateOnly LastVisit {  get; private set; }
        public int VisitsThisMonth { get; private set; }

        public Customer(string memberID, string name, MembershipTypes membershipType, DateOnly membershipExpiration)
        {   
            MemberID = memberID;
            PathToPhoto = "../../../images/" + name.Replace(" ", "_") + ".jpg";
            Name = name; 
            switch (membershipType)
            {
                case MembershipTypes.Full_Fitness:
                    this.MembershipType = "Full Fitness";
                    break;
                case MembershipTypes.Weights_Only:
                    this.MembershipType = "Weights Only";
                    break;
                case MembershipTypes.Cardio_Only:
                    this.MembershipType = "Cardio Only";
                    break;
                default:
                    this.MembershipType = "Error";
                    break;
            }
            MembershipExpiration = membershipExpiration;
        }

        public void RenewMembership()
        {
            if(MembershipExpiration < DateOnly.FromDateTime(DateTime.Now))
                MembershipExpiration = DateOnly.FromDateTime(DateTime.UtcNow).AddDays(30);
        }

        public void RenewMembership(int days)
        {
            if (MembershipExpiration < DateOnly.FromDateTime(DateTime.Now))
                MembershipExpiration = DateOnly.FromDateTime(DateTime.UtcNow).AddDays(days);
        }
    }

    public enum MembershipTypes
    {
        Full_Fitness,
        Cardio_Only,
        Weights_Only
    }
}
