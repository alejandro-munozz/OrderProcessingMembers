using OPMBL;
using OPMBL.Managers;
using OPMUI_WPF.Mapper;
using OPMUI_WPF.ModelUI;
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
        private Dictionary<string, MemberUI> emailToMember;
        private Dictionary<string, MemberUI> nameToMember;
        private MemberManager memberManager;
       public LoginWindow()
        {
            InitializeComponent();
            memberManager = new(OPMRepositoryMemoryFactory.GetOPMRepositoryMemory());
            emailToMember = memberManager.GetEmailToMember().ToDictionary(kvp => kvp.Key, kvp => new MemberUI(kvp.Value));

            nameToMember = memberManager.GetNameToMember().ToDictionary(kvp => kvp.Key, kvp => new MemberUI(kvp.Value));
            /*emailToMember = memberManager.GetEmailToMember();
            nameToMember = memberManager.GetNameToMember();*/
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (emailToMember[LoginEmailTextBox.Text].Id == nameToMember[LoginNameTextBox.Text].Id)
                {
                    var memberId = emailToMember[LoginEmailTextBox.Text].Id;
                    var member = memberManager.GetMemberById(memberId);
                    MainWindow mW = new MainWindow(MemberMapper.MapFromDomain(member));
                    mW.ShowDialog();
                }            
            } catch { 
            }
            MessageBox.Show("Invalid Login Information", "Error", MessageBoxButton.OK);
        }
    }
}
