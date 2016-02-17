using FFACETools;
using System.Drawing;

namespace CampahApp
{
    public class FFACE
    {
        private readonly int id;

        public FFACE(int id)
        {
            this.id = id;
        }

        public ChatTools Chat { get; set; }
        public ItemTools Item { get; set; }
        public MenuTools Menu { get; set; }
        public NPCTools NPC { get; set; }
        public PlayerTools Player { get; set; }
        public TargetTools Target { get; set; }
        public WindowerTools Windower { get; set; }

        public class ChatTools
        {
            public ChatLine GetNextLine()
            {
                throw new System.NotImplementedException();
            }

            public class ChatLine
            {
                public Color Color { get; set; }
                public string Now { get; set; }
                public string RawString { get; set; }
                public string Text { get; set; }
                public ChatMode Type { get; set; }
            }
        }

        public class MenuTools
        {
            public bool IsOpen { get; set; }
            public int MenuIndex { get; set; }
            public string Selection { get; set; }
        }

        public class ParseResources
        {
            public static object LanguagePreference { get; set; }
            public static bool UseFFXIDatFiles { get; set; }

            public class Languages
            {
                public static object English { get; set; }
            }
        }

        public class WindowerTools
        {
            public void SendKeyPress(KeyCode escapeKey)
            {
                throw new System.NotImplementedException();
            }

            public void SendString(string mouseBlockinputOffKeyboardBlockinputOff)
            {
                throw new System.NotImplementedException();
            }
        }
    }

    public class ItemTools
    {
        public int InventoryCount { get; set; }
        public int InventoryMax { get; set; }

        public void GetInventoryItemCount(ushort id)
        {
            throw new System.NotImplementedException();
        }
    }

    public class NPCTools
    {
        public double Distance(short id)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PlayerTools
    {
        public int GetSID { get; set; }
    }

    public class TargetTools
    {
        public short ID { get; set; }
        public string Name { get; set; }
    }
}