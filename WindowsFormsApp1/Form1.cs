using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string>[] phrases = new List<string>[6];
        public Form1()
        {
            InitializeComponent();
            InitializePhrases();
        }
        private void InitializePhrases()
        {
 
            phrases[0] = new List<string> 
            {
             "Ja chcę powiedzieć jedną rzecz: ",
             "Trzeba powiedzieć jasno: ",
             "Jak powiedział wybitny krakowianin Stanisław Lem, ",
             "Proszę mnie dobrze zrozumieć: ",
             "Ja chciałem państwu przypomnieć, że ",
             "Niech państwo nie mają złudzeń: ",
             "Powiedzmy to wyraźnie: ",
             "Proszę zwrócić uwagę, że ",
             "I tak mam trzy razy mniej czasu, więc proszę mi pozwolić powiedzieć: ",
             "Państwo się śmieją, ale ",
             "Ja nie potrzebowałem edukacji seksualnej, żeby wiedzieć, że ",
             "No niestety: ",
             "Gdzie leży przyczyna problemu? Ja państwu powiem: ",
             "Państwo chyba nie widzą, że ",
             "Oświadczam kategorycznie: ",
             "Powtarzam: ",
             "Powiedzmy to z całą mocą: ",
             "W Polsce dzisiaj ",
             "Państwo sobie nie zdają sprawy, że ",
             "To ja przepraszam bardzo: ",
             "Otóż nie wiem, czy pan wie, że ",
             "Yyyyy... ",
            };
            phrases[1] = new List<string>
            {
             "przedstawiciele czerwonej hołoty ",
             "ci wszyscy (tfu!) geje ",
             "funkcjonariusze reżymowej telewizji ",
             "tak zwani ekolodzy ",
             "ci wszyscy (tfu!) demokraci ",
             "agenci bezpieki ",
             "feminazistki ",
             "właściciele niewolników ",
             "związkowcy ",
             "trockiści ",
             "tak zwane dzieci kwiaty ",
             "rozmaici urzędnicy ",
             "federaści ",
             "etatyści ",
             "ci durnie i złodzieje ",
             "ludzie wybrani głosami meneli spod budki z piwem ",
             "socjaliści pobożni ",
             "socjaliści bezbożni ",
             "komuniści z krzyżem w zębach ",
             "agenci obcych służb ",
             "członkowie Bandy Czworga ",
             "pseudo-masoni z Wielkiego Wschodu Francji ",
            };
            phrases[2] = new List<string>
            {
             "zupełnie bezkarnie ",
             "całkowicie bezczelnie ",
             "o poglądach na lewo od komunizmu ",
             "celowo i świadomie ",
             "z premedytacją ",
             "od czasów Okrągłego Stołu ",
             "w ramach postępu ",
             "po przeczytaniu Manifestu komunistycznego ",
             "którymi się brzydzę ",
             "których nienawidzę ",
             "z okolic 'Gazety Wyborczej' ",
             "czyli ta żydokomuna ",
             "odkąd zniesiono karę śmierci ",
             "którymi pogardzam ",
             "których miejsce w normalnym kraju jest w więzieniu ",
             "na polecenie Brukseli ",
             "posłusznie ",
             "bezmyślnie ",
             "z nieprawdopodobną pogardą dla człowieka ",
             "za pieniądze podatników ",
             "zgodnie z ideologią LGBTQZ ",
             "za wszelką cenę ",
            };
            phrases[3] = new List<string>
            {
             "nawołują do podniesienia podatków, ",
             "próbują wyrzucić kierowców z miast, ",
             "próbują skłócić Polskę z Rosją, ",
             "głoszą brednie o globalnym ociepleniu, ",
             "zakazują posiadania broni, ",
             "nie dopuszczają prawicy do władzy, ",
             "uczą dzieci homoseksualizmu, ",
             "udają homoseksualistów ",
             "niszczą rodzinę ",
             "idą do polityki ",
             "zakazują góralom robienia oscypków ",
             "organizują paraolimpiady ",
             "wprowadzają ustrój, w którym raz na cztery lata można wybrać sobie pana ",
             "ustawiają fotoradary ",
             "wprowadzają dotacje ",
             "wydzielają buspasy ",
             "podnoszą wiek emerytalny ",
             "rżną głupa ",
             "odbierają dzieci rodzicom ",
             "wprowadzają absurdalne przepisy ",
             "umieszczają dzieci w szkołach koedukacyjnych ",
             "wprowadzają parytety ",
            };
            phrases[4] = new List<string>
            {
             "bo dzięki temu mogą kraść",
             "bo dostają za to pieniądze",
             "bo tak się uczy w państwowej szkole",
             "bo bez tego (tfu!) demokracja nie może istnieć",
             "bo głupich jest więcej niż mądrych",
             "bo chcą tworzyć raj na ziemi",
             "bo chcą niszczyć cywilizację białego człowieka",
             "żeby poddawać wszystkich tresurze",
             "bo taka jest ich natura",
             "bo chcą wszystko kontrolować",
             "bo nie rozumieją, że socjalizm nie działa",
             "żeby wreszcie zapanował socjalizm",
             "dokładnie tak jak tow. Janosik",
             "zamiast pozwolić ludziom zarabiać",
             "żeby wyrwać kobiety z domu",
             "bo to jest w interesie tak zwanych ludzi pracy",
             "zamiast pozwolić decydować konsumentowi",
             "żeby nie opłacało się mieć dzieci",
             "zamiast obniżyć podatki",
             "bo nie rozumieją, że selekcja naturalna jest czymś dobrym",
             "żeby mężczyźni przestali być agresywni",
             "bo dzięki temu mogą brać łapówki",
            };
            phrases[5] = new List<string>
            {
             " przez kolejne kadencje.",
             ", o czym się nie mówi.",
             " i właśnie dlatego Europa umiera.",
             ", ale przyjdą muzułmanie i zrobią porządek.",
             " — tak samo zresztą jak za Hitlera.",
             " — proszę zobaczyć, co się dzieje na Zachodzie, jeśli mi państwo nie wierzą.",
             ", co lat temu sto nikomu nie przyszłoby nawet do głowy.",
             " co ma zresztą tyle samo sensu, co zawody w szachach dla debili.", //ft
             " co zostało dokładnie zaplanowane w Magdalence przez śp. generała Kiszczaka.",
             " i trzeba być idiotą, żeby ten system popierać.",
             " ale nawet ja jeszcze dożyję normalnych czasów.",
             " co dowodzi, że wyskrobano nie tych, co trzeba.",
             " a zwykłym ludziom wmawiają, że im coś 'dadzą'.",
             " - cóż: chcieliście (tfu!) demokracji, to macie.",
             " dlatego trzeba zlikwidować koryto, a nie zmieniać świnie.",
             " a wystarczyłoby przestać płacić zasiłki.",
             " podczas gdy normalni ludzie uważani są za dziwaków.",
             " co w wieku XIX po prostu by wyśmiano.",
             " - dlatego w społeczeństwie jest równość, a powinno być rozwarstwienie.",
             " co prowadzi Polskę do katastrofy.",
             " - dlatego trzeba przywrócić normalność.",
             " ale w wolnej Polsce pójdą siedzieć."
            };

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            string sentence = string.Join(" ", phrases.Select(column => column[rng.Next(column.Count)]).ToArray());
            outputTextBox.Text = sentence;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputTextBox.Multiline = true;
            outputTextBox.Text = Environment.NewLine + "Inspiracja: Fanpage Zbliżeniowy (Facebook)" + Environment.NewLine; //+"Wykonał: Adam Mazur";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "Janusz Ryszard Korwin-Mikke, krótko Korwin, (JKM) (ur. 27 października 1942 w Warszawie). Polski polityk (obecnie były poseł na sejm RP i eurodeputowany), publicysta i brydżysta, z wykształcenia filozof. Od 5 stycznia 2024 prezes partii KORWiN.";
        }

        
    }
}
