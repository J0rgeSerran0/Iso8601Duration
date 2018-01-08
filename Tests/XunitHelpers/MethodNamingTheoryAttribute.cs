using System.Runtime.CompilerServices;
using Xunit;

namespace XunitHelpers
{

    public class MethodNamingTheoryAttribute : TheoryAttribute
    {
        public MethodNamingTheoryAttribute([CallerMemberName] string callerMemberName = null)
        {
            DisplayName = callerMemberName;
        }
    }

}