using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class BadgeRepository
    {
        Badge badge = new Badge();
        private List<string> _Doors = new List<string>();
        Dictionary<int, List<string>> _theDictionary = new Dictionary<int, List<string>>();

        public void _AddBadgetoDictionary()
        {
            _theDictionary.Add(badge.Id, badge.Doors);
        }
        public void AddDoortoList(Badge doors)
        {
            _Doors.Add();
        }
        
           
    }
}