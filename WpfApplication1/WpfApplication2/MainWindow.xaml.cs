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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string code = this.txtCCode.Text;
            string fname = this.txtFName.Text;
            string lname = this.txtLastName.Text;
            string countryCode = (this.CountryCode.SelectedItem as ComboBoxItem).Content.ToString();
            string gender;
            if (this.RbFemale.IsChecked == true) gender = "F";
            else if (this.RbMale.IsChecked == true) gender = "M";
            else gender = "Others";
            MessageBox.Show($"code {code} and name {fname} {lname} and CountryCode"+
                            $"{countryCode} and gender { gender}");
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Recruitment");
                con.Open();
                string sql = "Insert into Externalcandidate" + "(cCandidatecode, vfirstname)" + "(@code,@fname)";
                using (SqlCommand command = new SqlCommand(sql, con))
                {


                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@code",
                        Value = code,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };

                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter
                    {
                        ParameterName = "@fname",
                        Value = fname,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 25
                    };
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter
                    {
                        ParameterName = "@lname",
                        Value = lname,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 25
                    };
                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Some error occured");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Update button clicked");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete button clicked");
        }
    }
}
