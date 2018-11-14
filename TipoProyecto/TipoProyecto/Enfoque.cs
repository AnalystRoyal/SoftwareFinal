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
    public partial class Enfoque : Form
    {
        int Estado;
        Capa_Logica cl = new Capa_Logica();
        Boolean HuboBusqueda;
        public Enfoque()
        {
            InitializeComponent();
            HuboBusqueda = false;
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

        private void Enfoque_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_NavActualizar(object sender, EventArgs e)
        {
            caseSwitch = 1;
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

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Estado = 1;
            Txt_Codigo.Enabled = false;
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

                    if (Txt_Nombre.Text == "" || Txt_Descripcion.Text == "")
                    {
                        MessageBox.Show("No se han llenado los campos");
                    }
                    else
                    {
                        cl.EjecutarQuery("INSERT INTO ENFOQUE (Nombre, Descripcion) VALUES ('" + Txt_Nombre.Text + "','" + Txt_Descripcion.Text + "')");
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
                            cl.EjecutarQuery("DELETE FROM ENFOQUE WHERE idEnfoque = " + Convert.ToInt32(Txt_Codigo.Text));
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
                        if (Txt_Codigo.Text == "" || Txt_Nombre.Text == "" || Txt_Descripcion.Text == "")
                        {
                            MessageBox.Show("No se han llenado los campos");
                        }
                        else
                        {
                            cl.EjecutarQuery("UPDATE ENFOQUE SET Nombre = '" + Txt_Nombre.Text + "', Descripcion = '" + Txt_Descripcion.Text + "' WHERE idEnfoque = " + Convert.ToInt32(Txt_Codigo.Text));
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
                cl.ObtieneEnfoque(Convert.ToInt32(Txt_Codigo.Text), Txt_Nombre, Txt_Descripcion);
            }
            HuboBusqueda = true;
            Txt_Codigo.Enabled = true;
        }
    }
}
