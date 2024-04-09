using System.Data;

namespace DbDI
{
    public partial class Form1 : Form
    {
        //////////DbCon bd1 = new DbCon(Data.Chain1);
        //////////Logger logger = new Logger();

        private readonly IDbCon _dbCon;
        private readonly ILogger _logger;
        public Form1(IDbCon dbCon, ILogger logger) //Inyectamos
        {
            _dbCon = dbCon;
            _logger = logger;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT [Id], [Name], [Mobile] " +
                            "FROM [Test].[dbo].[TableTest]";
            DataTable dt;

            if (_dbCon.SelectDataTable(query, out dt))
            {
                dgv.DataSource = dt;
                _logger.TrAcE(1, "Form1", 23, "Se carga en dgv la query: " + query);
            }
        }
    }
}