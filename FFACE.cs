using EliteMMO.API;
using FFACETools;
using System.Drawing;

namespace CampahApp
{
    public class FFACE
    {
        public FFACE(int id)
        {
            var eliteApi = new EliteAPI(id);
            Chat = new ChatTools(eliteApi);
            Item = new ItemTools(eliteApi);
            Menu = new MenuTools(eliteApi);
            NPC = new NPCTools(eliteApi);
            Player = new PlayerTools(eliteApi);
            Target = new TargetTools(eliteApi);
            Windower = new WindowerTools(eliteApi);
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
            private readonly EliteAPI _eliteApi;

            public ChatTools(EliteAPI eliteApi)
            {
                _eliteApi = eliteApi;
            }

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
            private readonly EliteAPI _eliteApi;

            public MenuTools(EliteAPI eliteApi)
            {
                _eliteApi = eliteApi;
            }

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
            private readonly EliteAPI _eliteApi;

            public WindowerTools(EliteAPI eliteApi)
            {
                _eliteApi = eliteApi;
            }

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
        private readonly EliteAPI _eliteApi;

        public ItemTools(EliteAPI eliteApi)
        {
            _eliteApi = eliteApi;
        }

        public int InventoryCount { get; set; }
        public int InventoryMax { get; set; }

        public void GetInventoryItemCount(ushort id)
        {
            throw new System.NotImplementedException();
        }
    }

    public class NPCTools
    {
        private readonly EliteAPI _eliteApi;

        public NPCTools(EliteAPI eliteApi)
        {
            _eliteApi = eliteApi;
        }

        public double Distance(short id)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PlayerTools
    {
        private readonly EliteAPI _eliteApi;

        public PlayerTools(EliteAPI eliteApi)
        {
            _eliteApi = eliteApi;
        }

        public int GetSID { get; set; }
    }

    public class TargetTools
    {
        private readonly EliteAPI _eliteApi;

        public TargetTools(EliteAPI eliteApi)
        {
            _eliteApi = eliteApi;
        }

        public short ID { get; set; }
        public string Name { get; set; }
    }
}