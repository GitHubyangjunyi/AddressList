using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static public string username;
        static public string pwd;
        public void GetUserInfo()
        {
            username = textBox_username.Text;
            pwd = textBox_pwd.Text;
        }
        public int SignIn_Out(int In_Out)
        {
            string constr_sign_in = string.Format("Data Source=.;Initial Catalog=addresslist;UID={0};PWD={1}", username, pwd);
            string sql_sign_in = string.Format("select count(*) from login where username='{0}' and pwd='{1}'", username, pwd);
            SqlConnection connect_sign_in = new SqlConnection(constr_sign_in);
            SqlCommand cmd_sign_in = new SqlCommand
            {
                CommandText = sql_sign_in,
                Connection = connect_sign_in
            };
            if (In_Out==1)
            {
                connect_sign_in.Open();
                int i = Convert.ToInt32(cmd_sign_in.ExecuteScalar());//返回执行结果的第一行第一列
                return i;
            }
            else
            {
                connect_sign_in.Close();
                int i = 0;
                return i;
            }
        }
        private void bt_sign_in_Click(object sender, EventArgs e)
        {
            try
            {
                GetUserInfo();
                int i= SignIn_Out(1);
                if (i ==1)
                {
                    Information sinformation = new Information();
                    sinformation.Show();

                }
                else
                {
                    MessageBox.Show("用户名或密码错误!");
                }
                i = SignIn_Out(0);
                if (i != 0)
                {
                    MessageBox.Show("数据库临时断开失败!");
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败!请检查数据库连接服务是否已启用!");
            }
        }
    }
}
#region
//下面我们将详细讲解如何在Page_Load()中对数据库的增加、删除、修改，
//最后我们再来总结一下ExecuteNonQuery(),ExecuteScalar(),ExecuteReader的用法：
//1、 增加新的记录
//private void Page_Load(object sender, System.EventArgs e)
//{
//    MyConnection.Open();
//    MyCommand1.CommandText = "insert into admin values(‘aaddq‘,‘as‘,‘ss‘)";
//    MyCommand1.Connection = MyConnection;
//    MyCommand1.ExecuteNonQuery();//由于增加了一条记录，所以返回1
//或者MyCommand1.ExecuteReader();先增加一条记录，然后返回一个System.Data.OleDb.OleDbDataReader类型的对象，该对象为:EOF
//或者MyCommand1. ExecuteScalar();先增加一条记录，返回未实列化的对象
//    MyConnection.Close();
//}
//2、 删除现有数据
//private void Page_Load(object sender, System.EventArgs e)
//{
//    MyConnection.Open();//打开数据库
//    MyCommand1.CommandText = "delete * from admin";
//    MyCommand1.Connection = MyConnection;
//    MyCommand1.ExecuteNonQuery();//由于删除了n条记录，所以返回n
//或者MyCommand1.ExecuteReader();先删除n条记录，然后返回一个System.Data.OleDb.OleDbDataReader类型的对象，该对象为:EOF
//或者MyCommand1. ExecuteScalar();先删除n条记录，返回未实列化的对象
//    MyConnection.Close();//关闭数据库
//}
//3、 修改现有数据
//private void Page_Load(object sender, System.EventArgs e)
//{
//    MyConnection.Open();//打开数据库
//    MyCommand1.CommandText = "update admin set admin_code=’212’,Admin_pwd=’43’ where admin_code=’23’";
//    MyCommand1.Connection = MyConnection;
//    MyCommand1.ExecuteNonQuery();//由于修改了1条记录，所以返回n
//或者MyCommand1.ExecuteReader();先修改了1条记录，然后返回一个System.Data.OleDb.OleDbDataReader类型的对象，该对象为:EOF
//或者MyCommand1. ExecuteScalar();先修改了1条记录，返回未实列化的对象
//    MyConnection.Close();
//}
//三、关于MyCommand的ExecuteNonQuery(),ExecuteScalar(),ExecuteReader方法的区别:
//1、ExecuteNonQuery():执行SQL，返回一个整型变量，如果SQL是对数据库的记录进行操作，那么返回操作影响的记录条数，
//如果是 SQL = "CREATE TABLE LookupCodes (code_id smallint IDENTITY(1,1) PRIMARY KEY CLUSTERED, code_desc varchar(50) NOT NULL)"那么在表创建成功后该方法返回 –1。
//例如：
//private void Page_Load(object sender, System.EventArgs e)
//{
//    MyConnection.Open();//打开数据库
//    MyCommand1.CommandText = "CREATE TABLE LookupCodes (code_id smallint IDENTITY(1,1) PRIMARY KEY CLUSTERED, code_desc varchar(50) NOT NULL)"；
//    MyCommand1.Connection = MyConnection;
//    MyCommand1.ExecuteNonQuery();//首先建立一个LookupCodes表，然后返回 - 1
//或者MyCommand1.ExecuteReader();首先建立一个LookupCodes表，然后返回一个System.Data.OleDb.OleDbDataReader类型的对象，该对象为:EOF
//或者MyCommand1. ExecuteScalar();首先建立一个LookupCodes表，返回未实列化的对象
//    MyConnection.Close();
//} 
//2、 ExecuteScalar()：执行SQL，（如果SQL是查询Select）返回查询结果的第一行第一列，如果（如果SQL不是查询Select）那 么返回未实列化的对象，因为对象未实列化，所以返回结果不能ToString(),不能Equals(null)，也就是说返回结果没有任何作用
//3、 executeReader方法执行SQL，（如果SQL是查询Select）返回查询结果的集合，类型是 System.Data.OleDb.OleDbDataReader，你可以通过此结果，获取查询的数据。如果（如果SQL不是查询Select）那么返回一个没有任何数据的System.Data.OleDb.OleDbDataReader类型的集合(EOF)
//四、总结：
//ASP.Net中对于数据库的操作方法很多，要实现统一个目标不同的人可能会采取不同的方法，就好像在ASP中有的人喜欢用RS.ADDNEW，有的人喜 欢用”Insert Into”，主要是看个人的习惯，当然在性能上不同的方法可能会存在较大的差别，这个只能靠我们在平常的学习中一点一滴的积累经验的。另外顺便说一下 ASP.Net页提供类似如下方式的操作方法：
//OleDbCommand2.Parameters("au_id").Value = TextBox1.Text
//OleDbCommand2.Parameters("au_lname").Value = TextBox2.Text
//OleDbCommand2.Parameters("au_fname").Value = TextBox3.Text
//OleDbCommand2.Parameters("phone").Value = TextBox4.Text
//OleDbCommand2.Parameters("address").Value = TextBox5.Text
//OleDbCommand2.Parameters("city").Value = TextBox6.Text
//OleDbCommand2.Parameters("st").Value = TextBox7.Text
//OleDbCommand2.Parameters("zip").Value = TextBox8.Text
//OleDbCommand2.Parameters("contract").Value = CheckBox1.Checked
//cmdresults = OleDbcommand2.ExecuteNonQuery()
#endregion