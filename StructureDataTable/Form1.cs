using System;
using System.Data;
using System.Windows.Forms;

namespace StructureDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtMetaInfo = new DataTable("MetaInfoTable");
            dtMetaInfo.Columns.Add(new DataColumn("SampleRate", Type.GetType("System.String")));
            dtMetaInfo.Columns.Add(new DataColumn("Compensation", Type.GetType("System.String")));
            dtMetaInfo.Columns.Add(new DataColumn("Comission", Type.GetType("System.String")));
            dtMetaInfo.Columns.Add(new DataColumn("Rates", typeof(DataTable)));

            DataTable dtRatesInfo = new DataTable("RatesTable");
            dtRatesInfo.Columns.Add(new DataColumn("ProductA", typeof(DataTable)));
            dtRatesInfo.Columns.Add(new DataColumn("ProductB", typeof(DataTable)));
            dtRatesInfo.Columns.Add(new DataColumn("ProductC", typeof(DataTable)));
            dtRatesInfo.Columns.Add(new DataColumn("ProductX", typeof(DataTable)));
            dtRatesInfo.Columns.Add(new DataColumn("ProductY", typeof(DataTable)));
            dtRatesInfo.Columns.Add(new DataColumn("ProductZ", typeof(DataTable)));

            DataTable dtProductATableInfo = new DataTable("ProductATable");
            dtProductATableInfo.Columns.Add(new DataColumn("Delta", Type.GetType("System.String")));
            dtProductATableInfo.Columns.Add(new DataColumn("Profit", Type.GetType("System.String")));
            dtProductATableInfo.Rows.Add("0.0", "1.0");
            dtProductATableInfo.Rows.Add("0.0", "1.0");
            dtProductATableInfo.Rows.Add("0.0", "1.0");
            dtProductATableInfo.Rows.Add("0.0", "1.0");
            dtProductATableInfo.Rows.Add("0.0", "1.0");

            DataTable dtProductBTableInfo = new DataTable("ProductBTable");
            dtProductBTableInfo.Columns.Add(new DataColumn("Delta", Type.GetType("System.String")));
            dtProductBTableInfo.Columns.Add(new DataColumn("Profit", Type.GetType("System.String")));
            dtProductBTableInfo.Rows.Add("0.0", "1.0");
            dtProductBTableInfo.Rows.Add("0.0", "1.0");
            dtProductBTableInfo.Rows.Add("0.0", "1.0");
            dtProductBTableInfo.Rows.Add("0.0", "1.0");
            dtProductBTableInfo.Rows.Add("0.0", "1.0");

            DataTable dtProductCTableInfo = new DataTable("ProductCTable");
            dtProductCTableInfo.Columns.Add(new DataColumn("Delta", Type.GetType("System.String")));
            dtProductCTableInfo.Columns.Add(new DataColumn("Profit", Type.GetType("System.String")));
            dtProductCTableInfo.Rows.Add("0.0", "1.0");
            dtProductCTableInfo.Rows.Add("0.0", "1.0");
            dtProductCTableInfo.Rows.Add("0.0", "1.0");
            dtProductCTableInfo.Rows.Add("0.0", "1.0");
            dtProductCTableInfo.Rows.Add("0.0", "1.0");

            DataTable dtProductXTableInfo = new DataTable("ProductXTable");
            dtProductXTableInfo.Columns.Add(new DataColumn("Delta", Type.GetType("System.String")));
            dtProductXTableInfo.Columns.Add(new DataColumn("Profit", Type.GetType("System.String")));
            dtProductXTableInfo.Rows.Add("0.0", "1.0");
            dtProductXTableInfo.Rows.Add("0.0", "1.0");
            dtProductXTableInfo.Rows.Add("0.0", "1.0");
            dtProductXTableInfo.Rows.Add("0.0", "1.0");
            dtProductXTableInfo.Rows.Add("0.0", "1.0");

            DataTable dtProductYTableInfo = new DataTable("ProductYTable");
            dtProductYTableInfo.Columns.Add(new DataColumn("Delta", Type.GetType("System.String")));
            dtProductYTableInfo.Columns.Add(new DataColumn("Profit", Type.GetType("System.String")));
            dtProductYTableInfo.Rows.Add("0.0", "1.0");
            dtProductYTableInfo.Rows.Add("0.0", "1.0");
            dtProductYTableInfo.Rows.Add("0.0", "1.0");
            dtProductYTableInfo.Rows.Add("0.0", "1.0");
            dtProductYTableInfo.Rows.Add("0.0", "1.0");

            DataTable dtProductZTableInfo = new DataTable("ProductZTable");
            dtProductZTableInfo.Columns.Add(new DataColumn("Delta", Type.GetType("System.String")));
            dtProductZTableInfo.Columns.Add(new DataColumn("Profit", Type.GetType("System.String")));
            dtProductZTableInfo.Rows.Add("0.0", "1.0");
            dtProductZTableInfo.Rows.Add("0.0", "1.0");
            dtProductZTableInfo.Rows.Add("0.0", "1.0");
            dtProductZTableInfo.Rows.Add("0.0", "1.0");
            dtProductZTableInfo.Rows.Add("0.0", "1.0");


            dtRatesInfo.Rows.Add(dtProductATableInfo, dtProductBTableInfo, dtProductCTableInfo, dtProductXTableInfo, dtProductYTableInfo, dtProductZTableInfo);
            dtMetaInfo.Rows.Add("100.0", "1.0", "50.0", dtRatesInfo);
            dtMetaInfo.Rows.Add("200.0", "2.0", "100.0", dtRatesInfo);
            dtMetaInfo.Rows.Add("300.0", "3.0", "150.0", dtRatesInfo);
            dtMetaInfo.Rows.Add("400.0", "4.0", "200.0", dtRatesInfo);
            dtMetaInfo.Rows.Add("500.0", "5.0", "250.0", dtRatesInfo);

            //Output of Nested tables in all Enterance Table
            DataTable dtRatesInfoOutputX = (DataTable)dtRatesInfo.Rows[0]["ProductA"];
            DataTable dtRatesInfoOutputY = (DataTable)dtRatesInfo.Rows[0]["ProductB"];
            DataTable dtRatesInfoOutputZ = (DataTable)dtRatesInfo.Rows[0]["ProductC"];
            DataTable dtRatesInfoOutputP = (DataTable)dtRatesInfo.Rows[0]["ProductX"];
            DataTable dtRatesInfoOutputQ = (DataTable)dtRatesInfo.Rows[0]["ProductY"];
            DataTable dtRatesInfoOutputR = (DataTable)dtRatesInfo.Rows[0]["ProductZ"];

            //Nested Datatable
            DataTable dtMetaInfoOutputRates = (DataTable)dtMetaInfo.Rows[0]["Rates"];
        }
    }
}
