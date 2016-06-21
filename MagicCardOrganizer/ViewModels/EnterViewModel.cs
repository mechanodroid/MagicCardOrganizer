using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicCardOrganizer.Models;

namespace MagicCardOrganizer.ViewModels
{
    class EnterViewModel
    {
        private Card cardObj = new Card("");
        public string CardName
        {
            get { return cardObj.Name; }
            set { cardObj.Name = value; }
        }


    }
}
