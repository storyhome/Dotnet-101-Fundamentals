using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Badge_Challenge
{
    class BadgeRepository

      {
        Badge _badge = new Badge();
       
        public Dictionary<int,List<string>> _badgeDictionary = new Dictionary<int,List<string>>();      

        
        public Dictionary<int,List<string>>GetAllBadges()
        {
            return _badgeDictionary;
        }


        public void AddBadge(Badge badge)
        {
            _badgeDictionary.Add(badge.BadgeId, badge.DoorName);
        }

        public void UpdateBadge(Badge badge)
        {
            _badgeDictionary[badge.BadgeId] = badge.DoorName;
        }


    }
}
