using System.Runtime.Versioning;
using System.Windows.Forms.VisualStyles;

namespace ACA_Story_Generator_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] shop = {"Aldi", "Woolies", "Coles", "Foodworks", "IGA", "Friendly Grocer", "Franklins", "BI-LO", "Kogan", "Dick Smith", "Wish.com", "Aliexpress", "Kmart", "Big W"};
        String[] music = { "100 Gecs", "Eminem", "Death Grips", "Kerser", "Kim Petras", "Merzbow", "Marilyn Manson", "Limp Bizkit", "Rage Against The Machine", "Bliss N Eso", "Tame Impala", "The Wiggles", "Hyperpop", "Ska", "Breakcore", "Lad Rap", "Trapt", "The Chats", "Cardi B", "Nicki Minaj", "Weezer"};
        String[] game = { "Fortnite", "Minecraft", "Grand Theft Auto", "Call Of Duty", "Mortal Kombat", "The Sims", "Danganronpa", "Raid Shadow Legends", "Undertale", "Deltarune", "Animal Crossing", "Super Smash Bros", "Genshin Impact"};
        String[] person = { "Joe Biden", "RuPaul", "Markiplier", "Vinesauce Joel", "Vinesauce Vinny", "DankPods", "Hugh Jackman", "Chopper Read", "Scott Morrison", "Daniel Andrews", "Dominic Perrotet", "Courtney Act", "Molly Meldrum", "Call Me Kevin", "Cloybit", "Bam Margera", "Big Marn", "Nostalgia Critic", "AVGN" };
        String[] state = { "NSW", "QLD", "VIC", "ACT" };
        String[] show = { "MAFS", "The Bachelor", "The Bachelorette", "Millionaire Hot Seat", "Deal Or No Deal", "X Factor", "Australia's Got Talent", "The Amazing Race", "RuPaul's Drag Race", "Farmer Wants A Wife", "Gogglebox", "Spicks And Specks", "The Chase", "The Voice", "Neighbours", "Home And Away" };

        
        // shop = 14
        // music = 21
        // game = 13
        // person = 19
        // state = 4
        // show = 16
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int age = rand.Next(1, 110);
            int money = rand.Next(1, 5000);
            int shopNum = rand.Next(13);
            int musicNum = rand.Next(20);
            int gameNum = rand.Next(12);
            int personNum = rand.Next(18);
            int stateNum = rand.Next(3);
            int showNum = rand.Next(15);
            int adjNum = rand.Next(31);
            int nounNum = rand.Next(29);
            int actionNum = rand.Next(25);

            String[] adjective = {"Fat",
        "Transgender",
        "Western Sydney",
        "Dodgy",
        age + " Year Old",
        "Sleazy",
        "Retired",
        "Autistic",
        "Newly Retired",
        "Racist",
        "Brave",
        "Self Proclaimed",
        "'Emo'",
        "Stingy",
        "Drunk",
        "Obese",
        "Rogue",
        "Lebanese",
        "Vulnerable",
        "Indigenous",
        "Muslim",
        "Gay",
        "Non-Binary",
        "Former",
        "Insta-Famous",
        "Tiktok-Famous",
        "Irate",
        "Widowed",
        "Disabled",
        "Wannabe",
        "Single",
        "At-Risk" };
            age = rand.Next(1, 110);
            String[] noun = {"Pensioner",
        "Welfare Recipient",
        "Centrelink Rort",
        "Mother Of " + age,
        "Father Of " + age,
        "Tradie",
        "Neighbour",
        "Neighbour From Hell",
        "Gamer",
        "Nurse",
        state[stateNum] + " Police Commissioner",
        state[stateNum] + " MP",
        "Vandal",
        "Hooligan",
        "Senior",
        "COVID-19 Victim",
        "Sparky",
        "Farmer",
        "Bandit",
        "Drug Dealer",
        "Immigrant",
        "Grandmother of " + age,
        "Grandfather of " + age,
        "Grandmother",
        "Grandfather",
        "Mother",
        "Father",
        "Taxpayer",
        "Footy Player",
        "AFL Star" };
            age = rand.Next(1, 110);
            money = rand.Next(1, 5000);
            String[] action = {"Addicted To Smartphone",
        "Claims " + age + " Year Old Son Is Hooked On " + game[gameNum],
        "Claims " + age + " Year Old Son 'Stole Debit Card' And 'Spent $" + money + " On " + game[gameNum],
        "Saves $" + money + " By Switching To " + shop[shopNum],
        "Scammed By " + adjective[adjNum] + " " + noun[nounNum],
        "Attends 'Freedom Protest'",
        "Claims A New 'Weight Loss Drug' Gives Them Hope",
        "At Breaking Point",
        "Listens To " + music[musicNum],
        "Believes " + game[gameNum] + " Is A Bad Influence On Their " + age + " Year Old Child",
        "Becomes 'Tiktok Famous'",
        "To Star In Upcoming Season Of " + show[showNum],
        "Questions Safety Of Youtube After Finding '" + person[personNum] + "' In Their Child's History",
        "Living In Fear",
        "Dies Of Strange New Disease Known As 'Ligma'",
        "Gets Ratioed By " + person[personNum],
        "Arrested During Police Raid",
        "Shares Overseas Cruise Experience Amid COVID Outbreak",
        "Uses 'They/Them' Pronouns",
        "To EXPOSE '" + show[showNum] + "' Star",
        "Claps Back At " + adjective[adjNum] + " " + noun[nounNum] + " Previously Featured In ACA",
        "Faces " + age + " Years In Prison",
        "Faces Life In Prison",
        "Spends Taxpayer Money On Ice, Pot",
        "Forced To Pay $" + money + " To " + adjective[adjNum] + " " + noun[nounNum],
        "Sends Explicit Photos To A Reporter At ACA, Reporter Now Has Confusing Sexual Feelings" };

            adjNum = rand.Next(31);
            nounNum = rand.Next(29);
            String output = "";

            if (chkName.Checked && txtName.Text == "")
            {
                MessageBox.Show("You checked the name box, but didn't put any text in. Ya silly goose.", "Uh oh! Stinky!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (chkName.Checked)
            {
                output = adjective[adjNum] + " " + noun[nounNum] + " " + txtName.Text + " " + action[actionNum];
                txtOutput.Text = output;
            }

            else
            {
                output = adjective[adjNum] + " " + noun[nounNum] + " " + action[actionNum];
                txtOutput.Text = output;
            }
            
            
        }
    }
}