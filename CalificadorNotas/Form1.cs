using System;
using System.Windows.Forms;

namespace CalificadorNotas
{
    public partial class Form1 : Form
    {
        claUapa calificacionUapa = new claUapa();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nota_Click(object sender, EventArgs e)
        {
            float examen = float.Parse(txtbox_examen.Text);
            float plataforma = float.Parse(txtbox_plataforma.Text);
            float actitudesyValores = float.Parse(txtbox_actVal.Text);
            float trabajoFinal = float.Parse(txtbox_trabFinal.Text);

            float  nota = calificacionUapa.calcularNota(examen, plataforma, actitudesyValores, trabajoFinal);

            output_nota.Text = nota.ToString();
            output_estado.Text = calificacionUapa.calcularResultado(nota);
            output_literal.Text = calificacionUapa.calcularLiteral(nota);
            //calificacionUapa.calcularNota(examen, plataforma, actitudesyValores, trabajoFinal);

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtbox_examen.Text = "";
            txtbox_actVal.Text = "";
            txtbox_plataforma.Text = "";
            txtbox_trabFinal.Text = "";
            output_nota.Text = "NOTA";
            output_estado.Text = "ESTADO";
            output_literal.Text = "LITERAL";
        }
    }

    public class claUapa
    {
        
        float examen = 30;
        float Plataforma = 50;
        float ActitudesYValores = 5;
        float TrabajoFinal = 15;

        public float calcularNota(float exam, float plataforma, float ActyVal, float TrabFinal)
        {
            float total = ((exam*examen)/100) + (plataforma*Plataforma)/100 + (ActyVal*ActitudesYValores)/100 + (TrabFinal*TrabajoFinal)/100;
            return total;   
        }
        public string calcularResultado(float nota)
        {
            if(nota >= 70)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }
        public string calcularLiteral(float nota)
        {
            if (nota >= 90)
            {
                return "A";
            }
            else if (nota >= 80)
            {
                return "B";
            }
            else if(nota >= 70)
            {
                return "C";
            }
            else if(nota >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
