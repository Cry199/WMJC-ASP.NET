using Microsoft.EntityFrameworkCore;

namespace WMJC.Data
{
    public class WMJCDbContext : DbContext
    {
        public WMJCDbContext(DbContextOptions<WMJCDbContext> options) : base(options)
        {
        }

        // User
        public DbSet<WMJC.Models.User.UserModel> Users { get; set; }
        public DbSet<WMJC.Models.User.Profile.ProfileModel> Profiles { get; set; }
        public DbSet<WMJC.Models.User.Profile.Comments.ProfileComments> ProfileComments { get; set; }
        // public DbSet<WMJC.Models.User.Profile.Comments.ProfileCommentUserProfileModel> ProfileCommentUserProfileModel { get; set; }

        // Game
        public DbSet<WMJC.Models.Game.GameModel> GameModels { get; set; }
        public DbSet<WMJC.Models.Game.GameGeneralModel> GameGenerals { get; set; }
        public DbSet<WMJC.Models.Game.CommentsGame.GameCommentsModel> GameComments { get; set; }
        // public DbSet<WMJC.Models.Game.CommentsGame.GameCommentUserProfileModel> GameCommentUserProfileModel { get; set; }
        public DbSet<WMJC.Models.Game.Historico.GameContadorModel> GameContadors { get; set; }
        public DbSet<WMJC.Models.Game.Historico.GameHistoricoModel> GameHistoricos { get; set; }
    }
}
