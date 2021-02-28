using System;
using System.Collections.Generic;

using System.IO;

using Newtonsoft.Json;

public class CFG
{
    public static Setting set = new Setting();

    public class Setting
    {
        [JsonProperty("Труп")]
        public static bool corpse;
        [JsonProperty("Игроки")]
        public static bool players;
        [JsonProperty("adm")]
        public static bool adm;
        [JsonProperty("sdd")]
        public static float sdd = 500;
        [JsonProperty("dgdg")]
        public static bool dgdg;
        [JsonProperty("ssdd")]
        public static bool ssdd;
        [JsonProperty("dfdf")]
        public static bool dfdf;
        [JsonProperty("fdf")]
        public static bool fdf;
        [JsonProperty("gggf")]
        public static bool gggf;
        [JsonProperty("vbvc")]
        public static bool vbvc;
        [JsonProperty("dgdgd")]
        public static bool dgdgd;
        [JsonProperty("bb")]
        public static bool bb;
        [JsonProperty("dsfsf")]
        public static bool dsfsf;
        [JsonProperty("greg")]
        public static bool greg;
        [JsonProperty("q")]
        public static bool q;
        [JsonProperty("w")]
        public static bool w;
        [JsonProperty("e")]
        public static bool e;
        [JsonProperty("1")]
        public static bool r = false;
        [JsonProperty("2")]
        public static bool t = false;
        [JsonProperty("3")]
        public static bool y = false;
        [JsonProperty("4")]
        public static bool u = false;
        [JsonProperty("5")]
        public static bool i = false;
        [JsonProperty("6")]
        public static bool o = false;
        [JsonProperty("7")]
        public static bool p = false;
        [JsonProperty("8")]
        public static bool a = false;
        [JsonProperty("9")]
        public static bool s = false;
        [JsonProperty("0")]
        public static bool d = false;
        [JsonProperty("cx")]
        public static bool f = false;
        [JsonProperty("zx")]
        public static bool g = false;
        [JsonProperty("zxczc")]
        public static bool fdgdg = false;
        [JsonProperty("zczc")]
        public static bool ytytf = false;
        [JsonProperty("dfs")]
        public static bool vbcbc = false;
        [JsonProperty("xvxv")]
        public static bool iiii = false;
        [JsonProperty("sfa")]
        public static bool rtfgd = false;
        [JsonProperty("asdaf")]
        public static bool cvdfg = false;
        [JsonProperty("dfsdfgr")]
        public static bool ytcbcv = false;
        [JsonProperty("geger")]
        public static bool fdgvcbd = false;
        [JsonProperty("fdggvb")]
        public static bool bvcbfdge = false;
        [JsonProperty("bvcth")]
        public static bool gfgrttt = false;
        [JsonProperty("fdgdht")]
        public static bool rererrr = false;
        [JsonProperty("vbcbdss")]
        public static bool bvbcfd = false;
        [JsonProperty("sfrey3fgd")]
        public static bool fgfddd = false;
        [JsonProperty("dgdg334")]
        public static List<string> friendlyList;


