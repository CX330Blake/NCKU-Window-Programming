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

namespace AN4126068_practice_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.transactionHistoryTableAdapter.FillBy(this.an4126068_dbDataSet.TransactionHistory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 加载 Items 表
            this.itemsTableAdapter.Fill(this.an4126068_dbDataSet.Items);

            // 加载 Customers 表
            this.customersTableAdapter.Fill(this.an4126068_dbDataSet.Customers);

            // 加载 TransactionHistory 表
            this.transactionHistoryTableAdapter.Fill(this.an4126068_dbDataSet.TransactionHistory);

            // 绑定 TransactionHistory 到 dataGridView1
            dataGridView1.DataSource = this.an4126068_dbDataSet.TransactionHistory;

            // 初始化 dataGridView2 和 dataGridView3 数据源为空
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

            // 注册行选择事件
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

        }


        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillBy(this.an4126068_dbDataSet.Customers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 获取选中行的 CustomerID 和 ItemID
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells[1].Value); // CustomerID 位于第2列 (索引从0开始)
                int itemId = Convert.ToInt32(selectedRow.Cells[2].Value);    // ItemID 位于第3列

                // 加载对应的 Customer 和 Item 数据
                LoadCustomerData(customerId);
                LoadItemData(itemId);
            }
            else
            {
                // 如果没有选中行，则清空 dataGridView2 和 dataGridView3
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
            }
        }


        private void LoadCustomerData(int customerId)
        {
            // 从 Customers 表中筛选出匹配的行
            var customerRows = this.an4126068_dbDataSet.Customers.Select($"CID = {customerId}");

            if (customerRows.Length > 0)
            {
                // 将筛选结果绑定到 dataGridView2
                dataGridView2.DataSource = customerRows.CopyToDataTable();
            }
            else
            {
                dataGridView2.DataSource = null; // 清空数据源
            }
        }
        private void LoadItemData(int itemId)
        {
            // 从 Items 表中筛选出匹配的行
            var itemRows = this.an4126068_dbDataSet.Items.Select($"ItemID = {itemId}");

            if (itemRows.Length > 0)
            {
                // 将筛选结果绑定到 dataGridView3
                dataGridView3.DataSource = itemRows.CopyToDataTable();
            }
            else
            {
                dataGridView3.DataSource = null; // 清空数据源
            }
        }


    }
}
