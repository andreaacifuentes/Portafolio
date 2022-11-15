namespace AC_1221519_S11_C1
{
    public partial class Form1 : Form
    {
        //Variables globales
        cFormulario _objFormulario = new cFormulario();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, _nacionalidad, _genero, _carrera;
            int _edad;
            nombre = txtnombre.Text;
            _nacionalidad = textBox2.Text;
            _genero = textBox3.Text;
            _carrera = comboBox1.Text;
            _edad = int.Parse(textBox1.Text);

            //Mandar los valores a la clase (se utiliza metodo set de la clase)
            _objFormulario.setNombreCompleto(nombre);
            _objFormulario.setnacionalidad(_nacionalidad);
            _objFormulario.setgenero(_genero);
            _objFormulario.setcarrera(_carrera);
            _objFormulario.setedad(_edad);

            MessageBox.Show("El nombre ingresado es: " + nombre);

            label2.Text=nombre;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre ingresado es: " + _objFormulario.getNombrecCompleto());
            MessageBox.Show("La edad ingresada es: " + _objFormulario.getedad());
            MessageBox.Show("La nacionalidad ingresada es:" + _objFormulario.getnacionalidad());
            MessageBox.Show("El genero ingresado es:" + _objFormulario.getgenero());
            MessageBox.Show("La carrera ingresada es:" + _objFormulario.getcarrera());
        }
    }
}