        [JsonProperty("8rtg")]
        public static bool aimm = false;
        [JsonProperty("dgjty54")]
        public static bool silentmelee = false;
        [JsonProperty("3tgrhbe3")]
        public static bool meleewalls = false;
        [JsonProperty("bbr45fg")]
        public static bool silentmeleeanimals = false;
        [JsonProperty("gfe433")]
        public static bool killafterdead = false;
        [JsonProperty("gfdg45hf")]
        public static bool killscientist = false;
        [JsonProperty("dfh4545")]
        public static bool ssddd = false;
        [JsonProperty("65uikktf")]
        public static bool bbbb = false;
        [JsonProperty("fg54tr3")]
        public static bool cbvcbcd = false;
        [JsonProperty("dg4345fhhd")]
        public static bool fdsfdsfew = false;
        [JsonProperty("dh45hfh3")]
        public static bool uytgff = false;
        [JsonProperty("dgj54hgf34")]
        public static bool dfregcx = false;
        [JsonProperty("dgf54fh343")]
        public static bool dfertwdf = false;
        [JsonProperty("gdg33222")]
        public static bool qewqefdsf = false;
        [JsonProperty("dfgf34453")]
        public static bool dgvcbb = false;
        [JsonProperty("fhh45y5yy")]
        public static bool yyttff = false;
        [JsonProperty("hg65743")]
        public static bool slow = false;
        [JsonProperty("ghfh6854")]
        public static bool fast = false;
        [JsonProperty("h444ggggd")]
        public static bool gggg = false;
        [JsonProperty("456gf45hg")]
        public static bool dffs = false;
        [JsonProperty("gf654454")]
        public static bool cvvcv = false;
        [JsonProperty("hfg5445")]
        public static bool cdddeee = false;
        [JsonProperty("hf456yj76o8")]
        public static bool sfwewwww = false;
        [JsonProperty("jtjt7865")]
        public static bool dfdswe = false;
        [JsonProperty("ghyuk85")]
        public static bool FOV = false;
        [JsonProperty("56ghj67i")]
        public static bool FOV11 = false;
        [JsonProperty("jtyt7656")]
        public static bool BulletDropPrediction = false;
        [JsonProperty("gjyu7655")]
        public static bool FOV1 = false;
        [JsonProperty("ghjjghj778675")]
        public static bool crrr = false;
        [JsonProperty("ghj45yt45")]
        public static bool vcgrrrr = false;
        [JsonProperty("fghkuiluo;l")]
        public static bool sdfewewdff = false;
        [JsonProperty("tkjhgfdguy564")]
        public static bool bgdgdfff = false;
        [JsonProperty("45ukjh4678")]
        public static bool bbccvvdd = false;
        [JsonProperty("ghghjghj86756")]
        public static bool hhhh = false;
        [JsonProperty("ghj765654eghf")]
        public static bool uuyyttrrr = false;
        [JsonProperty("fgh765654tgfgjj")]
        public static bool radarrrrr = false;
        [JsonProperty("jhgjghjrty4564")]
        public static bool radar = false;
        [JsonProperty("456gjghfh54")]
        public static bool sdfdddddff = false;
        [JsonProperty("fghfh445323ghf")]
        public static bool radarmetal = false;
        [JsonProperty("fhfg33333fhghfh")]
        public static bool radarsulfur = false;
        [JsonProperty("hfgh,ilyut5643")]
        public static bool radarnpc = false;
        [JsonProperty("dfge3456u543")]
        public static bool radarstone = false;
        [JsonProperty("dgf3454323")]
        public static bool authh = false;
        [JsonProperty("gbnhjklo;[")]
        public static bool authlist = false;
        [JsonProperty("fgwfghjukil")]
        public static bool tt = false;
        [JsonProperty("gfnm,m nb")]
        public static bool adsafsddvcvc = false;
        [JsonProperty("hf098765tg")]
        public static bool oiuytgbmnb = false;
        [JsonProperty("swe435utjhg")]
        public static bool vbfgcvvcv = false;
        [JsonProperty("w435ytrhgfe")]
        public static bool ggdfggg = false;
        [JsonProperty("w234yhgbdfsg")]
        public static bool ouioiu = false;
        [JsonProperty("w245tyhfdgsh")]
        public static bool ylylyy = false;
        [JsonProperty("dgryt564y3ter")]
        public static bool ynhoock = false;
        [JsonProperty("dghty564y3tergr")]
        public static bool hookd = false;
        [JsonProperty("dfhgw435ytrhgf")]
        public static bool png = false;
        [JsonProperty("dgfhgjtu54y3dfe3")]
        public static bool spinnn = false;
        [JsonProperty("dgfhgjtu54y3dfsfffe3")]
        public static bool spin = false;
        [JsonProperty("dghrt54y32trgfddfg")]
        public static bool ayfff = false;
        [JsonProperty("dg43gfdg23tgdf")]
        public static bool cahh = false;
        [JsonProperty("gdf23yu6y3434")]
        public static bool hyk = false;
        [JsonProperty("dggdfg23534gdgd")]
        public static bool walkon = false;
        [JsonProperty("dghg434trfd244")]
        public static bool winrar = false;
        [JsonProperty("dfge23435rgfd43t")]
        public static bool rrrar = false;
        [JsonProperty("fdrey43y54534gfgd")]
        public static bool milll = false;
        [JsonProperty("dfgdfgdfg435678909876")]
        public static bool ahahahha = false;
        [JsonProperty("fdhi9876545665dgdf")]
        public static bool cccvvbbbffdd = false;
        [JsonProperty("gdget435gfdg2322gfd")]
        public static bool bbbvvvccc = false;
        [JsonProperty("dfgjtr534dgfert")]
        public static bool adsfdgrege = false;
        [JsonProperty("dfg435453df43545")]
        public static bool bbbbvvv = false;
        [JsonProperty("gdfbvgget534535")]
        public static bool fsass = false;
        [JsonProperty("456u78654gfdgfhgf")]
        public static bool ffffffffs = false;
        [JsonProperty("dgdhtye435dfgwwwgfdg")]
        public static bool nbvcv = false;
        [JsonProperty("dghe453453ef23rrsf2")]
        public static bool hghtrhf = false;
        [JsonProperty("sdggj45y3rwf2334")]
        public static bool podgs = false;
        [JsonProperty("dfgy676543rgdg")]
        public static bool HGHGH = false;
        [JsonProperty("dgvbrthy543345gfdgd")]
        public static bool ASDADAD = false;
        [JsonProperty("dgjtr543fg34er")]
        public static bool AASDD = false;
        [JsonProperty("dbvvert4354dg")]
        public static bool NAXYI = false;
        [JsonProperty("dggfhtry53df34")]
        public static bool ZAEB = false;
        [JsonProperty("dfg534gf345")]
        public static bool ZALYPA = false;
        [JsonProperty("dgf345tdg34t")]
        public static bool blats = false;
        [JsonProperty("dg234ui655gfduyr")]
        public static bool fdffddd = false;
        [JsonProperty("wrr345tgd34tdfgdf")]
        public static bool adadadaa = false;
        [JsonProperty("dfgbnrheh5443fgre")]
        public static bool asawersffd = false;
        [JsonProperty("34tyhgfgfbvcegjf")]
        public static bool offd = false;
        [JsonProperty("3453gf34t5dg")]
        public static bool eeeeeeeee = false;
        [JsonProperty("dg345ytrgf23rtfd")]
        public static bool ff = false;
        [JsonProperty("2345tdg34tdg")]
        public static bool mnmhmnb = false;
        [JsonProperty("gdfet34tdfg345gfdg")]
        public static bool asarwad = false;
        [JsonProperty("dgvbhtrydfg34")]
        public static bool nbnhg = false;
        [JsonProperty("ewrtyuiouytgf34434")]
        public static bool vcgdcv = false;
        [JsonProperty("sdgfhyukjer43643w")]
        public static bool iopiop = false;
        [JsonProperty("gf43trgf34tfg")]
        public static bool ooppoo = false;
        [JsonProperty("fdgmnvbcx/.,mn")]
        public static bool mnbvc = false;
        [JsonProperty("dfgyy345dfg")]
        public static bool adfsaa = false;
        [JsonProperty("dfg345ytrtef34")]
        public static bool adsfbc = false;
        [JsonProperty("dg45tfdg345gf")]
        public static bool yyttrrfff = false;
        [JsonProperty("356i5646gdfjаfhdg")]
        public static bool mmnb = false;
        [JsonProperty("dgj5463gfvbаfgfgfgf")]
        public static bool bvbvn = false;
        [JsonProperty("gfddggаddg")]
        public static bool df = false;
        [JsonProperty("dgdggddgаdg")]
        public static bool hgf = false;
        [JsonProperty("dgdggа098а7ddgdg")]
        public static bool frre = false;
        [JsonProperty("gdgdgdgdgаdg")]
        public static bool wertyu = false;

