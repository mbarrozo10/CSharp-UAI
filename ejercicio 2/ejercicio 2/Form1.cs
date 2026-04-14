using System.Reflection.Emit;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public ESTACION ESTACION = new ESTACION();
        public List<NAFTA> naftas = new List<NAFTA>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                SURTIDOR s = listBox2.SelectedItem as SURTIDOR;
                s.Nafta = listBox1.SelectedItem as NAFTA;
                Refrescar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            naftas.Add(new NAFTA("Normal", float.Parse("17,20")));
            naftas.Add(new NAFTA("Super", float.Parse("18,85")));
            naftas.Add(new NAFTA("Premium", float.Parse("21,30")));
            listBox1.DataSource = null;
            listBox1.DataSource = naftas;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ESTACION.surtidores.Add(new SURTIDOR());
            Refrescar();
        }

        public void Refrescar()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = this.ESTACION.surtidores;
            label1.Text = "Total vendido: " + ESTACION.CalcularRecaudacionTotal().ToString();
            label3.Text = "El surtidor que mas recuado: " + ESTACION.MaxRecaudado().ToString();
            label4.Text = "El surtidor que menos recuado: " + ESTACION.MinRecaudado().ToString();
            label5.Text = "El surtidor que mas ventas: " + ESTACION.MaxVentas().ToString();
            label8.Text = "El surtidor con mas recargas: " + ESTACION.ObtenerMaxRecargas().ToString();
            label9.Text = ESTACION.ObtenerPorcentajeCantSurtidor(listBox2.SelectedItem as SURTIDOR).ToString(); 
            label10.Text = ESTACION.ObtenerPorcentajeRecaudadoSurtidor(listBox2.SelectedItem as SURTIDOR).ToString();
            label2.Text = "Este surtidor recaudo: " + ESTACION.CalcularRecaudacionSurtidor(listBox2.SelectedItem as SURTIDOR).ToString();
            label6.Text = ESTACION.ObtenerPorcentajeRecaudado(listBox1.SelectedItem as NAFTA).ToString();
            label7.Text = ESTACION.ObtenerPorcentaje(listBox1.SelectedItem as NAFTA).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SURTIDOR s = listBox2.SelectedItem as SURTIDOR;
            s.Vender(float.Parse(textBox1.Text));
            Refrescar();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SURTIDOR s = listBox2.SelectedItem as SURTIDOR;
            s.Reponer();
        }
    }
}
