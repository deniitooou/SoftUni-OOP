
namespace AuthorProblem
{
    using System;
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}