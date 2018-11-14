using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoProyecto
{
    public partial class Tipo_Proyecto : Form
    {
        int Estado;
        Capa_Logica cl = new Capa_Logica();

        int CodigoEnfoqueAnt;
        int CodigoMetodologiaAnt;

        Boolean HuboBusqueda;

        public Tipo_Proyecto()
        {
            InitializeComponent();
            HuboBusqueda = false;
            cl.LlenaCombobox(Cmb_Enfoque, "Seleccione Enfoque", "SELECT idEnfoque, Nombre FROM ENFOQUE","Nombre", "idEnfoque");
            cl.LlenaCombobox(Cmb_Metodologias, "Seleccione Metodología", "SELECT idMetodologias, Nombre FROM METODOLOGIAS", "Nombre", "idMetodologias");
        }

        public struct tipoRegistro
        {
            public int no;
            public string DATO;
            public string COLUMNA;

        }

        List<tipoRegistro> listado = new List<tipoRegistro>();
        //numero registro
        int id = 0;
        int id2 = 0;

        //numero de accion buttom
        int caseSwitch = 0;

        private void Btn_Agregar_Enfoque_Click(object sender, EventArgs e)
        {
            Enfoque enfoque = new Enfoque();
            enfoque.Show();  
        }

        private void Btn_Agregar_Metodologias_Click(object sender, EventArgs e)
        {
            Metodologias metodologias = new Metodologias();
            metodologias.Show();
        }

        private void Tipo_Proyecto_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_NavActualizar(object sender, EventArgs e)
        {
            caseSwitch = 2;
        }

        private void navegador1_NavAnterior(object sender, EventArgs e)
        {
            id2--;
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)
                {
                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;

                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;
            }
        }

        private void navegador1_NavAyuda(object sender, EventArgs e)
        {

        }

        private void navegador1_NavEliminar(object sender, EventArgs e)
        {
            caseSwitch = 3;
        }

        private void navegador1_NavFin(object sender, EventArgs e)
        {
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)

                {
                    _textbox.Text = listado.Where(a => a.no == id && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;

                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == id && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;

            }
        }

        private void navegador1_NavGuardar(object sender, EventArgs e)
        {
            switch (caseSwitch)

            {
                case 1:
                    Navegador.INSERCION obj = new Navegador.INSERCION();
                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Text != string.Empty)
                        {
                            obj.CREANDOSQL(_textbox.Tag.ToString());
                        }
                        if (_textbox is ComboBox && _textbox.Text != string.Empty)
                        {
                            obj.CREANDOSQL(_textbox.Tag.ToString());
                        }
                    }

                    obj.value();
                    id++;

                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Text != string.Empty)
                        {
                            listado.Add(new tipoRegistro { no = id, DATO = _textbox.Text, COLUMNA = _textbox.Tag.ToString() });
                            obj.CREANDOSQL2(_textbox.Text);
                        }
                        if (_textbox is ComboBox && _textbox.Text != string.Empty)
                        {
                            listado.Add(new tipoRegistro { no = id, DATO = _textbox.Text, COLUMNA = _textbox.Tag.ToString() });
                            obj.CREANDOSQL2(_textbox.Text);
                        }
                        id2 = id;
                    }
                    obj.coma();
                    break;

                case 2:

                    Navegador.ACTUALIZAR obj2 = new Navegador.ACTUALIZAR();
                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Name == "primarykey")
                        {
                            obj2.COMPARACION(_textbox.Text, _textbox.Tag.ToString());
                        }
                        else if (_textbox is TextBox && _textbox.Name != string.Empty)
                        {
                            obj2.CREANDOSQL(_textbox.Text, _textbox.Tag.ToString());
                        }
                        if (_textbox is ComboBox && _textbox.Name == "primarykey")
                        {
                            obj2.COMPARACION(_textbox.Text, _textbox.Tag.ToString());
                        }
                        else if (_textbox is ComboBox && _textbox.Name != string.Empty)
                        {
                            obj2.CREANDOSQL(_textbox.Text, _textbox.Tag.ToString());
                        }
                    }

                    obj2.coma();
                    obj2.finalizarsql();
                    break;

                case 3:

                    Navegador.ELIMINAR obj3 = new Navegador.ELIMINAR();
                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Name == "primarykey")
                        {
                            obj3.finalizarsql(_textbox.Text, _textbox.Tag.ToString());
                        }
                        if (_textbox is ComboBox && _textbox.Name == "primarykey")
                        {
                            obj3.finalizarsql(_textbox.Text, _textbox.Tag.ToString());
                        }
                    }
                    break;
            }
        }

        private void navegador1_NavInicio(object sender, EventArgs e)
        {
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)
                {
                    _textbox.Text = listado.Where(a => a.no == 1 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;
                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == 1 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;
            }
        }

        private void navegador1_NavInsertar(object sender, EventArgs e)
        {
            caseSwitch = 1;
            MessageBox.Show("Aqui inserto");
        }

        private void navegador1_NavSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_NavSiguiente(object sender, EventArgs e)
        {
            id2++;
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)
                {
                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;
                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;
            }
        }

        private void Cmb_Enfoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_Enfoque.SelectedValue.ToString() != "")
            {
                Lbl_Codigo.Text = Cmb_Enfoque.SelectedValue.ToString();
            }

            MessageBox.Show(Cmb_Enfoque.SelectedValue.ToString());
        }

        private void Cmb_Metodologias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_Metodologias.SelectedValue.ToString() != "")
            {
                //label2.Text = Cmb_Metodologias.SelectedValue.ToString();
            }
            MessageBox.Show(Cmb_Metodologias.SelectedValue.ToString());
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Estado = 1;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            Txt_Codigo.Enabled = true;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Estado = 3;
            Txt_Codigo.Enabled = true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            switch (Estado)
            {
                case 1:

                    if (Txt_Nombre.Text == "" || Txt_Descripcion.Text == "" || Cmb_Enfoque.SelectedValue.ToString() == "" || Cmb_Metodologias.SelectedValue.ToString() == "")
                    {
                        MessageBox.Show("No se han llenado los campos");
                    }
                    else
                    {
                        cl.EjecutarQuery("INSERT INTO TIPOPROYECTO (Nombre, Descripcion, Enfoque_idEnfoque, Metodologias_idMetodologias) VALUES ('" + Txt_Nombre.Text + "','" + Txt_Descripcion.Text + "', " + Convert.ToInt32(Cmb_Enfoque.SelectedValue.ToString()) + ", " + Convert.ToInt32(Cmb_Metodologias.SelectedValue.ToString()) + ")");
                    }

                    break;
                case 2:

                    if (HuboBusqueda == false)
                    {
                        MessageBox.Show("No se ha hecho una búsqueda");
                    }
                    else
                    {
                        if (Txt_Codigo.Text == "")
                        {
                            MessageBox.Show("No se ha ingresado el código");
                        }
                        else
                        {
                            cl.EjecutarQuery("DELETE FROM TIPOPROYECTO WHERE idtipoProyecto = " + Convert.ToInt32(Txt_Codigo.Text));
                        }
                    }

                    break;
                case 3:

                    if (HuboBusqueda == false)
                    {
                        MessageBox.Show("No se ha hecho una búsqueda");
                    }
                    else
                    {
                        if (Txt_Codigo.Text == "" || Txt_Nombre.Text == "" || Txt_Descripcion.Text == "" || Cmb_Enfoque.SelectedValue.ToString() == "" || Cmb_Metodologias.SelectedValue.ToString() == "")
                        {
                            MessageBox.Show("No se han llenado los campos");
                        }
                        else
                        {
                            int CodigoE, CodigoM;

                            if (Convert.ToInt32(label1.Text) != Convert.ToInt32(Cmb_Enfoque.SelectedValue.ToString()))
                            {
                                CodigoE = Convert.ToInt32(Cmb_Enfoque.SelectedValue.ToString());
                            }
                            else
                            {
                                CodigoE = Convert.ToInt32(label1.Text);
                            }

                            if (Convert.ToInt32(label2.Text) != Convert.ToInt32(Cmb_Metodologias.SelectedValue.ToString()))
                            {
                                CodigoM = Convert.ToInt32(Cmb_Metodologias.SelectedValue.ToString());
                            }
                            else
                            {
                                CodigoM = Convert.ToInt32(label2.Text);
                            }

                            cl.EjecutarQuery("UPDATE TIPOPROYECTO SET Nombre = '" + Txt_Nombre.Text + "', Descripcion = '" + Txt_Descripcion.Text + "', Enfoque_idEnfoque = " + CodigoE + ", Metodologias_idMetodologias = " + CodigoM + " WHERE idtipoProyecto = " + Convert.ToInt32(Txt_Codigo.Text));
                        }
                    }

                    break;
            }
            limpiar();
        }

        public void limpiar()
        {
            Txt_Codigo.Clear();
            Txt_Nombre.Clear();
            Txt_Descripcion.Clear();
            cl.LlenaCombobox(Cmb_Enfoque, "Seleccione Enfoque", "SELECT idEnfoque, Nombre FROM ENFOQUE", "Nombre", "idEnfoque");
            cl.LlenaCombobox(Cmb_Metodologias, "Seleccione Metodología", "SELECT idMetodologias, Nombre FROM METODOLOGIAS", "Nombre", "idMetodologias");
            Estado = 0;
            HuboBusqueda = false;
            Txt_Codigo.Enabled = false;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("No se ha ingresado el código");
            }
            else
            {
                cl.ObtieneTipoProyecto(Convert.ToInt32(Txt_Codigo.Text), Txt_Nombre, Txt_Descripcion, Cmb_Enfoque, Cmb_Metodologias, label1, label2);
            }
            HuboBusqueda = true;
            Txt_Codigo.Enabled = true;
        }
    }
}
