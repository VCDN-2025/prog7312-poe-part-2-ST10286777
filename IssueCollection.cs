using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services
{
    public class IssueCollection
    {
        private Issue[] issues;
        private int count;
        private int capacity;

        public IssueCollection()
        {
            capacity = 10;
            issues = new Issue[capacity];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Add(Issue issue)
        {
            if (count >= capacity)
            {
                ResizeArray();
            }

            issue.IssueId = count + 1; // Auto-generate ID
            issues[count] = issue;
            count++;
        }

        public Issue GetIssue(int index)
        {
            if (index >= 0 && index < count)
            {
                return issues[index];
            }
            return null;
        }

        public Issue[] GetAllIssues()
        {
            Issue[] result = new Issue[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = issues[i];
            }
            return result;
        }

        public bool Remove(int issueId)
        {
            for (int i = 0; i < count; i++)
            {
                if (issues[i].IssueId == issueId)
                {
                    // Shift elements left
                    for (int j = i; j < count - 1; j++)
                    {
                        issues[j] = issues[j + 1];
                    }
                    count--;
                    issues[count] = null; // Clear reference
                    return true;
                }
            }
            return false;
        }

        public Issue FindById(int issueId)
        {
            for (int i = 0; i < count; i++)
            {
                if (issues[i].IssueId == issueId)
                {
                    return issues[i];
                }
            }
            return null;
        }

        public Issue[] FindByCategory(string category)
        {
            Issue[] temp = new Issue[count];
            int tempCount = 0;

            for (int i = 0; i < count; i++)
            {
                if (issues[i].Category.ToLower().Contains(category.ToLower()))
                {
                    temp[tempCount] = issues[i];
                    tempCount++;
                }
            }

            // Return exact size array
            Issue[] result = new Issue[tempCount];
            for (int i = 0; i < tempCount; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        public Issue[] FindByLocation(string location)
        {
            Issue[] temp = new Issue[count];
            int tempCount = 0;

            for (int i = 0; i < count; i++)
            {
                string fullAddress = issues[i].GetFullAddress().ToLower();
                if (fullAddress.Contains(location.ToLower()))
                {
                    temp[tempCount] = issues[i];
                    tempCount++;
                }
            }

            Issue[] result = new Issue[tempCount];
            for (int i = 0; i < tempCount; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        private void ResizeArray()
        {
            capacity *= 2;
            Issue[] newArray = new Issue[capacity];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = issues[i];
            }

            issues = newArray;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                issues[i] = null;
            }
            count = 0;
        }
    }
}
