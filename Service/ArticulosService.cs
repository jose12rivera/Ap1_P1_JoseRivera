using Ap1_P1_JoseRivera.DAL;
using Ap1_P1_JoseRivera.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Ap1_P1_JoseRivera.Service
{
    public class ArticulosService
    {
        private readonly Contexto _contexto;

        public ArticulosService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Existe(int ArticuloId)
        {
            return await _contexto.Articulos.AnyAsync(A => A.ArticuloId == ArticuloId);
        }

        public async Task<bool> Existe(string? Descripcion)
        {
            return await _contexto.Articulos.AnyAsync(A => A.Descripcion == Descripcion);
        }
        private async Task<bool> Insertar(Articulos Articulo)
        {

            _contexto.Articulos.Add(Articulo);
            return await _contexto.SaveChangesAsync() > 0;
        }

        private async Task<bool> Modificar(Articulos Articulo)
        {
            _contexto.Articulos.Update(Articulo);
            return await _contexto.SaveChangesAsync() > 0;

        }

        public async Task<bool> Guardar(Articulos Articulo)
        {

            if (!await Existe(Articulo.ArticuloId))
                return await Insertar(Articulo);
            else
                return await Modificar(Articulo);

        }

        public async Task<bool> Eliminar(int id)
        {

            var Articulo = await _contexto.Articulos.FindAsync(id);
            if (Articulo == null)
                return false;

            _contexto.Articulos.Remove(Articulo);
            return await _contexto.SaveChangesAsync() > 0;

        }

        public async Task<Articulos?> Buscar(int id)
        {

            return await _contexto.Articulos.AsNoTracking().FirstOrDefaultAsync(A => A.ArticuloId == id);
        }
        public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> criterio)
        {

            return await _contexto.Articulos.AsNoTracking().Where(criterio).ToListAsync();
        }
    }
}
