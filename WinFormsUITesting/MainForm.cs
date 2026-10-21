namespace WinFormsUITesting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Messages.StartMessage;
        }

        private void btnChangeMessage_Click(object sender, EventArgs e)
        {
            if (lblMessage.Text == Messages.HelloMessage)
            {
                lblMessage.Text = Messages.GoodbyeMessage;
            }
            else 
            {
                lblMessage.Text = Messages.HelloMessage;
            }
        }
    }
}
