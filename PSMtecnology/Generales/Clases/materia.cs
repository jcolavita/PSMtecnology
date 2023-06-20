using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMtecnology.Generales.Clases
{
    internal class materia
    {

        string[] sistemas = { " SIMULACIÓN Y CONTROL", "TELEINFORMATICA", "VISUAL BASIC", "ALGORITMOS", "NETWARE", "ADOBE", "UNIX", "SISTEMA OPERATIVOS", "WINDOWS", "DATOS", "COPILADORES", "SISTEMA DE INFORMACIÓN", "TEORIA DE SISTEMA", "ANALISIS Y DISEÑO", "AUDITORIA" };
        string[] comun = { "METODOLOGIA", "PROYECTOS", "FILOSOFIA", "ETICA", "SOCIOLOGÍA", "COMUNICACIÓN", "ESTADISTICA", "ECONOMIA", "DERECHO" };
        string[] electrica = { "LINEAS ELECTRICAS", "INSTALACIONES ELECTRICA", "SISTEMA DE CONTROL", "ANALISIS DE SEÑALES  Y SISTEMA", "AMPLIFICADORES", "SISTEMA DE COMUNICACIONES" };
        string[] electronica = { "LINEAS ELECTRICAS", "INSTALACIONES ELECTRICA", "SISTEMA DE CONTROL", "ANALISIS DE SEÑALES  Y SISTEMA", "AMPLIFICADORES", "SISTEMA DE COMUNICACIONES" };
        string[] arquitec = { "URBANISMO", "CARTILLA DE URBANISMO Y CONSTRUCCIÓN DE MADERA", "URBANIZACIÓN", "SUB-DESARROLLO", "CIUDADES", "CERCAS Y VELLADOS", "CASAS", "MUTACIONES" };
        string[] civil = { "INGENIERIA CIVIL", "MECANICA DE SOLIDOS", "MECANICA DE ESTATICA", "MECANICA DE VECTORIAL", "MECANICA DINAMICA", "MECANICA DE FLUIDOS" };

        public void materiasadeaf(ComboBox escuela, ComboBox materias)
        {
            if (escuela.SelectedIndex==7)
            {
                materias.Items.Clear();
                materias.Items.AddRange(sistemas);

            }
            if(escuela.SelectedIndex == 6)
            {

            }
            if (escuela.SelectedIndex == 5)
            {

            }
            if (escuela.SelectedIndex == 4)
            {
                materias.Items.Clear();
                materias.Items.AddRange(electronica);
            }
            if (escuela.SelectedIndex == 3)
            {
                materias.Items.Clear();
                materias.Items.AddRange(electrica);
            }
            if (escuela.SelectedIndex == 2)
            {
                materias.Items.Clear();
                materias.Items.AddRange(civil);
            }
            if (escuela.SelectedIndex == 1)
            {
                materias.Items.Clear();
                materias.Items.AddRange(arquitec);
            }
            if (escuela.SelectedIndex == 0)
            {
                materias.Items.Clear();
                materias.Items.AddRange(comun);
            }
        }
        
    }
}



