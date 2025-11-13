using OPMBL;
using OPMBL.Managers;
using OPMUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OPMUI_WPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Dictionary<string, Member> emailToMember;
        private Dictionary<string, Member> nameToMember;
        private MemberManager memberManager;
        public LoginWindow()
        {
            InitializeComponent();
            memberManager = new(OPMRepositoryMemoryFactory.GetOPMRepositoryMemory());
            emailToMember = memberManager.GetEmailToMember();
            nameToMember = memberManager.GetNameToMember();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (emailToMember[LoginEmailTextBox.Text] == nameToMember[LoginNameTextBox.Text])
                {
                    MainWindow mW = new(emailToMember[LoginEmailTextBox.Text]);
                    mW.ShowDialog();
                }            
            } catch { }
            MessageBox.Show("Invalid Login Information", "Error", MessageBoxButton.OK);
        }
    }
}
