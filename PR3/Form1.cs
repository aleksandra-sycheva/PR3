namespace PR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var list1 = db.TypeOfPartners.ToList();
                var list2 = db.TypeOfProducts.ToList();

                foreach (TypeOfProducts item in list1) {
            }
        }
    }
}