        [JsonProperty("gdgdgd1111111gаdgdg")]
        public static bool mbnbnm = false;
        [JsonProperty("gdgdgdgdg5678987654а5678765dg")]
        public static HashSet<ulong> friendsList;




        [JsonProperty("gdgdgr234eedgаdgdg")]
        public static bool mili = false;
        [JsonProperty("gdgd32r343gdgаdgdg")]
        public static bool heli = false;
        [JsonProperty("gdgd2r3234gdgdаgdg")]
        public static float fov1;
        [JsonProperty("gdgdger234erdgdаgdg")]
        public static bool hp = false;
        [JsonProperty("gdgdgd2345eeаgdgdg")]
        public static bool Cloth = false;
        [JsonProperty("gdgdgdg234ew2dаgdg")]
        public static bool hot = false;
        [JsonProperty("gdgd234et23gdgdgаdg")]
        public static bool boneESP = false;
        [JsonProperty("gdg234et23dgdgdgаdg")]
        public static bool ggg = false;
        [JsonProperty("gdgdg234dt32dgdgаdg")]
        public static bool gggggg = false;
        [JsonProperty("gdgdg23et23dgdgаdg")]
        public static bool grass = false;
        [JsonProperty("gdgdg23r345retdgdgаdg")]
        public static bool asdas = false;
        [JsonProperty("gdgdgd234et234gdgаdg")]
        public static bool head = false;
        [JsonProperty("gdgdgdwet435etewgаdgdg")]
        public static bool bvbgfg = false;
        [JsonProperty("gdgdgd2342wertgdgаdg")]
        public static bool grr = false;
        [JsonProperty("gdgdgd232rerwtgdgаdg")]
        public static float fov;



