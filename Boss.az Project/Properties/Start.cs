using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Boss.az_Project.Properties
{
    class Start
    {
        public Baza_Employer employers { get; set; } = new Baza_Employer();
        public CV_baza employer_CV_BAZA { get; set; } = new CV_baza(); 

        public Employer employer1 { get; set; } = new Employer();
        public CV_baza_Employer cV_Baza_Employer { get; set; } = new CV_baza_Employer();
        public Baza_Mesaj baza_Mesaj { get; set; } = new Baza_Mesaj();
        public Start()
        {
            employers = new Baza_Employer();
            employer_CV_BAZA = new CV_baza();
        }
      
        static int static_value = 0;
        public void UserName_password(Baza_Accounts baza1)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            Console.Write(" Enter Username : ");
            string new_Username = Console.ReadLine();
            Console.Write(" Enter Password : ");
            char mask = '*';
            const int ENTER = 13, BACKSP = 8, CTRLBACKSP = 127;
            int[] FILTERED = { 0, 27, 9, 10 }; 


            SecureString securePass = new SecureString();

            char chr = (char)0;

            while ((chr = System.Console.ReadKey(true).KeyChar) != ENTER)
            {
                if (((chr == BACKSP) || (chr == CTRLBACKSP))
                    && (securePass.Length > 0))
                {
                    System.Console.Write("\b \b");
                    securePass.RemoveAt(securePass.Length - 1);

                }
                else if (((chr == BACKSP) || (chr == CTRLBACKSP)) && (securePass.Length == 0))
                {
                }
                else if (FILTERED.Count(x => chr == x) > 0)
                {
                }
                else
                {
                    securePass.AppendChar(chr);
                    System.Console.Write(mask);
                }
            }

            System.Console.WriteLine();
            IntPtr ptr = new IntPtr();
            ptr = Marshal.SecureStringToBSTR(securePass);
            string plainPass = Marshal.PtrToStringBSTR(ptr);
            Marshal.ZeroFreeBSTR(ptr);

            int count = 0;
            for (int i = 0; i < baza1.Count; i++)
            {
                if (baza1.Acconds[i].Username == new_Username && baza1.Acconds[i].Password == plainPass)
                {
                    static_value = i;
                    Start_method(baza1);
                    break;
                }
                ++count;
                if (count == baza1.Acconds.Count)
                {
                    UserName_password(baza1);
                }
            }
                  
        }
        public void Ready_funk_Employer(Baza_Accounts baza)
        {
                
                employer1.Add_Employer("Akif", "Quliyev", "Baki", "0554322331", 23, 2);
                Share share1 = new Share("Telefon", "cox istifade elenmiyib,teze kimidir, alicilar elaqe saxlasin", " 230 - 250 ", "Tecnology");
                Share share2 = new Share("Kompyurter", "Kohnedir", " 200 - 250 ", "Tecnology");
                Share share3 = new Share("Monitor", "Yenidir", " 200 - 300 ", "Tecnology");
                employer1.Add_share(share1); 
                employer1.Add_share(share2); 
                employer1.Add_share(share3);
            Ready_Informations();
            //employer1.Show();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            foreach (var item in employers.employers)
            {

                Console.WriteLine();
                item.Show_shares();
            }

            Console.WriteLine();
            Console.WriteLine($" Back [ 0 ] ");
            Console.WriteLine();
            Console.Write($" Enter : ");
            bool rasuelt2 = int.TryParse(Console.ReadLine(), out int result2);

            if (result2 == 0)
            {
                for (int i = 0; i < employers.employers.Count; i++)
                {

                    employers.employers[i].ID_HUMAN = 0;
                    for (int k = 0; k < employers.employers[i].shares.Count; k++)
                    {
                        employers.employers[i].shares[k].ID_null();

                    }
                }
                Employer_in(baza);
            }
            else
            {
                Employer_in(baza);
            }



        }
        public void Ready_Informations()
        {
            Employer employer1 = new Employer("Akif", "Quliyev", "Baki", "0554322331", 23, 2);
            Share share1_1 = new Share("Telefon", "cox istifade elenmiyib,teze kimidir, alicilar elaqe saxlasin", " 230 - 250 ", "Tecnology");
            Share share1_2 = new Share("Kompyurter", "Kohnedir", " 200 - 250 ", "Tecnology");
            Share share1_3 = new Share("Monitor", "Yenidir", " 200 - 300 ", "Tecnology");
            employer1.Add_share(share1_1);
            employer1.Add_share(share1_2);
            employer1.Add_share(share1_3);

            Employer employer2 = new Employer("Fazil", "Qalibov", "Baki", "0551236587", 44, 1);
            Share share2_1 = new Share("Telefon", "alicilar elaqe saxlasin", " 2500 ", "Tecnology");
            Share share2_2 = new Share("Televizor", "Kohnedir", " 400 - 250 ", "Tecnology");
            Share share2_3 = new Share("Mouse", "Yenidir", " 20 ", "Tecnology");
            employer2.Add_share(share2_1);
            employer2.Add_share(share2_2);
            employer2.Add_share(share2_3);

            Employer employer3 = new Employer("Elnur", "Quliyev", "Gence", "0991234567", 53, 4);
            Share share3_1 = new Share("Velosipet", "cox istifade elenmiyib,teze kimidir, alicilar elaqe saxlasin", " 230 - 250 ", "Tecnology");
            Share share3_2 = new Share("Audi A8", "Yenidir", "130000 $ ", "Tecnology");
            Share share3_3 = new Share("Apple", "Yenidir", " 200 - 300 ", "Tecnology");
            employer3.Add_share(share3_1);
            employer3.Add_share(share3_2);
            employer3.Add_share(share3_3);

            employers = new Baza_Employer();
            employers.Add_Employer(employer1);
            employers.Add_Employer(employer2);
            employers.Add_Employer(employer3);
        }
        public void Ready_funk_Worker(Baza_Accounts baza)
        {

            //Baza_Employer employers=new Baza_Employer();
            //Employer_CV_BAZA employer_CV_BAZA=new Employer_CV_BAZA();


            Ready_Informations();







            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            foreach (var item in employers.employers)
            {

                Console.WriteLine();
                item.Show_shares();
            }


            Console.WriteLine();
            Console.WriteLine($" Back [ 0 ] ");
            Console.WriteLine();
            Console.Write($" Enter ID or Back : ");
            bool rasuelt2 = int.TryParse(Console.ReadLine(), out int result2);

            if (result2 == 0)
            {
                for (int i = 0; i < employers.employers.Count; i++)
                {

                    employers.employers[i].ID_HUMAN = 0;
                    for (int k = 0; k < employers.employers[i].shares.Count; k++)
                    {
                        employers.employers[i].shares[k].ID_null();

                    }
                }
                Worker_in(baza);
            }
            else
            {
                int empty_count = 0;
                for (int i = 0; i < employer_CV_BAZA.CVs.Count; i++)
                {
                    if (result2 == employer_CV_BAZA.CVs[i].ID)
                    {
                        cV_Baza_Employer.Add_cv(employer_CV_BAZA.CVs[i]);
                        //Mesages mesage = new Mesages(); 
                        //baza_Mesaj.Add_mesagge()
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($@"                                                     BOSS.az          ");
                        Console.WriteLine();
                        Console.WriteLine($" CV added ... ");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Worker_in(baza);
                    }
                    ++empty_count;
                }
                if (empty_count == employer_CV_BAZA.CVs.Count)
                {
                    for (int i = 0; i < employers.employers.Count; i++)
                    {

                        employers.employers[i].ID_HUMAN = 0;
                        for (int k = 0; k < employers.employers[i].shares.Count; k++)
                        {
                            //employers.employers[i].shares[k].ID_null();

                        }
                    }
                    Worker_in(baza);
                }
            }
        }
       
        public void Log_in(Baza_Accounts baza)
        {
            
            
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            Console.WriteLine($" Log in        [ 1 ] ");
            Console.WriteLine($" New account   [ 2 ] ");
            Console.WriteLine();
            Console.Write($" Enter : ");
            string first_logIN = Console.ReadLine();
            if (first_logIN == "1")
            {
                UserName_password( baza);
            }
            else if (first_logIN == "2")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                Console.Write(" Enter Username : ");
                string new_Username = Console.ReadLine();
                Console.Write(" Enter Password : ");
                string new_password = Console.ReadLine();

                Accond accond2 = new Accond(new_Username, new_password);
                baza.Add_accound(accond2);
                Log_in(baza);
            }
            else
            {
                Log_in(baza);
            }
        }
        public void Worker_in(Baza_Accounts baza)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            Console.WriteLine($" Back           [ 0 ] ");
            Console.WriteLine($" Advertisements [ 1 ] ");
            Console.WriteLine($" Messages       [ 2 ] ");
            Console.WriteLine($" Add CV         [ 3 ] ");
            Console.WriteLine();
            Console.Write($" Enter : ");
            string result = Console.ReadLine();
            if (result == "0")
            {
                Start_method(baza);
            }
            else if (result == "1")
            {
                Ready_funk_Worker(baza);
            }
            else if (result == "2")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                baza_Mesaj.Show();
                Console.WriteLine($" Back [ 0 ] ");
                Console.WriteLine();
                Console.Write($" Enter : ");
                string result3 = Console.ReadLine();
                if (result3 == "0")
                {
                    Worker_in(baza);
                }
                else
                {
                    Worker_in(baza);
                }
            }
            else if (result == "3")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                employer_CV_BAZA.Add_cv_Information();
                Console.WriteLine();
                Console.WriteLine($" Back [ 0 ] ");
                Console.WriteLine();
                Console.Write($" Enter : ");
                string result3 = Console.ReadLine();
                if (result3 == "0")
                {
                    Worker_in(baza);
                }
                else { 
                    Worker_in(baza);
                }
            }
            else
            {
                Worker_in(baza);
            }
        }
        public void Employer_in_3(Baza_Accounts baza)
        {
            //employer_CV_BAZA.Show_cvs();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            if (cV_Baza_Employer.CVs.Count != 0)
            {

            for (int i = 0; i < cV_Baza_Employer.Count; i++)
            {

                cV_Baza_Employer.CVs[i].Show();
            }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" Empty");
                Console.WriteLine();
            }
            Console.WriteLine($" Back [ 0 ] ");
            Console.WriteLine();
            Console.Write($" Enter ID or Back : ");
            bool rasuelt2 = int.TryParse(Console.ReadLine(), out int result2);
            if (result2 == 0)
            {
                Employer_in(baza);
            }
            else
            {
                //gelen cvye mesaj gondermek
                //Employer employer = new Employer();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                Console.Write($" Enter Message : ");
                string mesaj = Console.ReadLine();
                Mesages mesage = new Mesages(employer1,mesaj);
                baza_Mesaj.Add_mesagge(mesage);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                Console.WriteLine($" Great ");
                Thread.Sleep(1000);
                Employer_in(baza);
            }
        }
        public void Employer_in(Baza_Accounts baza)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            Console.WriteLine($" Back               [ 0 ] ");
            Console.WriteLine($" Advertisements     [ 1 ] ");
            Console.WriteLine($" Incoming CVs       [ 2 ] ");
            Console.WriteLine($" Add Advertisement  [ 3 ] ");
            Console.WriteLine();
            Console.Write($" Enter : ");
            string result = Console.ReadLine();
            if (result == "0")
            {
                Start_method(baza);
            }
            else if (result == "1")
            {
                Ready_funk_Employer(baza);
            }
            else if (result == "2")
            {

                Employer_in_3(baza);
            }
            else if (result == "3")
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                Employer new_emplloyer = new Employer();
                new_emplloyer.Add_share_informations();
                employers.Add_Employer(new_emplloyer);
                Console.WriteLine();
                Console.WriteLine($" Back [ 0 ] ");
                Console.WriteLine();
                Console.Write($" Enter : ");
                string result3 = Console.ReadLine();
                if (result3 == "0")
                {
                    Employer_in(baza);
                }
                else
                {
                    Employer_in(baza);
                }
            }
            else 
            {
                Employer_in(baza);
            }
        }
        public void Start_method(Baza_Accounts baza)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                                                     BOSS.az          ");
            Console.WriteLine();
            Console.WriteLine($" Back       [ 0 ]");
            Console.WriteLine($" Worker     [ 1 ] ");
            Console.WriteLine($" Employer   [ 2 ] ");
            Console.WriteLine();
            Console.Write($" Enter : ");
            string Ishci_Qonaq_IlkSecim=Console.ReadLine();
            if (Ishci_Qonaq_IlkSecim == "0")
            {
                Log_in(baza);
            }
            else if (Ishci_Qonaq_IlkSecim == "1")
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();

                Worker_in(baza);
            }
            else if (Ishci_Qonaq_IlkSecim == "2")
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($@"                                                     BOSS.az          ");
                Console.WriteLine();
                Employer_in(baza);
            }
            else
            {
                Start_method(baza);
            }
            

        }
    }
}
