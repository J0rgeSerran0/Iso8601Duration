using System.Runtime.CompilerServices;
using Xunit;

namespace XunitHelpers
{

    public class MethodNamingFactAttribute : FactAttribute
    {
        public MethodNamingFactAttribute([CallerMemberName] string callerMemberName = null)
        {
            DisplayName = callerMemberName;
        }
    }

}