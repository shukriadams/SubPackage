namespace SubPackage {
    public static class DateTimeSpanExtensions
    {
        public static string Ago(this DateTime beforeUtc)
        {
            return "some value";
        }
    }

    public class Sub {
        public string Id { get;set;}
        
        // v2 change
        public string Name { get;set;}
        
        public Sub()
        {
            DateTime d = new DateTime();
            // confirm extension property exists
            string test = d.Ago();
        }        
    }
}
