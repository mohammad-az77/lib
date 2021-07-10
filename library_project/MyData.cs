using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace library_project
{
    class MyData                                                //کلاس مای دیتا برای برای اجرای کوئری ها
    {
        public string strcon, strsql;
        public DataTable Showdata()                             //برای نمایش دیتا
        {

            SqlConnection con1 = new SqlConnection();              //تعریف شی اتصال به پایگاه داده
            con1.ConnectionString = strcon;                         //مقدار دهی رشته اتصال
            con1.Open();                                              //اتصال به پایگاه داده
            SqlDataAdapter da = new SqlDataAdapter(strsql, con1);       
            DataTable dt = new DataTable();                             //ایجاد جدول برای نشان دادن دیتا ها
            da.Fill(dt);
            con1.Close();                                                  //بستن اتصال به پایگاه داده
            return (dt);                                                       //برگرداندن اطلاعات برای نشان دادن در دیتا گرید ویو


        }
        public void ManData()                                               //تابع برای اعمال درج حذف و ویرایش
        {
            SqlConnection con1 = new SqlConnection(strcon);                    //تعریف اتصال پایگاه داده
            con1.Open();                                                        // باز کردن اتصال به پایگاه داده
            SqlCommand c1 = new SqlCommand();                                     //تعریف اس کیو ال کامند برای نوشتن کوئری مورد نظر
            c1.CommandText = strsql;                                                //مقدار دهی کوئری مورد نظر
            c1.Connection = con1;                                                     //مقدار دهی رشته اتصال
            try
            {
                c1.ExecuteNonQuery();                                                   //اجرای کوئری
            }
           catch
            {
               MessageBox.Show("نادرست است");

            }
            con1.Close();                                                                           //بستن اتصال پایگاه داده
        }
    }
}
