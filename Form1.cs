using System.Collections;

namespace Nomina
{
    public partial class Form1 : Form
    {
        Empleado e1;
        ArrayList empleados = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear empleado
            e1 = new Empleado();  // crear objeto
            e1.Nombre = txtNombre.Text;   // asignar atributos
            e1.Identificacion = txtIdentificacion.Text;
            e1.Arl = comboBox1.Text;
            e1.Salario = double.Parse(txtsalario.Text);

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Nivel I (Riesgo mínimo)":
                    e1.NivelRiesgoARL = NivelRiesgo.NivelI;
                    break;
                case "Nivel II (Riesgo bajo)":
                    e1.NivelRiesgoARL = NivelRiesgo.NivelII;
                    break;
                case "Nivel III (Riesgo medio)":
                    e1.NivelRiesgoARL = NivelRiesgo.NivelIII;
                    break;
                case "Nivel IV (Riesgo alto)":
                    e1.NivelRiesgoARL = NivelRiesgo.NivelIV;
                    break;
                case "Nivel V (Riesgo máximo)":
                    e1.NivelRiesgoARL = NivelRiesgo.NivelV;
                    break;
            }
            empleados.Add(e1);
            txtNombre.Clear();
            txtIdentificacion.Clear();

            txtsalario.Clear();

            // Mostrar todos los empleados cada vez que se agrega uno nuevo
            MostrarEmpleados();


        }
        private void MostrarEmpleados()
        {
            richTextBox1.Clear();  // Limpiar el RichTextBox antes de mostrar todos los empleados

            foreach (var item in empleados)
            {
                Empleado emp = item as Empleado;
                richTextBox1.AppendText(emp.VerInfo()); // Mostrar la información del empleado
                richTextBox1.AppendText("--------------------------\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();  // Mostrar todos los empleados
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un empleado
            if (empleados.Count > 0)
            {
                // Tomar el último empleado
                Empleado empleado = empleados[empleados.Count - 1] as Empleado;

                // Mostrar la nómina calculada

                string nomina = empleado.CalcularNomina();
                richTextBox2.Clear();
                richTextBox2.AppendText(nomina);
            }
            else
            {
                MessageBox.Show("No hay empleados para mostrar la nómina.");
            }
        }
    }
}