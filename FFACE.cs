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
                var message = _eliteApi.Chat.GetNextChatLine();

                var chatLine = new ChatLine
                {
                    Color = message.ChatColor,
                    Now = message.Timestamp.ToShortTimeString(),
                    RawString = message.RawText,
                    Text = message.Text,
                    Type = (ChatMode) message.ChatType
                };

                return chatLine;
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

            public bool IsOpen => _eliteApi.Menu.IsMenuOpen;

            public int MenuIndex
            {
                get { return _eliteApi.Menu.MenuIndex; }
                set { _eliteApi.Menu.MenuIndex = value; }
            }

            public string Selection => _eliteApi.Menu.MenuName;
        }

        public class ParseResources
        {
            public static int LanguagePreference = 1;
            public static bool UseFFXIDatFiles = true;

            public class Languages
            {
                public static int English = 1;
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
                _eliteApi.ThirdParty.KeyPress((byte)escapeKey);
            }

            public void SendString(string message)
            {
                _eliteApi.ThirdParty.SendString(message);
            }
        }
    }

    public class ItemTools
    {
        private const int InventoryId = 0;
        private readonly EliteAPI _eliteApi;

        public ItemTools(EliteAPI eliteApi)
        {
            _eliteApi = eliteApi;
        }

        public int InventoryCount => _eliteApi.Inventory.GetContainerCount(InventoryId);
        public int InventoryMax => _eliteApi.Inventory.GetContainerMaxCount(InventoryId);

        public int GetInventoryItemCount(ushort id)
        {
            return (int)_eliteApi.Inventory.GetContainerItem(InventoryId, id).Count;
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
            return _eliteApi.Entity.GetEntity(id).Distance;
        }
    }

    public class PlayerTools
    {
        private readonly EliteAPI _eliteApi;

        public PlayerTools(EliteAPI eliteApi)
        {
            _eliteApi = eliteApi;
        }

        public int GetSID => _eliteApi.Player.ServerId;
    }

    public class TargetTools
    {
        private readonly EliteAPI _eliteApi;

        public TargetTools(EliteAPI eliteApi)
        {
            _eliteApi = eliteApi;
        }

        public short ID => (short)_eliteApi.Target.GetTargetInfo().TargetId;
        public string Name => _eliteApi.Target.GetTargetInfo().TargetName;
    }
}