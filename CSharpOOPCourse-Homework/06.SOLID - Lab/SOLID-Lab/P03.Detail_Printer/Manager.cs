using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Current documents:");

            foreach (var document in this.Documents)
            {
                sb.AppendLine(document.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}