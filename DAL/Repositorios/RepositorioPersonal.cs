using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Repositorios
{
    public class RepositorioPersonal
    {
        private readonly string FileName = "Personal.txt";

        public bool Crear(Personal personal)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine($"{personal.cedula};{personal.nombre};{personal.apellido};{personal.telefono}");
                writer.Close();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear El Personal: {ex.Message}");
                return false;

            }
        }
        public Personal buscarPersonal(string cedula)
        {
            try
            {
                foreach (var personal in listaPersonal())
                {
                    if (cedula == personal.cedula)
                    {
                        return personal;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por cedula: {ex.Message}");
                return null;
            }
        }
        public bool Modificar(Personal personal) 
        {
            List<Personal> personals = new List<Personal>();
            personals = listaPersonal();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var PersonalAnterior in personals)
                {
                    if (PersonalAnterior.cedula != personal.cedula)
                    {
                        Crear(PersonalAnterior);
                    }
                    else
                        Crear(personal);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el empleado: {ex.Message}");
                return false;
            }
        }
        public bool Eliminar(string cedula)
        {
            List<Personal> personals = new List<Personal>();
            personals = listaPersonal();

            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                file.Close();

                foreach (var personal in personals)
                {
                    if (personal.cedula != cedula)
                    {
                        Crear(personal);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al elminar al empleado: {ex.Message}");
                return false;
            }
        }
        public List<Personal> listaPersonal()
        {
            List<Personal> personals = new List<Personal>();
            try
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Personal personal = Map(linea);
                    personals.Add(personal);
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar a los personales: {ex.Message}");
            }
            return personals;
        }
        private Personal Map(String linea)
        {
            try
            {
                Personal personal = new Personal();
                char delimiter = ';';
                string[] matrizPersonal = linea.Split(delimiter);
                personal.cedula = matrizPersonal[0];
                personal.nombre = matrizPersonal[1];
                personal.apellido = matrizPersonal[2];
                personal.telefono = int.Parse((matrizPersonal[3]));

                return personal;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mapear: {ex.Message}");
                return null;
            }
        }
    }
}
