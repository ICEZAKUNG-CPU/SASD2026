using System.Net.Sockets;
using System.Text;

namespace Restaurant
{
    public partial class WaiterForm : Form
    {
        public WaiterForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 11000);

            client.Client.Send(Encoding.UTF8.GetBytes(textBox1.Text));

            client.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
