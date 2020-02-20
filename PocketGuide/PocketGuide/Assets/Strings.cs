using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace PocketGuide
{
    public static class Strings
    {
        /*******************************************************************/
        // GLOBAL STRINGS
        /*******************************************************************/
        public static string courseTitle = "WHMIS";


        /*******************************************************************/
        // Image links
        /*******************************************************************/
        public static string LogoYowPath = "PocketGuide.Assets.Images.1-YOW_WEB.png";
        public static string LogoYowPath_W = "PocketGuide.Assets.Images.1-YOW_Print_Text_white.png";
        public static string LogoYowSmallPath = "PocketGuide.Assets.Images.1-YOW_WEB.png";
        //public static string LogoYowSmallPath_W = "PocketGuide.Assets.Images.logo_yow_small_white.png";



        //icons
        //https://dev.materialdesignicons.com/getting-started/xamarin
        //https://cdn.materialdesignicons.com/4.7.95/
        //<!--Example: FONTFAMILY MUST BE SET-->
        //   <!--<Button Text = "&#xf844;"
        //      TextColor="Green"
        //      BackgroundColor="Transparent"
        //      FontFamily="{StaticResource IconFont}"
        //      FontSize="Medium" />-->
        public static string IconSearch = "&#xF349;";
        public static string IconCancle = "&#xF739;";
        public static string IconHome = "&#xF2DC;";
        public static string IconPlus = "&#xF415;";
        public static string IconPlusBox = "&#xF703;";
        public static string IconNotePlus = "&#xFEC8;";
        public static string IconMinus = "&#xF374;";
        public static string IconMinusBox = "&#xF6F1;";
        public static string IconBookmark = "&#xF0C3;";
        public static string IconBookmarkAdd = "&#xF0C4;";
        public static string IconBookmarkOff = "&#xF9CE;";
        public static string IconArrowLeft = "&#xF04D;";
        public static string IconArrowRight = "&#xF054;";
        public static string IconInfo = "&#xF64E;";
        //public static object IconFont = Application.Current.Resources["IconFont"];

        /*******************************************************************/
        //Image WHMIS
        //Pictograms
        public static string ImgWhmisPicCorrosive = "PocketGuide.Assets.Images.WHMIS.corrosive.png";
        public static string ImgWhmisPicEnviroToxic = "PocketGuide.Assets.Images.WHMIS.enviro_toxic.png";
        public static string ImgWhmisPicExclamation= "PocketGuide.Assets.Images.WHMIS.exclamation.png";
        public static string ImgWhmisPicExplosive= "PocketGuide.Assets.Images.WHMIS.explosion.png";
        public static string ImgWhmisPicFire= "PocketGuide.Assets.Images.WHMIS.fire.png";
        public static string ImgWhmisPicGas= "PocketGuide.Assets.Images.WHMIS.gas.png";
        public static string ImgWhmisPicHealth= "PocketGuide.Assets.Images.WHMIS.health.png";
        public static string ImgWhmisPicOxflame= "PocketGuide.Assets.Images.WHMIS.oxflame.png";
        public static string ImgWhmisPicSkull= "PocketGuide.Assets.Images.WHMIS.skull.png";
        public static string ImgWhmisPicBio= "PocketGuide.Assets.Images.WHMIS.biohazard.png";

        //Pictograms Old
        public static string ImgWhmisPicClassA = "PocketGuide.Assets.Images.WHMIS.classA.png";
        public static string ImgWhmisPicClassB = "PocketGuide.Assets.Images.WHMIS.classB.png";
        public static string ImgWhmisPicClassC = "PocketGuide.Assets.Images.WHMIS.classC.png";
        public static string ImgWhmisPicClassD1 = "PocketGuide.Assets.Images.WHMIS.classD1.png";
        public static string ImgWhmisPicClassD2 = "PocketGuide.Assets.Images.WHMIS.classD2.png";
        public static string ImgWhmisPicClassD3 = "PocketGuide.Assets.Images.WHMIS.classD3.png";
        public static string ImgWhmisPicClassE = "PocketGuide.Assets.Images.WHMIS.classE.png";
        public static string ImgWhmisPicClassF = "PocketGuide.Assets.Images.WHMIS.classF.png";

        //PTE
        public static string ImgWhmisPPEApron = "PocketGuide.Assets.Images.WHMIS.apron.png";
        public static string ImgWhmisPPEBody = "PocketGuide.Assets.Images.WHMIS.bodysuit.png";
        public static string ImgWhmisPPEBoots = "PocketGuide.Assets.Images.WHMIS.boots.png";
        public static string ImgWhmisPPECartidge = "PocketGuide.Assets.Images.WHMIS.cartridge-respirator.png";
        public static string ImgWhmisPPEDust = "PocketGuide.Assets.Images.WHMIS.dust-mask.png";
        public static string ImgWhmisPPEFace = "PocketGuide.Assets.Images.WHMIS.face-shield.png";
        public static string ImgWhmisPPEFull = "PocketGuide.Assets.Images.WHMIS.full-face-mask.png";
        public static string ImgWhmisPPEGloves = "PocketGuide.Assets.Images.WHMIS.gloves.png";
        public static string ImgWhmisPPEGoggles = "PocketGuide.Assets.Images.WHMIS.goggles.png";
        public static string ImgWhmisPPESupplied = "PocketGuide.Assets.Images.WHMIS.supplied-air-respirator.png";

        //Lables
        public static string ImgWhmisSupplierLable = "PocketGuide.Assets.Images.WHMIS.Supplier-Label2017.png";
        public static string ImgWhmisWorplaceLable = "PocketGuide.Assets.Images.WHMIS.workplace-lable.png";
        public static string ImgSimdutWorplaceLable = "PocketGuide.Assets.Images.WHMIS.workplace-lable_FRENCH.png";

        //PG Images
        public static string ImgWhmisPicLadyLaw = "PocketGuide.Assets.Images.WHMIS.imgLadyLiberty.jpg";
        public static string ImgWhmisPicBarle = "PocketGuide.Assets.Images.WHMIS.imgBarle.jpg";
        public static string ImgWhmisPicExemptions = "PocketGuide.Assets.Images.WHMIS.imgExemptions.jpg";
        public static string ImgWhmisPicExemptions2 = "PocketGuide.Assets.Images.WHMIS.imgExemptions2.jpg";
        public static string ImgWhmisPicConsumer = "PocketGuide.Assets.Images.WHMIS.imgConsumer.jpg";



        /*******************************************************************/
        //Image PDFs / Files
        public static string ImgWhmisHTMLSDS = "PocketGuide.Assets.Images.WHMIS.speedy_sds.html";
        public static string ImgSimdutHTMLFDS = "PocketGuide.Assets.Images.WHMIS.speedy_fds.html";


        /*******************************************************************/
        //Colours   http://www.yowcanada.com/css/YOW-COLOUR%20TABLE.html
        /*******************************************************************/
        public static string ColYowBlue = "#003D79";
        public static string ColYowLBlue = "#D2E0FF";
        public static string ColYowMBlue = "#AEC7FF";
        public static string ColYowM2Blue = "#31639C";

        public static string ColYowGrey = "#CDCDCD";
        public static string ColYowLGrey = "#EEEEEE";
        public static string ColYowDarkGrey = "#535353";
        
        public static string ColYowOrange = "#FF8208";

        public static string ColYowLink = "#019DCE";

        
    }
}
