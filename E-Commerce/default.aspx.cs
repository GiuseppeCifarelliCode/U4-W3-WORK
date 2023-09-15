using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class _default : System.Web.UI.Page
    {
        public static List<Prodotto> Prodotti = new List<Prodotto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Prodotti.Clear();
            if (!IsPostBack)
            {
                Prodotto prodotto1 = new Prodotto(1, "CTR", "CTR è un videogioco di guida sviluppato da Naughty Dog nel 1999",
                               "CTR è un videogioco di guida sviluppato da Naughty Dog nel 1999 tratto dalla serie di videogiochi a piattaforme Crash Bandicoot. Questo è l'ultimo gioco di Crash Bandicoot prodotto da Naughty Dog, prima del passaggio da Universal Interactive Studios a Sony Computer Entertainment.",
                               80, "./Content/assets/crash.png");
                Prodotto prodotto2 = new Prodotto(2, "Crash Bash", "Crash Bash è un videogioco in stile party game",
                   "Crash Bash è un videogioco in stile party game della serie di Crash Bandicoot, prodotto da Eurocom e distribuito nel 2000. È l'ultimo gioco della serie per la prima PlayStation e il primo a non essere sviluppato da Naughty Dog.", 100, "./Content/assets/crashbash.jpg");
                Prodotto prodotto3 = new Prodotto(3, "Hercules", "Hercules è un videogioco a piattaforme per PC e PlayStation",
                    "Hercules  è un videogioco a piattaforme per PC e PlayStation sviluppato dalla Eurocom e pubblicato nel 1997 da Disney Interactive Studios.", 65, "./Content/assets/hercules.jpg");
                Prodotto prodotto4 = new Prodotto(4, "Lone Soldier", "Lone Soldier Lone Soldier is an action-adventure/shooter video game developed by British studio Tempest Software for the PlayStation.", "Lone Soldier is an action-adventure/shooter video game developed by British studio Tempest Software for the PlayStation. The game was released in January 1996 in Europe and on 4 October 1996 in Japan.", 5, "./Content/assets/lonesoldier.jpg");
                Prodotto prodotto5 = new Prodotto(5, "Rayman", "Rayman è un videogioco a piattaforme pubblicato da Ubisoft nel 1995", "Rayman è un videogioco a piattaforme pubblicato da Ubisoft nel 1995 per Atari Jaguar, PlayStation, Sega Saturn, MS-DOS e Game Boy Color. Inizialmente erano previste anche delle versioni per 3DO Interactive Multiplayer, Sega 32X, e Super Nintendo Entertainment System, ma vennero cancellate.", 50, "./Content/assets/rayman.jpg");
                Prodotto prodotto6 = new Prodotto(6, "SoulBlade", "SoulBlade è un videogioco picchiaduro in tre dimensioni uscito nel 1995.", "SoulBlade è un videogioco picchiaduro in tre dimensioni uscito nel 1995. È il primo capitolo della serie Soulcalibur. Realizzato dagli stessi creatori di Tekken, Namco.", 40, "./Content/assets/soulblade.jpg");
                Prodotti.Add(prodotto1);
                Prodotti.Add(prodotto2);
                Prodotti.Add(prodotto3);
                Prodotti.Add(prodotto4);
                Prodotti.Add(prodotto5);
                Prodotti.Add(prodotto6);

                Repeater1.DataSource = Prodotti;
                Repeater1.DataBind();
            }
        }
    }
}