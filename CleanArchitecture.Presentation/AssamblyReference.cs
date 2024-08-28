using System.Reflection;

namespace CleanArchitecture.Presentation
{
    public static class AssamblyReference
    {
        public static readonly Assembly assembly = typeof(Assembly).Assembly;
    }
}
