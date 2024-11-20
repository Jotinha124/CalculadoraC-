namespace Stuf
{
    public partial class Pagina_inicial : Form
    {
        public Pagina_inicial()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            String txt;
            txt = text_1.Text;
            label_1.Text = txt;
            text_1.Text = "";
        }
    }
}