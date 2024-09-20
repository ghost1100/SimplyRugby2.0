using System.Windows;

namespace SimplyRugby2._0
{
    /// <summary>
    /// Interaction logic for PlayerSkillsSection.xaml
    /// </summary>
    public partial class PlayerSkillsSection : Window
    {
        public PlayerSkillsSection()
        {
            InitializeComponent();

        }

        private void backtodash_Click(object sender, RoutedEventArgs e)
        {
            Coach_dashboard coach_Dashboard = new Coach_dashboard();
            coach_Dashboard.Show();
            this.Close();
        }

        private void discardchangebtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No Changes were Made");
            PlayerSkillsSection SkillSec = new PlayerSkillsSection();
            SkillSec.Show();
            this.Close();
            /*IDLookUptxtbox.Clear();
            displaymemberlstbox.Items.Clear();
            Tackling.Clear();
            Kicking.Clear();
            Passing.Clear();*/

        }

        private void searchbtn12321_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAccess.SkillPlayerFinder(displaymemberlstbox, SquadID22.Text);
        }

        private void SaveChages_Click(object sender, RoutedEventArgs e)
        {
            if (seniorchkbx.IsChecked == true)
            {
                if (rad1.IsChecked == true)
                {
                    Skills.SeniorStandardPassing1(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad2.IsChecked == true)
                {
                    Skills.SeniorStandardPassing2(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad3.IsChecked == true)
                {
                    Skills.SeniorStandardPassing3(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad4.IsChecked == true)
                {
                    Skills.SeniorStandardPassing4(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad5.IsChecked == true)
                {
                    Skills.SeniorStandardPassing5(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                // end of passing section
                if (rad6.IsChecked == true)
                {
                    Skills.SeniorStandardSpin1(SquadID22.Text);
                }
                if (rad7.IsChecked == true)
                {
                    Skills.SeniorStandardSpin2(SquadID22.Text);
                }
                if (rad8.IsChecked == true)
                {
                    Skills.SeniorStandardSpin3(SquadID22.Text);
                }
                if (rad9.IsChecked == true)
                {
                    Skills.SeniorStandardSpin4(SquadID22.Text);
                }
                if (rad10.IsChecked == true)
                {
                    Skills.SeniorStandardSpin5(SquadID22.Text);
                }
                // end of spin section
                if (rad11.IsChecked == true)
                {
                    Skills.SeniorStandardPop1(SquadID22.Text);
                }
                if (rad12.IsChecked == true)
                {
                    Skills.SeniorStandardPop2(SquadID22.Text);
                }
                if (rad13.IsChecked == true)
                {
                    Skills.SeniorStandardPop3(SquadID22.Text);
                }
                if (rad14.IsChecked == true)
                {
                    Skills.SeniorStandardPop4(SquadID22.Text);
                }
                if (rad15.IsChecked == true)
                {
                    Skills.SeniorStandardPop5(SquadID22.Text);
                }
                // end of pop Section and the standard section in totall
                // start of tackling section
                if (rad16.IsChecked == true)
                {
                    Skills.SeniorTacklingFront1(SquadID22.Text);
                }
                if (rad17.IsChecked == true)
                {
                    Skills.SeniorTacklingFront2(SquadID22.Text);
                }
                if (rad18.IsChecked == true)
                {
                    Skills.SeniorTacklingFront3(SquadID22.Text);
                }
                if (rad19.IsChecked == true)
                {
                    Skills.SeniorTacklingFront4(SquadID22.Text);
                }
                if (rad20.IsChecked == true)
                {
                    Skills.SeniorTacklingFront5(SquadID22.Text);
                }
                // end of front section
                if (rad21.IsChecked == true)
                {
                    Skills.SeniorTacklingRear1(SquadID22.Text);
                }
                if (rad22.IsChecked == true)
                {
                    Skills.SeniorTacklingRear2(SquadID22.Text);
                }
                if (rad23.IsChecked == true)
                {
                    Skills.SeniorTacklingRear3(SquadID22.Text);
                }
                if (rad24.IsChecked == true)
                {
                    Skills.SeniorTacklingRear4(SquadID22.Text);
                }
                if (rad25.IsChecked == true)
                {
                    Skills.SeniorTacklingRear5(SquadID22.Text);
                }
                // end of rear section
                if (rad26.IsChecked == true)
                {
                    Skills.SeniorTacklingSide1(SquadID22.Text);
                }
                if (rad27.IsChecked == true)
                {
                    Skills.SeniorTacklingSide2(SquadID22.Text);
                }
                if (rad28.IsChecked == true)
                {
                    Skills.SeniorTacklingSide3(SquadID22.Text);
                }
                if (rad29.IsChecked == true)
                {
                    Skills.SeniorTacklingSide4(SquadID22.Text);
                }
                if (rad30.IsChecked == true)
                {
                    Skills.SeniorTacklingSide5(SquadID22.Text);
                }
                // end of side section.
                if (rad31.IsChecked == true)
                {
                    Skills.SeniorTacklingScrabble1(SquadID22.Text);
                }
                if (rad32.IsChecked == true)
                {
                    Skills.SeniorTacklingScrabble2(SquadID22.Text);
                }
                if (rad33.IsChecked == true)
                {
                    Skills.SeniorTacklingScrabble3(SquadID22.Text);
                }
                if (rad34.IsChecked == true)
                {
                    Skills.SeniorTacklingScrabble4(SquadID22.Text);
                }
                if (rad35.IsChecked == true)
                {
                    Skills.SeniorTacklingScrabble5(SquadID22.Text);
                }
                // end of Scrabble section and tackling in totall
                // start of kicking section.
                if (rad36.IsChecked == true)
                {
                    Skills.SeniorKickingDrop1(SquadID22.Text);
                }
                if (rad37.IsChecked == true)
                {
                    Skills.SeniorKickingDrop2(SquadID22.Text);
                }
                if (rad38.IsChecked == true)
                {
                    Skills.SeniorKickingDrop3(SquadID22.Text);
                }
                if (rad39.IsChecked == true)
                {
                    Skills.SeniorKickingDrop4(SquadID22.Text);
                }
                if (rad40.IsChecked == true)
                {
                    Skills.SeniorKickingDrop5(SquadID22.Text);
                }
                // end of kicking drop section
                if (rad41.IsChecked == true)
                {
                    Skills.SeniorKickingPunt1(SquadID22.Text);
                }
                if (rad42.IsChecked == true)
                {
                    Skills.SeniorKickingPunt2(SquadID22.Text);
                }
                if (rad43.IsChecked == true)
                {
                    Skills.SeniorKickingPunt3(SquadID22.Text);
                }
                if (rad44.IsChecked == true)
                {
                    Skills.SeniorKickingPunt4(SquadID22.Text);
                }
                if (rad45.IsChecked == true)
                {
                    Skills.SeniorKickingPunt5(SquadID22.Text);
                }
                // end of kicking punt section
                if (rad46.IsChecked == true)
                {
                    Skills.SeniorKickingGrubber1(SquadID22.Text);
                }
                if (rad47.IsChecked == true)
                {
                    Skills.SeniorKickingGrubber2(SquadID22.Text);
                }
                if (rad48.IsChecked == true)
                {
                    Skills.SeniorKickingGrubber3(SquadID22.Text);
                }
                if (rad49.IsChecked == true)
                {
                    Skills.SeniorKickingGrubber4(SquadID22.Text);
                }
                if (rad50.IsChecked == true)
                {
                    Skills.SeniorKickingGrubber5(SquadID22.Text);
                }
                // end of kicking gruber section
                if (rad51.IsChecked == true)
                {
                    Skills.SeniorKickingGoal1(SquadID22.Text);
                }
                if (rad52.IsChecked == true)
                {
                    Skills.SeniorKickingGoal2(SquadID22.Text);
                }
                if (rad54.IsChecked == true)
                {
                    Skills.SeniorKickingGoal3(SquadID22.Text);
                }
                if (rad54.IsChecked == true)
                {
                    Skills.SeniorKickingGoal4(SquadID22.Text);
                }
                if (rad55.IsChecked == true)
                {
                    Skills.SeniorKickingGoal5(SquadID22.Text);
                }
                // end of kicking goal section and all of the kickig section in totoall

            }



            // above is the seniors section below is the juniors section.


            else
            {
                if (rad1.IsChecked == true)
                {
                    Skills.JuniorStandardPassing1(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad2.IsChecked == true)
                {
                    Skills.JuniorStandardPassing2(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad3.IsChecked == true)
                {
                    Skills.JuniorStandardPassing3(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad4.IsChecked == true)
                {
                    Skills.JuniorStandardPassing4(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                if (rad5.IsChecked == true)
                {
                    Skills.JuniorStandardPassing5(Passingcomments.Text, Kickingcomments.Text, Tacklingcomments.Text, SquadID22.Text);
                }
                // end of passing section
                if (rad6.IsChecked == true)
                {
                    Skills.JuniorStandardSpin1(SquadID22.Text);
                }
                if (rad7.IsChecked == true)
                {
                    Skills.JuniorStandardSpin2(SquadID22.Text);
                }
                if (rad8.IsChecked == true)
                {
                    Skills.JuniorStandardSpin3(SquadID22.Text);
                }
                if (rad9.IsChecked == true)
                {
                    Skills.JuniorStandardSpin4(SquadID22.Text);
                }
                if (rad10.IsChecked == true)
                {
                    Skills.JuniorStandardSpin5(SquadID22.Text);
                }
                // end of spin section
                if (rad11.IsChecked == true)
                {
                    Skills.JuniorStandardPop1(SquadID22.Text);
                }
                if (rad12.IsChecked == true)
                {
                    Skills.JuniorStandardPop2(SquadID22.Text);
                }
                if (rad13.IsChecked == true)
                {
                    Skills.JuniorStandardPop3(SquadID22.Text);
                }
                if (rad14.IsChecked == true)
                {
                    Skills.JuniorStandardPop4(SquadID22.Text);
                }
                if (rad15.IsChecked == true)
                {
                    Skills.JuniorStandardPop5(SquadID22.Text);
                }
                // end of pop section and standard section in totall.
                // start of tackling "front" section
                if (rad16.IsChecked == true)
                {
                    Skills.JuniorTacklingFront1(SquadID22.Text);
                }
                if (rad17.IsChecked == true)
                {
                    Skills.JuniorTacklingFront2(SquadID22.Text);
                }
                if (rad18.IsChecked == true)
                {
                    Skills.JuniorTacklingFront3(SquadID22.Text);
                }
                if (rad19.IsChecked == true)
                {
                    Skills.JuniorTacklingFront4(SquadID22.Text);
                }
                if (rad20.IsChecked == true)
                {
                    Skills.JuniorTacklingFront5(SquadID22.Text);
                }
                // end of front section
                if (rad21.IsChecked == true)
                {
                    Skills.JuniorTacklingRear1(SquadID22.Text);
                }
                if (rad22.IsChecked == true)
                {
                    Skills.JuniorTacklingRear2(SquadID22.Text);
                }
                if (rad23.IsChecked == true)
                {
                    Skills.JuniorTacklingRear3(SquadID22.Text);
                }
                if (rad24.IsChecked == true)
                {
                    Skills.JuniorTacklingRear4(SquadID22.Text);
                }
                if (rad25.IsChecked == true)
                {
                    Skills.JuniorTacklingRear5(SquadID22.Text);
                }
                // end of rear section
                if (rad26.IsChecked == true)
                {
                    Skills.JuniorTacklingSide1(SquadID22.Text);
                }
                if (rad27.IsChecked == true)
                {
                    Skills.JuniorTacklingSide2(SquadID22.Text);
                }
                if (rad28.IsChecked == true)
                {
                    Skills.JuniorTacklingSide3(SquadID22.Text);
                }
                if (rad29.IsChecked == true)
                {
                    Skills.JuniorTacklingSide4(SquadID22.Text);
                }
                if (rad30.IsChecked == true)
                {
                    Skills.JuniorTacklingSide5(SquadID22.Text);
                }
                // end of side section.
                if (rad31.IsChecked == true)
                {
                    Skills.JuniorTacklingScrabble1(SquadID22.Text);
                }
                if (rad32.IsChecked == true)
                {
                    Skills.JuniorTacklingScrabble2(SquadID22.Text);
                }
                if (rad33.IsChecked == true)
                {
                    Skills.JuniorTacklingScrabble3(SquadID22.Text);
                }
                if (rad34.IsChecked == true)
                {
                    Skills.JuniorTacklingScrabble4(SquadID22.Text);
                }
                if (rad35.IsChecked == true)
                {
                    Skills.JuniorTacklingScrabble5(SquadID22.Text);
                }
                // end of Scrabble section and tackling in totall
                // start of kicking section.
                if (rad36.IsChecked == true)
                {
                    Skills.JuniorKickingDrop1(SquadID22.Text);
                }
                if (rad37.IsChecked == true)
                {
                    Skills.JuniorKickingDrop2(SquadID22.Text);
                }
                if (rad38.IsChecked == true)
                {
                    Skills.JuniorKickingDrop3(SquadID22.Text);
                }
                if (rad39.IsChecked == true)
                {
                    Skills.JuniorKickingDrop4(SquadID22.Text);
                }
                if (rad40.IsChecked == true)
                {
                    Skills.JuniorKickingDrop5(SquadID22.Text);
                }
                // end of kicking drop section
                if (rad41.IsChecked == true)
                {
                    Skills.JuniorKickingPunt1(SquadID22.Text);
                }
                if (rad42.IsChecked == true)
                {
                    Skills.JuniorKickingPunt2(SquadID22.Text);
                }
                if (rad43.IsChecked == true)
                {
                    Skills.JuniorKickingPunt3(SquadID22.Text);
                }
                if (rad44.IsChecked == true)
                {
                    Skills.JuniorKickingPunt4(SquadID22.Text);
                }
                if (rad45.IsChecked == true)
                {
                    Skills.JuniorKickingPunt5(SquadID22.Text);
                }
                // end of kicking punt section
                if (rad46.IsChecked == true)
                {
                    Skills.JuniorKickingGrubber1(SquadID22.Text);
                }
                if (rad47.IsChecked == true)
                {
                    Skills.JuniorKickingGrubber2(SquadID22.Text);
                }
                if (rad48.IsChecked == true)
                {
                    Skills.JuniorKickingGrubber3(SquadID22.Text);
                }
                if (rad49.IsChecked == true)
                {
                    Skills.JuniorKickingGrubber4(SquadID22.Text);
                }
                if (rad50.IsChecked == true)
                {
                    Skills.JuniorKickingGrubber5(SquadID22.Text);
                }
                // end of kicking gruber section
                if (rad51.IsChecked == true)
                {
                    Skills.JuniorKickingGoal1(SquadID22.Text);
                }
                if (rad52.IsChecked == true)
                {
                    Skills.JuniorKickingGoal2(SquadID22.Text);
                }
                if (rad54.IsChecked == true)
                {
                    Skills.JuniorKickingGoal3(SquadID22.Text);
                }
                if (rad54.IsChecked == true)
                {
                    Skills.JuniorKickingGoal4(SquadID22.Text);
                }
                if (rad55.IsChecked == true)
                {
                    Skills.JuniorKickingGoal5(SquadID22.Text);
                }
                // end of kicking goal section and all of the kickig section in totoall
            }
        }
    }

}





