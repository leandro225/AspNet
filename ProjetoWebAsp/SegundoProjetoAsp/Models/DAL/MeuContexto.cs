using System.Data.Entity;

namespace SegundoProjetoAsp.Models.DAL
{
    public class MeuContexto: DbContext
    {

        public MeuContexto() : base("strConn")
        {
            //DropCreateDatabaseAlways 

            //DropCreateDatabaseIfModelChanges

            //Migrations (pra produção)


            Database.SetInitializer<MeuContexto>(new DropCreateDatabaseAlways<MeuContexto>());
        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
    }
}