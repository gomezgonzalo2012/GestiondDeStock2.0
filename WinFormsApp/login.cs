using GestionDeStock;
using GestionDeStock.Business.Autenticacion;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class login : Form
    {
        private readonly ILoginUsuario _loginUsuario;
        //private readonly IUsuarioRepository _usuarioRepository;
        //private readonly IPasswordHasher _passwordHasher;
        public login(ILoginUsuario loginUsuario)
        {
            InitializeComponent();
            //_usuarioRepository = usuarioRepository;
            //_passwordHasher = passwordHasher;
            _loginUsuario = loginUsuario;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string contrasenia = txtContrasenia.Text;


            int loginResult = _loginUsuario.VerificarUsuario(usuario, contrasenia);


            if (loginResult == 1)
            {

                Menu form2 = Program.ServiceProvider.GetRequiredService<Menu>();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string usuario =txtusuario.Text;
            string contrasenia = txtContrasenia.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Usuario nuevoUsuario = new Usuario
            {
                 Nombre = usuario,
                Hash = contrasenia,
                // A�ade otros campos necesarios si los hay
            };

            bool registResult = _loginUsuario.RegistrarUsuario(nuevoUsuario, contrasenia);
            if (!registResult)
            {
                MessageBox.Show("El nombre de usuario ya existe.");
            }
            else
            {
                MessageBox.Show("Usuario guardado exitosamente.");
            }
            
        }
    }


        //private bool Autenticar(string usuario, string contrase�a)
        //{
        //    var user = _usuarioRepository.GetUsuarioByNombre(usuario);

        //    if (user == null)
        //        return false;

        //    var hashedPassword = _passwordHasher.GenerateHashPassword(contrase�a, user.Salt);

        //    return hashedPassword.SequenceEqual(user.Hash);
        //}
    }




