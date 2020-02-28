using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomRequest
{
    public partial class Form1 : Form
    {
        Point moveStart;
        Logger logger;
        RequestSender reqSender;
        JsonConverter jsonConverter;
        DataLoader dataLoader;

        public Form1(Logger _logger, RequestSender _reqSender, JsonConverter _jsonConverter, DataLoader _dataLoader)
        {
            logger = _logger;
            reqSender = _reqSender;
            jsonConverter = _jsonConverter;
            dataLoader = _dataLoader;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            logger.LogToFile("Program end", msgState.OK);
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }

        private void GetErrors_Click(object sender, EventArgs e)
        {
            logger.LogToFile("Program Get Errors Request", msgState.Info);
            Task task3 = Task.Run(() => reqSender.MakeErrorCodesRequest());
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            logger.LogToFile("Program Get Categories Request", msgState.Info);
            Task task2 = Task.Run(() => reqSender.MakeCategoriesRequest());
        }

        private void MakeJson_Click(object sender, EventArgs e)
        {
            logger.LogToFile("Program Make Json", msgState.Info);
            Task task = Task.Run(() => jsonConverter.MakeJsonToTxt());
        }

        private void ShowCategories_Click(object sender, EventArgs e)
        {
            logger.LogToFile("Program Show Category", msgState.Info);
            this.richTextBox1.Text = dataLoader.ShowData();
        }

        private void MakeAll_Click(object sender, EventArgs e)
        {
            logger.LogToFile("Program Start Multi Call", msgState.Info);
            Task task = Task.Run(() => jsonConverter.MakeJsonToTxt());
            Task task2 = Task.Run(() => reqSender.MakeCategoriesRequest());
            Task task3 = Task.Run(() => reqSender.MakeErrorCodesRequest());
        }
    }
}
