using GestionDeStock.Data.Interfaces;

namespace GestionStock
{
    public partial class Form1 : Form
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public Form1(IUsuarioRepository usuarioRepository)
        {
            InitializeComponent();
            _usuarioRepository = usuarioRepository;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string contraseña = txtContraseña.Text;
            Menu form2 = new Menu();
            form2.Show();



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
