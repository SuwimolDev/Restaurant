using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataRow dr;
        string strconn = "";
        string strsql = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\config.txt"))
                {
                    string strline = "";
                    StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\config.txt");
                    strline = sr.ReadLine();
                    sr.Close();
                    strconn = strline;
                    conn = new SqlConnection(strconn); 
                    conn.Open();
                    strsql = "select * from Orders order by OrderNo";
                    ds = new DataSet();
                    da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(strsql, conn);
                    da.Fill(ds, "selectOrder");
                    strsql = "";
                    if (ds.Tables["selectOrder"].Rows.Count > 0)
                    {
                        for (int aa = 0; aa <= (ds.Tables["selectOrder"].Rows.Count - 1); aa++)
                        {
                            dr = ds.Tables["selectOrder"].Rows[aa];

                            string _id = dr.ItemArray[0].ToString();
                            string _tableNo = dr.ItemArray[3].ToString();
                            string _time = dr.ItemArray[2].ToString();
                            string _price = dr.ItemArray[4].ToString();
                            string _status = dr.ItemArray[7].ToString();                          
                            string[] _addrow_dataGridView1;

                            _addrow_dataGridView1 = new string[] { _id, _tableNo, _time, _price, _status};
                            dgv_Tab1.Rows.Add(_addrow_dataGridView1);

                        }

                    }

                    strsql = "select * from Menu order by MenuID";
                    ds = new DataSet();
                    da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(strsql, conn);
                    da.Fill(ds, "selectMenu");
                    strsql = "";
                    if (ds.Tables["selectMenu"].Rows.Count > 0)
                    {
                        for (int aa = 0; aa <= (ds.Tables["selectMenu"].Rows.Count - 1); aa++)
                        {
                            dr = ds.Tables["selectMenu"].Rows[aa];

                            string _id = dr.ItemArray[0].ToString();
                            string _name = dr.ItemArray[1].ToString();
                            string _price = dr.ItemArray[2].ToString();
                            string[] _addrow_dataGridView1;

                            _addrow_dataGridView1 = new string[] { "false", _id, _name, _price };
                            dgv_Menu.Rows.Add(_addrow_dataGridView1);
                           

                        }

                    }
                    dgv_Detailfood.RowHeadersVisible = false;
                    dgv_Menu.RowHeadersVisible = false;
                    dgv_Tab1.RowHeadersVisible = false;

                    rd_Total.Checked = true;

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgv_Detailfood.Rows.Count - 1;

                for (int i = row; i >= 0 ; i--)
                {
                    var Check = dgv_Detailfood.Rows[i].Cells["CheckDetail"].Value;
                    var aa = "";
                    if (Check == null)
                    {
                        aa = "";
                    }
                    else
                    {
                        aa = Check.ToString();
                    }

                    if (aa == "True")
                    {
                        dgv_Detailfood.Rows.RemoveAt(i);
                        
                    }


                }
                calPrice();

            }
            catch
            {

            }
        }

        private void btn_Rigth_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_Menu.Rows.Count; i++)
                {
                    var Menu = dgv_Menu.Rows[i].Cells["Menu1"].Value.ToString();                    
                    var Check = dgv_Menu.Rows[i].Cells["CheckMenu"].Value.ToString();
                    if (Check == "True")
                    {
                        for (int x = 0; x < dgv_Detailfood.Rows.Count; x++)
                        {
                            var food = dgv_Detailfood.Rows[x].Cells["MenuId1"].Value.ToString();
                            if (food == Menu)
                            {
                                throw new Exception("รายการอาหารซ้ำ1");
                            }
                        }

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgv_Detailfood);
                        row.Cells[1].Value = dgv_Menu.Rows[i].Cells["Menu1"].Value.ToString();
                        row.Cells[2].Value = dgv_Menu.Rows[i].Cells["Menu"].Value.ToString();
                        row.Cells[3].Value = dgv_Menu.Rows[i].Cells["PriceMenu"].Value.ToString();
                        row.Cells[4].Value = "1";
                        dgv_Detailfood.Rows.Add(row);
                    }


                }
                for (int i = 0; i < dgv_Menu.Rows.Count; i++)
                {
                    dgv_Menu.Rows[i].Cells["CheckMenu"].Value = false;
                }
                    calPrice();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void calPrice()
        {
            try
            {
                
                    decimal Total = 0;
                    foreach (DataGridViewRow item in dgv_Detailfood.Rows)
                    {
                        var Price = item.Cells["Price1"].Value;
                        var Qty = item.Cells["Qty"].Value;
                        Total += Convert.ToDecimal(Price) * Convert.ToDecimal(Qty);
                    }
                     txt_SumPrice.Text = Total.ToString();
                

            }
            catch
            {

            }

        }

        private void dgv_Detailfood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Detailfood_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
       
        }

        private void dgv_Detailfood_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
           
            dgv_Detailfood.CommitEdit(DataGridViewDataErrorContexts.Commit);
            calPrice();
        }

        private void txt_Receive_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                decimal Total = !string.IsNullOrEmpty(txt_SumPrice.Text.ToString()) ? Convert.ToDecimal(txt_SumPrice.Text.ToString()) : 0;
                decimal Pay1 = !string.IsNullOrEmpty(txt_Receive.Text.ToString()) ? Convert.ToDecimal(txt_Receive.Text.ToString()) : 0;
                if (Pay1 > 0)
                {
                    txt_Change.Text = (Pay1 - Total).ToString();
                }
                else
                {
                    txt_Change.Text = "";
                }
            }
            catch
            {

            }
        }

        private void txt_Receive_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = e.KeyChar;
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || x == 46);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Detailfood.RowCount > 0)
                {
                    if (!string.IsNullOrEmpty(txt_Change.Text.ToString()))
                    {
                        if (Convert.ToDecimal(txt_Change.Text.ToString()) < 0)
                        {
                            throw new Exception("เงินไม่พอจ่าย");
                        }
                    }

                    if (string.IsNullOrEmpty(txt_Order.Text.ToString()))
                    {
                        if (numeric_Table.Value > 0 && string.IsNullOrEmpty(lbl_status.Text))
                        {
                            strsql = "select * from Orders order by OrderNo";
                            ds = new DataSet();
                            da = new SqlDataAdapter();
                            da.SelectCommand = new SqlCommand(strsql, conn);
                            da.Fill(ds, "selectOrders");
                            strsql = "";
                            var checkCount = ds.Tables["selectOrders"].Rows.Count;
                            checkCount++;
                            var OrderId = checkCount;
                            var Table = numeric_Table.Value;
                            var Date = dtp_Date2.Value.Year.ToString() + "-" + dtp_Date2.Value.Month.ToString() + "-" + dtp_Date2.Value.Day.ToString();
                            var Time = dtp_Time.AccessibilityObject.Value.ToString();
                            var Total = txt_SumPrice.Text.ToString();
                            var Receive = "null";
                            if (!string.IsNullOrEmpty(txt_Receive.Text.ToString()))
                                Receive = txt_Receive.Text.ToString();
                            var Change = "null";
                            if (!string.IsNullOrEmpty(txt_Change.Text.ToString()))
                                Change = txt_Change.Text.ToString();
                            var Status = "null";
                            if (!string.IsNullOrEmpty(txt_Receive.Text.ToString()))
                            {
                                Status = "จ่ายแล้ว";
                            }
                            else
                            {

                                Status = "ยังไม่จ่าย";

                            }


                            strsql = "insert into Orders(OrderNo,Date,Time,TableNo,Total,Payment,Change,Status) " +
                                 " values(" + OrderId + ",'" + Date + "','" + Time + "'," + Table + "," + Total + "," + Receive + "," + Change + ",'" + Status + "')";
                            ds = new DataSet();
                            da = new SqlDataAdapter();
                            da.SelectCommand = new SqlCommand(strsql, conn);
                            da.Fill(ds, "insertOrders");
                            strsql = "";
                            for (int i = 0; i < dgv_Detailfood.Rows.Count; i++)
                            {
                                var MenuId = dgv_Detailfood.Rows[i].Cells["MenuId1"].Value.ToString();
                                var Price = dgv_Detailfood.Rows[i].Cells["Price1"].Value.ToString();
                                var Qty = dgv_Detailfood.Rows[i].Cells["Qty"].Value.ToString();
                                strsql = "insert into OrderDt(OrderNo,Date,MenuID,Price,Qty) " +
                                 " values(" + OrderId + ",'" + Date + "'," + MenuId + "," + Price + "," + Qty + ")";
                                ds = new DataSet();
                                da = new SqlDataAdapter();
                                da.SelectCommand = new SqlCommand(strsql, conn);
                                da.Fill(ds, "insertdetails");
                                strsql = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("ไม่ระบุเลขโต๊ะ หรือ โต๊ะไม่ว่าง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        var OrderId = txt_Order.Text.ToString();
                        var Table = numeric_Table.Value;
                        var Date = dtp_Date2.Value.Year.ToString() + "-" + dtp_Date2.Value.Month.ToString() + "-" + dtp_Date2.Value.Day.ToString();
                        var Time = dtp_Time.AccessibilityObject.Value.ToString();
                        var Total = txt_SumPrice.Text.ToString();
                        var Receive = "null";
                        if (!string.IsNullOrEmpty(txt_Receive.Text.ToString()))
                            Receive = txt_Receive.Text.ToString();
                        var Change = "null";
                        if (!string.IsNullOrEmpty(txt_Change.Text.ToString()))
                            Change = txt_Change.Text.ToString();
                        var Status = "null";
                        if (!string.IsNullOrEmpty(txt_Receive.Text.ToString()))
                        {
                            Status = "จ่ายแล้ว";
                        }
                        else
                        {

                            Status = "ยังไม่จ่าย";

                        }


                        strsql = "update Orders set TableNo =" + Table + ",Total =" + Total + ",Payment = " + Receive + ",Change =" + Change + ",Status = '" + Status + "' where orderNo =" + OrderId;
                        ds = new DataSet();
                        da = new SqlDataAdapter();
                        da.SelectCommand = new SqlCommand(strsql, conn);
                        da.Fill(ds, "updateOrders");
                        strsql = "";

                        strsql = "Delete from orderDt where OrderNo = " + OrderId;
                        ds = new DataSet();
                        da = new SqlDataAdapter();
                        da.SelectCommand = new SqlCommand(strsql, conn);
                        da.Fill(ds, "Deletedetails");
                        strsql = "";
                        for (int i = 0; i < dgv_Detailfood.Rows.Count; i++)
                        {
                            var MenuId = dgv_Detailfood.Rows[i].Cells["MenuId1"].Value.ToString();
                            var Price = dgv_Detailfood.Rows[i].Cells["Price1"].Value.ToString();
                            var Qty = dgv_Detailfood.Rows[i].Cells["Qty"].Value.ToString();
                            strsql = "insert into OrderDt(OrderNo,Date,MenuID,Price,Qty) " +
                             " values(" + OrderId + ",'" + Date + "'," + MenuId + "," + Price + "," + Qty + ")";
                            ds = new DataSet();
                            da = new SqlDataAdapter();
                            da.SelectCommand = new SqlCommand(strsql, conn);
                            da.Fill(ds, "insertdetails");
                            strsql = "";
                        }
                    }

                    Reload();
                    Setdata();
                }
                else
                {
                    MessageBox.Show("ยังไม่มีรายการอาหาร โปรดระบุ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_Tab1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgv_Tab1.CurrentRow.Selected = true;
                tabControl1.SelectedTab = tabPage2;
                var Id = dgv_Tab1.Rows[e.RowIndex].Cells["Order"].FormattedValue.ToString();               
                selectDetail(Id);
               
            }
            catch
            {
                
            }
        }

        private void selectDetail(string Id)
        {
            try
            {
                this.dgv_Detailfood.Rows.Clear();
                strsql = "select * from Orders  where orderNo ="+ Id +"order by OrderNo";
                ds = new DataSet();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(strsql, conn);
                da.Fill(ds, "selectOrder");
                strsql = "";
                if (ds.Tables["selectOrder"].Rows.Count > 0)
                {
                    
                        dr = ds.Tables["selectOrder"].Rows[0];
                        string _id = dr.ItemArray[0].ToString();
                        string _date = dr.ItemArray[1].ToString();
                        string _time = dr.ItemArray[2].ToString();
                        string _table = dr.ItemArray[3].ToString();
                        string _total = dr.ItemArray[4].ToString();
                        string _payment = dr.ItemArray[5].ToString();
                        string _change = dr.ItemArray[6].ToString();
                        string _status = dr.ItemArray[7].ToString();
                        txt_Order.Text = _id;
                        dtp_Date2.Text = _date;
                        dtp_Time.Text = _time;
                        numeric_Table.Value = Convert.ToDecimal(_table);
                        txt_SumPrice.Text = _total;
                        txt_Receive.Text = _payment;
                        txt_Change.Text = _change;                   

                   
                }

                strsql = "select * from OrderDt left outer join Menu on OrderDt.MenuID = Menu.MenuID  where orderNo =" + Id + "order by OrderDt.MenuId";
                ds = new DataSet();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(strsql, conn);
                da.Fill(ds, "selectOrderDt");
                strsql = "";
                if (ds.Tables["selectOrderDt"].Rows.Count > 0)
                {
                    for (int aa = 0; aa <= (ds.Tables["selectOrderDt"].Rows.Count - 1); aa++)
                    {
                        dr = ds.Tables["selectOrderDt"].Rows[aa];
                        string _id = dr.ItemArray[0].ToString();
                        string _date = dr.ItemArray[1].ToString();
                        string _menuId = dr.ItemArray[2].ToString();
                        string _price = dr.ItemArray[3].ToString();
                        string _Qty = dr.ItemArray[4].ToString();
                        string _Name = dr.ItemArray[6].ToString();
                        string[] _addrow_dataGridView1;

                        _addrow_dataGridView1 = new string[] {"False", _menuId, _Name, _price, _Qty};
                        dgv_Detailfood.Rows.Add(_addrow_dataGridView1);

                    }

                }

                if (string.IsNullOrEmpty(txt_Receive.Text.ToString()))
                {
                    btn_Save.Visible = true;
                }
                else
                {
                    btn_Save.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Setdata();
            }
            catch
            {

            }
        }

        private void Setdata()
        {
            this.dgv_Detailfood.Rows.Clear();
            btn_Save.Visible = true;
            txt_Order.Text = "";
            numeric_Table.Value = 0;
            dtp_Date2.Text = DateTime.Now.ToString();
            dtp_Time.Text = DateTime.Now.ToString();
            txt_SumPrice.Text = "";
            txt_Receive.Text = "";
            txt_Change.Text = "";
        }

        private void Reload()
        {
            try
            {
                this.dgv_Tab1.Rows.Clear();

                var Date = dtp_Date.Value.Year.ToString() + "-" + dtp_Date.Value.Month.ToString() + "-" + dtp_Date.Value.Day.ToString();
                if (rd_Total.Checked)
                {
                    strsql = "select * from Orders where Date = '"+ Date + "' order by OrderNo";
                }
                else if (rd_Notpay.Checked)
                {
                    strsql = "select * from Orders where Date = '" + Date + "' and status = 'ยังไม่จ่าย' order by OrderNo";
                }
                else if (rd_Pay.Checked)
                {
                    strsql = "select * from Orders where Date = '" + Date + "' and status = 'จ่ายแล้ว' order by OrderNo";
                }
                
                ds = new DataSet();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(strsql, conn);
                da.Fill(ds, "selectOrder");
                strsql = "";
                if (ds.Tables["selectOrder"].Rows.Count > 0)
                {
                    for (int aa = 0; aa <= (ds.Tables["selectOrder"].Rows.Count - 1); aa++)
                    {
                        dr = ds.Tables["selectOrder"].Rows[aa];

                        string _id = dr.ItemArray[0].ToString();
                        string _tableNo = dr.ItemArray[3].ToString();
                        string _time = dr.ItemArray[2].ToString();
                        string _price = dr.ItemArray[4].ToString();
                        string _status = dr.ItemArray[7].ToString();
                        string[] _addrow_dataGridView1;

                        _addrow_dataGridView1 = new string[] { _id, _tableNo, _time, _price, _status };
                        dgv_Tab1.Rows.Add(_addrow_dataGridView1);

                    }

                }
            }
            catch
            {

            }

        }

        private void numeric_Table_ValueChanged(object sender, EventArgs e)
        {
            var _date = DateTime.Now.Year.ToString()+"-"+ DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            strsql = "select * from Orders where Date = '"+ _date + "' and TableNo = " + numeric_Table.Value.ToString() + " and Status = 'ยังไม่จ่าย'";
            ds = new DataSet();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(strsql, conn);
            da.Fill(ds, "selectOrder2");
            strsql = "";
            if (ds.Tables["selectOrder2"].Rows.Count > 0)
            {
                lbl_status.Text = "ยังไม่จ่าย";
            }
            else
            {
                lbl_status.Text = "";
            }
        }

        private void rd_Total_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void rd_Notpay_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void dgv_Tab1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int iRow = e.RowIndex;
            DataGridViewRow r = dgv_Tab1.Rows[iRow];
            string cellValue = Convert.ToString(r.Cells[4].Value);
            if (cellValue == "ยังไม่จ่าย" )
            {
                r.DefaultCellStyle.BackColor = Color.OrangeRed;
              

            }
        }
    }
}
