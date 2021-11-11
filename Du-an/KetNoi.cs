using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;              // Khai báo thư viện
using System.Data.SqlClient; // Khai báo thư viện
using System.IO;

namespace Du_an
{
    class KetNoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_Dulieu()
        {
<<<<<<< HEAD
            string strKetNoi = @"Data Source=DESKTOP-86JDTF6\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
=======
            string strKetNoi = @"Data Source=DESKTOP-5594BKK\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=TrueData Source=DESKTOP-2021BGT;Initial Catalog=QLBH;Integrated Security=True";
>>>>>>> 45082e912ba4ef75e889471fb433657b5a6c92d4
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
