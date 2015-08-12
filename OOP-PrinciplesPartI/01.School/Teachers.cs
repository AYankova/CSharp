namespace _01.School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teachers:People
    {
        private List<Disciplines> disciplines;

        public Teachers(string name,params Disciplines[] taughtDisc):base(name)
        {
            this.disciplines = new List<Disciplines>();
            this.disciplines.AddRange(taughtDisc);
        }

        public List<Disciplines> AllTaughtDisciplines
        {
            get { return new List<Disciplines>(this.disciplines); }
        }

        public void AddDiscipline(Disciplines disc)
        {
            this.disciplines.Add(disc);
        }

        public void RemoveDiscipline(Disciplines disc)
        {
            this.disciplines.Remove(disc);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Teacher's name: " + this.Name);
            sb.Append("Taught disciplines: " + string.Join(", ", this.disciplines));
            
            return sb.ToString();
        }
    }
}
