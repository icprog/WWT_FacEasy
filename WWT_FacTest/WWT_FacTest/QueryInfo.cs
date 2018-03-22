using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace WWT_FacTest
{
    public partial class QueryInfo : Form
    {
        public QueryInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteDataReader reader = Data.sql.ReadFullTable("table_All");
            while (reader.Read())
            {
                //读取ID
                Trace.WriteLine("" + reader.GetString(reader.GetOrdinal("锁唯一ID")));
                //读取Name
                Trace.WriteLine("" + reader.GetString(reader.GetOrdinal("时间")));
                //读取Age
                Trace.WriteLine("" + reader.GetString(reader.GetOrdinal("结果")));
                //读取Email
                Trace.WriteLine(reader.GetString(reader.GetOrdinal("详细信息")));
            }

            //mAdapter = new SQLiteDataAdapter("SELECT * FROM [" + cboTables.Text + "]", mConn);
            //DataTable mTable = new DataTable(); // Don't forget initialize!
            //mAdapter.Fill(mTable);

            //// 绑定数据到DataGridView
            //grdDetail.DataSource = mTable;

        }
    }
}
