using WMJC.Models.User.Profile;
using WMJC.Models.User.Profile.Comments;

namespace WMJC.Models.User.Profile.Comments
{
    public class ProfileCommentUserProfileModel
    {
        public ProfileModel UserProfile { get; set; }
        public ProfileComments CommentProfile { get; set; }

        public ProfileCommentUserProfileModel(ProfileModel userProfile, ProfileComments commentProfile)
        {
            UserProfile = userProfile;
            CommentProfile = commentProfile;
        }
    }
}
