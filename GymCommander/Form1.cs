namespace GymCommander
{
    public partial class MainForm : Form
    {
        public static string currentVersion = "0.0.1";
        public MainForm()
        {
            InitializeComponent();
        }

        private void TestingInitializer()
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Gym Commander v{currentVersion}";
            TestingInitializer();
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

    class Client
    {
        // all nullables are for testing
        // placeholders should be used when possible, and nullable disabled

        public string MemberID { get; private set; }
        public Image? Photo { get; private set; }
        public string Name { get; private set; }
        public MembershipTypes MembershipType { get; private set; }
        public DateOnly MembershipExpiration { get; private set; }

        // for statistical use
        public DateOnly LastVisit {  get; private set; }
        public int VisitsThisMonth { get; private set; }

        public Client(string memberID, Image? photo, string name, MembershipTypes membershipType, DateOnly membershipExpiration)
        {
            MemberID = memberID;
            Photo = photo;
            Name = name;
            MembershipType = membershipType;
            MembershipExpiration = membershipExpiration;
        }
    }

    public enum MembershipTypes
    {
        Full_Fitness,
        Cardio_Only,
        Weights_Only
    }
}
