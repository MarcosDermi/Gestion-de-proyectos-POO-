using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using static TP_2___FInal.clsEnum;

namespace TP_2___FInal
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();


        }

        clsTarea oTarea;
        clsEquipo oEquipo;
        Exception ex;
        public static List<clsEquipo> LEquipo = new List<clsEquipo> { };
        public static List<clsTarea> LTareas = new List<clsTarea> { };
        public static List<clsProyecto> LProyecto = new List<clsProyecto> { };

        private void frmSistema_Load(object sender, EventArgs e)
        {
            refreshCombo();
            //defino objetos

            MessageBox.Show("Para comenzar cree un equipo");
        }

        void limpiarTextBox(TextBox textBox)
        {
            textBox.Text = string.Empty;
        }

        private void refreshCombo()
        {
            this.comboCategoria.DataSource = null;
            this.comboCategoria.DataSource = Enum.GetValues(typeof(clsEnum.Categorias));
        }

        private void refreshDatagridTarea()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = oEquipo.ListaTareas;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView1.Columns["Estado"].Visible = false;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void refreshDatagridEquipo()
        {
            dataGridViewEquipos.DataSource = null;

            dataGridViewEquipos.DataSource = LEquipo;

            dataGridViewEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridViewEquipos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void refreshDataGridProyecto()
        {
            dataGridViewProyecto.DataSource = null;

            dataGridViewProyecto.DataSource = LProyecto;

            dataGridViewEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridViewEquipos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsEnum.Categorias Tarea = (clsEnum.Categorias)comboCategoria.SelectedItem;

            try
            {


                if (clsEnum.Categorias.Desarrollo == Tarea)
                {
                    clsDesarrollo oTarea = new clsDesarrollo(txtDescDesa.Text);
                    oTarea.nombre = txtTareaNombre.Text;
                    oTarea.Estado = (int)clsEnum.Estados.Iniciada;

                    
                        if (string.IsNullOrEmpty(txtTareaValor.Text) || Convert.ToDouble(txtTareaValor.Text) > 0)
                        {

                        
                            oTarea.Valor = Convert.ToDouble(txtTareaValor.Text);
                        oTarea.PresupuestarHoras();

                        oEquipo.ListaTareas.Add(oTarea);

                        }
                    else
                    {
                        clsErrorPersonalizado ex = new clsErrorPersonalizado();
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else if (clsEnum.Categorias.Prueba == Tarea)
                {
                    clsPrueba oTarea = new clsPrueba();
                    oTarea.nombre = txtTareaNombre.Text;
                    oTarea.Estado = (int)clsEnum.Estados.Iniciada;
                    oTarea.fechafinalizacion = dateTimePicker1.Value.ToString();

                    if(string.IsNullOrEmpty(txtTareaValor.Text) || Convert.ToDouble(txtTareaValor.Text) > 0)
                    {
                        oTarea.Valor = Convert.ToDouble(txtTareaValor.Text);
                        oTarea.PresupuestarHoras();

                        oEquipo.ListaTareas.Add(oTarea);
                    }
                    else
                    {
                        clsErrorPersonalizado ex = new clsErrorPersonalizado();
                        MessageBox.Show(ex.Message);
                    }


                }

                limpiarTextBox(txtDescDesa);
                limpiarTextBox(txtTareaNombre);
                limpiarTextBox(txtTareaValor);



                refreshDatagridTarea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            oEquipo = new clsEquipo();

            try
            {
                oEquipo.nombre = txtNombreEquipo.Text;

                LEquipo.Add(oEquipo);

                refreshDatagridEquipo();

                limpiarTextBox(txtNombreEquipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            Tareas.Enabled = true;
            groupBox4.Enabled = true;


        }

        private void dataGridViewEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oEquipo = (clsEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = oEquipo.ListaTareas;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            lblValortotal.Text = ((Icalculable)this.oEquipo).CalcularTotal(oEquipo).ToString();
        }

        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                oTarea = (clsTarea)dataGridView1.CurrentRow.DataBoundItem;

                //oTarea.codigo = Convert.ToInt32(txtCodigoTarea.Text);

                foreach (clsTarea Item in oEquipo.ListaTareas)
                {
                    if (oTarea.codigo == Item.codigo)
                    {
                        Item.nombre = txtTareaNombre.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error", "Error");
            }

            refreshDatagridTarea();

        }

        private void btnBorrarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                oTarea = (clsTarea)dataGridView1.CurrentRow.DataBoundItem;
                DialogResult Respuesta;
                int pos = 0;

                foreach (clsTarea item in oEquipo.ListaTareas) ;
                {
                    if (oTarea.codigo == Convert.ToInt32(txtCodigoTarea.Text))
                    {
                        Respuesta = MessageBox.Show("Esta seguro de eliminar la tarea?", "Borrar", MessageBoxButtons.YesNo);
                        if (Respuesta == DialogResult.Yes)
                        {
                            pos = oEquipo.ListaTareas.IndexOf(oTarea);

                            oEquipo.ListaTareas.RemoveAt(pos);

                        }
                        else
                        { }
                    }
                }

                refreshDatagridTarea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            clsEquipo oEquipoaBuscar = new clsEquipo();
            oEquipoaBuscar.nombre = txtNombreEquipo.Text;

            foreach (clsEquipo item in LEquipo)
            {
                if (item.nombre.Equals(oEquipoaBuscar.nombre))
                {
                    label6.Text = "Se encontro el equipo en la posicion: " + LEquipo.IndexOf(item);
                    break;

                }
                else
                {
                    label6.Text = "No se encontro el equipo en la lista";

                }
            }
        }

        private void btnClonar_Click(object sender, EventArgs e)
        {
            clsEquipo oEquipo = (clsEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;
            LEquipo.Add((clsEquipo)oEquipo.Clone());

            refreshDatagridEquipo();
        }

        private void lblCate_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((clsTarea)dataGridView1.CurrentRow.DataBoundItem is clsDesarrollo)
            {
                clsDesarrollo oTarea = (clsDesarrollo)dataGridView1.CurrentRow.DataBoundItem;
                lblCate.Text = "Desarrollo";
                lblespecial.Text = oTarea.Desc.ToString();
            }
            else
            {
                clsPrueba oTarea = (clsPrueba)dataGridView1.CurrentRow.DataBoundItem;
                lblCate.Text = "Prueba";
                lblespecial.Text = oTarea.fechafinalizacion.ToString();
            }
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                clsEquipo EquipoSelec = (clsEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;
                DialogResult Respuesta;
                int pos = 0;

                foreach(clsEquipo item in LEquipo)
                {
                    if (EquipoSelec.nombre == txtNombreEquipo.Text)
                    {
                        Respuesta = MessageBox.Show("Quiere borrar el equipo?", "Borrar", MessageBoxButtons.YesNo);
                        if (Respuesta == DialogResult.Yes)
                        {
                            pos = LEquipo.IndexOf(EquipoSelec);

                            LEquipo.RemoveAt(pos);

                            refreshDatagridEquipo();

                            limpiarTextBox(txtNombreEquipo);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                clsProyecto oProyecto = new clsProyecto();

                oProyecto.nombre = txtNombreProyecto.Text;

                oProyecto.Equipo = (clsEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;

                oProyecto.Equipo.Estado = (int)clsEnum.Estados.Proceso;

                if(oProyecto.Equipo.Estado == 1)
                {
                    
                    //dataGridViewProyecto.Columns["Estado"].Value = "En Proceso";
                }

                LProyecto.Add(oProyecto);

                refreshDataGridProyecto();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

        }


        private void dataGridViewProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
