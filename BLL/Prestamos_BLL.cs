using System;
using System.Collections.Generic;
using System.Text;
using Registro_Pago.Entidades;
using Registro_Pago.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
 
namespace Registro_Pago.BLL
{
    public class Prestamos_BLL
    {
        //Guardar
        public static bool Guardar(Personas persona)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (db.Personas.Add(persona) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }      
            //Eliminar
           public static bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                var eliminar = Prestamos_BLL.Buscar(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

            //Buscar
          public static Personas Buscar(int id)
        {
            Contexto db = new Contexto();
            Personas persona = new Personas();

            try
            {
                persona = db.Personas.Include(t => t.PersonaId).Where(p => p.PersonaId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return persona;
        }

        
    }                      
           
}       