using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace _123.View
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }
       
        private void reg_Click(object sender, RoutedEventArgs e)
        {

            #region 123
            //if (regUsername.Text.Length > 0)
            //{
            //    if (regPassord.Password.Length > 0)
            //    {

            //        if (regPassord.Password.Length >= 6)
            //        {

            //            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MRVQLJQ; DataBase=IventManager; Integrated Security=true;");
            //            try
            //            {



            //                if (sqlCon.State == ConnectionState.Closed)
            //                    sqlCon.Open();
            //                String logincheck = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
            //                SqlCommand cmdcheck = new SqlCommand(logincheck, sqlCon);
            //                cmdcheck.CommandType = CommandType.Text;
            //                cmdcheck.Parameters.AddWithValue("@Username", regUsername.Text);
            //                cmdcheck.Parameters.AddWithValue("@Password", regPassord.Password);
            //                int countcheck = Convert.ToInt32(cmdcheck.ExecuteScalar());


            //                if (countcheck == 1)
            //                {
            //                    MessageBox.Show("A user with this name already exists");

            //                }
            //                else
            //                {
            #endregion 
            using ( IventContext db = new IventContext())
            {

                if (db.Users.FirstOrDefault(x1 => x1.Username == regUsername.Text) != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                    
                }
                else
                {
                    Users users = new Users(regUsername.Text, regPassord.Password);
                    db.Users.Add(new Users { Username = regUsername.Text, Password = regPassord.Password, Level = Level.User });
                    db.SaveChanges();
                    MessageBox.Show("Регистрация выполнена успешно");
                }
             }
            

             #region Old


                                //String query = "INSERT INTO Users (Username, Password, Level) values(@Username, @Password, 1)";
                                //SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                                //sqlCmd.CommandType = CommandType.Text;
                                //sqlCmd.Parameters.AddWithValue("@Username", regUsername.Text);
                                //sqlCmd.Parameters.AddWithValue("@Password", regPassord.Password);
                                //int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                                //if (count == 1)
                                //{

                                //    MessageBox.Show("A user with this name already exists");

                                //}
                                //else
                                //{

                                //MessageBox.Show("Registration was completed successfully");
                                //LoginScreen loginScreen = new LoginScreen();
                                //loginScreen.Show();
                                //this.Close();
                                //}     
                        
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show(ex.Message);
        //                }
        //                finally
        //                {

        //                }



        //            }
        //            else MessageBox.Show("The password is too short, at least 6 characters");
        //        }
        //        else MessageBox.Show("Specified password");
        //    }
        //    else MessageBox.Show("Enter your username");
           #endregion
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
   