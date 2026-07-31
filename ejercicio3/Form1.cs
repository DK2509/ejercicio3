namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboProductosPrecios.Items.Add("Arroz (Campos Premium; RD$235.00");
            cboProductosPrecios.Items.Add("Aceite de Soya (Wala); RD$207.00");
            cboProductosPrecios.Items.Add("Huevos Grandes (Wala); RD$209.00");
            cboProductosPrecios.Items.Add("Leche Entera (Wala); RD$59.00");
            cboProductosPrecios.Items.Add("Plátano Verde; RD$21.00");
        }

        private void cboProductosPrecios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void txtResultado_Click(object sender, EventArgs e)
        {


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = 0;
           

            if (cboProductosPrecios.Text == "Arroz (Campos Premium; RD$235.00")
            {
                ;

                txtResultado.Text = ("El precioa pagar es de: " + double.Parse(txtCantidad.Text) * 235 + " pesos").ToString() ;
            }

            else if (cboProductosPrecios.Text == "Aceite de Soya (Wala); RD$207.00")
            {
                
                txtResultado.Text = ("El precio a pagar es de: " + double.Parse(txtCantidad.Text) * 207 + " pesos").ToString();
            }
            else if (cboProductosPrecios.Text == "Huevos Grandes (Wala); RD$209.00")
            {
                
                txtResultado.Text = ("El precio a pagar es de: " + double.Parse(txtCantidad.Text) * 209 + " pesos").ToString();
            }
            else if (cboProductosPrecios.Text == "Leche Entera (Wala); RD$59.00")
            {
               
                txtResultado.Text = ("El precio a pagar es de: " + double.Parse(txtCantidad.Text) * 59 + " pesos").ToString();
            }
            else if (cboProductosPrecios.Text == "Plátano Verde; RD$21.00")
            {
                
                txtResultado.Text = ("El precio a pagar es de: " + double.Parse(txtCantidad.Text) * 21 + " pesos").ToString();
            }
        }
    }
}
