using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoDeGrado.Generales
{
    internal class paginacion
    {
        public DataTable totaldatos = new DataTable();
        private double total = 0;
        public int pagina = 0;
        private double maximopaginas = 0;
        private double items_por_pagina  = 10;

        public void cargardatos(DataTable dt, Label lbltotalfilas, Label lbltotalpaginas,Label lblpaginacion, DataGridView grid, Button btnAnterior, Button btnSiguiente)
        {
            totaldatos = dt;
            total = dt.Rows.Count;
            lbltotalfilas.Text = "Total = " + total.ToString();

            maximopaginas = Math.Ceiling(total / items_por_pagina);
            lbltotalpaginas.Text = maximopaginas.ToString();
            if (dt.Rows.Count> 0)
            {
                grid.DataSource = split(totaldatos, grid, lblpaginacion, btnAnterior, btnSiguiente);
                Habilitar_Botones(btnAnterior, btnSiguiente);
            }
            
        }

        public DataTable split(DataTable dt,DataGridView grid,Label lblpaginacion, Button btnAnterior, Button btnSiguiente)
        {
            
            if (grid.RowCount==0)
            {
            }
            else
            {
                lblpaginacion.Text = ""+(pagina + 1) +"";
                Habilitar_Botones(btnAnterior,btnSiguiente);
            }

            return dt.Select().Skip(Convert.ToInt32(items_por_pagina * pagina)).Take(Convert.ToInt32(items_por_pagina)).CopyToDataTable();

        }
        public void Habilitar_Botones(Button btnAnterior, Button btnSiguiente)
        {
            if (pagina<1)
            {
                btnAnterior.Enabled = false;

            }
            else
            {
                btnAnterior.Enabled = true;

            }
            if (pagina == (maximopaginas-1))
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;

            }
        }

        public void anterior(DataGridView grid, Label lblpaginacion, Button btnAnterior, Button btnSiguiente)
        {
            pagina = pagina - 1;
            grid.DataSource = split(totaldatos, grid, lblpaginacion, btnAnterior, btnSiguiente);
        }

        public void siguiente(DataGridView grid, Label lblpaginacion, Button btnAnterior, Button btnSiguiente)
        {
            pagina = pagina + 1;
            grid.DataSource = split(totaldatos, grid, lblpaginacion, btnAnterior, btnSiguiente);
        }

    }
    
}
