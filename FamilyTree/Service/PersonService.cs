using FamilyTree.Model;

namespace FamilyTree.Service
{
    public class PersonService
    {
        private int FindSameNameUtil(Person person, string firstName, int total)
        {
            if (person.Children == null)
            { 
                return 0;
            }

            int totalChildrenSameName = 0;

            if (person.Children != null)
            {
                foreach (Person child in person.Children)
                {
                    if (child.FirstName.Equals(firstName))
                    {
                        totalChildrenSameName++;
                    }
                    totalChildrenSameName += FindSameNameUtil(child, firstName, total);
                }
            }

            return total + totalChildrenSameName;
        }

        public int FindSameName(Person person, string firstName)
        {
            return FindSameNameUtil(person, firstName, 0);
        }
    }
}
