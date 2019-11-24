using SQLite;

namespace Mentr
{

    /*
     * Declares classes that represent the tables in the Database
     * They are also used as return objects when the database is queried
     * */

    public class User
    {
        [PrimaryKey]
        public string Username { get; set; } // Username - must be unquie, used as Pkey
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Field { get; set; }    // Field of study or work
        public string UserType { get; set; } // Mentor/Mentee classification
        public string Email { get; set; }
        public string College { get; set; }  // College of study or employment

        public string Description { get; set; }
        public string Picture { get; set; }
    }

    // Stores info on User Profile info not used in matching
    public class UserProfile
    {
        [PrimaryKey]
        public string Username { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
    }

    public class Mentor
    {
        [PrimaryKey]
        public string Username { get; set; } // Seperate info for Mentors only
        public string JobTitle { get; set; } // position they hold
    }

    // Stores Match information and which parties have accepted or denied
    public class Match
    {
        [PrimaryKey, AutoIncrement]
        public int MatchID { get; set; }
        public string MentorUsername { get; set; }
        public string MenteeUsername { get; set; }
        public bool MentorAccept { get; set; }
        public bool MenteeAccept { get; set; }
        public int Priority { get; set; }
    }

    // DM storeage
    public class TextMessage
    {
        [PrimaryKey, AutoIncrement]
        public int MessageID { get; set; }
        public string MentorUsername { get; set; }
        public string MenteeUsername { get; set; }
        public string UserMessage { get; set; }
        public string MessageNumber { get; set; } // order of messages
    }

    // Social Page articles
    public class CardDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int ArtcileID { get; set; }
        public string HeadTitle { get; set; }
        public string HeadLines { get; set; }
        public string HeadLinesDesc { get; set; }
        public string ProfileImage { get; set; }
    }

}