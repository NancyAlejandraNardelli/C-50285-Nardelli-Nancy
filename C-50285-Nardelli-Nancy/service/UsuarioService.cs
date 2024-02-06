using C_50285_Nardelli_Nancy.database;
using C_50285_Nardelli_Nancy.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_50285_Nardelli_Nancy.service
{
    internal static class UsuarioService
    {
        public static List<Usuario> GetAllUsers()
        {
            using(AppDbContext context =new AppDbContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();
                return usuarios;
            }
        }

        public static Usuario GetUserById(int userId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Usuario usuario = context.Usuarios.FirstOrDefault(u => u.Id == userId);
                return usuario;
            }
        }

        public static bool AddUser(Usuario usuario)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return true;
            }
        }
        public static void UpdateUser(Usuario usuario)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static bool DeleteUser(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var usuario = GetUserById(id);

                if (usuario != null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}
