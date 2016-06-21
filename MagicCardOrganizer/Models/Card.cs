using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;


namespace MagicCardOrganizer.Models
{
    class Card
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String power;
        public String Power
        {
            get { return power; }
            set { power = value; }
        }
        private String defense;
        public String Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        private String special;
        public String Special
        {
            get { return special; }
            set { special = value; }
        }
        public Card(String init)
        {
            name = init;
        }
        BitmapImage image;
        public BitmapImage Image
        {
            get { return image; }
            set
            {
                image = value;
            }
        }
    }
}
