using System.Windows.Forms;

namespace CapaVista_Navegador
{
    // Formulario de ejemplo que usa el Navegador. Es un Form normal: el control Navegador (navegador1)
    // se arrastró desde la caja de herramientas, igual que se haría en cualquier otro formulario.
    // Una sola línea lo configura: tabla, IdModulo e IdAplicacion (con los que Seguridad busca los
    // permisos del usuario en sesión). La ayuda y el usuario no se parametrizan.
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            navegador1.NavegadorMetConfigurar("tblusuario", 4, 5);
        }
    }
}
