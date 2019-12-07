using System;
using System.Collections.Generic;
using System.Text;

namespace Mentr
{
    public static class GlobalVariables
    {
        /**
         * Once logged in, the current_user variable should be updated to the
         * username of the user. For checking if a user is logged in, we can just check
         * if this variable is still equal to NULL
         */
        public static string current_user = null;
    }
}