        [JsonProperty("left")]
        public static float left = 20f;

        [JsonProperty("up")]
        public static float up = 40;

        [JsonProperty("size")]
        public static float size = 240;

        [JsonProperty("dist")]
        public static float dist = 350f;


        [JsonProperty("gdgdg2r2wer23dgdgаdg")]
        public static bool test3 = false;
        [JsonProperty("gdgd234ewrt23gdgdаgdg")]
        public static bool свет = false;
        [JsonProperty("gdgdg45435345redgdаgdg")]
        public static bool traf = false;
        [JsonProperty("gdgdget23523424dgdgаdg")]
        public static bool nnn = false;
        [JsonProperty("gdgdgdet324243242gаdgdg")]
        public static bool test41 = false;
        [JsonProperty("gdgdgd23424etttegdаgdg")]
        public static bool test411 = false;
        [JsonProperty("gdgdgdtetet342gdgdаg")]
        public static bool nnnn = false;
        [JsonProperty("gdgdgdet32424sa3242gаdgdg")]
        public static bool tree = false;
        [JsonProperty("gdgdgd23424etsfaftteаgdgdg")]
        public static bool animal = false;
        [JsonProperty("gdgdgdtetetasfaf342gdаgdg")]
        public static bool xyi = false;
        [JsonProperty("traps")]
        public static float traps = 300f;
        [JsonProperty("guntrap")]
        public static bool guntrap = false;
        [JsonProperty("Flame")]
        public static bool Flame = false;
        [JsonProperty("rtgfcxccc")]
        public static bool bag = false;
        [JsonProperty("gdgd32r343cger34gаdgdgdg")]
        public static bool h = false;
        [JsonProperty("gdgd2r3234gfgdgeаdgdgdg")]
        public static bool bbf;
        [JsonProperty("giva")]
        public static bool giva;
        [JsonProperty("trraaa")]
        public static bool traa = false;
        [JsonProperty("gdgdger234e3ggfdrdgаdgdg")]
        public static bool test4 = false;
        [JsonProperty("gdgdgd2345edg3rgredfаegdgdg")]
        public static bool turr = false;
        [JsonProperty("gdgdgdg234egdfer3w2dаgdg")]
        public static bool vvvv = false;
        [JsonProperty("gdgd234et23dge343ttgаdgdgdg")]
        public static float WorldEspDistance = 300f;
        [JsonProperty("gdg234et23dge43dgdgdgаdgdg")]
        public static float range = 400f;
        [JsonProperty("gdgdg234dt32ge43resdаdgdgdg")]
        public static bool sleep = false;
        [JsonProperty("gdgdg23et23we23sdfdgаgdg")]
        public static int fgghhhh;
        [JsonProperty("gdgdg23r345r234dfsg3etdgаdgdg")]
        public static bool gf = false;
        [JsonProperty("gdgdgd234et2sdfg345ydf34аgdgdg")]
        public static bool govno2 = false;
        [JsonProperty("gdgdgd2342werfg65uhgftаgdgdg")]
        public static int fdfd;
        [JsonProperty("gdgdgd232re987yhrwtgdgаdg")]
        public static float sped;
        [JsonProperty("gdgdg2r2wer23dgr56tgdgаdg")]
        public static bool time = false;
        [JsonProperty("gdgd234ewrt23gdggfghytr4а5dgdg")]
        public static bool spoof;
        [JsonProperty("gdgdg454353435trgdfg5redаgdgdg")]
        public static string faked = "[Nick]";
        [JsonProperty("gdgdget2352dfghrt5y43424аdgdgdg")]
        public static bool test2 = false;
        [JsonProperty("gdgdgdet324234t2243242gаdgdg")]
        public static bool spam = false;
        [JsonProperty("gdgdgd23424e234345ttteаgdgdg")]
        public static bool mmmm = false;
        [JsonProperty("gdgdgdtetet342ertetdfаggdgdg")]
        public static bool hhhfg = false;
        [JsonProperty("gdgdgdtetet342ertetdfаfdffggdgdg")]
        public static bool color = false;
        [JsonProperty("gdgdgdgdgd23424etsdgdаgfafttegdgdg")]
        public static float speedhackspeed = 6;
        [JsonProperty("gdgdgdtetetasfaf3dgdаg42gdgdg")]
        public static float player1 = 200;
        [JsonProperty("stag")]
        public static bool stag = false;




