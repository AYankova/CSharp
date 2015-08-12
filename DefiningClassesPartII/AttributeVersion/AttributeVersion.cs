namespace AttributeVersion
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute: Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }

    [Version("v. 2.11")]
    class AttributeVersionTest
    {
        static void Main()
        {
            Type type = typeof(AttributeVersionTest);
            object[] attr = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
