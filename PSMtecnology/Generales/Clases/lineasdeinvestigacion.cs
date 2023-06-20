using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoDeGrado.Generales.Clases
{
    internal class lineasdeinvestigacion
    {
        
            string[] lineasistema = { "TELECOMUNICACIONES", "INVESTIGACIÓN DOCUMENTAL", "MODELOS DE SISTEMAS", 
                                    "INTELIGENCIA ARTIFICIAL", "SISTEMA DE INFORMACIÓN TRANSACCIONALES Y DATA WAREHOUSE" };
            string[] ejesistema =  {"REDES", "PORTALES DE INFORMACIÓN", "SERVICIOS ELECTRÓNICOS A DISTANCIA", "TELEFONÍA MÓVIL",
                                    " GPS (SISTEMA DE POSICIONAMIENTO GLOBAL)","METODOLOGÍAS", " NORMAS DE PROCEDIMIENTOS",
                                    "REINGENIERÍA", "SIMULADORES", "JUEGOS", "TUTORIALES", "SISTEMAS DE CONSULTA", "AUDITORÍA",
                                    "ROBÓTICA", "BIOMETRÍA", "SISTEMAS DE SEGURIDAD", "APLICACIONES CLIENTE/ SERVIDOR",
                                    "PLANIFICACIÓN DE RECURSOS EMPRESARIALES", "SEGURIDAD/ANTIVIRUS", "SIMULACIÓN DE PROCESOS"};


            string[] lineamantenimiento = { "PROYECTOS MECÁNICOS", "ADMINISTRACIÓN DE MTTO. MECÁNICO", "MATERIALES", "PRODUCCIÓN", "INSPECCIÓN Y SUPERVISIÓN " };
            string[] ejemantenimiento = {"DISEÑOS DE DISPOSITIVOS, BANCO DE PRUEBAS, EQUIPOS Y LÍNEAS DE PRODUCCIÓN", "SISTEMAS DE LUBRICACIÓN", "CONTROLES AUTOMÁTICOS",
                                        "INSTRUMENTACIÓN Y Y CONTROL","SISTEMA DE GENERACIÓN DE POTENCIA HIDRÁULICA. NEUM. CALOR Y ENFRENTAMIENTO",
                                        "CONSTRUCCIÓN", "POLÍTICAS DE MANTENIMIENTO", "PLANIFICACIÓN Y CONTROL", "IMPLANTACIÓN SISTEMA DE MANTENIMIENTO",
                                        "MANTENIMIENTO PRODUCTIVO TOTAL", "MANTENIMIENTO INDUSTRIAL", "SISTEMAS DE MANTENIMIENTO INTEGRAL",
                                        "ESTUDIO Y COMPOSICIÓN DE MATERIALES", "ENSAYOS MECÁNICOS DE MATERIALES DESTRUCTIVOS Y NO DESTRUCTIVOS",
                                        "SOLDADURA", "CORROSIÓN", "LUBRICACIÓN", "PROCESOS DE MANUFACTURAS", "AUTOMATIZACIÓN DE PROCESOS DE MANUFACTURA",
                                        "SUPERVISIÓN Y CONTROL", "PROGRAMAS DE MANTENIMIENTO", "PROGRAMAS DE SEGURIDAD INDUSTRIAL",
                                         "CLASIFICACIÓN Y ANÁLISIS DE FALLAS", "MONTAJE Y PUESTA EN MARCHA DE EQUIPOS", "APLICACIÓN DE NORMAS DE PROCEDIMIENTOS"};

            string[] lineaindustrial = {"PRODUCCIÓN", "HIGIENE Y SEGURIDAD INDUSTRIAL", "GESTIÓN GERENCIAL",
                                        "INGENIERÍA DE MÉTODOS", "MERCADO", "LOGÍSTICA"};
            string[] ejeindustrial = {"MANTENIMIENTO INDUSTRIAL", "PLANIFICACIÓN Y CONTROL DE LA PRODUCCIÓN",
                                    "MEJORAMIENTO CONTINUO DE PROCESOS", "REINGENIERÍA", "MODELO DE COSTOS INDUSTRIALES",
                                    "INNOVACIÓN TECNOLÓGICA EN MANUFACTURA","SALUD OCUPACIONAL", "ERGONOMÍA", "PREVENCIÓN DE RIESGOS PROFESIONALES",
                                    "GESTIÓN AMBIENTAL", "GERENCIA DE SERVICIOS", "GESTIÓN DEL CONOCIMIENTO","MODELOS DE COMPETENCIA", "TÉCNICAS GERENCIALES",
                                    "ADMINISTRACIÓN DE PERSONAL","FINANZAS", "MÉTODOS INDUSTRIALES", "ESTUDIOS DE TIEMPO Y MOVIMIENTO", "MANEJO DE MATERIALES",
                                    "ANÁLISIS COMPETITIVO", "FRANQUICIAS", "MERCADEO", "PLANIFICACIÓN DE VENTAS","GERENCIA DE PRODUCTOS", "COMPRAS",
                                    "ALMACÉN Y CONTROL DE INVENTARIO", "DISTRIBUCIÓN"};

            string[] lineaelectronica = {"DISEÑO ELECTRÓNICO", "BIOTECNOLOGÍA", "AUTOMATIZACIÓN Y CONTROL",
                                        "ELECTRÓNICA PROGRAMADA", "TELECOMUNICACIONES", "MANTENIMIENTO ELECTRÓNICO"};
            string[] ejeelectronica = {"SISTEMAS ELÉCTRICOS DIGITALES", "SISTEMAS ELÉCTRICOS DE POTENCIA","SISTEMAS DE COMUNICACIÓN",
                                      "INTERFASES Y PROGRAMAS (MICROCOMPONENTES)", "ROBÓTICA", "SISTEMA DE INSTRUMENTACIÓN Y CONTROL",
                                      "BIOINGENIERÍA", "INGENIERÍA BIOMÉDICA", "AMBIENTE", "SIMULACIÓN", "CONTROL DE PROCESOS AUTOMÁTICOS (PLC)",
                                      "SISTEMAS SCADA", "CONTROL LÓGICA DIFUSA", "INFORMÁTICA", "DESARROLLO DE REDES NEURALES","MICRO CONTROLADORES",
                                      "SISTEMAS DE CONTROL", "ROBÓTICA", "TRANS. DE SEÑALES DE VIDEO AUDIO","FIBRA ÓPTICA", "ANTENAS", "TELEFONÍA CELULAR",
                                      "GUÍA DE ONDAS TRANS. DE SEÑALES EN MICROONDAS","SISTEMA DE MANTENIMIENTO PREVENTIVO, CORRECTIVO Y PRODUCTIVO",
                                      "SISTEMAS DIGITALES","COMUNICACIONES", "SISTEMAS ELECTRÓNICOS DE POTENCIA", "SEGURIDAD ELECTRÓNICA"};

          string[] lineaelectrica = { "DISEÑO ELÉCTRICO", "MANTENIMIENTO ELÉCTRICO", "FUENTES DE ENERGÍA", "BIOTECNOLOGÍA" };
            string[] ejeelectrica = {"PLANTAS ELÉCTRICAS Y SUBESTACIONES", "LÍNEAS DE ALIMENTACIÓN, TRANSMISIÓN Y DISTRIBUCIÓN",
                                    "PROTECCIONES ELÉCTRICAS", "CANALIZACIONES ELÉCTRICAS", "SISTEMA DE POTENCIA","SISTEMA DE GENERACIÓN ELÉCTRICA",
                                    "SISTEMA DE INSTRUMENTACIÓN Y CONTROL", "SISTEMA DE MANTENIMIENTO PREVENTIVO, CORRECTIVO Y PRODUCTIVO",
                                    "PRUEBAS DE EFICIENCIA EN SISTEMAS ELÉCTRICOS", "MTTO. DE REDES ELÉCTRICAS","MÁQUINAS ELÉCTRICAS", "TRANSFORMADORES",
                                    "SISTEMAS ALTERNATIVOS DE","GENERACIÓN DE ENERGÍA ELÉCTRICA", "PLANTAS ELÉCTRICAS Y SUBESTACIONES", "BIOINGENIERÍA",
                                    "AMBIENTE", "INGENIERÍA BIOMÉDICA"};

            string[] lineacivil = { "PROYECTOS CIVILES", "CONSTRUCCIÓN", "MANTENIMIENTO PREVENTIVO CORRECTIVO", 
                                    "ADMINISTRACIÓN DE OBRAS", "RIESGOS Y REDUCCIÓN DE DESASTRES NATURALES" };
            string[] ejecivil = {"EDIFICACIONES", "VIALIDAD", "SANITARIAS", "HIDRÁULICAS", "URBANISMOS","DESARROLLO ÁREAS TURÍSTICAS Y COLONIAL",
                                "AMBIENTAL", "ESTRUCTURA DE OBRAS CIVILES", "ESTRUCTURA DE OBRAS VIALES","ESTRUCTURA DE OBRAS SANITARIAS",
                                "ESTRUCTURA DE OBRAS HIDRÁULICAS", "MATERIALES ACERO, MADERA CONCRETO, CONCRETO CELULAR","DESARROLLO DE NUEVAS TECNOLOGÍAS",
                                "SUELOS, ESTUDIO, FUNDACIONES, PILOTES", "OBRAS CIVILES VIALES, SANITARIAS, HIDRÁULICA Y DEL AMBIENTE","NORMATIVAS DE SEGURIDAD",
                                "REHABILITACIÓN DE EDIFICACIONES (COLONIALES)", "CONSERVACIONES DE PARQUES Y CUENCAS HIDROLÓGICAS","CONTAMINACIÓN DEL AMBIENTE",
                                "GERENCIA DE OBRAS CIVILES", "INSPECCIÓN Y SUPERVISIÓN DE OBRAS", "PLANIFICACIÓN Y CATASTRO URBANO","AVALÚO INMOBILIARIO E INDUSTRIAL",
                                "NORMATIVAS", "SISMOS", "INUNDACIONES", "VIENTOS Y HURACANES","EVALUACIÓN DE EDIFICACIONES Y ESTRUCTURAS", "NORMATIVAS", "PLANES DE CONTINGENCIA"};

            string[] lineaarquitec = { "DISEÑO ARQUITECTÓNICO", "PRODUCCIÓN DE SISTEMAS CONSTRUCTIVOS", "PATRIMONIO HISTÓRICO",
                                        "DISEÑO URBANO", "ARQUITECTURA ABIERTA", "ADMINISTRACIÓN Y PLANIFICACIÓN" };
            string[] ejearquitec = {"MÉDICO ASISTENCIAL", "EDUCATIVO", "HABITACIONAL", "GUBERNAMENTAL","RELIGIOSO", "DEPORTIVO",
                                   "RECREACIONAL", "COMERCIAL", "CULTURAL", "CENTROS CÍVICOS", "MILITAR", "TURÍSTICO","TÉCNICAS DE CONSTRUCCIÓN",
                                   "MATERIALES DE CONSTRUCCIÓN", "PROYECTOS DE INSTALACIONES: SANITARIAS, ELÉCTRICAS, MECÁNICAS Y ESPECIALES",
                                   "RESTAURACIÓN DE MONUMENTOS", "CONSERVACIÓN Y MANTENIMIENTO DE MONUMENTOS", "RECICLAJE Y RECONSTRUCCIÓN",
                                   "DE ELEMENTOS ARQUITECTÓNICOS", "RENOVACIÓN URBANÍSTICA", "ESPACIOS PÚBLICOS", "REHABILITACIÓN URBANA",
                                   "PAISAJE: PARQUES, JARDINES Y PLAZAS", "ESTILOS DE PAISAJES URBANOS", "AMBIENTE Y", "RECURSOS NATURALES",
                                   "SUPERVISIÓN E INSPECCIÓN DE OBRAS", "EVALUACIÓN DE ESTRUCTURAS", "NORMATIVAS Y ORDENANZAS","GERENCIA Y ADMINISTRACIÓN"};

        public void definirlineas(ComboBox cblinea,ComboBox Cbescuela,ComboBox cbeje)
        {
            if (Cbescuela.SelectedIndex == 6)
            {
                cblinea.Items.Clear();
                cbeje.Items.Clear();

                cblinea.Items.AddRange(lineasistema);
                cbeje.Items.AddRange(ejesistema);
            }
            if (Cbescuela.SelectedIndex == 5)
            {
                cblinea.Items.Clear();
                cbeje.Items.Clear();

                cblinea.Items.AddRange(lineamantenimiento);
                cbeje.Items.AddRange(ejemantenimiento);
            }
            if (Cbescuela.SelectedIndex == 4)
            {
                cblinea.Items.Clear();
                cbeje.Items.Clear();

                cblinea.Items.AddRange(lineaindustrial);
                cbeje.Items.AddRange(ejeindustrial);
            }
            if (Cbescuela.SelectedIndex == 3)
            {
                cblinea.Items.Clear();
                cbeje.Items.Clear();

                cblinea.Items.AddRange(lineaelectronica);
                cbeje.Items.AddRange(ejeelectronica);
            }
            if (Cbescuela.SelectedIndex == 2)
            {
                cblinea.Items.Clear();
                cbeje.Items.Clear();

                cblinea.Items.AddRange(lineaelectrica);
                cbeje.Items.AddRange(ejeelectrica);
            }
            if (Cbescuela.SelectedIndex == 1)
            {
                cblinea.Items.Clear();
                cbeje.Items.Clear();

                cblinea.Items.AddRange(lineacivil);
                cbeje.Items.AddRange(ejecivil);
            }
            if (Cbescuela.SelectedIndex == 0)
            {
                cblinea.Items.Clear();
                cbeje.Items.Clear();

                cblinea.Items.AddRange(lineaarquitec);
                cbeje.Items.AddRange(ejearquitec);
            }
            
        }
    }

       
}
