namespace FormPersonaEdadHE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona UnaPersona;

        private void btn_Persona_Click(object sender, EventArgs e)
        {
            UnaPersona = new Persona(Convert.ToString(txtbNombre.Text), Convert.ToInt32(txtbDni.Text), Convert.ToDateTime(txtbFechaNac.Text));
        }

        private void btn_Edad_Click(object sender, EventArgs e)
        {
            lblEdad.Text = Convert.ToString(UnaPersona.EdadPersona(UnaPersona.p_fechanacimiento));
        }
    }
}