using System;
using System.Windows.Forms;

namespace CalificadorNotas
{
    public partial class Form1 : Form
    {
        //se crea el objeto calificacionUapa instancia de la clase claUapa
        claUapa calificacionUapa = new claUapa();

        public Form1()
        {
            InitializeComponent();
        }

        //hago las llamada de los tres metodos al hacer click en calcular nota.
        private void btn_nota_Click(object sender, EventArgs e)
        {
            //asigne a variables el texto en textbox transformados en float por uso de la funcion Parse
            float examen = float.Parse(txtbox_examen.Text);
            float plataforma = float.Parse(txtbox_plataforma.Text);
            float actitudesyValores = float.Parse(txtbox_actVal.Text);
            float trabajoFinal = float.Parse(txtbox_trabFinal.Text);

            //asigno la nota que retorna el metodo calcularNota del objeto calificacionUapa, que recibe como argumentos los datos en textbox
            float  nota = calificacionUapa.calcularNota(examen, plataforma, actitudesyValores, trabajoFinal);

            //Imprime la nota disponible en la var nota transformada de float a text.
            output_nota.Text = nota.ToString();

            /*llamo a los dos metodos restantes pasando la var nota como argumento para su calculo
             * el dato salida es string por lo que no requiere conversion y es asignado al output directamente.
            */
            output_estado.Text = calificacionUapa.calcularResultado(nota);
            output_literal.Text = calificacionUapa.calcularLiteral(nota);
        }

        //Limpia los valores en la interfaz grafica.
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
        /*
         La notas son calculadas con diferentes promedios que regularmente cambian, para cambios
        dirigirse a esta seccion, los cambios afectaran al resto del codigo.
         */
        float examen = 30;
        float Plataforma = 50;
        float ActitudesYValores = 5;
        float TrabajoFinal = 15;

        /*
         El metodo recibe los argumentos valorados en una nota que va del (0 al 100) se multiplica con su participacion
        real en la nota y se calcula en porciento aproximado al dividir entre 100

        Como multiplicaciones y divisiones tienen el mismo nivel de prioridad utilizo signos() para indicar que operaciones
        realizar primero

        por ultimo se efectua la suma y se retorna el total en float.
         */
        public float calcularNota(float exam, float plataforma, float ActyVal, float TrabFinal)
        {
            float total = ((exam*examen)/100) + (plataforma*Plataforma)/100 + (ActyVal*ActitudesYValores)/100 + (TrabFinal*TrabajoFinal)/100;
            return total;   
        }

        //Simplemente verificar si el estudiante paso o no, esto es si consigue un 70 o superior
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

        /*Se coloca en orden desendente para evitar que una nota salga con un grado mayor al que deberia, evitando colocar
         mas logica a if conditions
         */
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
