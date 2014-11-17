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
using System.Windows.Navigation;
using System.Windows.Shapes;



using System.Collections.ObjectModel;

namespace TermProject5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Course> courseList = new ObservableCollection<Course>();


        List<Course> coursesTaken = new List<Course>();


        Concentration bioinformatics = new Concentration();
        Concentration software = new Concentration();
        Concentration database = new Concentration();
        Concentration graphics = new Concentration();
        Concentration hardware = new Concentration();
        Concentration networks = new Concentration();
        Concentration theoreticalCS = new Concentration();        


        List<Grade> gradeList = new List<Grade>();

        Double previousGPA, currentGPA, overallGPA;

        Course lastItemSelected1_1 = new Course(null, 0);
        Course lastItemSelected1_2 = new Course(null, 0);
        Course lastItemSelected1_3 = new Course(null, 0);
        Course lastItemSelected1_4 = new Course(null, 0);
        Course lastItemSelected1_5 = new Course(null, 0);
        Course lastItemSelected1_6 = new Course(null, 0);
        Course lastItemSelected1_7 = new Course(null, 0);
        Course lastItemSelected1_8 = new Course(null, 0);
        Course lastItemSelected1_9 = new Course(null, 0);


        Course lastItemSelected1 = new Course(null, 0);
        Course lastItemSelected2 = new Course(null, 0);
        Course lastItemSelected3 = new Course(null, 0);
        Course lastItemSelected4 = new Course(null, 0);
        Course lastItemSelected5 = new Course(null, 0);

        Boolean cb1_1hadSomeItem = false;
        Boolean cb1_2hadSomeItem = false;
        Boolean cb1_3hadSomeItem = false;
        Boolean cb1_4hadSomeItem = false;
        Boolean cb1_5hadSomeItem = false;
        Boolean cb1_6hadSomeItem = false;
        Boolean cb1_7hadSomeItem = false;
        Boolean cb1_8hadSomeItem = false;
        Boolean cb1_9hadSomeItem = false;

        Boolean cb2_1hadSomeItem = false;
        Boolean cb2_2hadSomeItem = false;
        Boolean cb2_3hadSomeItem = false;
        Boolean cb2_4hadSomeItem = false;
        Boolean cb2_5hadSomeItem = false;


        public MainWindow()
        {
            InitializeComponent();

            Binding sourceBinding = new Binding();
            



            cb2_1.ItemsSource = courseList;
            cb2_2.ItemsSource = courseList;
            cb2_3.ItemsSource = courseList;
            cb2_4.ItemsSource = courseList;
            cb2_5.ItemsSource = courseList;


            cb1_1.ItemsSource = courseList;
            cb1_2.ItemsSource = courseList;
            cb1_3.ItemsSource = courseList;
            cb1_4.ItemsSource = courseList;
            cb1_5.ItemsSource = courseList;
            cb1_6.ItemsSource = courseList;
            cb1_7.ItemsSource = courseList;
            cb1_8.ItemsSource = courseList;
            cb1_9.ItemsSource = courseList;
            cbg1_1.ItemsSource = gradeList;
            cbg1_2.ItemsSource = gradeList;
            cbg1_3.ItemsSource = gradeList;
            cbg1_4.ItemsSource = gradeList;
            cbg1_5.ItemsSource = gradeList;
            cbg1_6.ItemsSource = gradeList;
            cbg1_7.ItemsSource = gradeList;
            cbg1_8.ItemsSource = gradeList;
            cbg1_9.ItemsSource = gradeList;

            cbg2_1.ItemsSource = gradeList;
            cbg2_2.ItemsSource = gradeList;
            cbg2_3.ItemsSource = gradeList;
            cbg2_4.ItemsSource = gradeList;
            cbg2_5.ItemsSource = gradeList;

           
            initializeList();
        }

        private void initializeList()
        {
            courseList.Add(new Course("CSC 2010 (Introduction to Computer Science)", 3));
            courseList.Add(new Course("CSC 2310 (Introduction to Computer Programming)", 3));
            courseList.Add(new Course("CSC 2510 (Theoretical Foundations of Computer Science)", 3));
            courseList.Add(new Course("CSC 3210 (Computer Organization and Programming)", 3));
            courseList.Add(new Course("CSC 3320 (System-Level Programming)", 3));
            courseList.Add(new Course("CSC 3410 (Data Structures)", 3));
            courseList.Add(new Course("CSC 4210 (Computer Architecture)", 4));
            courseList.Add(new Course("CSC 4320 (Operating Systems)", 4));
            courseList.Add(new Course("CSC 4330 (Programming Language Concepts)", 4));
            courseList.Add(new Course("CSC 4350 (Software Engineering)", 4));
            courseList.Add(new Course("CSC 4370 (Web Programming)", 4));
            courseList.Add(new Course("CSC 4380 (Windowing Systems Programming)", 4));
            courseList.Add(new Course("CSC 4520 (Design and Analysis of Algorithms)", 4));
            courseList.Add(new Course("CSC 4710 (Database Systems)", 4));
            courseList.Add(new Course("CSC 4810 (Artificial Intelligence)", 4));

            gradeList.Add(new Grade("A+"));
            gradeList.Add(new Grade("A"));
            gradeList.Add(new Grade("A-"));
            gradeList.Add(new Grade("B+"));
            gradeList.Add(new Grade("B"));
            gradeList.Add(new Grade("B-"));
            gradeList.Add(new Grade("C+"));
            gradeList.Add(new Grade("C"));

            bioinformatics.addRequirement(new Course("CSC 4540 (Bioinformatics Algorithms)", 4));
            bioinformatics.addRequirement(new Course("CSc 4540 Bioinformatics Algorithms)", 4));
            bioinformatics.addRequirement(new Course("CSc 4630 Introduction to Matlab Programming)", 4));
            bioinformatics.addRequirement(new Course("CSc 4650 Introduction to Bioinformatics)", 4));
            bioinformatics.addRequirement(new Course("CSc 4710 Database Systems)", 4));
            bioinformatics.addRequirement(new Course("CSc 4740 Data Mining)", 4));
            bioinformatics.addRequirement(new Course("CSc 4810 Artificial Intelligence)", 4));

            software.addRequirement(new Course("CSC 4110 Introduction to Embedded Systems Laboratory)", 4));
            software.addRequirement(new Course("CSc 4310 Parallel and Distributed Computing)", 4));
            software.addRequirement(new Course("CSc 4320 Operating Systems)", 4));
            software.addRequirement(new Course("CSc 4340 Introduction to Compilers)", 4));
            software.addRequirement(new Course("CSc 4360 Network-Oriented Software Development)", 4));
            software.addRequirement(new Course("CSc 4370 Web Programming)", 4));
            software.addRequirement(new Course("CSc 4380 Windowing Systems Programming)", 4));

            database.addRequirement(new Course("CSc 4260 Digital Image Processing)", 4));
            database.addRequirement(new Course("CSc 4360 Network-Oriented Software Development)", 4));
            database.addRequirement(new Course("CSc 4370 Web Programming)", 4));
            database.addRequirement(new Course("CSc 4710 Database Systems)", 4));
            database.addRequirement(new Course("CSc 4740 Data Mining)", 4));
            database.addRequirement(new Course("CSc 4810 Artificial Intelligence)", 4));

            graphics.addRequirement(new Course("CSc 4260 Digital Image Processing)", 4));
            graphics.addRequirement(new Course("CSc 4380 Windowing Systems Programming)", 4));
            graphics.addRequirement(new Course("CSc 4720 Human-Computer Interaction)", 4));
            graphics.addRequirement(new Course("CSc 4730 Data Visualization)", 4));
            graphics.addRequirement(new Course("CSc 4820 Interactive Computer Graphics)", 4));
            graphics.addRequirement(new Course("CSc 4840 Computer Graphics Imaging)", 4));
            graphics.addRequirement(new Course("CSc 4841 Computer Animation)", 3));


            hardware.addRequirement(new Course("CSc 4110 Introduction to Embedded Systems Laboratory)", 4));
            hardware.addRequirement(new Course("CSc 4120 Introduction to Robotics)", 4));
            hardware.addRequirement(new Course("CSc 4220 Computer Networks)", 4));
            hardware.addRequirement(new Course("CSc 4230 VLSI Design)", 4));
            hardware.addRequirement(new Course("CSc 4270 Introduction to Digital Signal Processing)", 4));
            hardware.addRequirement(new Course("CSc 4630 Introduction to Matlab Programming)", 4));

            networks.addRequirement(new Course("CSc 4220 Computer Networks)", 4));
            networks.addRequirement(new Course("CSc 4221 Wireless Networks and Mobile Computing)", 4));
            networks.addRequirement(new Course("CSc 4225 Internetwork Programming)", 4));
            networks.addRequirement(new Course("CSc 4310 Parallel and Distributed Computing)", 4));
            networks.addRequirement(new Course("CSc 4320 Operating Systems)", 4));
            networks.addRequirement(new Course("CSc 4830 System Simulation)", 4));

            theoreticalCS.addRequirement(new Course("CSc 4340 Introduction to Compilers)", 4));
            theoreticalCS.addRequirement(new Course("CSc 4510 Automata)", 4));
            theoreticalCS.addRequirement(new Course("CSc 4610 Numerical Analysis I)", 3));
            theoreticalCS.addRequirement(new Course("CSc 4620 Numerical Analysis II)", 3));



        }


        private void OK_Clicked1(object sender, RoutedEventArgs e)
        {
            if (cb2_1hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1);
            }

            Course itemSelected = (Course)cb2_1.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);


            if (!cb2_1hadSomeItem)
                cb2_1hadSomeItem = true;

            tbh2_1.Text = itemSelected.getHours().ToString();

            lastItemSelected1 = itemSelected;

            //Sample print
            Console.WriteLine("List contains " + courseList.Count + " elements");

            //cb2_1.Items.Clear();
            //cb2_2.Items.Clear();
            //cb2_3.Items.Clear();
            //cb2_4.Items.Clear();
            //cb2_5.Items.Clear();

            cb2_1.IsEditable = true;
            cb2_1.Text = itemSelected.getName();
            cb2_1.IsEditable = false;

            courseTextbox2_1.Text = itemSelected.getName();

        }

        private void OK_Clicked2(object sender, RoutedEventArgs e)
        {
            if (cb2_2hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected2);
            }

            Course itemSelected = (Course)cb2_2.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);


            if (!cb2_2hadSomeItem)
                cb2_2hadSomeItem = true;

            tbh2_2.Text = itemSelected.getHours().ToString();

            lastItemSelected2 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            cb2_2.Text = itemSelected.getName();

            courseTextbox2_2.Text = itemSelected.getName();
        }

        private void OK_Clicked3(object sender, RoutedEventArgs e)
        {
            if (cb2_3hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected3);
            }

            Course itemSelected = (Course)cb2_3.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb2_3hadSomeItem)
                cb2_3hadSomeItem = true;

            tbh2_3.Text = itemSelected.getHours().ToString();

            lastItemSelected3 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");


            cb2_3.Text = itemSelected.getName();

            courseTextbox2_3.Text = itemSelected.getName();
        }

        private void OK_Clicked4(object sender, RoutedEventArgs e)
        {
            if (cb2_4hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected4);
            }

            Course itemSelected = (Course)cb2_4.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb2_4hadSomeItem)
                cb2_4hadSomeItem = true;

            tbh2_4.Text = itemSelected.getHours().ToString();

            lastItemSelected4 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            cb2_4.Text = itemSelected.getName();

            courseTextbox2_4.Text = itemSelected.getName();
        }

        private void OK_Clicked5(object sender, RoutedEventArgs e)
        {
            if (cb2_5hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected5);
            }

            Course itemSelected = (Course)cb2_5.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb2_5hadSomeItem)
                cb2_5hadSomeItem = true;

            tbh2_5.Text = itemSelected.getHours().ToString();

            lastItemSelected5 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");


            cb2_5.Text = itemSelected.getName();

            courseTextbox2_5.Text = itemSelected.getName();
        }

        private void OK_Clicked1_1(object sender, RoutedEventArgs e)
        {
            if (cb1_1hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_1);
            }

            Course itemSelected = (Course)cb1_1.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_1hadSomeItem)
                cb1_1hadSomeItem = true;

            tbh1_1.Text = itemSelected.getHours().ToString();

            lastItemSelected1_1 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_1.Text = itemSelected.getName();
        }

        private void OK_Clicked1_2(object sender, RoutedEventArgs e)
        {
            if (cb1_2hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_2);
            }

            Course itemSelected = (Course)cb1_2.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_2hadSomeItem)
                cb1_2hadSomeItem = true;

            tbh1_2.Text = itemSelected.getHours().ToString();

            lastItemSelected1_2 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_2.Text = itemSelected.getName();
        }

        private void OK_Clicked1_3(object sender, RoutedEventArgs e)
        {
            if (cb1_3hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_3);
            }

            Course itemSelected = (Course)cb1_3.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_3hadSomeItem)
                cb1_3hadSomeItem = true;

            tbh1_3.Text = itemSelected.getHours().ToString();

            lastItemSelected1_3 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_3.Text = itemSelected.getName();
        }

        private void OK_Clicked1_4(object sender, RoutedEventArgs e)
        {
            if (cb1_4hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_4);
            }

            Course itemSelected = (Course)cb1_4.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_4hadSomeItem)
                cb1_4hadSomeItem = true;

            tbh1_4.Text = itemSelected.getHours().ToString();

            lastItemSelected1_4 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_4.Text = itemSelected.getName();
        }

        private void OK_Clicked1_5(object sender, RoutedEventArgs e)
        {
            if (cb1_5hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_5);
            }

            Course itemSelected = (Course)cb1_5.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_5hadSomeItem)
                cb1_5hadSomeItem = true;

            tbh1_5.Text = itemSelected.getHours().ToString();

            lastItemSelected1_5 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_5.Text = itemSelected.getName();
        }

        private void OK_Clicked1_6(object sender, RoutedEventArgs e)
        {
            if (cb1_6hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_6);
            }

            Course itemSelected = (Course)cb1_6.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_6hadSomeItem)
                cb1_6hadSomeItem = true;

            tbh1_6.Text = itemSelected.getHours().ToString();

            lastItemSelected1_6 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_6.Text = itemSelected.getName();
        }

        private void OK_Clicked1_7(object sender, RoutedEventArgs e)
        {
            if (cb1_7hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_7);
            }

            Course itemSelected = (Course)cb1_7.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_7hadSomeItem)
                cb1_7hadSomeItem = true;

            tbh1_7.Text = itemSelected.getHours().ToString();

            lastItemSelected1_7 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_7.Text = itemSelected.getName();
        }

        private void OK_Clicked1_8(object sender, RoutedEventArgs e)
        {
            if (cb1_8hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_8);
            }

            Course itemSelected = (Course)cb1_8.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_8hadSomeItem)
                cb1_8hadSomeItem = true;

            tbh1_8.Text = itemSelected.getHours().ToString();

            lastItemSelected1_8 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_8.Text = itemSelected.getName();
        }

        private void OK_Clicked1_9(object sender, RoutedEventArgs e)
        {
            if (cb1_9hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1_9);
            }

            Course itemSelected = (Course)cb1_9.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);

            if (!cb1_9hadSomeItem)
                cb1_9hadSomeItem = true;

            tbh1_9.Text = itemSelected.getHours().ToString();

            lastItemSelected1_9 = itemSelected;

            Console.WriteLine("List contains " + courseList.Count + " elements");

            courseTextbox1_9.Text = itemSelected.getName();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox[] tbh1 = new TextBox[9];
            tbh1[0] = tbh1_1;
            tbh1[1] = tbh1_2;
            tbh1[2] = tbh1_3;
            tbh1[3] = tbh1_4;
            tbh1[4] = tbh1_5;
            tbh1[5] = tbh1_6;
            tbh1[6] = tbh1_7;
            tbh1[7] = tbh1_8;
            tbh1[8] = tbh1_9;

            TextBox[] tbh2 = new TextBox[5];
            tbh2[0] = tbh2_1;
            tbh2[1] = tbh2_2;
            tbh2[1] = tbh2_3;
            tbh2[2] = tbh2_4;
            tbh2[3] = tbh2_5;

            ComboBox[] cbg1 = new ComboBox[9]; //grades
            cbg1[0] = cbg1_1;
            cbg1[1] = cbg1_2;
            cbg1[2] = cbg1_3;
            cbg1[3] = cbg1_4;
            cbg1[4] = cbg1_5;
            cbg1[5] = cbg1_6;
            cbg1[6] = cbg1_7;
            cbg1[7] = cbg1_8;
            cbg1[8] = cbg1_9;

            ComboBox[] cbg2 = new ComboBox[5];
            cbg2[0] = cbg2_1;
            cbg2[1] = cbg2_2;
            cbg2[2] = cbg2_3;
            cbg2[3] = cbg2_4;
            cbg2[4] = cbg2_5;
