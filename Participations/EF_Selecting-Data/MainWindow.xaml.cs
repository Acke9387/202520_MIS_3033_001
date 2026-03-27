using EF_Selecting_Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_Selecting_Data
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DB_128040_practiceContext db = new Models.DB_128040_practiceContext();
        public MainWindow()
        {
            InitializeComponent();

            lstStudents.ItemsSource = db.Students.Include(x => x.Registrations).ThenInclude(c => c.Course).ToList();
            //lstStudents.ItemsSource = db.Students.ToList();
            lstCourses.ItemsSource = db.Courses.ToList();

            var students = db.Students.Where(x => x.Registrations.Count() > 0).ToList();
        }

        private void AddStudent()
        {

            Student s = new Student()
            {
                FirstName = "John",
                LastName = "Smith",
                FavoriteColor = "Blue",
                StudentId = 6
            };

            Registration r = new Registration()
            {
                Student = s,
                CourseId = 1,
            };

            db.Students.Add(s);

            db.SaveChanges();
        }

        private void RemoveStudent()
        {
            var student = db.Students.Where(c => c.FavoriteColor == "blue").FirstOrDefault();


            var studentToRemove = db.Students.Find(6);

            studentToRemove.FavoriteColor = "Red";
            db.SaveChanges();

            db.Students.Remove(studentToRemove);

            foreach (var x in db.Students)
            {

            }

            db.SaveChanges();
        }

        private void lstStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get the selected student and display the registrations for that student

            Student selectedStudent = lstStudents.SelectedItem as Student;

            if (selectedStudent != null)
            {
                //var db = new Models.DB_128040_practiceContext();

                /*
                 SELECT *
                FROM    Registration
                WHERE   studentId = @selectedStudent.StudentId
                 */
                //var registrations = db.Registrations.Where(x => x.StudentId == selectedStudent.StudentId).ToList();

                //MessageBox.Show($"Student {selectedStudent.FirstName} {selectedStudent.LastName} is registered for {registrations.Count} courses.");
                MessageBox.Show($"Student {selectedStudent.FirstName} {selectedStudent.LastName} is registered for {selectedStudent.Registrations.Count} courses.");

            }
        }
    }
}