        [JsonProperty("horse")]
        public static bool horse = false;

        [JsonProperty("boar")]
        public static bool boar = false;
        [JsonProperty("bear")]
        public static bool bear = false;
        [JsonProperty("chicken")]
        public static bool chicken = false;
        [JsonProperty("cross")]
        public static bool cross = false;
        [JsonProperty("grass12")]
        public static bool grass12 = false;
        [JsonProperty("sleeps")]
        public static bool sleeps = false;
        [JsonProperty("flyhack")]
        public static bool flyhack = false;
        [JsonProperty("skin")]
        public static bool skin = true;
        [JsonProperty("wolf")]
        public static bool wolf = false;
        [JsonProperty("teleport")]
        public static bool teleport = false;
        [JsonProperty("breed")]
        public static bool breed = false;
        [JsonProperty("debug")]
        public static bool debug = false;
        [JsonProperty("gdgdgdtetet342gdgddgаdgdgg")]
        public static float teleportheight = 50;
        [JsonProperty("gdgdgddgdgdet32424saа3dgdggd242gdgdg")]
        public static string string_1 = "4365";
        [JsonProperty("gdgdgddgdgd23424etsfaаfttegdgdg")]
        public static int fgghhh1 = 0;
        [JsonProperty("gdgdgddgdgd23424etsfds3faаfttegdgdg")]
        public static int fgghhh = 6;
        [JsonProperty("растояние говна")]
        public static float distt = 300f;
        [JsonProperty("растояние говdadа")]
        public static float vov = 70f;
        [JsonProperty("растояние dddebug")]
        public static float debugg = 1f;
        [JsonProperty("gdgdgdtetdgdgdgdgetasаfraf342gdgdg")]
        public static string string_0;

        [JsonProperty("gdgdgddgdgasassd234а24etesfafttegdgdg")]
        public static float dfd = 6;
        [JsonProperty("gdgdgdtetet342gdgddаgdgdrgdgg")]
        public static string string_11 = "Тут спам текст спама";
        [JsonProperty("gdgdgdet3dgdg2424saа324dgdgdggd2gdgrdg")]
        public static float spamm = 3;
        [JsonProperty("gdgdgdet3dgdg2424saа1324dgdgdggd2gdgrdg")]
        public static float skele = 1.5f;
    }

    private static readonly string path = Environment.CurrentDirectory + "\\Bundles\\items\\" + "xmasdoorwreath.window.png";

    public static void LoadSettings()
    {
        if (File.Exists(path))
        {
            set = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(path));

        }
    }

    public static void SaveSettings()
    {
        string pathDir = Environment.CurrentDirectory + "\\Bundles\\items\\";
        if (!Directory.Exists(pathDir))
        {
            Directory.CreateDirectory(pathDir);
        }

        File.WriteAllText(path, JsonConvert.SerializeObject(set, Formatting.Indented));
    }





}

