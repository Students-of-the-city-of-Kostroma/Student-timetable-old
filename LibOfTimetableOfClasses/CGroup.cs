using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class CGroup
    {
        List<MGroup> grouplist = new List<MGroup>();

        /// <summary>
        /// Добавляет группу в grouplist
        /// </summary>
        /// <param name="group">Добавляемая группа</param>
        /// <returns>true => если группа успешно добавлена, false => если добавляемая группа уже существует</returns>
        public bool Add(MGroup group)
        {
            int count = 0;

            foreach(MGroup m in grouplist)
            {
                count++;
                if (m.Id == group.Id)
                    break;
            }

            if (count == grouplist.Count)
            {
                grouplist.Add(group);
                return true;
            }
            else
                return false;
        }
    }
}
