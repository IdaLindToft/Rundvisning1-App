//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Rundvisning_App.Model
//{
//    public class UdstillingsKatalog
//    {
//        private Dictionary<int, Udstilling> _katalog;
//        private static UdstillingsKatalog _instance;




//        private UdstillingsKatalog()
//        {
//            Udstilling u1 = new Udstilling("Fankultur", "beskrivelse");
//            Udstilling u2 = new Udstilling("Jazz Kultur", "beskrivelse");
//            Udstilling u3 = new Udstilling("Pop Kultur", "beskrivelse");
//            Udstilling u4 = new Udstilling("HipHop Kultur", "beskrivelse");
//            Udstilling u5 = new Udstilling("Rock Kultur", "beskrivelse");
//            Udstilling u6 = new Udstilling("Ungdom & Dans", "beskrivelse");


//            _katalog.Add(u1.Id, u1);
//            _katalog.Add(u2.Id, u2);
//            _katalog.Add(u3.Id, u3);
//            _katalog.Add(u4.Id, u4);
//            _katalog.Add(u5.Id, u5);
//            _katalog.Add(u6.Id, u6);




//        }

//        public static UdstillingsKatalog Instance
//        {
//            get {
//                if (_instance == null) _instance = new UdstillingsKatalog();
//                return _instance;
//            }
//        }
//    }

	
//}
