using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ayaBOL;
namespace ayaBL
{
    
        public class ayaBL
        {            public static bool InsertarAlumno(Alumnos alumno)
            {
                try
                {
                    ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                    obj.InsertarAlumno(alumno);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static bool ModificarAlumno(Alumnos alumno)
            {
                try
                {
                    ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                    obj.ModificarAlumnos(alumno);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static bool EliminarAlumno(int id)
            {
                try
                {
                    ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                      obj.EliminarAlumno(id);
                return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static List<Alumnos> SeleccionarTodosAlumnos()
            {
                List<Alumnos> lista = new List<Alumnos>();
                try
                {
                    ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                    lista = obj.SeleccionarTodos();
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }

            

            public static bool InsertarAsignatura(Asignatura asignatura)
            {
                try
                {
                    ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                    obj.InsertarAsignatura(asignatura);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static bool ModificarAsignatura(Asignatura asignatura)
            {
                try
                {
                    ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                    obj.ModificarAsignatura(asignatura);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static bool EliminarAsignatura(int codigo)
            {
                try
                {
                    ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                    obj.EliminarAsignatura(codigo);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static List<Asignatura> SeleccionarTodasAsignaturas()
            {
            List<Asignatura> lista = new List<Asignatura>();
            try
            {
                ayaDAL.ayaDAL obj = new ayaDAL.ayaDAL();
                lista = obj.SeleccionarTodasAsignaturas();


                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

            
        }
    }
