using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelos
{
    public class ExportarExcel
    {
        private int id;
        private string plan;
        private string cons;
        private string noControl;
        private string nombre;
        private string asesorInterno;
        private string asesorexterno;
        private string proyecto;
        private string empresa;
        private string telefonoEmpresa;
        private string telefono;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Plan
        {
            get
            {
                return plan;
            }

            set
            {
                plan = value;
            }
        }

        public string Cons
        {
            get
            {
                return cons;
            }

            set
            {
                cons = value;
            }
        }

        public string NoControl
        {
            get
            {
                return noControl;
            }

            set
            {
                noControl = value;
            }
        }

        public string AsesorInterno
        {
            get
            {
                return asesorInterno;
            }

            set
            {
                asesorInterno = value;
            }
        }

        public string Asesorexterno
        {
            get
            {
                return asesorexterno;
            }

            set
            {
                asesorexterno = value;
            }
        }

        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
            }
        }

        public string TelefonoEmpresa
        {
            get
            {
                return telefonoEmpresa;
            }

            set
            {
                telefonoEmpresa = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Proyecto
        {
            get
            {
                return proyecto;
            }

            set
            {
                proyecto = value;
            }
        }
    }
}
