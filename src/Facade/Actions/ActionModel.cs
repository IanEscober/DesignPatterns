namespace Facade.Actions
{
    using System.Collections.Generic;

    public class ActionModel
    {
        public string Type { get; set; }
        public IEnumerable<object> Props { get; set;  }
    }
}
