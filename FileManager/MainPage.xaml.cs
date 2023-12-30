namespace FileManager
{
    public partial class MainPage : ContentPage
    {
        string outputString = "身份验证错误，请选择身份！\n";
        string output;

        bool enableOutput = false;

        public MainPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), UpdateTime);
        }

        private void OnUpdateClicked(object sender, EventArgs e)
        {
            if (enableOutput)
            {
                output += outputString + "上传至工作室服务器; 操作时间: " + DateTime.Now.ToString() + '\n';

                Console.Text = output;
            }
            else
            {
                output += outputString + '\n';

                Console.Text = outputString;
            }
        }

        private void OnDownloadClicked(object sender, EventArgs e)
        {
            if (enableOutput)
            {
                output += outputString + "工作室文件下载到本地电脑; 操作时间: " + DateTime.Now.ToString() + '\n';

                Console.Text = output;
            }
            else
            {
                output += outputString + '\n';

                Console.Text = output;
            }
        }

        private void OnClickRadioButton(object sender, CheckedChangedEventArgs e)
        {
            enableOutput = true;

            var item = sender as RadioButton;
            if (item != null)
            {
                if (item.Content.ToString() == "指导教师")
                    outputString = ">>指导教师: ";
                else if (item.Content.ToString() == "管理员")
                    outputString = ">>管理员: ";
                else if (item.Content.ToString() == "正式成员")
                    outputString = ">>正式成员: ";
                else if (item.Content.ToString() == "实习生")
                    outputString = ">>实习生: ";
            }
        }

        private bool UpdateTime()
        {
            NowTime.Text = DateTime.Now.ToString();

            return true;
        }
    }

}
