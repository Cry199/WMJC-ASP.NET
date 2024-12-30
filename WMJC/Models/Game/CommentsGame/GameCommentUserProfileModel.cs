using WMJC.Models.User.Profile;

namespace WMJC.Models.Game.CommentsGame
{
    public class GameCommentUserProfileModel
    {
        public GameCommentsModel Comment { get; set; }
        public ProfileModel UserProfile { get; set; }


        public GameCommentUserProfileModel(GameCommentsModel comment, ProfileModel userProfile)
        {
            Comment = comment;
            UserProfile = userProfile;
        }

        public override string ToString()
        {
            return $"GameCommentUserProfileModel {{ Comment={Comment}, UserProfile={UserProfile} }}";
        }
    }
}