/*
            ComboBox[] cb1 = new ComboBox[9]; //courses taken
            cb1[0] = cb1_1;
            cb1[1] = cb1_2;
            cb1[2] = cb1_3;
            cb1[3] = cb1_4;
            cb1[4] = cb1_5;
            cb1[5] = cb1_6;
            cb1[6] = cb1_7;
            cb1[7] = cb1_8;
            cb1[8] = cb1_9;

            ComboBox[] cb2 = new ComboBox[5]; //courses current
            cb2[0] = cb2_1;
            cb2[1] = cb2_2;
            cb2[2] = cb2_3;
            cb2[3] = cb2_4;
            cb2[4] = cb2_5;      */
/*
            foreach(ComboBox cb in cb1)
            {
                coursesTaken = Course.insertInOrder(coursesTaken, (Course) cb.SelectedItem);
            }

            foreach (ComboBox cb in cb2)
            {
                coursesTaken = Course.insertInOrder(coursesTaken, (Course)cb.SelectedItem);
            }

            foreach(Course c in coursesTaken)
            {
                Console.WriteLine(c.getName());
            }

            */



            double previousGPAhours = 0;

            for (int i = 0; i < tbh1.Length; i++)
            {
                if (tbh1[i] != null)
                {
                    String t = tbh1[i].Text;
                    if (t != "" & t != null)
                    {
                        Grade g = (Grade)(cbg1[i].SelectedItem);
                        if (g != null)
                        {
                            //previousGPA += (g.getQpoints()) * Double.Parse(t);
                            previousGPA += (g.getQpoints()) * Double.Parse(t);
                            previousGPAhours += Double.Parse(t);
                        }
                    }
                }
            }

            previousGPA /= previousGPAhours;

            double currentGPAhours = 0;

            for (int i = 0; i < tbh2.Length; i++)
            {
                if (tbh2[i] != null)
                {
                    String t = tbh2[i].Text.ToString();
                    if (t != "" & t != null)
                    {
                        Grade g = (Grade)(cbg2[i].SelectedItem);
                        if (g != null)
                        {
                            currentGPA += (g.getQpoints()) * Double.Parse(t);
                            currentGPAhours += Double.Parse(t);
                        }
                    }
                }

            }

            currentGPA /= currentGPAhours;
            overallGPA = (previousGPA * previousGPAhours + currentGPA * currentGPAhours) / (currentGPAhours + previousGPAhours);

            MessageBoxResult result = MessageBox.Show("Previous GPA: " + previousGPA +
                                                      "\nCurrent GPA: " + currentGPA +
                                                      "\nOverall: " + string.Format("{0:N2}", Math.Truncate(overallGPA * 100) / 100), "Results", MessageBoxButton.OK, MessageBoxImage.Information);


            Console.WriteLine(previousGPA + " " + currentGPA);

        }


        /*
        private void cb2_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb2_1hadSomeItem)
            {
                courseList = Course.insertInOrder(courseList, lastItemSelected1);
            }

            Course itemSelected = (Course)cb2_1.SelectedItem;

            courseList = Course.removeItem(courseList, itemSelected);


            if (!cb2_1hadSomeItem)
                cb2_1hadSomeItem = true;

            tb2_1.Text = itemSelected.getHours().ToString();

            lastItemSelected1 = itemSelected;

            //Sample print
            Console.WriteLine("List contains " + courseList.Count + " elements");

            //cb2_1.Items.Clear();
            //cb2_2.Items.Clear();
            //cb2_3.Items.Clear();
            //cb2_4.Items.Clear();
            //cb2_5.Items.Clear();

            cb2_1.IsEditable = true;
            cb2_1.Text = itemSelected.getName();
            cb2_1.IsEditable = false;
        }       
         */
    }
}